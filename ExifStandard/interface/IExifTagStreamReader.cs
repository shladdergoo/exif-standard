using System.IO;

namespace ExifStandard
{
    public interface IExifTagStreamReader
    {
        void Open(Stream stream);

         ushort ReadUShort();
    }
}