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
    /// SchoolHourPlanDetailsSchoolHourEntry
    /// </summary>
    /// <remarks>
    /// Details about a school hours entry
    /// </remarks>
    public partial class SchoolHoursPlanDetailsExternalResponseSchoolHourPlanDetailsSchoolHourEntry
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SchoolHoursPlanDetailsExternalResponseSchoolHourPlanDetailsSchoolHourEntry
        /// class.
        /// </summary>
        public SchoolHoursPlanDetailsExternalResponseSchoolHourPlanDetailsSchoolHourEntry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SchoolHoursPlanDetailsExternalResponseSchoolHourPlanDetailsSchoolHourEntry
        /// class.
        /// </summary>
        /// <param name="schoolHourEntryId">Guid</param>
        /// <param name="entryType">SchoolHourEntryType</param>
        /// <param name="startTime">Time</param>
        /// <param name="endTime">Time</param>
        /// <param name="name">String</param>
        /// <param name="duration">Duration of this entry in minutes. Valid for
        /// breaks only.</param>
        public SchoolHoursPlanDetailsExternalResponseSchoolHourPlanDetailsSchoolHourEntry(System.Guid schoolHourEntryId, string entryType, string startTime, string endTime, string name = default(string), int? duration = default(int?))
        {
            SchoolHourEntryId = schoolHourEntryId;
            EntryType = entryType;
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
            Duration = duration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets guid
        /// </summary>
        /// <remarks>
        /// Id of the school hours entry
        /// </remarks>
        [JsonProperty(PropertyName = "schoolHourEntryId")]
        public System.Guid SchoolHourEntryId { get; set; }

        /// <summary>
        /// Gets or sets schoolHourEntryType
        /// </summary>
        /// <remarks>
        /// Type of the entry, e.g. module or break. Possible values include:
        /// 'Break', 'Module', 'Lecture'
        /// </remarks>
        [JsonProperty(PropertyName = "entryType")]
        public string EntryType { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Name of the entry
        /// </remarks>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets time
        /// </summary>
        /// <remarks>
        /// Start time of this specific entry
        /// </remarks>
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets time
        /// </summary>
        /// <remarks>
        /// End time of this specific entry
        /// </remarks>
        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or sets duration of this entry in minutes. Valid for breaks
        /// only.
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
            if (StartTime == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StartTime");
            }
            if (EndTime == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EndTime");
            }
            if (Name != null)
            {
                if (Name.Length > 255)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 255);
                }
            }
            if (StartTime != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(StartTime, "([01]?[0-9]|2[0-3]):[0-5][0-9]"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "StartTime", "([01]?[0-9]|2[0-3]):[0-5][0-9]");
                }
            }
            if (EndTime != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(EndTime, "([01]?[0-9]|2[0-3]):[0-5][0-9]"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "EndTime", "([01]?[0-9]|2[0-3]):[0-5][0-9]");
                }
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
