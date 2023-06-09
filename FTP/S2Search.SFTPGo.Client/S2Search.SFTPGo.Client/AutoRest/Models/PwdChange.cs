// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.SFTPGo.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PwdChange
    {
        /// <summary>
        /// Initializes a new instance of the PwdChange class.
        /// </summary>
        public PwdChange()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PwdChange class.
        /// </summary>
        public PwdChange(string currentPassword = default(string), string newPassword = default(string))
        {
            CurrentPassword = currentPassword;
            NewPassword = newPassword;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "current_password")]
        public string CurrentPassword { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_password")]
        public string NewPassword { get; set; }

    }
}
