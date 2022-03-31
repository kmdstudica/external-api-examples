// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Students.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// StudentMarksExternalRequest
    /// </summary>
    /// <remarks>
    /// Returns a list of students and their marks
    /// </remarks>
    public partial class StudentMarksExternalRequest
    {
        /// <summary>
        /// Initializes a new instance of the StudentMarksExternalRequest
        /// class.
        /// </summary>
        public StudentMarksExternalRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StudentMarksExternalRequest
        /// class.
        /// </summary>
        /// <param name="studentIds">A list of students to get marks
        /// for</param>
        /// <param name="onlyIncludeMarksForExamPaper">Boolean</param>
        /// <param name="pageNumber">Int32</param>
        /// <param name="pageSize">Int32</param>
        /// <param name="inlineCount">Boolean</param>
        /// <param name="schoolCode">String</param>
        public StudentMarksExternalRequest(IList<System.Guid> studentIds, bool onlyIncludeMarksForExamPaper, int pageNumber, int pageSize, bool inlineCount, string schoolCode)
        {
            StudentIds = studentIds;
            OnlyIncludeMarksForExamPaper = onlyIncludeMarksForExamPaper;
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
        /// Gets or sets a list of students to get marks for
        /// </summary>
        [JsonProperty(PropertyName = "studentIds")]
        public IList<System.Guid> StudentIds { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Flag to indicate if service should only return marks that should be
        /// included on exam paper
        /// </remarks>
        [JsonProperty(PropertyName = "onlyIncludeMarksForExamPaper")]
        public bool OnlyIncludeMarksForExamPaper { get; set; }

        /// <summary>
        /// Gets or sets int32
        /// </summary>
        /// <remarks>
        /// The number of the page to return (1 is the first page).
        /// </remarks>
        [JsonProperty(PropertyName = "pageNumber")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or sets int32
        /// </summary>
        /// <remarks>
        /// Number of objects per page.
        /// </remarks>
        [JsonProperty(PropertyName = "pageSize")]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// A flag indicating if total number of items should be included.
        /// </remarks>
        [JsonProperty(PropertyName = "inlineCount")]
        public bool InlineCount { get; set; }

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
            if (StudentIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StudentIds");
            }
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