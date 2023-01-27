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
    /// GroupsExternalRequest
    /// </summary>
    /// <remarks>
    /// The request for retrieving groups
    /// The parameters for the request can be a combination of each of the
    /// individual properties
    /// which will each further narrow the requested data.
    /// At least one parameter has to be specified
    /// </remarks>
    public partial class GroupsExternalRequest
    {
        /// <summary>
        /// Initializes a new instance of the GroupsExternalRequest class.
        /// </summary>
        public GroupsExternalRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupsExternalRequest class.
        /// </summary>
        /// <param name="schoolCode">String</param>
        /// <param name="groupsActiveOnOrAfterDate">Groups must be active on or
        /// after this date</param>
        /// <param name="groupEntityTypes">An array of group types (Group
        /// Entity Type) to query for
        /// &lt;example&gt;
        /// 0 = SubjectCourse
        /// &lt;/example&gt;</param>
        /// <param name="groupIds">Optional array of groups to read.
        /// Must contain 1 to 1000 elements</param>
        public GroupsExternalRequest(string schoolCode, System.DateTime? groupsActiveOnOrAfterDate = default(System.DateTime?), IList<string> groupEntityTypes = default(IList<string>), IList<System.Guid> groupIds = default(IList<System.Guid>), bool? includeDeletedGroups = default(bool?))
        {
            GroupsActiveOnOrAfterDate = groupsActiveOnOrAfterDate;
            GroupEntityTypes = groupEntityTypes;
            GroupIds = groupIds;
            IncludeDeletedGroups = includeDeletedGroups;
            SchoolCode = schoolCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets groups must be active on or after this date
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "groupsActiveOnOrAfterDate")]
        public System.DateTime? GroupsActiveOnOrAfterDate { get; set; }

        /// <summary>
        /// Gets or sets an array of group types (Group Entity Type) to query
        /// for
        /// &amp;lt;example&amp;gt;
        /// 0 = SubjectCourse
        /// &amp;lt;/example&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "groupEntityTypes")]
        public IList<string> GroupEntityTypes { get; set; }

        /// <summary>
        /// Gets or sets optional array of groups to read.
        /// Must contain 1 to 1000 elements
        /// </summary>
        [JsonProperty(PropertyName = "groupIds")]
        public IList<System.Guid> GroupIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "includeDeletedGroups")]
        public bool? IncludeDeletedGroups { get; set; }

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
            if (GroupIds != null)
            {
                if (GroupIds.Count > 1000)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "GroupIds", 1000);
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
