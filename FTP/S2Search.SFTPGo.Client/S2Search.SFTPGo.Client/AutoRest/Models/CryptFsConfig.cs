// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.SFTPGo.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Crypt filesystem configuration details
    /// </summary>
    public partial class CryptFsConfig
    {
        /// <summary>
        /// Initializes a new instance of the CryptFsConfig class.
        /// </summary>
        public CryptFsConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CryptFsConfig class.
        /// </summary>
        public CryptFsConfig(Secret passphrase = default(Secret))
        {
            Passphrase = passphrase;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "passphrase")]
        public Secret Passphrase { get; set; }

    }
}
