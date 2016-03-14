using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPILearning1.Models
{
    public class ImageInfo
    {
     

        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public string ImageSource { get; set; }
        public int ImageTop { get; set; }
        public int ImageLeft { get; set; }
        public MacineryInfo Machine { get; set; }
    }
}