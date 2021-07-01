using System;
using System.Collections.Generic;
using System.Text;

namespace PdfModification
{
    public class Images
    {
        public string ImageID { get; set; }
        public string AttachmentName { get; set; }
        public string Keys { get; set; }
        public string DocumentType { get; set; }
        public string DbId { get; set; }
        public string DbName { get; set; }
        public byte[] Image { get; set; }
        public string FileType { get; set; }
        public string ImageUrl { get; set; }
    }
}
