// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.SFTPGo.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Secret
    {
        /// <summary>
        /// Initializes a new instance of the Secret class.
        /// </summary>
        public Secret()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Secret class.
        /// </summary>
        /// <param name="status">Set to "Plain" to add or update an existing
        /// secret, set to "Redacted" to preserve the existing value. Possible
        /// values include: 'Plain', 'AES-256-GCM', 'Secretbox', 'GCP', 'AWS',
        /// 'VaultTransit', 'Redacted'</param>
        /// <param name="mode">1 means encrypted using a master key</param>
        public Secret(string status = default(string), string payload = default(string), string key = default(string), string additionalData = default(string), int? mode = default(int?))
        {
            Status = status;
            Payload = payload;
            Key = key;
            AdditionalData = additionalData;
            Mode = mode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets set to "Plain" to add or update an existing secret,
        /// set to "Redacted" to preserve the existing value. Possible values
        /// include: 'Plain', 'AES-256-GCM', 'Secretbox', 'GCP', 'AWS',
        /// 'VaultTransit', 'Redacted'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public string Payload { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "additional_data")]
        public string AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets 1 means encrypted using a master key
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public int? Mode { get; set; }

    }
}
