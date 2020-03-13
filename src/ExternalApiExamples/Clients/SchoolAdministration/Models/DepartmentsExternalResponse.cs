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
    /// DepartmentsExternalResponse
    /// </summary>
    /// <remarks>
    /// Model of department.
    /// </remarks>
    public partial class DepartmentsExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the DepartmentsExternalResponse
        /// class.
        /// </summary>
        public DepartmentsExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DepartmentsExternalResponse
        /// class.
        /// </summary>
        /// <param name="id">Identifier of the department.</param>
        /// <param name="name">Name of the department.</param>
        /// <param name="validFrom">Beginning date of being valid.</param>
        /// <param name="validTo">End date of being valid.</param>
        public DepartmentsExternalResponse(System.Guid id, string name, System.DateTime validFrom, System.DateTime? validTo = default(System.DateTime?))
        {
            Id = id;
            Name = name;
            ValidFrom = validFrom;
            ValidTo = validTo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets identifier of the department.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets name of the department.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets beginning date of being valid.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "validFrom")]
        public System.DateTime ValidFrom { get; set; }

        /// <summary>
        /// Gets or sets end date of being valid.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "validTo")]
        public System.DateTime? ValidTo { get; set; }

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
                if (Name.Length > 255)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Name", 255);
                }
                if (Name.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Name", 1);
                }
            }
        }
    }
}