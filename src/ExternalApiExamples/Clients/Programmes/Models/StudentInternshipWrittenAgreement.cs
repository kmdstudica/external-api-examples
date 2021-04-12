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
    using System.Linq;

    /// <summary>
    /// StudentInternship_WrittenAgreement
    /// </summary>
    /// <remarks>
    /// A student's written agreement for school based internship
    /// </remarks>
    public partial class StudentInternshipWrittenAgreement
    {
        /// <summary>
        /// Initializes a new instance of the StudentInternshipWrittenAgreement
        /// class.
        /// </summary>
        public StudentInternshipWrittenAgreement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StudentInternshipWrittenAgreement
        /// class.
        /// </summary>
        /// <param name="startDate">Date</param>
        /// <param name="endDate">Date</param>
        /// <param name="agreementType">String</param>
        /// <param name="agreementTypeDescription">String</param>
        /// <param name="placeOfInternshipName">String</param>
        /// <param name="placeOfInternshipCvrNumber">String</param>
        /// <param name="placeOfInternshipEmail">String</param>
        /// <param name="placeOfInternshipSerialNumber">String</param>
        /// <param name="seNumber">String</param>
        /// <param name="placeOfInternshipAddress">String</param>
        /// <param name="placeOfInternshipCity">String</param>
        /// <param name="placeOfInternshipPostalCode">String</param>
        public StudentInternshipWrittenAgreement(System.DateTime startDate, System.DateTime endDate, string agreementType = default(string), string agreementTypeDescription = default(string), string placeOfInternshipName = default(string), string placeOfInternshipCvrNumber = default(string), string placeOfInternshipEmail = default(string), string placeOfInternshipSerialNumber = default(string), string seNumber = default(string), string placeOfInternshipAddress = default(string), string placeOfInternshipCity = default(string), string placeOfInternshipPostalCode = default(string))
        {
            AgreementType = agreementType;
            AgreementTypeDescription = agreementTypeDescription;
            StartDate = startDate;
            EndDate = endDate;
            PlaceOfInternshipName = placeOfInternshipName;
            PlaceOfInternshipCvrNumber = placeOfInternshipCvrNumber;
            PlaceOfInternshipEmail = placeOfInternshipEmail;
            PlaceOfInternshipSerialNumber = placeOfInternshipSerialNumber;
            SeNumber = seNumber;
            PlaceOfInternshipAddress = placeOfInternshipAddress;
            PlaceOfInternshipCity = placeOfInternshipCity;
            PlaceOfInternshipPostalCode = placeOfInternshipPostalCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The written agreement's internship type
        /// </remarks>
        [JsonProperty(PropertyName = "agreementType")]
        public string AgreementType { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Textual description of the internship type
        /// </remarks>
        [JsonProperty(PropertyName = "agreementTypeDescription")]
        public string AgreementTypeDescription { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// Start date of internship
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// End date for internship
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The name of the company where the internship takes place.
        /// </remarks>
        [JsonProperty(PropertyName = "placeOfInternshipName")]
        public string PlaceOfInternshipName { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The CVR number of the company where the internship takes place.
        /// </remarks>
        [JsonProperty(PropertyName = "placeOfInternshipCvrNumber")]
        public string PlaceOfInternshipCvrNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The contact email address of the company where the internship takes
        /// place.
        /// </remarks>
        [JsonProperty(PropertyName = "placeOfInternshipEmail")]
        public string PlaceOfInternshipEmail { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The serial number of the internship.
        /// </remarks>
        [JsonProperty(PropertyName = "placeOfInternshipSerialNumber")]
        public string PlaceOfInternshipSerialNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The salary number for the internship.
        /// </remarks>
        [JsonProperty(PropertyName = "seNumber")]
        public string SeNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The address of the place of internship.
        /// </remarks>
        [JsonProperty(PropertyName = "placeOfInternshipAddress")]
        public string PlaceOfInternshipAddress { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The city of the place of internship.
        /// </remarks>
        [JsonProperty(PropertyName = "placeOfInternshipCity")]
        public string PlaceOfInternshipCity { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The postal code of the place of internship.
        /// </remarks>
        [JsonProperty(PropertyName = "placeOfInternshipPostalCode")]
        public string PlaceOfInternshipPostalCode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
