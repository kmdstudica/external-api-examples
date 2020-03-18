// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolAdministration.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SchoolHourEntryExternalResponse
    /// </summary>
    /// <remarks>
    /// Model of the school hour entry.
    /// </remarks>
    public partial class SchoolHourEntryExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the SchoolHourEntryExternalResponse
        /// class.
        /// </summary>
        public SchoolHourEntryExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SchoolHourEntryExternalResponse
        /// class.
        /// </summary>
        /// <param name="schoolHoursPlanId">Id of school hours plan where this
        /// entry belongs to.</param>
        /// <param name="entryType">The type of entry. Possible values include:
        /// 'Break', 'Lecture'</param>
        /// <param name="name">Optional name of this entry.</param>
        /// <param name="duration">Duration of this entry, only valid for
        /// breaks.</param>
        public SchoolHourEntryExternalResponse(System.Guid schoolHoursPlanId, string entryType, string name = default(string), int? duration = default(int?))
        {
            SchoolHoursPlanId = schoolHoursPlanId;
            EntryType = entryType;
            Name = name;
            Duration = duration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of school hours plan where this entry belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "schoolHoursPlanId")]
        public System.Guid SchoolHoursPlanId { get; set; }

        /// <summary>
        /// Gets or sets the type of entry. Possible values include: 'Break',
        /// 'Lecture'
        /// </summary>
        [JsonProperty(PropertyName = "entryType")]
        public string EntryType { get; set; }

        /// <summary>
        /// Gets or sets optional name of this entry.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets duration of this entry, only valid for breaks.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EntryType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EntryType");
            }
            if (Duration > 1440)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Duration", 1440);
            }
            if (Duration < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Duration", 1);
            }
        }
    }
}
