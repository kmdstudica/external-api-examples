// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolInternships.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// StudentInternshipsExternalResponse
    /// </summary>
    public partial class StudentInternshipsExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StudentInternshipsExternalResponse class.
        /// </summary>
        public StudentInternshipsExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// StudentInternshipsExternalResponse class.
        /// </summary>
        /// <param name="studentId">Guid</param>
        /// <param name="civilRegistrationNumber">String</param>
        /// <param name="givenName">String</param>
        /// <param name="surname">String</param>
        /// <param name="insertedAt">When it was created</param>
        /// <param name="updatedAt">Last update of student's
        /// information</param>
        /// <param name="writtenAgreements">List of the students written
        /// internship agreements</param>
        /// <param name="internshipPeriods">List of the students internship
        /// periods as split by fx. school course participation periods</param>
        public StudentInternshipsExternalResponse(System.Guid studentId, string civilRegistrationNumber = default(string), string givenName = default(string), string surname = default(string), System.DateTime? insertedAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?), IList<StudentInternshipsWrittenAgreementDto> writtenAgreements = default(IList<StudentInternshipsWrittenAgreementDto>), IList<StudentInternshipsInternshipPeriodDto> internshipPeriods = default(IList<StudentInternshipsInternshipPeriodDto>))
        {
            StudentId = studentId;
            CivilRegistrationNumber = civilRegistrationNumber;
            GivenName = givenName;
            Surname = surname;
            InsertedAt = insertedAt;
            UpdatedAt = updatedAt;
            WrittenAgreements = writtenAgreements;
            InternshipPeriods = internshipPeriods;
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
        /// Students civil registration number
        /// </remarks>
        [JsonProperty(PropertyName = "civilRegistrationNumber")]
        public string CivilRegistrationNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Students given name
        /// </remarks>
        [JsonProperty(PropertyName = "givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Students surname
        /// </remarks>
        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets when it was created
        /// </summary>
        [JsonProperty(PropertyName = "insertedAt")]
        public System.DateTime? InsertedAt { get; set; }

        /// <summary>
        /// Gets or sets last update of student's information
        /// </summary>
        [JsonProperty(PropertyName = "updatedAt")]
        public System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets list of the students written internship agreements
        /// </summary>
        [JsonProperty(PropertyName = "writtenAgreements")]
        public IList<StudentInternshipsWrittenAgreementDto> WrittenAgreements { get; set; }

        /// <summary>
        /// Gets or sets list of the students internship periods as split by
        /// fx. school course participation periods
        /// </summary>
        [JsonProperty(PropertyName = "internshipPeriods")]
        public IList<StudentInternshipsInternshipPeriodDto> InternshipPeriods { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (WrittenAgreements != null)
            {
                foreach (var element in WrittenAgreements)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (InternshipPeriods != null)
            {
                foreach (var element1 in InternshipPeriods)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
