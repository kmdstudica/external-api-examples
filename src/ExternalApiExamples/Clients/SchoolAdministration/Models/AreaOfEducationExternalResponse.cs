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
    /// AreaOfEducationExternalResponse
    /// </summary>
    /// <remarks>
    /// The model of area of education.
    /// </remarks>
    public partial class AreaOfEducationExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the AreaOfEducationExternalResponse
        /// class.
        /// </summary>
        public AreaOfEducationExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AreaOfEducationExternalResponse
        /// class.
        /// </summary>
        /// <param name="id">Identifier of the area of education.</param>
        /// <param name="name">String</param>
        /// <param name="validFrom">Date</param>
        /// <param name="validTo">End date of the area of education.</param>
        /// <param name="dayCalendarId">Id of day calendar for this area of
        /// education</param>
        /// <param name="schoolHoursPlanId">Id of school hours plan for this
        /// area of education</param>
        /// <param name="areaOfResponsibilityId">Id of area of responsibility
        /// for this area of education</param>
        /// <param name="educationCoesaNumber">String</param>
        /// <param name="educationName">String</param>
        /// <param name="educationVersion">C????SA education version</param>
        /// <param name="specialisation">String</param>
        /// <param name="insertedAt">When was area of education created</param>
        /// <param name="updatedAt">Last update of the area of
        /// education</param>
        public AreaOfEducationExternalResponse(System.Guid id, string name, System.DateTime validFrom, System.DateTime? validTo = default(System.DateTime?), System.Guid? dayCalendarId = default(System.Guid?), System.Guid? schoolHoursPlanId = default(System.Guid?), System.Guid? areaOfResponsibilityId = default(System.Guid?), string educationCoesaNumber = default(string), string educationName = default(string), int? educationVersion = default(int?), string specialisation = default(string), System.DateTime? insertedAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?))
        {
            Id = id;
            Name = name;
            ValidFrom = validFrom;
            ValidTo = validTo;
            DayCalendarId = dayCalendarId;
            SchoolHoursPlanId = schoolHoursPlanId;
            AreaOfResponsibilityId = areaOfResponsibilityId;
            EducationCoesaNumber = educationCoesaNumber;
            EducationName = educationName;
            EducationVersion = educationVersion;
            Specialisation = specialisation;
            InsertedAt = insertedAt;
            UpdatedAt = updatedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets identifier of the area of education.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Name of the area of education.
        /// </remarks>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// Start date of the area of education.
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "validFrom")]
        public System.DateTime ValidFrom { get; set; }

        /// <summary>
        /// Gets or sets end date of the area of education.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "validTo")]
        public System.DateTime? ValidTo { get; set; }

        /// <summary>
        /// Gets or sets id of day calendar for this area of education
        /// </summary>
        [JsonProperty(PropertyName = "dayCalendarId")]
        public System.Guid? DayCalendarId { get; set; }

        /// <summary>
        /// Gets or sets id of school hours plan for this area of education
        /// </summary>
        [JsonProperty(PropertyName = "schoolHoursPlanId")]
        public System.Guid? SchoolHoursPlanId { get; set; }

        /// <summary>
        /// Gets or sets id of area of responsibility for this area of
        /// education
        /// </summary>
        [JsonProperty(PropertyName = "areaOfResponsibilityId")]
        public System.Guid? AreaOfResponsibilityId { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// C????SA number for the education this area covers
        /// </remarks>
        [JsonProperty(PropertyName = "educationCoesaNumber")]
        public string EducationCoesaNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Name of the C????SA education this area covers
        /// </remarks>
        [JsonProperty(PropertyName = "educationName")]
        public string EducationName { get; set; }

        /// <summary>
        /// Gets or sets C????SA education version
        /// </summary>
        [JsonProperty(PropertyName = "educationVersion")]
        public int? EducationVersion { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Name of the C????SA specialization of the education for this area
        /// </remarks>
        [JsonProperty(PropertyName = "specialisation")]
        public string Specialisation { get; set; }

        /// <summary>
        /// Gets or sets when was area of education created
        /// </summary>
        [JsonProperty(PropertyName = "insertedAt")]
        public System.DateTime? InsertedAt { get; set; }

        /// <summary>
        /// Gets or sets last update of the area of education
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
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Name != null)
            {
                if (Name.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 1);
                }
            }
        }
    }
}
