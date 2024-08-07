// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolAdministration.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// DayCalendarsExternalResponse
    /// </summary>
    public partial class DayCalendarsExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the DayCalendarsExternalResponse
        /// class.
        /// </summary>
        public DayCalendarsExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DayCalendarsExternalResponse
        /// class.
        /// </summary>
        /// <param name="id">Identifier of the day calendar.</param>
        /// <param name="schoolDays">List of school days.</param>
        /// <param name="name">String</param>
        /// <param name="insertedAt">When was day calendar created</param>
        /// <param name="updatedAt">Last update of the day calendar</param>
        public DayCalendarsExternalResponse(System.Guid id, IList<SchoolDay> schoolDays, string name = default(string), System.DateTime? insertedAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?))
        {
            Id = id;
            Name = name;
            InsertedAt = insertedAt;
            UpdatedAt = updatedAt;
            SchoolDays = schoolDays;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets identifier of the day calendar.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Name of the day calendar.
        /// </remarks>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets when was day calendar created
        /// </summary>
        [JsonProperty(PropertyName = "insertedAt")]
        public System.DateTime? InsertedAt { get; set; }

        /// <summary>
        /// Gets or sets last update of the day calendar
        /// </summary>
        [JsonProperty(PropertyName = "updatedAt")]
        public System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets list of school days.
        /// </summary>
        [JsonProperty(PropertyName = "schoolDays")]
        public IList<SchoolDay> SchoolDays { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SchoolDays == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchoolDays");
            }
            if (SchoolDays != null)
            {
                foreach (var element in SchoolDays)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
