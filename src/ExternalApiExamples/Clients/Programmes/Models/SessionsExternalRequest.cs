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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SessionsExternalRequest
    /// </summary>
    /// <remarks>
    /// Get sessions.
    /// </remarks>
    public partial class SessionsExternalRequest
    {
        /// <summary>
        /// Initializes a new instance of the SessionsExternalRequest class.
        /// </summary>
        public SessionsExternalRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SessionsExternalRequest class.
        /// </summary>
        /// <param name="pageNumber">Int32</param>
        /// <param name="pageSize">Int32</param>
        /// <param name="inlineCount">Boolean</param>
        /// <param name="schoolCode">String</param>
        /// <param name="groupIds">If specified, returns sessions which have at
        /// least one of the specific groups.</param>
        /// <param name="teacherIds">If specified, returns sessions which have
        /// at least one of the specific teachers.</param>
        /// <param name="roomIds">If specified, returns sessions which have at
        /// least one of the specific rooms.</param>
        /// <param name="dateFrom">If specified, returns sessions which are
        /// planned on a date no earlier than this.</param>
        /// <param name="dateTo">If specified, returns sessions which are
        /// planned on a date no later than this.</param>
        public SessionsExternalRequest(int pageNumber, int pageSize, bool inlineCount, string schoolCode, IList<System.Guid> groupIds = default(IList<System.Guid>), IList<System.Guid> teacherIds = default(IList<System.Guid>), IList<System.Guid> roomIds = default(IList<System.Guid>), System.DateTime? dateFrom = default(System.DateTime?), System.DateTime? dateTo = default(System.DateTime?))
        {
            GroupIds = groupIds;
            TeacherIds = teacherIds;
            RoomIds = roomIds;
            DateFrom = dateFrom;
            DateTo = dateTo;
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
        /// Gets or sets if specified, returns sessions which have at least one
        /// of the specific groups.
        /// </summary>
        [JsonProperty(PropertyName = "groupIds")]
        public IList<System.Guid> GroupIds { get; set; }

        /// <summary>
        /// Gets or sets if specified, returns sessions which have at least one
        /// of the specific teachers.
        /// </summary>
        [JsonProperty(PropertyName = "teacherIds")]
        public IList<System.Guid> TeacherIds { get; set; }

        /// <summary>
        /// Gets or sets if specified, returns sessions which have at least one
        /// of the specific rooms.
        /// </summary>
        [JsonProperty(PropertyName = "roomIds")]
        public IList<System.Guid> RoomIds { get; set; }

        /// <summary>
        /// Gets or sets if specified, returns sessions which are planned on a
        /// date no earlier than this.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "dateFrom")]
        public System.DateTime? DateFrom { get; set; }

        /// <summary>
        /// Gets or sets if specified, returns sessions which are planned on a
        /// date no later than this.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "dateTo")]
        public System.DateTime? DateTo { get; set; }

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
