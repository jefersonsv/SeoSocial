using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSocial.Schema.Enumerations
{
	/// <summary>
	///     /// An enumeration of genders.
    /// <see cref="https://schema.org/GenderType"/>
    /// </summary>
    public enum GenderType
    {
        [ItemType("https://schema.org/Female")]
        Female,

        [ItemType("https://schema.org/Male")]
        Male
    }
}
