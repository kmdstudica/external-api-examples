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
    /// EmployeesExternalRequest
    /// </summary>
    /// <remarks>
    /// Returns a paged list of employees satisfying provided criteria.
    /// </remarks>
    public partial class EmployeesExternalRequest
    {
        /// <summary>
        /// Initializes a new instance of the EmployeesExternalRequest class.
        /// </summary>
        public EmployeesExternalRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EmployeesExternalRequest class.
        /// </summary>
        /// <param name="employmentStartDateTo">End of range for start date
        /// employment.</param>
        /// <param name="pageNumber">The number of the page to return (1 is the
        /// first page).</param>
        /// <param name="pageSize">Number of objects per page.</param>
        /// <param name="inlineCount">A flag indicating if total number of
        /// items should be included.</param>
        /// <param name="schoolCode">The school code for which to get
        /// data.</param>
        /// <param name="employmentStartDateFrom">Beginning of range for start
        /// date employment.</param>
        public EmployeesExternalRequest(System.DateTime employmentStartDateTo, int pageNumber, int pageSize, bool inlineCount, string schoolCode, System.DateTime? employmentStartDateFrom = default(System.DateTime?))
        {
            EmploymentStartDateFrom = employmentStartDateFrom;
            EmploymentStartDateTo = employmentStartDateTo;
            PageNumber = pageNumber;
            PageSize = pageSize;
            InlineCount = inlineCount;
            SchoolCode = schoolCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets beginning of range for start date employment.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "employmentStartDateFrom")]
        public System.DateTime? EmploymentStartDateFrom { get; set; }

        /// <summary>
        /// Gets or sets end of range for start date employment.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "employmentStartDateTo")]
        public System.DateTime EmploymentStartDateTo { get; set; }

        /// <summary>
        /// Gets or sets the number of the page to return (1 is the first
        /// page).
        /// </summary>
        [JsonProperty(PropertyName = "pageNumber")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or sets number of objects per page.
        /// </summary>
        [JsonProperty(PropertyName = "pageSize")]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating if total number of items should be
        /// included.
        /// </summary>
        [JsonProperty(PropertyName = "inlineCount")]
        public bool InlineCount { get; set; }

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
            if (SchoolCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchoolCode");
            }
            if (PageNumber > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "PageNumber", 2147483647);
            }
            if (PageNumber < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "PageNumber", 1);
            }
            if (PageSize > 1000)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "PageSize", 1000);
            }
            if (PageSize < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "PageSize", 1);
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
