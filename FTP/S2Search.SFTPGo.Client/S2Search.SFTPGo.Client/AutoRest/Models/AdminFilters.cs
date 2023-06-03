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

    public partial class AdminFilters
    {
        /// <summary>
        /// Initializes a new instance of the AdminFilters class.
        /// </summary>
        public AdminFilters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdminFilters class.
        /// </summary>
        /// <param name="allowList">only clients connecting from these IP/Mask
        /// are allowed. IP/Mask must be in CIDR notation as defined in RFC
        /// 4632 and RFC 4291, for example "192.0.2.0/24" or
        /// "2001:db8::/32"</param>
        public AdminFilters(IList<string> allowList = default(IList<string>))
        {
            AllowList = allowList;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets only clients connecting from these IP/Mask are
        /// allowed. IP/Mask must be in CIDR notation as defined in RFC 4632
        /// and RFC 4291, for example "192.0.2.0/24" or "2001:db8::/32"
        /// </summary>
        [JsonProperty(PropertyName = "allow_list")]
        public IList<string> AllowList { get; set; }

    }
}
