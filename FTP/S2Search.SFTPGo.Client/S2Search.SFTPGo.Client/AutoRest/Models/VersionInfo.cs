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

    public partial class VersionInfo
    {
        /// <summary>
        /// Initializes a new instance of the VersionInfo class.
        /// </summary>
        public VersionInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VersionInfo class.
        /// </summary>
        /// <param name="features">Features for the current build. Available
        /// features are "portable", "bolt", "mysql", "sqlite", "pgsql", "s3",
        /// "gcs", "metrics". If a feature is available it has a "+" prefix,
        /// otherwise a "-" prefix</param>
        public VersionInfo(string version = default(string), string buildDate = default(string), string commitHash = default(string), IList<string> features = default(IList<string>))
        {
            Version = version;
            BuildDate = buildDate;
            CommitHash = commitHash;
            Features = features;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "build_date")]
        public string BuildDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "commit_hash")]
        public string CommitHash { get; set; }

        /// <summary>
        /// Gets or sets features for the current build. Available features are
        /// "portable", "bolt", "mysql", "sqlite", "pgsql", "s3", "gcs",
        /// "metrics". If a feature is available it has a "+" prefix, otherwise
        /// a "-" prefix
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public IList<string> Features { get; set; }

    }
}
