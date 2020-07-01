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
        /// <param name="usePeriodFromSubjectCourse">Flag indicating, whether
        /// period should be taken from subject course.</param>
        /// <param name="startDate">Start date of the period.</param>
        /// <param name="endDate">End date of the period.</param>
        public SubjectCourseExternalResponseStudent(System.Guid studentId, bool usePeriodFromSubjectCourse, System.DateTime startDate, System.DateTime endDate, UVMSubjectDetails uvmSubject = default(UVMSubjectDetails))
        {
            StudentId = studentId;
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
        /// </summary>
        [JsonProperty(PropertyName = "uvmSubject")]
        public UVMSubjectDetails UvmSubject { get; set; }

        /// <summary>
        /// Gets or sets flag indicating, whether period should be taken from
        /// subject course.
        /// </summary>
        [JsonProperty(PropertyName = "usePeriodFromSubjectCourse")]
        public bool UsePeriodFromSubjectCourse { get; set; }

        /// <summary>
        /// Gets or sets start date of the period.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets end date of the period.
        /// </summary>
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
            if (UvmSubject != null)
            {
                UvmSubject.Validate();
            }
        }
    }
}
