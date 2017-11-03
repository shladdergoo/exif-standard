using System;
using System.IO;

namespace ExifStandard
{
    public class ExifTagStreamReader : IExifTagStreamReader
    {
        BinaryReader _reader;

        public void Open(Stream stream)
        {
            if (stream == null) throw new ArgumentNullException(nameof(stream));

            _reader = new BinaryReader(stream);
        }

        public ushort ReadUShort()
        {
            return BitConverter.ToUInt16(_reader.ReadBytes(2), 0);
        }
    }
}
