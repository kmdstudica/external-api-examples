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
    /// AbsenceRegistrationsExternalRequest
    /// </summary>
    /// <remarks>
    /// Returns a paged list of absences satisfying provided criteria.
    /// </remarks>
    public partial class AbsenceRegistrationsExternalRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AbsenceRegistrationsExternalRequest class.
        /// </summary>
        public AbsenceRegistrationsExternalRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AbsenceRegistrationsExternalRequest class.
        /// </summary>
        /// <param name="dateFrom">Beginning of the range for absence
        /// date.</param>
        /// <param name="dateTo">End of the range for absence date.</param>
        /// <param name="schoolCode">The school code for which to get
        /// data.</param>
        /// <param name="pageNumber">The number of the page to return (1 is the
        /// first page).</param>
        /// <param name="pageSize">Number of objects per page.</param>
        /// <param name="inlineCount">A flag indicating if total number of
        /// items should be included.</param>
        /// <param name="studentId">Absent student.</param>
        /// <param name="lessonId">Lesson of absence.</param>
        public AbsenceRegistrationsExternalRequest(System.DateTime dateFrom, System.DateTime dateTo, string schoolCode, int pageNumber, int pageSize, bool inlineCount, System.Guid? studentId = default(System.Guid?), System.Guid? lessonId = default(System.Guid?))
        {
            StudentId = studentId;
            LessonId = lessonId;
            DateFrom = dateFrom;
            DateTo = dateTo;
            SchoolCode = schoolCode;
            PageNumber = pageNumber;
            PageSize = pageSize;
            InlineCount = inlineCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets absent student.
        /// </summary>
        [JsonProperty(PropertyName = "studentId")]
        public System.Guid? StudentId { get; set; }

        /// <summary>
        /// Gets or sets lesson of absence.
        /// </summary>
        [JsonProperty(PropertyName = "lessonId")]
        public System.Guid? LessonId { get; set; }

        /// <summary>
        /// Gets or sets beginning of the range for absence date.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "dateFrom")]
        public System.DateTime DateFrom { get; set; }

        /// <summary>
        /// Gets or sets end of the range for absence date.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "dateTo")]
        public System.DateTime DateTo { get; set; }

        /// <summary>
        /// Gets or sets the school code for which to get data.
        /// </summary>
        [JsonProperty(PropertyName = "schoolCode")]
        public string SchoolCode { get; set; }

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
        }
    }
}
