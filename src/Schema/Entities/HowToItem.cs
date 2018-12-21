using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SeoSocial.Schema;
using SeoSocial.Schema.Enumerations;
using SeoSocial.SuperStructs;

namespace SeoSocial.Schema.Entities
{
    /// <summary>
    /// An item used as either a tool or supply when performing the instructions for how to to achieve a result.
    /// <see cref="https://schema.org/HowToItem"/>
    /// </summary>
    public class HowToItem : IEntity
    {
        /// The required quantity of the item(s).
        public Or<double, QuantitativeValue, string>? RequiredQuantity { get; set; }
    }
}
