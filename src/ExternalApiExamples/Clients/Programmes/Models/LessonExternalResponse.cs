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
    /// LessonExternalResponse
    /// </summary>
    /// <remarks>
    /// The model of lesson.
    /// </remarks>
    public partial class LessonExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the LessonExternalResponse class.
        /// </summary>
        public LessonExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LessonExternalResponse class.
        /// </summary>
        /// <param name="id">Unique identifier.</param>
        /// <param name="sessionEntityType">SessionEntityType</param>
        /// <param name="subjectCourseId">Reference to the subject course that
        /// lesson is part of.</param>
        /// <param name="date">Date</param>
        /// <param name="title">String</param>
        /// <param name="isPrivate">Boolean</param>
        /// <param name="isMandatory">Boolean</param>
        /// <param name="isCancelled">Boolean</param>
        /// <param name="externalLessonId">String</param>
        /// <param name="subjectCourseIds">The ids of the subject courses which
        /// are associated with this session. If the type
        /// is anything else than SubjectCourse, this value is empty.</param>
        /// <param name="sessionEntityIds">The ids of the entities which are
        /// associated with this session. For some types
        /// (e.g. None) this value is empty.</param>
        /// <param name="roomId">Obsolete!
        /// Reference to the room where lesson is conducted.
        /// Use RoomIds instead of RoomId. RoomId will be removed in a future
        /// update.</param>
        /// <param name="roomIds">The ids of the rooms where the lesson is
        /// conducted.</param>
        /// <param name="startTime">Start time of the lesson.
        /// This property is filled if the lesson is using a user defined
        /// schedule</param>
        /// <param name="endTime">End time of the lesson.
        /// This property is filled if the lesson is using a user defined
        /// schedule</param>
        /// <param name="schoolHourEntryId">If the lesson is planned using the
        /// school hours time table, the SchoolHourEntryId will be populated.
        /// If the lesson otherwise is using custom start and end time, the
        /// SchoolHourEntryId will be null (this is the default of most of the
        /// partnering time table systems)</param>
        /// <param name="teachersIds">Teachers (or employees) assigned to the
        /// lesson.</param>
        /// <param name="comment">String</param>
        /// <param name="recurrenceId">The recurrence id of the session, if
        /// any</param>
        public LessonExternalResponse(System.Guid id, string sessionEntityType, System.Guid subjectCourseId, System.DateTime date, string title, bool isPrivate, bool isMandatory, bool isCancelled, string externalLessonId = default(string), IList<System.Guid> subjectCourseIds = default(IList<System.Guid>), IList<System.Guid> sessionEntityIds = default(IList<System.Guid>), System.Guid? roomId = default(System.Guid?), IList<System.Guid> roomIds = default(IList<System.Guid>), string startTime = default(string), string endTime = default(string), System.Guid? schoolHourEntryId = default(System.Guid?), IList<System.Guid> teachersIds = default(IList<System.Guid>), string comment = default(string), System.Guid? recurrenceId = default(System.Guid?))
        {
            Id = id;
            SessionEntityType = sessionEntityType;
            ExternalLessonId = externalLessonId;
            SubjectCourseId = subjectCourseId;
            SubjectCourseIds = subjectCourseIds;
            SessionEntityIds = sessionEntityIds;
            RoomId = roomId;
            RoomIds = roomIds;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
            SchoolHourEntryId = schoolHourEntryId;
            TeachersIds = teachersIds;
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
        /// Gets or sets unique identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

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
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// External identifier set by partners to allow them to match it with
        /// the lessons known by them.
        /// </remarks>
        [JsonProperty(PropertyName = "externalLessonId")]
        public string ExternalLessonId { get; set; }

        /// <summary>
        /// Gets or sets reference to the subject course that lesson is part
        /// of.
        /// </summary>
        [JsonProperty(PropertyName = "subjectCourseId")]
        public System.Guid SubjectCourseId { get; set; }

        /// <summary>
        /// Gets or sets the ids of the subject courses which are associated
        /// with this session. If the type
        /// is anything else than SubjectCourse, this value is empty.
        /// </summary>
        [JsonProperty(PropertyName = "subjectCourseIds")]
        public IList<System.Guid> SubjectCourseIds { get; set; }

        /// <summary>
        /// Gets or sets the ids of the entities which are associated with this
        /// session. For some types
        /// (e.g. None) this value is empty.
        /// </summary>
        [JsonProperty(PropertyName = "sessionEntityIds")]
        public IList<System.Guid> SessionEntityIds { get; set; }

        /// <summary>
        /// Gets or sets obsolete!
        /// Reference to the room where lesson is conducted.
        /// Use RoomIds instead of RoomId. RoomId will be removed in a future
        /// update.
        /// </summary>
        [JsonProperty(PropertyName = "roomId")]
        public System.Guid? RoomId { get; set; }

        /// <summary>
        /// Gets or sets the ids of the rooms where the lesson is conducted.
        /// </summary>
        [JsonProperty(PropertyName = "roomIds")]
        public IList<System.Guid> RoomIds { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// Date of the lesson.
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "date")]
        public System.DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets start time of the lesson.
        /// This property is filled if the lesson is using a user defined
        /// schedule
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets end time of the lesson.
        /// This property is filled if the lesson is using a user defined
        /// schedule
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or sets if the lesson is planned using the school hours time
        /// table, the SchoolHourEntryId will be populated.
        /// If the lesson otherwise is using custom start and end time, the
        /// SchoolHourEntryId will be null (this is the default of most of the
        /// partnering time table systems)
        /// </summary>
        [JsonProperty(PropertyName = "schoolHourEntryId")]
        public System.Guid? SchoolHourEntryId { get; set; }

        /// <summary>
        /// Gets or sets teachers (or employees) assigned to the lesson.
        /// </summary>
        [JsonProperty(PropertyName = "teachersIds")]
        public IList<System.Guid> TeachersIds { get; set; }

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
