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
    using System.Linq;

    /// <summary>
    /// SubjectCourseExternalResponse_GroupStudent
    /// </summary>
    /// <remarks>
    /// Model of a student participating in a group.
    /// </remarks>
    public partial class SubjectCourseExternalResponseGroupStudent
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SubjectCourseExternalResponseGroupStudent class.
        /// </summary>
        public SubjectCourseExternalResponseGroupStudent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SubjectCourseExternalResponseGroupStudent class.
        /// </summary>
        /// <param name="studentId">The id of the student participating in the
        /// group.</param>
        /// <param name="courseStudentType">CourseStudentType</param>
        /// <param name="startDate">Date</param>
        /// <param name="endDate">Date</param>
        public SubjectCourseExternalResponseGroupStudent(System.Guid studentId, string courseStudentType, System.DateTime startDate, System.DateTime endDate)
        {
            StudentId = studentId;
            CourseStudentType = courseStudentType;
            StartDate = startDate;
            EndDate = endDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the student participating in the group.
        /// </summary>
        [JsonProperty(PropertyName = "studentId")]
        public System.Guid StudentId { get; set; }

        /// <summary>
        /// Gets or sets courseStudentType
        /// </summary>
        /// <remarks>
        /// The type of student which the student id refers to. Possible values
        /// include: 'Student', 'BridgingCourseStudent', 'Employee',
        /// 'ExternalBoardingFacilityStudent'
        /// </remarks>
        [JsonProperty(PropertyName = "courseStudentType")]
        public string CourseStudentType { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// The start date of the particiaption.
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// The end date of the participation.
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime EndDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CourseStudentType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CourseStudentType");
            }
        }
    }
}
