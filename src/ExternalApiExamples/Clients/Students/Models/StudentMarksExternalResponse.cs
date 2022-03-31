// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Students.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// StudentMarksExternalResponse
    /// </summary>
    /// <remarks>
    /// Model of student marks response
    /// </remarks>
    public partial class StudentMarksExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the StudentMarksExternalResponse
        /// class.
        /// </summary>
        public StudentMarksExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StudentMarksExternalResponse
        /// class.
        /// </summary>
        /// <param name="studentId">Guid</param>
        /// <param name="civilRegistrationNumber">String</param>
        /// <param name="givenName">String</param>
        /// <param name="surname">String</param>
        /// <param name="protectedGivenName">String</param>
        /// <param name="protectedSurname">String</param>
        public StudentMarksExternalResponse(System.Guid studentId, string civilRegistrationNumber, string givenName = default(string), string surname = default(string), string protectedGivenName = default(string), string protectedSurname = default(string), IList<StudentMark> marks = default(IList<StudentMark>))
        {
            StudentId = studentId;
            CivilRegistrationNumber = civilRegistrationNumber;
            GivenName = givenName;
            Surname = surname;
            ProtectedGivenName = protectedGivenName;
            ProtectedSurname = protectedSurname;
            Marks = marks;
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
        /// Student's identifier.
        /// </remarks>
        [JsonProperty(PropertyName = "studentId")]
        public System.Guid StudentId { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Student's civil registration (CPR) number.
        /// </remarks>
        [JsonProperty(PropertyName = "civilRegistrationNumber")]
        public string CivilRegistrationNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Student's given name.
        /// </remarks>
        [JsonProperty(PropertyName = "givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Student's surname.
        /// </remarks>
        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Protected given name from national registry
        /// </remarks>
        [JsonProperty(PropertyName = "protectedGivenName")]
        public string ProtectedGivenName { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Protected surname from national registry
        /// </remarks>
        [JsonProperty(PropertyName = "protectedSurname")]
        public string ProtectedSurname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "marks")]
        public IList<StudentMark> Marks { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CivilRegistrationNumber == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CivilRegistrationNumber");
            }
            if (Marks != null)
            {
                foreach (var element in Marks)
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