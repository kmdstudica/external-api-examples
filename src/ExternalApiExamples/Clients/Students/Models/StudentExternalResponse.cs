// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Students.Client.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// StudentExternalResponse
    /// </summary>
    /// <remarks>
    /// Model of the student.
    /// </remarks>
    public partial class StudentExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the StudentExternalResponse class.
        /// </summary>
        public StudentExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StudentExternalResponse class.
        /// </summary>
        /// <param name="id">Student's identifier.</param>
        /// <param name="civilRegistrationNumber">Student's civil registration
        /// number.</param>
        /// <param name="protectedNameAndAddress">Whether the name and address
        /// of the applicant are protected.</param>
        /// <param name="email">Student's e-mail address.</param>
        /// <param name="studyStartDate">Study date of start.</param>
        /// <param name="departmentId">Id of the department that student is
        /// affiliated to.</param>
        /// <param name="studentTypes">StudentTypes associated with the
        /// student.</param>
        /// <param name="guardians">The student's guardian(s).</param>
        /// <param name="givenName">Student's given name.</param>
        /// <param name="surname">Student's surname.</param>
        /// <param name="protectedGivenName">Protected given name from national
        /// registry</param>
        /// <param name="protectedSurname">Protected surname from national
        /// registry</param>
        /// <param name="careOfAddress">The C/O address line of the
        /// student.</param>
        /// <param name="addressLine">Full address including street, house-nr
        /// letter, etc. where the student lives.</param>
        /// <param name="place">The place of the student.</param>
        /// <param name="city">The city where the student lives.</param>
        /// <param name="postalCode">The matching postal code for the
        /// city.</param>
        /// <param name="country">The country where the student lives.</param>
        /// <param name="phoneNumber">The student's phone number.</param>
        /// <param name="uniLoginUsername">Student's Unilogin username.</param>
        /// <param name="studyEndDate">Study date of end.</param>
        /// <param name="dsDepartmentNumber">DS Department number that student
        /// is affiliated to.</param>
        /// <param name="studyEndCause">Cause of study ending.</param>
        /// <param name="adUsername">Student's Active Directory
        /// username.</param>
        public StudentExternalResponse(System.Guid id, string civilRegistrationNumber, bool protectedNameAndAddress, string email, System.DateTime studyStartDate, System.Guid departmentId, IList<StudentType> studentTypes, IList<StudentGuardian> guardians, string givenName = default(string), string surname = default(string), string protectedGivenName = default(string), string protectedSurname = default(string), string careOfAddress = default(string), string addressLine = default(string), string place = default(string), string city = default(string), string postalCode = default(string), string country = default(string), string phoneNumber = default(string), string uniLoginUsername = default(string), System.DateTime? studyEndDate = default(System.DateTime?), string dsDepartmentNumber = default(string), string studyEndCause = default(string), string adUsername = default(string))
        {
            Id = id;
            CivilRegistrationNumber = civilRegistrationNumber;
            GivenName = givenName;
            Surname = surname;
            ProtectedGivenName = protectedGivenName;
            ProtectedSurname = protectedSurname;
            CareOfAddress = careOfAddress;
            AddressLine = addressLine;
            Place = place;
            City = city;
            PostalCode = postalCode;
            Country = country;
            ProtectedNameAndAddress = protectedNameAndAddress;
            PhoneNumber = phoneNumber;
            Email = email;
            UniLoginUsername = uniLoginUsername;
            StudyStartDate = studyStartDate;
            StudyEndDate = studyEndDate;
            DepartmentId = departmentId;
            DsDepartmentNumber = dsDepartmentNumber;
            StudyEndCause = studyEndCause;
            AdUsername = adUsername;
            StudentTypes = studentTypes;
            Guardians = guardians;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets student's identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets student's civil registration number.
        /// </summary>
        [JsonProperty(PropertyName = "civilRegistrationNumber")]
        public string CivilRegistrationNumber { get; set; }

        /// <summary>
        /// Gets or sets student's given name.
        /// </summary>
        [JsonProperty(PropertyName = "givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets student's surname.
        /// </summary>
        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets protected given name from national registry
        /// </summary>
        [JsonProperty(PropertyName = "protectedGivenName")]
        public string ProtectedGivenName { get; set; }

        /// <summary>
        /// Gets or sets protected surname from national registry
        /// </summary>
        [JsonProperty(PropertyName = "protectedSurname")]
        public string ProtectedSurname { get; set; }

        /// <summary>
        /// Gets or sets the C/O address line of the student.
        /// </summary>
        [JsonProperty(PropertyName = "careOfAddress")]
        public string CareOfAddress { get; set; }

        /// <summary>
        /// Gets or sets full address including street, house-nr letter, etc.
        /// where the student lives.
        /// </summary>
        [JsonProperty(PropertyName = "addressLine")]
        public string AddressLine { get; set; }

        /// <summary>
        /// Gets or sets the place of the student.
        /// </summary>
        [JsonProperty(PropertyName = "place")]
        public string Place { get; set; }

        /// <summary>
        /// Gets or sets the city where the student lives.
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the matching postal code for the city.
        /// </summary>
        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the country where the student lives.
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets whether the name and address of the applicant are
        /// protected.
        /// </summary>
        [JsonProperty(PropertyName = "protectedNameAndAddress")]
        public bool ProtectedNameAndAddress { get; set; }

        /// <summary>
        /// Gets or sets the student's phone number.
        /// </summary>
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets student's e-mail address.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets student's Unilogin username.
        /// </summary>
        [JsonProperty(PropertyName = "uniLoginUsername")]
        public string UniLoginUsername { get; set; }

        /// <summary>
        /// Gets or sets study date of start.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "studyStartDate")]
        public System.DateTime StudyStartDate { get; set; }

        /// <summary>
        /// Gets or sets study date of end.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "studyEndDate")]
        public System.DateTime? StudyEndDate { get; set; }

        /// <summary>
        /// Gets or sets id of the department that student is affiliated to.
        /// </summary>
        [JsonProperty(PropertyName = "departmentId")]
        public System.Guid DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets DS Department number that student is affiliated to.
        /// </summary>
        [JsonProperty(PropertyName = "dsDepartmentNumber")]
        public string DsDepartmentNumber { get; set; }

        /// <summary>
        /// Gets or sets cause of study ending.
        /// </summary>
        [JsonProperty(PropertyName = "studyEndCause")]
        public string StudyEndCause { get; set; }

        /// <summary>
        /// Gets or sets student's Active Directory username.
        /// </summary>
        [JsonProperty(PropertyName = "adUsername")]
        public string AdUsername { get; set; }

        /// <summary>
        /// Gets or sets studentTypes associated with the student.
        /// </summary>
        [JsonProperty(PropertyName = "studentTypes")]
        public IList<StudentType> StudentTypes { get; set; }

        /// <summary>
        /// Gets or sets the student's guardian(s).
        /// </summary>
        [JsonProperty(PropertyName = "guardians")]
        public IList<StudentGuardian> Guardians { get; set; }

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
            if (Email == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Email");
            }
            if (StudentTypes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StudentTypes");
            }
            if (Guardians == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Guardians");
            }
            if (StudentTypes != null)
            {
                foreach (var element in StudentTypes)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Guardians != null)
            {
                foreach (var element1 in Guardians)
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
