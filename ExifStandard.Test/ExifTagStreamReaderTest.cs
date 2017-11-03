using System;
using System.IO;

using Xunit;

namespace ExifStandard.Test
{
    public class ExifTagStreamReaderTest
    {
        [Fact]
        public void Open_StreamNull_ThrowsException()
        {
            ExifTagStreamReader sut = new ExifTagStreamReader();

            Assert.Throws<ArgumentNullException>(() => { sut.Open(null); });
        }

        [Fact]
        public void ReadUShort_Succeeds_ReturnsUShort()
        {
            ushort val = 0x01;
            byte[] buffer = BitConverter.GetBytes(val);
            MemoryStream stream = new MemoryStream(buffer);

            ExifTagStreamReader sut = new ExifTagStreamReader();
            sut.Open(stream);

            ushort ret = sut.ReadUShort();
            Assert.Equal(val, ret);
            Assert.Equal(2, stream.Position);
        }
    }
}