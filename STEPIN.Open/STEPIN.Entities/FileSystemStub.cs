﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPIN.Entities
{
    public class FileSystemStub
    {
        public FileSystemStub()
        {
            Files = new List<FileStub>();
        }

        public string TriggerID { get; set; }

        public DateTime LastUpdatedOn { get; set; }

        public List<FileStub> Files { get; set; }
    }
}
