using System;
using System.Collections.Generic;

namespace MeuMoocBack.Models
{
    public class VideoAula
    {
        public string Uri { get; set; }

        public VideoAula(string uri)
        {
            this.Uri = uri;
        }
    }
}
