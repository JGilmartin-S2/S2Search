// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.SFTPGo.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class QuotaScan
    {
        /// <summary>
        /// Initializes a new instance of the QuotaScan class.
        /// </summary>
        public QuotaScan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QuotaScan class.
        /// </summary>
        /// <param name="username">username with an active scan</param>
        /// <param name="startTime">scan start time as unix timestamp in
        /// milliseconds</param>
        public QuotaScan(string username = default(string), long? startTime = default(long?))
        {
            Username = username;
            StartTime = startTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets username with an active scan
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets scan start time as unix timestamp in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public long? StartTime { get; set; }

    }
}
