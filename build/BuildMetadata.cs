using System.Globalization;
using Colorful;
using Nuke.Common.BuildServers;
using Nuke.Common.Tools.GitVersion;

class BuildMetadata
{
    public BuildMetadata(GitVersion gitVersion)
    {
        BuildVersion = gitVersion.FullSemVer;
        ReleaseGitTag = $"v{gitVersion.FullSemVer}";
        UniversalPackageVersion = gitVersion.NuGetVersionV2;
        ReleaseType = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(gitVersion.PreReleaseLabel ?? "stable");
    }

    public string BuildVersion { get; }
    public string ReleaseGitTag { get; }
    public string UniversalPackageVersion { get; }
    public string ReleaseType { get; }

    public void SetToCi()
    {
        if (TeamServices.Instance == null)
        {
            return;
        }
        TeamServices.Instance.UpdateBuildNumber(BuildVersion);
        Set(nameof(UniversalPackageVersion), UniversalPackageVersion);
        Set(nameof(ReleaseType), ReleaseType);
        Set(nameof(ReleaseGitTag), ReleaseGitTag);
    }

    static void Set(string name, string value)
    {
        Console.WriteLine($"##vso[task.setvariable variable={name}]{value}");
    }
}