// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.ClientConfigurationApi.Client.AutoRest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Theme
    {
        /// <summary>
        /// Initializes a new instance of the Theme class.
        /// </summary>
        public Theme()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Theme class.
        /// </summary>
        public Theme(System.Guid? themeId = default(System.Guid?), string primaryHexColour = default(string), string secondaryHexColour = default(string), string navBarHexColour = default(string), string logoURL = default(string), string missingImageURL = default(string))
        {
            ThemeId = themeId;
            PrimaryHexColour = primaryHexColour;
            SecondaryHexColour = secondaryHexColour;
            NavBarHexColour = navBarHexColour;
            LogoURL = logoURL;
            MissingImageURL = missingImageURL;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "themeId")]
        public System.Guid? ThemeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryHexColour")]
        public string PrimaryHexColour { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "secondaryHexColour")]
        public string SecondaryHexColour { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "navBarHexColour")]
        public string NavBarHexColour { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "logoURL")]
        public string LogoURL { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "missingImageURL")]
        public string MissingImageURL { get; set; }

    }
}