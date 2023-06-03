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

    public partial class Synonym
    {
        /// <summary>
        /// Initializes a new instance of the Synonym class.
        /// </summary>
        public Synonym()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Synonym class.
        /// </summary>
        public Synonym(System.Guid? synonymId = default(System.Guid?), string key = default(string), IList<string> words = default(IList<string>), string solrFormat = default(string))
        {
            SynonymId = synonymId;
            Key = key;
            Words = words;
            SolrFormat = solrFormat;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "synonymId")]
        public System.Guid? SynonymId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "words")]
        public IList<string> Words { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solrFormat")]
        public string SolrFormat { get; set; }

    }
}
