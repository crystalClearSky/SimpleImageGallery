﻿using System;
using System.Collections.Generic;

namespace SimpleImageGallery.Models
{
    public class GalleryDetailModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Url { get; set; }

        public List<string> Tags { get; set; }
    }
}
