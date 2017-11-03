using System;
using System.IO;

using NSubstitute;
using Xunit;

namespace ExifStandard.Test
{
    public class TestReaderTest
    {
        [Fact]
        public void Ctor_Empty_Succeeds()
        {
            TagReader sut = new TagReader();

            Assert.NotNull(sut);
        }

        [Fact]
        public void Ctor_ReaderNull_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => { TagReader sut = new TagReader(null); });
        }

        [Fact]
        public void ReadTags_StreamNull_ThrowsException()
        {
            TagReader sut = new TagReader();

            Assert.Throws<ArgumentNullException>(() => {sut.ReadTags(null); });
        }

        [Fact]
        public void ReadTags_HasStream_OpensReader()
        {
            IExifTagStreamReader reader = Substitute.For<IExifTagStreamReader>();

            TagReader sut = new TagReader(reader);

            sut.ReadTags(new MemoryStream());

            reader.ReceivedWithAnyArgs().Open(default(Stream));
        }
    }
}