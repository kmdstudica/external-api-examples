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
    /// GroupsExternalResponse
    /// </summary>
    public partial class GroupsExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the GroupsExternalResponse class.
        /// </summary>
        public GroupsExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupsExternalResponse class.
        /// </summary>
        /// <param name="groupId">The id of the group.</param>
        /// <param name="groupEntityType">GroupEntityType</param>
        /// <param name="groupEntityId">Id of the root entity that this group
        /// belongs to (owner)</param>
        /// <param name="rootGroupId">Id of the root group in this
        /// hierarchy</param>
        /// <param name="startDate">Date</param>
        /// <param name="endDate">Date</param>
        /// <param name="lmsIndicator">Boolean</param>
        /// <param name="parentGroupId">The parent group, if any. Only the top
        /// level groups will not have a parent id.</param>
        /// <param name="name">String</param>
        /// <param name="displayName">String</param>
        /// <param name="designation">String</param>
        /// <param name="numberOfSessions">The number of sessions defined for
        /// this group.</param>
        /// <param name="participationPeriods">Array of participants in this
        /// group</param>
        /// <param name="deletedAt">If the group has been deleted, this
        /// property will have a value</param>
        /// <param name="insertedAt">When it was created</param>
        /// <param name="updatedAt">Last update of the group's basic
        /// information</param>
        public GroupsExternalResponse(System.Guid groupId, string groupEntityType, System.Guid groupEntityId, System.Guid rootGroupId, System.DateTime startDate, System.DateTime endDate, bool lmsIndicator, System.Guid? parentGroupId = default(System.Guid?), string name = default(string), string displayName = default(string), string designation = default(string), int? numberOfSessions = default(int?), IList<GroupsExternalResponseParticipationPeriodDto> participationPeriods = default(IList<GroupsExternalResponseParticipationPeriodDto>), System.DateTime? deletedAt = default(System.DateTime?), System.DateTime? insertedAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?))
        {
            GroupId = groupId;
            GroupEntityType = groupEntityType;
            GroupEntityId = groupEntityId;
            RootGroupId = rootGroupId;
            ParentGroupId = parentGroupId;
            Name = name;
            DisplayName = displayName;
            Designation = designation;
            StartDate = startDate;
            EndDate = endDate;
            NumberOfSessions = numberOfSessions;
            LmsIndicator = lmsIndicator;
            ParticipationPeriods = participationPeriods;
            DeletedAt = deletedAt;
            InsertedAt = insertedAt;
            UpdatedAt = updatedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the group.
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        public System.Guid GroupId { get; set; }

        /// <summary>
        /// Gets or sets groupEntityType
        /// </summary>
        /// <remarks>
        /// Type of entity that this group refers to
        /// e.g. a subject course or an educational programme. Possible values
        /// include: 'SubjectCourse', 'EducationalProgramme', 'Custom'
        /// </remarks>
        [JsonProperty(PropertyName = "groupEntityType")]
        public string GroupEntityType { get; set; }

        /// <summary>
        /// Gets or sets id of the root entity that this group belongs to
        /// (owner)
        /// </summary>
        [JsonProperty(PropertyName = "groupEntityId")]
        public System.Guid GroupEntityId { get; set; }

        /// <summary>
        /// Gets or sets id of the root group in this hierarchy
        /// </summary>
        [JsonProperty(PropertyName = "rootGroupId")]
        public System.Guid RootGroupId { get; set; }

        /// <summary>
        /// Gets or sets the parent group, if any. Only the top
        /// level groups will not have a parent id.
        /// </summary>
        [JsonProperty(PropertyName = "parentGroupId")]
        public System.Guid? ParentGroupId { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The name of the group.
        /// </remarks>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The group's display name.
        /// The name is a combination of the entity type's name and name of the
        /// group
        /// </remarks>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The group's designation.
        /// The designation is a combination of the entity type's designation
        /// and name of the group
        /// </remarks>
        [JsonProperty(PropertyName = "designation")]
        public string Designation { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// The start date of the group.
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// The end date of the group.
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the number of sessions defined for this group.
        /// </summary>
        [JsonProperty(PropertyName = "numberOfSessions")]
        public int? NumberOfSessions { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Is the entity to be created in the LMS.
        /// </remarks>
        [JsonProperty(PropertyName = "lmsIndicator")]
        public bool LmsIndicator { get; set; }

        /// <summary>
        /// Gets or sets array of participants in this group
        /// </summary>
        [JsonProperty(PropertyName = "participationPeriods")]
        public IList<GroupsExternalResponseParticipationPeriodDto> ParticipationPeriods { get; set; }

        /// <summary>
        /// Gets or sets if the group has been deleted, this property will have
        /// a value
        /// </summary>
        [JsonProperty(PropertyName = "deletedAt")]
        public System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Gets or sets when it was created
        /// </summary>
        [JsonProperty(PropertyName = "insertedAt")]
        public System.DateTime? InsertedAt { get; set; }

        /// <summary>
        /// Gets or sets last update of the group's basic information
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
            if (GroupEntityType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GroupEntityType");
            }
            if (ParticipationPeriods != null)
            {
                foreach (var element in ParticipationPeriods)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
