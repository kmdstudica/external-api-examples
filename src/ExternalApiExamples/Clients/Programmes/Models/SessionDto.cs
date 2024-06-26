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
    /// SessionDto
    /// </summary>
    public partial class SessionDto
    {
        /// <summary>
        /// Initializes a new instance of the SessionDto class.
        /// </summary>
        public SessionDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SessionDto class.
        /// </summary>
        /// <param name="sessionId">Guid</param>
        /// <param name="sessionEntityType">SessionEntityType</param>
        /// <param name="title">String</param>
        /// <param name="isPrivate">Boolean</param>
        /// <param name="isMandatory">Boolean</param>
        /// <param name="isCancelled">Boolean</param>
        /// <param name="sessionEntityId">The id of the entity which is
        /// associated with this session. If the type
        /// is None then this value is null, otherwise it has a value.
        ///
        /// If there are more than one related session entity, the first is
        /// returned.</param>
        /// <param name="sessionEntityIds">The ids of the entities which are
        /// associated with this session. For some types
        /// (e.g. None) this value is empty.</param>
        /// <param name="externalLessonId">String</param>
        /// <param name="groupIds">Ids of groups related to the
        /// session.</param>
        /// <param name="roomIds">Ids of rooms related to the session.</param>
        /// <param name="teacherIds">Ids of teachers (or employees) related to
        /// the session.</param>
        /// <param name="date">The date when the session is held.</param>
        /// <param name="startTime">The time when the session starts.</param>
        /// <param name="endTime">The time when the session ends.</param>
        /// <param name="schoolHourEntryId">The id of the school hour entry
        /// which the session is scheduled to.</param>
        /// <param name="comment">String</param>
        /// <param name="recurrenceId">The recurrence id of the session, if
        /// any</param>
        public SessionDto(System.Guid sessionId, string sessionEntityType, string title, bool isPrivate, bool isMandatory, bool isCancelled, System.Guid? sessionEntityId = default(System.Guid?), IList<System.Guid> sessionEntityIds = default(IList<System.Guid>), string externalLessonId = default(string), IList<System.Guid> groupIds = default(IList<System.Guid>), IList<System.Guid> roomIds = default(IList<System.Guid>), IList<System.Guid> teacherIds = default(IList<System.Guid>), System.DateTime? date = default(System.DateTime?), string startTime = default(string), string endTime = default(string), System.Guid? schoolHourEntryId = default(System.Guid?), string comment = default(string), System.Guid? recurrenceId = default(System.Guid?))
        {
            SessionId = sessionId;
            SessionEntityType = sessionEntityType;
            SessionEntityId = sessionEntityId;
            SessionEntityIds = sessionEntityIds;
            ExternalLessonId = externalLessonId;
            GroupIds = groupIds;
            RoomIds = roomIds;
            TeacherIds = teacherIds;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
            SchoolHourEntryId = schoolHourEntryId;
            Comment = comment;
            Title = title;
            IsPrivate = isPrivate;
            IsMandatory = isMandatory;
            IsCancelled = isCancelled;
            RecurrenceId = recurrenceId;
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
        /// Gets or sets sessionEntityType
        /// </summary>
        /// <remarks>
        /// The type of session entity which is associated with this session.
        /// Possible values include: 'SubjectCourse', 'None',
        /// 'EducationalProgramme', 'PrivateAbsence', 'Meeting', 'Social',
        /// 'Other'
        /// </remarks>
        [JsonProperty(PropertyName = "sessionEntityType")]
        public string SessionEntityType { get; set; }

        /// <summary>
        /// Gets or sets the id of the entity which is associated with this
        /// session. If the type
        /// is None then this value is null, otherwise it has a value.
        ///
        /// If there are more than one related session entity, the first is
        /// returned.
        /// </summary>
        [JsonProperty(PropertyName = "sessionEntityId")]
        public System.Guid? SessionEntityId { get; set; }

        /// <summary>
        /// Gets or sets the ids of the entities which are associated with this
        /// session. For some types
        /// (e.g. None) this value is empty.
        /// </summary>
        [JsonProperty(PropertyName = "sessionEntityIds")]
        public IList<System.Guid> SessionEntityIds { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// An exsternal id for the session
        /// </remarks>
        [JsonProperty(PropertyName = "externalLessonId")]
        public string ExternalLessonId { get; set; }

        /// <summary>
        /// Gets or sets ids of groups related to the session.
        /// </summary>
        [JsonProperty(PropertyName = "groupIds")]
        public IList<System.Guid> GroupIds { get; set; }

        /// <summary>
        /// Gets or sets ids of rooms related to the session.
        /// </summary>
        [JsonProperty(PropertyName = "roomIds")]
        public IList<System.Guid> RoomIds { get; set; }

        /// <summary>
        /// Gets or sets ids of teachers (or employees) related to the session.
        /// </summary>
        [JsonProperty(PropertyName = "teacherIds")]
        public IList<System.Guid> TeacherIds { get; set; }

        /// <summary>
        /// Gets or sets the date when the session is held.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// Gets or sets the time when the session starts.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time when the session ends.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or sets the id of the school hour entry which the session is
        /// scheduled to.
        /// </summary>
        [JsonProperty(PropertyName = "schoolHourEntryId")]
        public System.Guid? SchoolHourEntryId { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Any comments (or description) for the session.
        /// </remarks>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Title of the session
        /// </remarks>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Whether the session is private
        /// </remarks>
        [JsonProperty(PropertyName = "isPrivate")]
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Whether the session is mandatory
        /// </remarks>
        [JsonProperty(PropertyName = "isMandatory")]
        public bool IsMandatory { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Whether the session is cancelled
        /// </remarks>
        [JsonProperty(PropertyName = "isCancelled")]
        public bool IsCancelled { get; set; }

        /// <summary>
        /// Gets or sets the recurrence id of the session, if any
        /// </summary>
        [JsonProperty(PropertyName = "recurrenceId")]
        public System.Guid? RecurrenceId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SessionEntityType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SessionEntityType");
            }
            if (Title == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Title");
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
            if (Title != null)
            {
                if (Title.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Title", 1);
                }
            }
        }
    }
}
