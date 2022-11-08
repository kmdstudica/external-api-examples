// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolInternships.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// BulkInternshipDepartmentsExternalRequest
    /// </summary>
    /// <remarks>
    /// Get information about specific internship departments.
    /// </remarks>
    public partial class BulkInternshipDepartmentsExternalRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BulkInternshipDepartmentsExternalRequest class.
        /// </summary>
        public BulkInternshipDepartmentsExternalRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BulkInternshipDepartmentsExternalRequest class.
        /// </summary>
        /// <param name="internshipDepartmentIds">The ids of the internship
        /// departments to query for.</param>
        /// <param name="schoolCode">String</param>
        public BulkInternshipDepartmentsExternalRequest(IList<System.Guid> internshipDepartmentIds, string schoolCode)
        {
            InternshipDepartmentIds = internshipDepartmentIds;
            SchoolCode = schoolCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ids of the internship departments to query for.
        /// </summary>
        [JsonProperty(PropertyName = "internshipDepartmentIds")]
        public IList<System.Guid> InternshipDepartmentIds { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The school code for which to get data.
        /// </remarks>
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
            if (InternshipDepartmentIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InternshipDepartmentIds");
            }
            if (SchoolCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchoolCode");
            }
            if (InternshipDepartmentIds != null)
            {
                if (InternshipDepartmentIds.Count > 1000)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "InternshipDepartmentIds", 1000);
                }
                if (InternshipDepartmentIds.Count < 1)
                {
                    throw new ValidationException(ValidationRules.MinItems, "InternshipDepartmentIds", 1);
                }
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
