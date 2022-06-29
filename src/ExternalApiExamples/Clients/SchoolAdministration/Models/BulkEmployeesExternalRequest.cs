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
    /// BulkEmployeesExternalRequest
    /// </summary>
    /// <remarks>
    /// Returns a list of employees satisfying provided criteria.
    /// </remarks>
    public partial class BulkEmployeesExternalRequest
    {
        /// <summary>
        /// Initializes a new instance of the BulkEmployeesExternalRequest
        /// class.
        /// </summary>
        public BulkEmployeesExternalRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BulkEmployeesExternalRequest
        /// class.
        /// </summary>
        /// <param name="employeeIds">Employees identifiers for bulk
        /// query.</param>
        /// <param name="schoolCode">String</param>
        public BulkEmployeesExternalRequest(IList<System.Guid> employeeIds, string schoolCode)
        {
            EmployeeIds = employeeIds;
            SchoolCode = schoolCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets employees identifiers for bulk query.
        /// </summary>
        [JsonProperty(PropertyName = "employeeIds")]
        public IList<System.Guid> EmployeeIds { get; set; }

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
            if (EmployeeIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EmployeeIds");
            }
            if (SchoolCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchoolCode");
            }
            if (EmployeeIds != null)
            {
                if (EmployeeIds.Count > 1000)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "EmployeeIds", 1000);
                }
                if (EmployeeIds.Count < 1)
                {
                    throw new ValidationException(ValidationRules.MinItems, "EmployeeIds", 1);
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
