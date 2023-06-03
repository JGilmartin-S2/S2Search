// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.CustomerResourceApi.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UpdatePasswordRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdatePasswordRequest class.
        /// </summary>
        public UpdatePasswordRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdatePasswordRequest class.
        /// </summary>
        public UpdatePasswordRequest(System.Guid? searchIndexId = default(System.Guid?), string username = default(string), string password = default(string))
        {
            SearchIndexId = searchIndexId;
            Username = username;
            Password = password;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "searchIndexId")]
        public System.Guid? SearchIndexId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

    }
}
