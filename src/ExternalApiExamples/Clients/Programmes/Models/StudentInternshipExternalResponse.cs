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
    /// StudentInternshipExternalResponse
    /// </summary>
    /// <remarks>
    /// Model of a student's internship agreements and school based periods
    /// </remarks>
    public partial class StudentInternshipExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the StudentInternshipExternalResponse
        /// class.
        /// </summary>
        public StudentInternshipExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StudentInternshipExternalResponse
        /// class.
        /// </summary>
        /// <param name="studentId">Id of student</param>
        /// <param name="civilRegistrationNumber">String</param>
        /// <param name="givenName">String</param>
        /// <param name="surname">String</param>
        /// <param name="writtenAgreements">List of the student's written
        /// internship agreements</param>
        /// <param name="schoolInternships">List of school based internships
        /// for the student linked to the written agreement</param>
        /// <param name="contributionPeriods">List of contribution
        /// periods</param>
        public StudentInternshipExternalResponse(System.Guid studentId, string civilRegistrationNumber = default(string), string givenName = default(string), string surname = default(string), IList<StudentInternshipWrittenAgreement> writtenAgreements = default(IList<StudentInternshipWrittenAgreement>), IList<StudentInternshipSchoolInternship> schoolInternships = default(IList<StudentInternshipSchoolInternship>), IList<StudentInternshipContributionPeriodDto> contributionPeriods = default(IList<StudentInternshipContributionPeriodDto>))
        {
            StudentId = studentId;
            CivilRegistrationNumber = civilRegistrationNumber;
            GivenName = givenName;
            Surname = surname;
            WrittenAgreements = writtenAgreements;
            SchoolInternships = schoolInternships;
            ContributionPeriods = contributionPeriods;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of student
        /// </summary>
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
        /// Gets or sets list of the student's written internship agreements
        /// </summary>
        [JsonProperty(PropertyName = "writtenAgreements")]
        public IList<StudentInternshipWrittenAgreement> WrittenAgreements { get; set; }

        /// <summary>
        /// Gets or sets list of school based internships for the student
        /// linked to the written agreement
        /// </summary>
        [JsonProperty(PropertyName = "schoolInternships")]
        public IList<StudentInternshipSchoolInternship> SchoolInternships { get; set; }

        /// <summary>
        /// Gets or sets list of contribution periods
        /// </summary>
        [JsonProperty(PropertyName = "contributionPeriods")]
        public IList<StudentInternshipContributionPeriodDto> ContributionPeriods { get; set; }

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
            if (SchoolInternships != null)
            {
                foreach (var element1 in SchoolInternships)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (ContributionPeriods != null)
            {
                foreach (var element2 in ContributionPeriods)
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
