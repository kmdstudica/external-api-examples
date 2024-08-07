// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// RegisterAbsenceExternalCommand
    /// </summary>
    /// <remarks>
    /// Registers absence of student.
    /// </remarks>
    public partial class RegisterAbsenceExternalCommand
    {
        /// <summary>
        /// Initializes a new instance of the RegisterAbsenceExternalCommand
        /// class.
        /// </summary>
        public RegisterAbsenceExternalCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegisterAbsenceExternalCommand
        /// class.
        /// </summary>
        /// <param name="lessonId">Id of lesson to register absence on.</param>
        /// <param name="subjectCourseId">Id of the subject course the lesson
        /// is part of.</param>
        /// <param name="absenceRegistered">Boolean</param>
        /// <param name="absenceRegistrations">The absence registrations on the
        /// lesson.</param>
        /// <param name="schoolCode">String</param>
        public RegisterAbsenceExternalCommand(System.Guid lessonId, System.Guid subjectCourseId, bool absenceRegistered, IList<RegisterAbsenceRegistrationDto> absenceRegistrations, string schoolCode = default(string))
        {
            LessonId = lessonId;
            SubjectCourseId = subjectCourseId;
            AbsenceRegistered = absenceRegistered;
            AbsenceRegistrations = absenceRegistrations;
            SchoolCode = schoolCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of lesson to register absence on.
        /// </summary>
        [JsonProperty(PropertyName = "lessonId")]
        public System.Guid LessonId { get; set; }

        /// <summary>
        /// Gets or sets id of the subject course the lesson is part of.
        /// </summary>
        [JsonProperty(PropertyName = "subjectCourseId")]
        public System.Guid SubjectCourseId { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Has all absence been registered
        /// </remarks>
        [JsonProperty(PropertyName = "absenceRegistered")]
        public bool AbsenceRegistered { get; set; }

        /// <summary>
        /// Gets or sets the absence registrations on the lesson.
        /// </summary>
        [JsonProperty(PropertyName = "absenceRegistrations")]
        public IList<RegisterAbsenceRegistrationDto> AbsenceRegistrations { get; set; }

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
            if (AbsenceRegistrations == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AbsenceRegistrations");
            }
            if (AbsenceRegistrations != null)
            {
                foreach (var element in AbsenceRegistrations)
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
