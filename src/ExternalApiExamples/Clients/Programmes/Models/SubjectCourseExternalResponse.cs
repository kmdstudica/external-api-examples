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
    /// SubjectCourseExternalResponse
    /// </summary>
    /// <remarks>
    /// Model of the subject course.
    /// </remarks>
    public partial class SubjectCourseExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the SubjectCourseExternalResponse
        /// class.
        /// </summary>
        public SubjectCourseExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubjectCourseExternalResponse
        /// class.
        /// </summary>
        /// <param name="id">Id of the subject course.</param>
        /// <param name="educationalProgrammeId">Id of the associated
        /// educational programme.</param>
        /// <param name="name">Name of the subject course.</param>
        /// <param name="startDate">Start date of the subject course.</param>
        /// <param name="endDate">End date for the subject course.</param>
        /// <param name="lmsIndicator">Is the entity to be created in the
        /// LMS.</param>
        /// <param name="students">Assigned students.</param>
        /// <param name="teachersIds">Reference ids to assigned
        /// teachers.</param>
        /// <param name="designation">The designation (user facing unique id)
        /// of the subject course</param>
        /// <param name="defaultSubjectId">The id of the default subject for
        /// this subject course.</param>
        public SubjectCourseExternalResponse(System.Guid id, System.Guid educationalProgrammeId, string name, System.DateTime startDate, System.DateTime endDate, bool lmsIndicator, IList<SubjectCourseExternalResponseStudent> students, IList<System.Guid> teachersIds, string designation = default(string), System.Guid? defaultSubjectId = default(System.Guid?))
        {
            Id = id;
            Designation = designation;
            EducationalProgrammeId = educationalProgrammeId;
            DefaultSubjectId = defaultSubjectId;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            LmsIndicator = lmsIndicator;
            Students = students;
            TeachersIds = teachersIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the subject course.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the designation (user facing unique id) of the subject
        /// course
        /// </summary>
        [JsonProperty(PropertyName = "designation")]
        public string Designation { get; set; }

        /// <summary>
        /// Gets or sets id of the associated educational programme.
        /// </summary>
        [JsonProperty(PropertyName = "educationalProgrammeId")]
        public System.Guid EducationalProgrammeId { get; set; }

        /// <summary>
        /// Gets or sets the id of the default subject for this subject course.
        /// </summary>
        [JsonProperty(PropertyName = "defaultSubjectId")]
        public System.Guid? DefaultSubjectId { get; set; }

        /// <summary>
        /// Gets or sets name of the subject course.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets start date of the subject course.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets end date for the subject course.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets is the entity to be created in the LMS.
        /// </summary>
        [JsonProperty(PropertyName = "lmsIndicator")]
        public bool LmsIndicator { get; set; }

        /// <summary>
        /// Gets or sets assigned students.
        /// </summary>
        [JsonProperty(PropertyName = "students")]
        public IList<SubjectCourseExternalResponseStudent> Students { get; set; }

        /// <summary>
        /// Gets or sets reference ids to assigned teachers.
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
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Students == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Students");
            }
            if (TeachersIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TeachersIds");
            }
            if (Students != null)
            {
                foreach (var element in Students)
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
