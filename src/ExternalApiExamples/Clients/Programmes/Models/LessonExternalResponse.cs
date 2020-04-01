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
        /// <param name="subjectCourseId">Reference to the subject course that
        /// lesson is part of.</param>
        /// <param name="date">Date of the lesson.</param>
        /// <param name="name">Name of the lesson.</param>
        /// <param name="roomId">Reference to the room where lesson is
        /// conducted.</param>
        /// <param name="startTime">Start time of the lesson.</param>
        /// <param name="endTime">End time of the lesson.</param>
        /// <param name="teachersIds">Teachers assigned to the lesson.</param>
        public LessonExternalResponse(System.Guid id, System.Guid subjectCourseId, System.DateTime date, string name = default(string), System.Guid? roomId = default(System.Guid?), string startTime = default(string), string endTime = default(string), IList<System.Guid> teachersIds = default(IList<System.Guid>))
        {
            Id = id;
            Name = name;
            SubjectCourseId = subjectCourseId;
            RoomId = roomId;
            Date = date;
            StartTime = startTime;
            EndTime = endTime;
            TeachersIds = teachersIds;
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
        /// Gets or sets name of the lesson.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets reference to the subject course that lesson is part
        /// of.
        /// </summary>
        [JsonProperty(PropertyName = "subjectCourseId")]
        public System.Guid SubjectCourseId { get; set; }

        /// <summary>
        /// Gets or sets reference to the room where lesson is conducted.
        /// </summary>
        [JsonProperty(PropertyName = "roomId")]
        public System.Guid? RoomId { get; set; }

        /// <summary>
        /// Gets or sets date of the lesson.
        /// </summary>
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
        /// Gets or sets teachers assigned to the lesson.
        /// </summary>
        [JsonProperty(PropertyName = "teachersIds")]
        public IList<System.Guid> TeachersIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}