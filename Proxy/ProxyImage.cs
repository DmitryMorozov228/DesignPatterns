// Developed by Softeq Development Corporation
// http://www.softeq.com
// 

namespace Proxy
{
    // The Proxy has an interface identical to the RealSubject.
    internal class ProxyImage : IImage
    {
        private RealImage _realImage;
        private readonly string _fileName;

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