// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolInternships.Client.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// StudentInternships_InternshipPeriodDto
    /// </summary>
    public partial class StudentInternshipsInternshipPeriodDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StudentInternshipsInternshipPeriodDto class.
        /// </summary>
        public StudentInternshipsInternshipPeriodDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// StudentInternshipsInternshipPeriodDto class.
        /// </summary>
        /// <param name="writtenAgreementId">The written agreement the
        /// internship period belongs to</param>
        /// <param name="schoolInternshipType">SchoolInternshipType</param>
        /// <param name="startDate">Date</param>
        /// <param name="endDate">Date</param>
        /// <param name="insertedAt">When it was created</param>
        /// <param name="updatedAt">Last update of the internship
        /// period</param>
        public StudentInternshipsInternshipPeriodDto(System.Guid writtenAgreementId, string schoolInternshipType, System.DateTime startDate, System.DateTime endDate, System.DateTime? insertedAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?))
        {
            WrittenAgreementId = writtenAgreementId;
            SchoolInternshipType = schoolInternshipType;
            StartDate = startDate;
            EndDate = endDate;
            InsertedAt = insertedAt;
            UpdatedAt = updatedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the written agreement the internship period belongs to
        /// </summary>
        [JsonProperty(PropertyName = "writtenAgreementId")]
        public System.Guid WrittenAgreementId { get; set; }

        /// <summary>
        /// Gets or sets schoolInternshipType
        /// </summary>
        /// <remarks>
        /// The type of the school internships (SKPS/VFU/DEL). Possible values
        /// include: 'SKPS', 'DEL', 'VFU'
        /// </remarks>
        [JsonProperty(PropertyName = "schoolInternshipType")]
        public string SchoolInternshipType { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// Start date of the internship period
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// End date of the internship period
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets when it was created
        /// </summary>
        [JsonProperty(PropertyName = "insertedAt")]
        public System.DateTime? InsertedAt { get; set; }

        /// <summary>
        /// Gets or sets last update of the internship period
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
            if (SchoolInternshipType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchoolInternshipType");
            }
        }
    }
}
