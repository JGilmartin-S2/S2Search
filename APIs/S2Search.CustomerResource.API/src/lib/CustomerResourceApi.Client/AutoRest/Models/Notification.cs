// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.CustomerResourceApi.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Notification
    {
        /// <summary>
        /// Initializes a new instance of the Notification class.
        /// </summary>
        public Notification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Notification class.
        /// </summary>
        public Notification(int? notificationId = default(int?), System.Guid? searchIndexId = default(System.Guid?), string eventProperty = default(string), string category = default(string), string recipients = default(string), IList<string> recipientsList = default(IList<string>), string transmitType = default(string), System.DateTime? createdDate = default(System.DateTime?))
        {
            NotificationId = notificationId;
            SearchIndexId = searchIndexId;
            EventProperty = eventProperty;
            Category = category;
            Recipients = recipients;
            RecipientsList = recipientsList;
            TransmitType = transmitType;
            CreatedDate = createdDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "notificationId")]
        public int? NotificationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "searchIndexId")]
        public System.Guid? SearchIndexId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "event")]
        public string EventProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recipients")]
        public string Recipients { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recipientsList")]
        public IList<string> RecipientsList { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transmitType")]
        public string TransmitType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdDate")]
        public System.DateTime? CreatedDate { get; set; }

    }
}