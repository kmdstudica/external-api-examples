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
        /// <param name="id">Guid</param>
        /// <param name="educationalProgrammeId">Guid</param>
        /// <param name="name">String</param>
        /// <param name="startDate">Date</param>
        /// <param name="endDate">Date</param>
        /// <param name="lmsIndicator">Boolean</param>
        /// <param name="students">Assigned students.</param>
        /// <param name="teachersIds">Reference ids to assigned
        /// teachers.</param>
        /// <param name="isBridgingCourse">Boolean</param>
        /// <param name="associatedEducationalProgrammeIds">Ids of all
        /// associated educational programmes</param>
        /// <param name="groups">The groups of students participating in the
        /// subject course. Includes multiple
        /// levels of groups when available.</param>
        /// <param name="participants">The participants for the entire subject
        /// course.</param>
        /// <param name="designation">String</param>
        /// <param name="defaultSubjectId">The id of the default subject for
        /// this subject course.</param>
        /// <param name="deletedAt">If the subject course has been deleted,
        /// this property will have a value</param>
        /// <param name="insertedAt">When it was created</param>
        /// <param name="updatedAt">Last update of the subject course's basic
        /// information</param>
        public SubjectCourseExternalResponse(System.Guid id, System.Guid educationalProgrammeId, string name, System.DateTime startDate, System.DateTime endDate, bool lmsIndicator, IList<SubjectCourseExternalResponseStudent> students, IList<System.Guid> teachersIds, bool isBridgingCourse, IList<System.Guid> associatedEducationalProgrammeIds, IList<SubjectCourseExternalResponseGroup> groups, IList<SubjectCourseExternalResponseStudent> participants, string designation = default(string), System.Guid? defaultSubjectId = default(System.Guid?), System.DateTime? deletedAt = default(System.DateTime?), System.DateTime? insertedAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?))
        {
            Id = id;
            Designation = designation;
            EducationalProgrammeId = educationalProgrammeId;
            DefaultSubjectId = defaultSubjectId;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            LmsIndicator = lmsIndicator;
            DeletedAt = deletedAt;
            InsertedAt = insertedAt;
            UpdatedAt = updatedAt;
            Students = students;
            TeachersIds = teachersIds;
            IsBridgingCourse = isBridgingCourse;
            AssociatedEducationalProgrammeIds = associatedEducationalProgrammeIds;
            Groups = groups;
            Participants = participants;
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
        /// Id of the subject course.
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The designation (user facing unique id) of the subject course
        /// </remarks>
        [JsonProperty(PropertyName = "designation")]
        public string Designation { get; set; }

        /// <summary>
        /// Gets or sets guid
        /// </summary>
        /// <remarks>
        /// Id of the default associated educational programme.
        /// </remarks>
        [JsonProperty(PropertyName = "educationalProgrammeId")]
        public System.Guid EducationalProgrammeId { get; set; }

        /// <summary>
        /// Gets or sets the id of the default subject for this subject course.
        /// </summary>
        [JsonProperty(PropertyName = "defaultSubjectId")]
        public System.Guid? DefaultSubjectId { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Name of the subject course.
        /// </remarks>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// Start date of the subject course.
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// End date for the subject course.
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Is the entity to be created in the LMS.
        /// </remarks>
        [JsonProperty(PropertyName = "lmsIndicator")]
        public bool LmsIndicator { get; set; }

        /// <summary>
        /// Gets or sets if the subject course has been deleted, this property
        /// will have a value
        /// </summary>
        [JsonProperty(PropertyName = "deletedAt")]
        public System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Gets or sets when it was created
        /// </summary>
        [JsonProperty(PropertyName = "insertedAt")]
        public System.DateTime? InsertedAt { get; set; }

        /// <summary>
        /// Gets or sets last update of the subject course's basic information
        /// </summary>
        [JsonProperty(PropertyName = "updatedAt")]
        public System.DateTime? UpdatedAt { get; set; }

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
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Indicates that this is a bridging course
        /// </remarks>
        [JsonProperty(PropertyName = "isBridgingCourse")]
        public bool IsBridgingCourse { get; set; }

        /// <summary>
        /// Gets or sets ids of all associated educational programmes
        /// </summary>
        [JsonProperty(PropertyName = "associatedEducationalProgrammeIds")]
        public IList<System.Guid> AssociatedEducationalProgrammeIds { get; set; }

        /// <summary>
        /// Gets or sets the groups of students participating in the subject
        /// course. Includes multiple
        /// levels of groups when available.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<SubjectCourseExternalResponseGroup> Groups { get; set; }

        /// <summary>
        /// Gets or sets the participants for the entire subject course.
        /// </summary>
        [JsonProperty(PropertyName = "participants")]
        public IList<SubjectCourseExternalResponseStudent> Participants { get; set; }

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
            if (AssociatedEducationalProgrammeIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AssociatedEducationalProgrammeIds");
            }
            if (Groups == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Groups");
            }
            if (Participants == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Participants");
            }
            if (Name != null)
            {
                if (Name.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 1);
                }
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
            if (Groups != null)
            {
                foreach (var element1 in Groups)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (Participants != null)
            {
                foreach (var element2 in Participants)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}
