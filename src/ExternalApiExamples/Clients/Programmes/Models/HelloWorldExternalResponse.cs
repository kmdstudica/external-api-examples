// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// HelloWorldExternalResponse
    /// </summary>
    public partial class HelloWorldExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the HelloWorldExternalResponse class.
        /// </summary>
        public HelloWorldExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HelloWorldExternalResponse class.
        /// </summary>
        /// <param name="response">String</param>
        public HelloWorldExternalResponse(string response = default(string))
        {
            Response = response;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The hello world response
        /// </remarks>
        [JsonProperty(PropertyName = "response")]
        public string Response { get; set; }

    }
}
