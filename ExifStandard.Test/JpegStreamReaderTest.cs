using System;

using Xunit;

namespace ExifStandard.Test
{
    public class JpegStreamReaderTest
    {
        [Fact]
        public void Ctor_NullStream_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() =>
                {
                    JpegStreamReader sut = new JpegStreamReader(null);
                });
        }
    }
}