﻿namespace Resize_Image.Helpers
{
    public class ValueDefault
    {
        public static string _imageDefault = "./assets/logo.jpg";

        public static string _path = Directory.GetCurrentDirectory();

        public static string _folderImages = "img";

        public static string _folderZip = "zip";

        public static string _fileNameOne = DateTime.Now.ToString("yyyyMMddHHmmss");

        public static string _fileNameTwo = $"{Guid.NewGuid()}.png";

        public static int _width = 0;

        public static int _height = 0;

        public static int _maxFileSize = 10 * 1024 * 1024;

        public static int _imageCount = 0;

        public static bool _btnResize = false;

        public static bool _btnDownLoad = false;

        public static string _base64 = null!;

        public static byte[] _file = null!;

        public static List<string> _imagesBase64 = new List<string>();

        public static List<byte[]> _imagesBytes = new List<byte[]>();

        public static void ResetImage()
        {
            _width = 0;
            _height = 0;
            _base64 = null!;
            _file = null!;
            _btnResize = true;
            _btnDownLoad = true;
            _imagesBase64 = new List<string>();
            _imagesBytes = new List<byte[]>();
            _imageCount = 0;
        }
    }
}