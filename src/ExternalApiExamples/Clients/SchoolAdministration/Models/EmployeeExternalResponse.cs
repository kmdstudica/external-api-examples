// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolAdministration.Client.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// EmployeeExternalResponse
    /// </summary>
    /// <remarks>
    /// Model of the employee.
    /// </remarks>
    public partial class EmployeeExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the EmployeeExternalResponse class.
        /// </summary>
        public EmployeeExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EmployeeExternalResponse class.
        /// </summary>
        /// <param name="id">Gets employee identifier in Studica.</param>
        /// <param name="civilRegistrationNumber">String</param>
        /// <param name="protectedNameAndAddress">Boolean</param>
        /// <param name="lmsIndicator">Boolean</param>
        /// <param name="givenName">String</param>
        /// <param name="surname">String</param>
        /// <param name="email">String</param>
        /// <param name="deceased">Boolean</param>
        /// <param name="reportToUniLogin">Boolean</param>
        /// <param name="createAdLogin">Boolean</param>
        /// <param name="employmentStartDate">Date</param>
        /// <param name="protectedGivenName">String</param>
        /// <param name="protectedSurname">String</param>
        /// <param name="initials">String</param>
        /// <param name="privateEmail">String</param>
        /// <param name="phoneNumber">String</param>
        /// <param name="mobileNumber">String</param>
        /// <param name="privatePhoneNumber">String</param>
        /// <param name="uniLoginUsername">String</param>
        /// <param name="adUserName">String</param>
        /// <param name="roleNames">Gets employee roles.</param>
        /// <param name="jobTitle">String</param>
        /// <param name="employmentResignationDate">Gets employee resignation
        /// date.</param>
        /// <param name="areaOfResponsibilityId">Reference id to the area of
        /// responsibility.</param>
        /// <param name="departmentIds">Gets employee department
        /// affilation.</param>
        /// <param name="addressLine">String</param>
        /// <param name="careOfAddressLine">String</param>
        /// <param name="place">String</param>
        /// <param name="city">String</param>
        /// <param name="postalCode">String</param>
        /// <param name="country">String</param>
        /// <param name="insertedAt">When was employee created</param>
        /// <param name="updatedAt">Last update of the employee</param>
        public EmployeeExternalResponse(System.Guid id, string civilRegistrationNumber, bool protectedNameAndAddress, bool lmsIndicator, string givenName, string surname, string email, bool deceased, bool reportToUniLogin, bool createAdLogin, System.DateTime employmentStartDate, string protectedGivenName = default(string), string protectedSurname = default(string), string initials = default(string), string privateEmail = default(string), string phoneNumber = default(string), string mobileNumber = default(string), string privatePhoneNumber = default(string), string uniLoginUsername = default(string), string adUserName = default(string), IList<string> roleNames = default(IList<string>), string jobTitle = default(string), System.DateTime? employmentResignationDate = default(System.DateTime?), System.Guid? areaOfResponsibilityId = default(System.Guid?), IList<System.Guid> departmentIds = default(IList<System.Guid>), string addressLine = default(string), string careOfAddressLine = default(string), string place = default(string), string city = default(string), string postalCode = default(string), string country = default(string), System.DateTime? insertedAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?))
        {
            Id = id;
            CivilRegistrationNumber = civilRegistrationNumber;
            ProtectedNameAndAddress = protectedNameAndAddress;
            LmsIndicator = lmsIndicator;
            GivenName = givenName;
            Surname = surname;
            ProtectedGivenName = protectedGivenName;
            ProtectedSurname = protectedSurname;
            Initials = initials;
            Email = email;
            PrivateEmail = privateEmail;
            PhoneNumber = phoneNumber;
            MobileNumber = mobileNumber;
            PrivatePhoneNumber = privatePhoneNumber;
            Deceased = deceased;
            UniLoginUsername = uniLoginUsername;
            ReportToUniLogin = reportToUniLogin;
            CreateAdLogin = createAdLogin;
            AdUserName = adUserName;
            RoleNames = roleNames;
            JobTitle = jobTitle;
            EmploymentStartDate = employmentStartDate;
            EmploymentResignationDate = employmentResignationDate;
            AreaOfResponsibilityId = areaOfResponsibilityId;
            DepartmentIds = departmentIds;
            AddressLine = addressLine;
            CareOfAddressLine = careOfAddressLine;
            Place = place;
            City = city;
            PostalCode = postalCode;
            Country = country;
            InsertedAt = insertedAt;
            UpdatedAt = updatedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets employee identifier in Studica.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee civil registration number.
        /// </remarks>
        [JsonProperty(PropertyName = "civilRegistrationNumber")]
        public string CivilRegistrationNumber { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Gets a flag indicating if name and address are protected.
        /// </remarks>
        [JsonProperty(PropertyName = "protectedNameAndAddress")]
        public bool ProtectedNameAndAddress { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Gets Learning Management System indicator.
        /// </remarks>
        [JsonProperty(PropertyName = "lmsIndicator")]
        public bool LmsIndicator { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee given name.
        /// </remarks>
        [JsonProperty(PropertyName = "givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee surname.
        /// </remarks>
        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee protected given name.
        /// </remarks>
        [JsonProperty(PropertyName = "protectedGivenName")]
        public string ProtectedGivenName { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee protected surname.
        /// </remarks>
        [JsonProperty(PropertyName = "protectedSurname")]
        public string ProtectedSurname { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee initials.
        /// </remarks>
        [JsonProperty(PropertyName = "initials")]
        public string Initials { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee e-mail address.
        /// </remarks>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The employee's private e-mail address.
        /// </remarks>
        [JsonProperty(PropertyName = "privateEmail")]
        public string PrivateEmail { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee phone number.
        /// </remarks>
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The employee's work related mobile phone number.
        /// </remarks>
        [JsonProperty(PropertyName = "mobileNumber")]
        public string MobileNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The employee's private phone number.
        /// </remarks>
        [JsonProperty(PropertyName = "privatePhoneNumber")]
        public string PrivatePhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Gets indticator if employee is deceased.
        /// </remarks>
        [JsonProperty(PropertyName = "deceased")]
        public bool Deceased { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee Unilogin username.
        /// </remarks>
        [JsonProperty(PropertyName = "uniLoginUsername")]
        public string UniLoginUsername { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Flag denoting whether the employee should be created as a user in
        /// UNI-Login
        /// </remarks>
        [JsonProperty(PropertyName = "reportToUniLogin")]
        public bool ReportToUniLogin { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Flag denoting whether the employee should be created in the local
        /// Active Directory
        /// </remarks>
        [JsonProperty(PropertyName = "createAdLogin")]
        public bool CreateAdLogin { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee Active Directory username.
        /// </remarks>
        [JsonProperty(PropertyName = "adUserName")]
        public string AdUserName { get; set; }

        /// <summary>
        /// Gets employee roles.
        /// </summary>
        [JsonProperty(PropertyName = "roleNames")]
        public IList<string> RoleNames { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee job title.
        /// </remarks>
        [JsonProperty(PropertyName = "jobTitle")]
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// Gets employee start date.
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "employmentStartDate")]
        public System.DateTime EmploymentStartDate { get; set; }

        /// <summary>
        /// Gets employee resignation date.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "employmentResignationDate")]
        public System.DateTime? EmploymentResignationDate { get; set; }

        /// <summary>
        /// Gets or sets reference id to the area of responsibility.
        /// </summary>
        [JsonProperty(PropertyName = "areaOfResponsibilityId")]
        public System.Guid? AreaOfResponsibilityId { get; set; }

        /// <summary>
        /// Gets employee department affilation.
        /// </summary>
        [JsonProperty(PropertyName = "departmentIds")]
        public IList<System.Guid> DepartmentIds { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee address line.
        /// </remarks>
        [JsonProperty(PropertyName = "addressLine")]
        public string AddressLine { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee care of address line.
        /// </remarks>
        [JsonProperty(PropertyName = "careOfAddressLine")]
        public string CareOfAddressLine { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee place.
        /// </remarks>
        [JsonProperty(PropertyName = "place")]
        public string Place { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee city.
        /// </remarks>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee postal code.
        /// </remarks>
        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Gets employee country.
        /// </remarks>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets when was employee created
        /// </summary>
        [JsonProperty(PropertyName = "insertedAt")]
        public System.DateTime? InsertedAt { get; set; }

        /// <summary>
        /// Gets or sets last update of the employee
        /// </summary>
        [JsonProperty(PropertyName = "updatedAt")]
        public System.DateTime? UpdatedAt { get; set; }

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
            if (GivenName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GivenName");
            }
            if (Surname == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Surname");
            }
            if (Email == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Email");
            }
            if (CivilRegistrationNumber != null)
            {
                if (CivilRegistrationNumber.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "CivilRegistrationNumber", 1);
                }
            }
            if (GivenName != null)
            {
                if (GivenName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "GivenName", 1);
                }
            }
            if (Surname != null)
            {
                if (Surname.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Surname", 1);
                }
            }
            if (Email != null)
            {
                if (Email.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Email", 1);
                }
            }
        }
    }
}
