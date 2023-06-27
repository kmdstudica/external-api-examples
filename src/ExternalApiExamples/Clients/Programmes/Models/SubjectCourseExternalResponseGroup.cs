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
    /// SubjectCourseExternalResponse_Group
    /// </summary>
    /// <remarks>
    /// Model of a group of students on the subject course.
    /// </remarks>
    public partial class SubjectCourseExternalResponseGroup
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SubjectCourseExternalResponseGroup class.
        /// </summary>
        public SubjectCourseExternalResponseGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SubjectCourseExternalResponseGroup class.
        /// </summary>
        /// <param name="groupId">Guid</param>
        /// <param name="startDate">Date</param>
        /// <param name="endDate">Date</param>
        /// <param name="numberOfSessions">Int32</param>
        /// <param name="lmsIndicator">Boolean</param>
        /// <param name="participants">The participants for the group.</param>
        /// <param name="name">String</param>
        /// <param name="displayName">String</param>
        /// <param name="designation">String</param>
        /// <param name="parentGroupId">The parent group, if any. Only the top
        /// level groups will not have a parent id.</param>
        /// <param name="minimumNumberOfSessions">The minimum number of
        /// sessions expected to be taught on this subject course</param>
        public SubjectCourseExternalResponseGroup(System.Guid groupId, System.DateTime startDate, System.DateTime endDate, int numberOfSessions, bool lmsIndicator, IList<SubjectCourseExternalResponseGroupStudent> participants, string name = default(string), string displayName = default(string), string designation = default(string), System.Guid? parentGroupId = default(System.Guid?), int? minimumNumberOfSessions = default(int?))
        {
            GroupId = groupId;
            Name = name;
            DisplayName = displayName;
            Designation = designation;
            StartDate = startDate;
            EndDate = endDate;
            ParentGroupId = parentGroupId;
            NumberOfSessions = numberOfSessions;
            LmsIndicator = lmsIndicator;
            Participants = participants;
            MinimumNumberOfSessions = minimumNumberOfSessions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets guid
        /// </summary>
        /// <remarks>
        /// The id of the group.
        /// </remarks>
        [JsonProperty(PropertyName = "groupId")]
        public System.Guid GroupId { get; set; }

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
        /// The name is a combination of the subject course's name and name of
        /// the group
        /// </remarks>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The group's designation.
        /// The designation is a combination of the subject course's
        /// designation and name of the group
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
        /// Gets or sets the parent group, if any. Only the top
        /// level groups will not have a parent id.
        /// </summary>
        [JsonProperty(PropertyName = "parentGroupId")]
        public System.Guid? ParentGroupId { get; set; }

        /// <summary>
        /// Gets or sets int32
        /// </summary>
        /// <remarks>
        /// The number of sessions defined for this group.
        /// </remarks>
        [JsonProperty(PropertyName = "numberOfSessions")]
        public int NumberOfSessions { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Is the entity to be created in the LMS.
        /// </remarks>
        [JsonProperty(PropertyName = "lmsIndicator")]
        public bool LmsIndicator { get; set; }

        /// <summary>
        /// Gets or sets the participants for the group.
        /// </summary>
        [JsonProperty(PropertyName = "participants")]
        public IList<SubjectCourseExternalResponseGroupStudent> Participants { get; set; }

        /// <summary>
        /// Gets or sets the minimum number of sessions expected to be taught
        /// on this subject course
        /// </summary>
        [JsonProperty(PropertyName = "minimumNumberOfSessions")]
        public int? MinimumNumberOfSessions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Participants == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Participants");
            }
            if (Participants != null)
            {
                foreach (var element in Participants)
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
