using System;
using System.IO;

namespace ExifStandard
{
    public class JpegStreamReader: StreamReader
    {
        public JpegStreamReader(Stream stream): base(stream)
        {
        }
    }
}
