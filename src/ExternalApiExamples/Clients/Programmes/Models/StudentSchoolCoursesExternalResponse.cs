// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// StudentSchoolCoursesExternalResponse
    /// </summary>
    /// <remarks>
    /// Details of a students school course participation periods
    /// </remarks>
    public partial class StudentSchoolCoursesExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StudentSchoolCoursesExternalResponse class.
        /// </summary>
        public StudentSchoolCoursesExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// StudentSchoolCoursesExternalResponse class.
        /// </summary>
        /// <param name="studentId">Guid</param>
        /// <param name="civilRegistrationNumber">String</param>
        /// <param name="schoolCourseParticipations">List of school course
        /// participation periods</param>
        public StudentSchoolCoursesExternalResponse(System.Guid studentId, string civilRegistrationNumber = default(string), IList<StudentSchoolCourseParticipation> schoolCourseParticipations = default(IList<StudentSchoolCourseParticipation>))
        {
            StudentId = studentId;
            CivilRegistrationNumber = civilRegistrationNumber;
            SchoolCourseParticipations = schoolCourseParticipations;
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
        /// Id of student
        /// </remarks>
        [JsonProperty(PropertyName = "studentId")]
        public System.Guid StudentId { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Student's civil registration number (CPR)
        /// </remarks>
        [JsonProperty(PropertyName = "civilRegistrationNumber")]
        public string CivilRegistrationNumber { get; set; }

        /// <summary>
        /// Gets or sets list of school course participation periods
        /// </summary>
        [JsonProperty(PropertyName = "schoolCourseParticipations")]
        public IList<StudentSchoolCourseParticipation> SchoolCourseParticipations { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SchoolCourseParticipations != null)
            {
                foreach (var element in SchoolCourseParticipations)
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
