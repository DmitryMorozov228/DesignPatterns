// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Proxy
{
    /// <summary>
    /// The Proxy has an interface identical to the RealSubject. 
    /// </summary>
    internal class ProxyImage : IImage
    {
        private readonly string _fileName;
        private IImage _realImage;

        internal ProxyImage(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_fileName);
            }
            _realImage.Display();
        }
    }
}