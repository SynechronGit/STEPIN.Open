﻿using System;

namespace STEPIN.Entities
{
    public class FileStub
    {
        public Guid _id { get; set; }

        public string Folder { get; set; }

        public string FileName { get; set; }

        public long SizeInBytes { get; set; }

        public string Hash { get; set; }
    }
}
