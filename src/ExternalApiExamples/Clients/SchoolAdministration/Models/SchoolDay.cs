// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolAdministration.Client.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SchoolDay
    /// </summary>
    public partial class SchoolDay
    {
        /// <summary>
        /// Initializes a new instance of the SchoolDay class.
        /// </summary>
        public SchoolDay()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SchoolDay class.
        /// </summary>
        /// <param name="date">Date of the school day.</param>
        /// <param name="isSchoolDay">Flag indicating if a day is a school
        /// day.</param>
        /// <param name="comment">Comments to the school day.</param>
        public SchoolDay(System.DateTime date, bool isSchoolDay, string comment = default(string))
        {
            Date = date;
            IsSchoolDay = isSchoolDay;
            Comment = comment;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets date of the school day.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "date")]
        public System.DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets flag indicating if a day is a school day.
        /// </summary>
        [JsonProperty(PropertyName = "isSchoolDay")]
        public bool IsSchoolDay { get; set; }

        /// <summary>
        /// Gets or sets comments to the school day.
        /// </summary>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}