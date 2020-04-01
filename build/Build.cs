using Nuke.Common;
using Nuke.Common.BuildServers;
using Nuke.Common.Execution;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.GitVersion;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.GitVersion.GitVersionTasks;

[CheckBuildProjectConfigurations]
[UnsetVisualStudioEnvironmentVariables]
class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main () => Execute<Build>(x => x.CiBuild);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [Solution] readonly Solution Solution;
    [GitVersion] readonly GitVersion GitVersion;
    BuildMetadata Metadata;

    AbsolutePath ArtifactsDirectory => RootDirectory / "artifacts";
    AbsolutePath NuGetPackagesDirectory => RootDirectory / "packages";

    Target LocalBuild => _ => _.DependsOn(Pack);
    Target CiBuild => _ => _.DependsOn(Pack);

    Target CiVersion => _ => _
        .Before(Pack)
        .Executes(() =>
        {
            if (TeamServices.Instance != null)
            {
                var buildNumber = $"{GitVersion.SemVer}#{TeamServices.Instance.BuildId}";
                TeamServices.Instance.UpdateBuildNumber(buildNumber);
            }
        });

    Target Clean => _ => _
        .Executes(() =>
        {
            EnsureCleanDirectory(ArtifactsDirectory);
            EnsureCleanDirectory(NuGetPackagesDirectory);
            DotNetClean(o => o.SetConfiguration(Configuration)
                .SetProject(Solution)
            );
        });

    Target Restore => _ => _
        .DependsOn(Clean)
        .Executes(() =>
        {
            DotNetRestore(o => o.SetProjectFile(Solution));
        });

    Target Compile => _ => _
        .DependsOn(Restore)
        .Executes(() =>
        {
            DotNetBuild(o => o.SetProjectFile(Solution)
                .EnableNoRestore()
            );
        });

    Target Pack => _ => _
        .DependsOn(Compile)
        .Executes(() =>
        {
            var version = GitVersion.SemVer;
            var informationalVersion = GitVersion.SemVer.Replace("build.", "");
            DotNetPack(o => o.SetVersion(version)
                .SetInformationalVersion(informationalVersion)
                .SetProject(Solution)
                .SetOutputDirectory(ArtifactsDirectory)
                .SetConfiguration(Configuration)
            );
        });

    protected override void OnBuildInitialized()
    {
        base.OnBuildInitialized();
        var gitVersion = GitVersion(o => o.SetLogOutput(false).SetOutput(GitVersionOutput.json)).Result;
        Metadata = new BuildMetadata(gitVersion);
    }
}
