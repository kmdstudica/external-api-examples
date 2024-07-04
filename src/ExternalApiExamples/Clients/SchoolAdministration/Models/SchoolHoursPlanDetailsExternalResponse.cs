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
    /// SchoolHoursPlanDetailsExternalResponse
    /// </summary>
    /// <remarks>
    /// Model for a school hour plan, containing the name, start time, lesson
    /// length,
    /// school days, and individual lesson modules
    /// </remarks>
    public partial class SchoolHoursPlanDetailsExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SchoolHoursPlanDetailsExternalResponse class.
        /// </summary>
        public SchoolHoursPlanDetailsExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SchoolHoursPlanDetailsExternalResponse class.
        /// </summary>
        /// <param name="id">Id of school hours plan</param>
        /// <param name="name">String</param>
        /// <param name="startTime">Time</param>
        /// <param name="lectureDurationInMinutes">Int32</param>
        /// <param name="hasLecturesOnMondays">Boolean</param>
        /// <param name="hasLecturesOnTuesdays">Boolean</param>
        /// <param name="hasLecturesOnWednesdays">Boolean</param>
        /// <param name="hasLecturesOnThursdays">Boolean</param>
        /// <param name="hasLecturesOnFridays">Boolean</param>
        /// <param name="hasLecturesOnSaturdays">Boolean</param>
        /// <param name="hasLecturesOnSundays">Boolean</param>
        /// <param name="schoolHours">List of modules (school hours) for the
        /// school hours plan</param>
        /// <param name="insertedAt">When was the school hours plan
        /// created</param>
        /// <param name="updatedAt">Last update of the school hours
        /// plan</param>
        public SchoolHoursPlanDetailsExternalResponse(System.Guid id, string name, string startTime, int lectureDurationInMinutes, bool hasLecturesOnMondays, bool hasLecturesOnTuesdays, bool hasLecturesOnWednesdays, bool hasLecturesOnThursdays, bool hasLecturesOnFridays, bool hasLecturesOnSaturdays, bool hasLecturesOnSundays, IList<SchoolHoursPlanDetailsExternalResponseSchoolHourPlanDetailsSchoolHourEntry> schoolHours, System.DateTime? insertedAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?))
        {
            Id = id;
            Name = name;
            StartTime = startTime;
            LectureDurationInMinutes = lectureDurationInMinutes;
            HasLecturesOnMondays = hasLecturesOnMondays;
            HasLecturesOnTuesdays = hasLecturesOnTuesdays;
            HasLecturesOnWednesdays = hasLecturesOnWednesdays;
            HasLecturesOnThursdays = hasLecturesOnThursdays;
            HasLecturesOnFridays = hasLecturesOnFridays;
            HasLecturesOnSaturdays = hasLecturesOnSaturdays;
            HasLecturesOnSundays = hasLecturesOnSundays;
            InsertedAt = insertedAt;
            UpdatedAt = updatedAt;
            SchoolHours = schoolHours;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of school hours plan
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Name of school hours plan
        /// </remarks>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets time
        /// </summary>
        /// <remarks>
        /// Time of day when the school hours start
        /// </remarks>
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets int32
        /// </summary>
        /// <remarks>
        /// Duration of each lesson in minutes
        /// </remarks>
        [JsonProperty(PropertyName = "lectureDurationInMinutes")]
        public int LectureDurationInMinutes { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Are there lessons on Mondays
        /// </remarks>
        [JsonProperty(PropertyName = "hasLecturesOnMondays")]
        public bool HasLecturesOnMondays { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Are there lessons on Tuesdays
        /// </remarks>
        [JsonProperty(PropertyName = "hasLecturesOnTuesdays")]
        public bool HasLecturesOnTuesdays { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Are there lessons on Wednesdays
        /// </remarks>
        [JsonProperty(PropertyName = "hasLecturesOnWednesdays")]
        public bool HasLecturesOnWednesdays { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Are there lessons on Thursdays
        /// </remarks>
        [JsonProperty(PropertyName = "hasLecturesOnThursdays")]
        public bool HasLecturesOnThursdays { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Are there lessons on Fridays
        /// </remarks>
        [JsonProperty(PropertyName = "hasLecturesOnFridays")]
        public bool HasLecturesOnFridays { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Are there lessons on Saturdays
        /// </remarks>
        [JsonProperty(PropertyName = "hasLecturesOnSaturdays")]
        public bool HasLecturesOnSaturdays { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Are there lessons on Sundays
        /// </remarks>
        [JsonProperty(PropertyName = "hasLecturesOnSundays")]
        public bool HasLecturesOnSundays { get; set; }

        /// <summary>
        /// Gets or sets when was the school hours plan created
        /// </summary>
        [JsonProperty(PropertyName = "insertedAt")]
        public System.DateTime? InsertedAt { get; set; }

        /// <summary>
        /// Gets or sets last update of the school hours plan
        /// </summary>
        [JsonProperty(PropertyName = "updatedAt")]
        public System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets list of modules (school hours) for the school hours
        /// plan
        /// </summary>
        [JsonProperty(PropertyName = "schoolHours")]
        public IList<SchoolHoursPlanDetailsExternalResponseSchoolHourPlanDetailsSchoolHourEntry> SchoolHours { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (StartTime == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StartTime");
            }
            if (SchoolHours == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchoolHours");
            }
            if (Name != null)
            {
                if (Name.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 1);
                }
            }
            if (StartTime != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(StartTime, "([01]?[0-9]|2[0-3]):[0-5][0-9]"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "StartTime", "([01]?[0-9]|2[0-3]):[0-5][0-9]");
                }
            }
            if (LectureDurationInMinutes > 1440)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "LectureDurationInMinutes", 1440);
            }
            if (LectureDurationInMinutes < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "LectureDurationInMinutes", 1);
            }
            if (SchoolHours != null)
            {
                foreach (var element in SchoolHours)
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
