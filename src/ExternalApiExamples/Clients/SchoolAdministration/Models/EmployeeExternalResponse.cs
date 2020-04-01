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
        /// <param name="civilRegistrationNumber">Gets employee civil
        /// registration number.</param>
        /// <param name="lmsIndicator">Gets Learning Management System
        /// indicator.</param>
        /// <param name="givenName">Gets employee given name.</param>
        /// <param name="surname">Gets employee surname.</param>
        /// <param name="email">Gets employee e-mail address.</param>
        /// <param name="employmentStartDate">Gets employee start date.</param>
        /// <param name="uniLoginUsername">Gets employee Unilogin
        /// username.</param>
        /// <param name="adUserName">Gets employee Active Directory
        /// username.</param>
        /// <param name="employmentResignationDate">Gets employee resignation
        /// date.</param>
        /// <param name="areaOfResponsibilityId">Reference id to the area of
        /// responsibility.</param>
        public EmployeeExternalResponse(System.Guid id, string civilRegistrationNumber, bool lmsIndicator, string givenName, string surname, string email, System.DateTime employmentStartDate, string uniLoginUsername = default(string), string adUserName = default(string), System.DateTime? employmentResignationDate = default(System.DateTime?), System.Guid? areaOfResponsibilityId = default(System.Guid?))
        {
            Id = id;
            CivilRegistrationNumber = civilRegistrationNumber;
            LmsIndicator = lmsIndicator;
            GivenName = givenName;
            Surname = surname;
            Email = email;
            UniLoginUsername = uniLoginUsername;
            AdUserName = adUserName;
            EmploymentStartDate = employmentStartDate;
            EmploymentResignationDate = employmentResignationDate;
            AreaOfResponsibilityId = areaOfResponsibilityId;
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
        /// Gets employee civil registration number.
        /// </summary>
        [JsonProperty(PropertyName = "civilRegistrationNumber")]
        public string CivilRegistrationNumber { get; set; }

        /// <summary>
        /// Gets Learning Management System indicator.
        /// </summary>
        [JsonProperty(PropertyName = "lmsIndicator")]
        public bool LmsIndicator { get; set; }

        /// <summary>
        /// Gets employee given name.
        /// </summary>
        [JsonProperty(PropertyName = "givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets employee surname.
        /// </summary>
        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets employee e-mail address.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets employee Unilogin username.
        /// </summary>
        [JsonProperty(PropertyName = "uniLoginUsername")]
        public string UniLoginUsername { get; set; }

        /// <summary>
        /// Gets employee Active Directory username.
        /// </summary>
        [JsonProperty(PropertyName = "adUserName")]
        public string AdUserName { get; set; }

        /// <summary>
        /// Gets employee start date.
        /// </summary>
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
        }
    }
}
