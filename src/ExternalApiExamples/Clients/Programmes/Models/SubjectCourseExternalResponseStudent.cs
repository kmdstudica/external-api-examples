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
    /// SubjectCourseExternalResponse_Student
    /// </summary>
    /// <remarks>
    /// Model of the student assigned to a subject course.
    /// </remarks>
    public partial class SubjectCourseExternalResponseStudent
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SubjectCourseExternalResponseStudent class.
        /// </summary>
        public SubjectCourseExternalResponseStudent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SubjectCourseExternalResponseStudent class.
        /// </summary>
        /// <param name="studentId">Id of the student.</param>
        /// <param name="courseStudentType">CourseStudentType</param>
        /// <param name="usePeriodFromSubjectCourse">Boolean</param>
        /// <param name="startDate">Date</param>
        /// <param name="endDate">Date</param>
        /// <param name="uvmSubject">Subject that student is assigned
        /// to.</param>
        public SubjectCourseExternalResponseStudent(System.Guid studentId, string courseStudentType, bool usePeriodFromSubjectCourse, System.DateTime startDate, System.DateTime endDate, SubjectCourseExternalResponseStudentUvmSubject uvmSubject = default(SubjectCourseExternalResponseStudentUvmSubject))
        {
            StudentId = studentId;
            CourseStudentType = courseStudentType;
            UvmSubject = uvmSubject;
            UsePeriodFromSubjectCourse = usePeriodFromSubjectCourse;
            StartDate = startDate;
            EndDate = endDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the student.
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
        /// Gets or sets subject that student is assigned to.
        /// </summary>
        [JsonProperty(PropertyName = "uvmSubject")]
        public SubjectCourseExternalResponseStudentUvmSubject UvmSubject { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Flag indicating, whether period should be taken from subject
        /// course.
        /// </remarks>
        [JsonProperty(PropertyName = "usePeriodFromSubjectCourse")]
        public bool UsePeriodFromSubjectCourse { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// Start date of the period.
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// End date of the period.
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
            if (UvmSubject != null)
            {
                UvmSubject.Validate();
            }
        }
    }
}
