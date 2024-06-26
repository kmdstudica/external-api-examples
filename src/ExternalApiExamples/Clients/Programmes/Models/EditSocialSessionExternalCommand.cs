// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// EditSocialSessionExternalCommand
    /// </summary>
    /// <remarks>
    /// Edit an existing social session.
    /// </remarks>
    public partial class EditSocialSessionExternalCommand
    {
        /// <summary>
        /// Initializes a new instance of the EditSocialSessionExternalCommand
        /// class.
        /// </summary>
        public EditSocialSessionExternalCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EditSocialSessionExternalCommand
        /// class.
        /// </summary>
        /// <param name="sessionId">Guid</param>
        /// <param name="groupIds">The groups which the session is assigned
        /// to.</param>
        /// <param name="roomIds">The Ids of the rooms where the session is
        /// conducted.</param>
        /// <param name="employeeIds">List of teacher' identifiers.</param>
        /// <param name="date">Date</param>
        /// <param name="title">String</param>
        /// <param name="isPrivate">Boolean</param>
        /// <param name="isMandatory">Boolean</param>
        /// <param name="schoolCode">String</param>
        /// <param name="externalLessonId">String</param>
        /// <param name="startTime">Start time of the session.</param>
        /// <param name="endTime">End time of the session.</param>
        /// <param name="schoolHourEntryId">The school hour entry which the
        /// session is scheduled to.</param>
        /// <param name="description">String</param>
        public EditSocialSessionExternalCommand(System.Guid sessionId, IList<System.Guid> groupIds, IList<System.Guid> roomIds, IList<System.Guid> employeeIds, System.DateTime date, string title, bool isPrivate, bool isMandatory, string schoolCode, string externalLessonId = default(string), string startTime = default(string), string endTime = default(string), System.Guid? schoolHourEntryId = default(System.Guid?), string description = default(string))
        {
            SessionId = sessionId;
            ExternalLessonId = externalLessonId;
            GroupIds = groupIds;
            RoomIds = roomIds;
            EmployeeIds = employeeIds;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
            SchoolHourEntryId = schoolHourEntryId;
            Description = description;
            Title = title;
            IsPrivate = isPrivate;
            IsMandatory = isMandatory;
            SchoolCode = schoolCode;
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
        /// The id of the session.
        /// </remarks>
        [JsonProperty(PropertyName = "sessionId")]
        public System.Guid SessionId { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// External identifier set by partners to allow them to match it with
        /// the lessons known by them.
        /// </remarks>
        [JsonProperty(PropertyName = "externalLessonId")]
        public string ExternalLessonId { get; set; }

        /// <summary>
        /// Gets or sets the groups which the session is assigned to.
        /// </summary>
        [JsonProperty(PropertyName = "groupIds")]
        public IList<System.Guid> GroupIds { get; set; }

        /// <summary>
        /// Gets or sets the Ids of the rooms where the session is conducted.
        /// </summary>
        [JsonProperty(PropertyName = "roomIds")]
        public IList<System.Guid> RoomIds { get; set; }

        /// <summary>
        /// Gets or sets list of teacher' identifiers.
        /// </summary>
        [JsonProperty(PropertyName = "employeeIds")]
        public IList<System.Guid> EmployeeIds { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// Date of the session.
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "date")]
        public System.DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets start time of the session.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets end time of the session.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or sets the school hour entry which the session is scheduled
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "schoolHourEntryId")]
        public System.Guid? SchoolHourEntryId { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// A description about the session.
        /// </remarks>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The title of the session.
        /// </remarks>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Indicator to show if the session is private or not.
        /// </remarks>
        [JsonProperty(PropertyName = "isPrivate")]
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Indicator to show if the session is mandatory or not.
        /// </remarks>
        [JsonProperty(PropertyName = "isMandatory")]
        public bool IsMandatory { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The school code for which to get data.
        /// </remarks>
        [JsonProperty(PropertyName = "schoolCode")]
        public string SchoolCode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (GroupIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GroupIds");
            }
            if (RoomIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RoomIds");
            }
            if (EmployeeIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EmployeeIds");
            }
            if (Title == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Title");
            }
            if (SchoolCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchoolCode");
            }
            if (ExternalLessonId != null)
            {
                if (ExternalLessonId.Length > 50)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ExternalLessonId", 50);
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
            if (Description != null)
            {
                if (Description.Length > 400)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 400);
                }
            }
            if (Title != null)
            {
                if (Title.Length > 30)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Title", 30);
                }
                if (Title.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Title", 1);
                }
            }
            if (SchoolCode != null)
            {
                if (SchoolCode.Length > 6)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "SchoolCode", 6);
                }
                if (SchoolCode.Length < 6)
                {
                    throw new ValidationException(ValidationRules.MinLength, "SchoolCode", 6);
                }
            }
        }
    }
}