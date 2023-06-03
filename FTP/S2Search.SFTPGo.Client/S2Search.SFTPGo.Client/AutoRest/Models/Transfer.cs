// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.SFTPGo.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Transfer
    {
        /// <summary>
        /// Initializes a new instance of the Transfer class.
        /// </summary>
        public Transfer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Transfer class.
        /// </summary>
        /// <param name="operationType">Possible values include: 'upload',
        /// 'download'</param>
        /// <param name="path">file path for the upload/download</param>
        /// <param name="startTime">start time as unix timestamp in
        /// milliseconds</param>
        /// <param name="size">bytes transferred</param>
        public Transfer(string operationType = default(string), string path = default(string), long? startTime = default(long?), long? size = default(long?))
        {
            OperationType = operationType;
            Path = path;
            StartTime = startTime;
            Size = size;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'upload', 'download'
        /// </summary>
        [JsonProperty(PropertyName = "operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// Gets or sets file path for the upload/download
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets start time as unix timestamp in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public long? StartTime { get; set; }

        /// <summary>
        /// Gets or sets bytes transferred
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public long? Size { get; set; }

    }
}
