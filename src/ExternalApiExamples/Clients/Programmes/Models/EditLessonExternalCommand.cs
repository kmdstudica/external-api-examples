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
    /// EditLessonExternalCommand
    /// </summary>
    /// <remarks>
    /// Edits existing lesson.
    /// </remarks>
    public partial class EditLessonExternalCommand
    {
        /// <summary>
        /// Initializes a new instance of the EditLessonExternalCommand class.
        /// </summary>
        public EditLessonExternalCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EditLessonExternalCommand class.
        /// </summary>
        /// <param name="id">Identifier of the lesson.</param>
        /// <param name="date">Date</param>
        /// <param name="subjectCourseId">The Id of the subject course this
        /// lesson is added to.</param>
        /// <param name="teacherIds">List of teacher' identifiers.</param>
        /// <param name="externalLessonId">String</param>
        /// <param name="roomId">Obsolete!
        /// Identifier of the room where lesson is conducted.
        /// Use RoomIds instead of RoomId. RoomId will be removed in a future
        /// update.</param>
        /// <param name="roomIds">The Ids of the rooms where the lesson is
        /// conducted.</param>
        /// <param name="startTime">Start time of the lesson.</param>
        /// <param name="endTime">End time of the lesson.</param>
        /// <param name="schoolCode">String</param>
        public EditLessonExternalCommand(System.Guid id, System.DateTime date, System.Guid subjectCourseId, IList<System.Guid> teacherIds, string externalLessonId = default(string), System.Guid? roomId = default(System.Guid?), IList<System.Guid> roomIds = default(IList<System.Guid>), string startTime = default(string), string endTime = default(string), string schoolCode = default(string))
        {
            Id = id;
            ExternalLessonId = externalLessonId;
            RoomId = roomId;
            RoomIds = roomIds;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
            SubjectCourseId = subjectCourseId;
            TeacherIds = teacherIds;
            SchoolCode = schoolCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets identifier of the lesson.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

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
        /// Gets or sets obsolete!
        /// Identifier of the room where lesson is conducted.
        /// Use RoomIds instead of RoomId. RoomId will be removed in a future
        /// update.
        /// </summary>
        [JsonProperty(PropertyName = "roomId")]
        public System.Guid? RoomId { get; set; }

        /// <summary>
        /// Gets or sets the Ids of the rooms where the lesson is conducted.
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
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets end time of the lesson.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or sets the Id of the subject course this lesson is added to.
        /// </summary>
        [JsonProperty(PropertyName = "subjectCourseId")]
        public System.Guid SubjectCourseId { get; set; }

        /// <summary>
        /// Gets or sets list of teacher' identifiers.
        /// </summary>
        [JsonProperty(PropertyName = "teacherIds")]
        public IList<System.Guid> TeacherIds { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The school code for which command is performed.
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
            if (TeacherIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TeacherIds");
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
        }
    }
}
