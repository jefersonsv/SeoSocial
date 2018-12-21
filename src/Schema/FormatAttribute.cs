using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSocial.Schema
{
    public class ItemTypeAttribute : Attribute
    {
        public ItemTypeAttribute(string canonicalUrl)
        {
            this.CanonicalUrl = canonicalUrl;
        }

        public string CanonicalUrl { get; set; }
    }
}
