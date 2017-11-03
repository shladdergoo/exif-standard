using System;
using System.IO;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("ExifStandard.Test")]
namespace ExifStandard
{
    public class TagReader
    {
        private readonly IExifTagStreamReader _reader;

        public TagReader(): this(new ExifTagStreamReader())
        {
        }

        internal TagReader(IExifTagStreamReader reader)
        {
            this._reader = reader ?? throw new ArgumentNullException(nameof(reader));
        }

        public void ReadTags(Stream stream)
        {
            if (stream == null) throw new ArgumentNullException(nameof(stream));

            this._reader.Open(stream);
        }
    }
}