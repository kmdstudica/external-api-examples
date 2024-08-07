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
    /// ActivityResponse
    /// </summary>
    /// <remarks>
    /// Activity and the Contribution Periods for students
    /// </remarks>
    public partial class ActivityResponse
    {
        /// <summary>
        /// Initializes a new instance of the ActivityResponse class.
        /// </summary>
        public ActivityResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivityResponse class.
        /// </summary>
        /// <param name="activityId">Id of the Activity</param>
        /// <param name="activityEntityId">Id of the source for the
        /// Activity</param>
        /// <param name="activityEntityType">ActivityExternalEntityType</param>
        /// <param name="name">String</param>
        /// <param name="startDate">Activity start date</param>
        /// <param name="endDate">Activity end date</param>
        /// <param name="dayCalendarId">Id of the day calendar assigned to the
        /// Activity</param>
        /// <param name="areaOfResponsibilityId">Id of the area of
        /// responsibility the Activity is assigned to</param>
        /// <param name="contributionPeriods">List of Contribution
        /// Periods</param>
        public ActivityResponse(System.Guid activityId, System.Guid activityEntityId, string activityEntityType, string name = default(string), System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), System.Guid? dayCalendarId = default(System.Guid?), System.Guid? areaOfResponsibilityId = default(System.Guid?), IList<ActivityContributionPeriodResponse> contributionPeriods = default(IList<ActivityContributionPeriodResponse>))
        {
            ActivityId = activityId;
            ActivityEntityId = activityEntityId;
            ActivityEntityType = activityEntityType;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            DayCalendarId = dayCalendarId;
            AreaOfResponsibilityId = areaOfResponsibilityId;
            ContributionPeriods = contributionPeriods;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the Activity
        /// </summary>
        [JsonProperty(PropertyName = "activityId")]
        public System.Guid ActivityId { get; set; }

        /// <summary>
        /// Gets or sets id of the source for the Activity
        /// </summary>
        [JsonProperty(PropertyName = "activityEntityId")]
        public System.Guid ActivityEntityId { get; set; }

        /// <summary>
        /// Gets or sets activityExternalEntityType
        /// </summary>
        /// <remarks>
        /// Type of the Activity. Possible values include: 'SchoolCourse',
        /// 'Pptt', 'BridgingCourse', 'DurationIndependentContribution',
        /// 'SchoolInternship', 'BoardingFacilities',
        /// 'BoardingFacilitiesExternalStudents'
        /// </remarks>
        [JsonProperty(PropertyName = "activityEntityType")]
        public string ActivityEntityType { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Name of the Activity
        /// </remarks>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets activity start date
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets activity end date
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets id of the day calendar assigned to the Activity
        /// </summary>
        [JsonProperty(PropertyName = "dayCalendarId")]
        public System.Guid? DayCalendarId { get; set; }

        /// <summary>
        /// Gets or sets id of the area of responsibility the Activity is
        /// assigned to
        /// </summary>
        [JsonProperty(PropertyName = "areaOfResponsibilityId")]
        public System.Guid? AreaOfResponsibilityId { get; set; }

        /// <summary>
        /// Gets or sets list of Contribution Periods
        /// </summary>
        [JsonProperty(PropertyName = "contributionPeriods")]
        public IList<ActivityContributionPeriodResponse> ContributionPeriods { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ActivityEntityType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ActivityEntityType");
            }
            if (ContributionPeriods != null)
            {
                foreach (var element in ContributionPeriods)
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
