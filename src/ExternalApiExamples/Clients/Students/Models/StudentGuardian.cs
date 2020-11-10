// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Students.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Student_Guardian
    /// </summary>
    public partial class StudentGuardian
    {
        /// <summary>
        /// Initializes a new instance of the StudentGuardian class.
        /// </summary>
        public StudentGuardian()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StudentGuardian class.
        /// </summary>
        /// <param name="id">Guid</param>
        /// <param name="protectedNameAndAddress">Boolean</param>
        /// <param name="civilRegistrationNumber">String</param>
        /// <param name="role">The guardian's role towards the student.
        /// Possible values include: 'Mother', 'Father', 'Other',
        /// 'OfficialAuthority'</param>
        /// <param name="givenName">String</param>
        /// <param name="surname">String</param>
        /// <param name="protectedGivenName">String</param>
        /// <param name="protectedSurname">String</param>
        /// <param name="phoneNumber">String</param>
        /// <param name="email">String</param>
        /// <param name="careOfAddressLine">String</param>
        /// <param name="addressLine">String</param>
        /// <param name="place">String</param>
        /// <param name="city">String</param>
        /// <param name="postalCode">String</param>
        /// <param name="country">String</param>
        public StudentGuardian(System.Guid id, bool protectedNameAndAddress, string civilRegistrationNumber = default(string), string role = default(string), string givenName = default(string), string surname = default(string), string protectedGivenName = default(string), string protectedSurname = default(string), string phoneNumber = default(string), string email = default(string), string careOfAddressLine = default(string), string addressLine = default(string), string place = default(string), string city = default(string), string postalCode = default(string), string country = default(string))
        {
            Id = id;
            CivilRegistrationNumber = civilRegistrationNumber;
            Role = role;
            GivenName = givenName;
            Surname = surname;
            ProtectedGivenName = protectedGivenName;
            ProtectedSurname = protectedSurname;
            PhoneNumber = phoneNumber;
            Email = email;
            CareOfAddressLine = careOfAddressLine;
            AddressLine = addressLine;
            Place = place;
            City = city;
            PostalCode = postalCode;
            Country = country;
            ProtectedNameAndAddress = protectedNameAndAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets guid
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The guardian's Civil Registration (CPR) number.
        /// </remarks>
        [JsonProperty(PropertyName = "civilRegistrationNumber")]
        public string CivilRegistrationNumber { get; set; }

        /// <summary>
        /// Gets or sets the guardian's role towards the student. Possible
        /// values include: 'Mother', 'Father', 'Other', 'OfficialAuthority'
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The guardian's first- and middle names.
        /// </remarks>
        [JsonProperty(PropertyName = "givenName")]
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The guardian's last name.
        /// </remarks>
        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The given name(s) of the guardian, as registered in the national
        /// registry.
        /// </remarks>
        [JsonProperty(PropertyName = "protectedGivenName")]
        public string ProtectedGivenName { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The surname of the guardian, as registered in the national
        /// registry.
        /// </remarks>
        [JsonProperty(PropertyName = "protectedSurname")]
        public string ProtectedSurname { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The guardian's phone number.
        /// </remarks>
        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The guardian's e-mail address.
        /// </remarks>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The C/O address line of the guardian.
        /// </remarks>
        [JsonProperty(PropertyName = "careOfAddressLine")]
        public string CareOfAddressLine { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The guardian's full address including street, house-nr letter, etc.
        /// </remarks>
        [JsonProperty(PropertyName = "addressLine")]
        public string AddressLine { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The place of the guardian.
        /// </remarks>
        [JsonProperty(PropertyName = "place")]
        public string Place { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The city where the guardian lives.
        /// </remarks>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The matching postal code for the city.
        /// </remarks>
        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The country where the guardian lives.
        /// </remarks>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Whether the guardian has name and address protection.
        /// </remarks>
        [JsonProperty(PropertyName = "protectedNameAndAddress")]
        public bool ProtectedNameAndAddress { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
