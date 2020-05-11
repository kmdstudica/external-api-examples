// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolAdministration.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// BulkAreasOfResponsibilityExternalRequest
    /// </summary>
    /// <remarks>
    /// Returns a list of areas of responsibility satisfying provided criteria.
    /// </remarks>
    public partial class BulkAreasOfResponsibilityExternalRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BulkAreasOfResponsibilityExternalRequest class.
        /// </summary>
        public BulkAreasOfResponsibilityExternalRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BulkAreasOfResponsibilityExternalRequest class.
        /// </summary>
        /// <param name="areaOfResponsibilityIds">Areas of responsibility
        /// identifiers for bulk query.</param>
        /// <param name="schoolCode">The school code for which to get
        /// data.</param>
        public BulkAreasOfResponsibilityExternalRequest(IList<System.Guid> areaOfResponsibilityIds, string schoolCode)
        {
            AreaOfResponsibilityIds = areaOfResponsibilityIds;
            SchoolCode = schoolCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets areas of responsibility identifiers for bulk query.
        /// </summary>
        [JsonProperty(PropertyName = "areaOfResponsibilityIds")]
        public IList<System.Guid> AreaOfResponsibilityIds { get; set; }

        /// <summary>
        /// Gets or sets the school code for which to get data.
        /// </summary>
        [JsonProperty(PropertyName = "schoolCode")]
        public string SchoolCode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AreaOfResponsibilityIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AreaOfResponsibilityIds");
            }
            if (SchoolCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchoolCode");
            }
            if (SchoolCode != null)
            {
                if (SchoolCode.Length > 6)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "SchoolCode", 6);
                }
                if (SchoolCode.Length < 6)
                {
                    throw new ValidationException(ValidationRules.MinLength, "SchoolCode", 6);
                }
            }
        }
    }
}