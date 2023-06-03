// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.SFTPGo.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PatternsFilter
    {
        /// <summary>
        /// Initializes a new instance of the PatternsFilter class.
        /// </summary>
        public PatternsFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatternsFilter class.
        /// </summary>
        /// <param name="path">exposed virtual path, if no other specific
        /// filter is defined, the filter apply for sub directories too. For
        /// example if filters are defined for the paths "/" and "/sub" then
        /// the filters for "/" are applied for any file outside the "/sub"
        /// directory</param>
        /// <param name="allowedPatterns">list of, case insensitive, allowed
        /// shell like file patterns.</param>
        /// <param name="deniedPatterns">list of, case insensitive, denied
        /// shell like file patterns. Denied patterns are evaluated before the
        /// allowed ones</param>
        public PatternsFilter(string path = default(string), IList<string> allowedPatterns = default(IList<string>), IList<string> deniedPatterns = default(IList<string>))
        {
            Path = path;
            AllowedPatterns = allowedPatterns;
            DeniedPatterns = deniedPatterns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets exposed virtual path, if no other specific filter is
        /// defined, the filter apply for sub directories too. For example if
        /// filters are defined for the paths "/" and "/sub" then the filters
        /// for "/" are applied for any file outside the "/sub" directory
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets list of, case insensitive, allowed shell like file
        /// patterns.
        /// </summary>
        [JsonProperty(PropertyName = "allowed_patterns")]
        public IList<string> AllowedPatterns { get; set; }

        /// <summary>
        /// Gets or sets list of, case insensitive, denied shell like file
        /// patterns. Denied patterns are evaluated before the allowed ones
        /// </summary>
        [JsonProperty(PropertyName = "denied_patterns")]
        public IList<string> DeniedPatterns { get; set; }

    }
}