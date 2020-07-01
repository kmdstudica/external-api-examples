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
    /// RegisterLessonExternalCommand
    /// </summary>
    /// <remarks>
    /// Creates new lesson.
    /// </remarks>
    public partial class RegisterLessonExternalCommand
    {
        /// <summary>
        /// Initializes a new instance of the RegisterLessonExternalCommand
        /// class.
        /// </summary>
        public RegisterLessonExternalCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegisterLessonExternalCommand
        /// class.
        /// </summary>
        /// <param name="id">Identifier of the lesson.</param>
        /// <param name="subjectCourseId">The Id of the subject course this
        /// lesson is added to.</param>
        /// <param name="teacherIds">List of teacher' identifiers.</param>
        /// <param name="roomId">Identifier of the room where lesson is
        /// conducted.</param>
        /// <param name="date">Date of the lesson.</param>
        /// <param name="startTime">Start time of the lesson.</param>
        /// <param name="endTime">End time of the lesson.</param>
        /// <param name="schoolCode">The school code for which command is
        /// performed.</param>
        public RegisterLessonExternalCommand(System.Guid id, System.Guid subjectCourseId, IList<System.Guid> teacherIds, System.Guid? roomId = default(System.Guid?), System.DateTime? date = default(System.DateTime?), string startTime = default(string), string endTime = default(string), string schoolCode = default(string))
        {
            Id = id;
            RoomId = roomId;
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
        /// Gets or sets identifier of the room where lesson is conducted.
        /// </summary>
        [JsonProperty(PropertyName = "roomId")]
        public System.Guid? RoomId { get; set; }

        /// <summary>
        /// Gets or sets date of the lesson.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "date")]
        public System.DateTime? Date { get; set; }

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
        /// Gets or sets the school code for which command is performed.
        /// </summary>
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
