﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAPILesson.Domain.Entities.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }    
        public long Length { get; set; }
        public string ContentType { get; set; }
    }
}
