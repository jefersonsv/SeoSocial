using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSocial.Schema
{
    public class FormatAttribute : Attribute
    {
        public FormatAttribute(string format)
        {
            this.Format = format;
        }

        public string Format { get; set; }
    }
}
