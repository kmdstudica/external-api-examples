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
    /// ActivityContributionPeriodResponse
    /// </summary>
    /// <remarks>
    /// Contribution period for a student
    /// </remarks>
    public partial class ActivityContributionPeriodResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ActivityContributionPeriodResponse class.
        /// </summary>
        public ActivityContributionPeriodResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ActivityContributionPeriodResponse class.
        /// </summary>
        /// <param name="studentId">Guid</param>
        /// <param name="countingPeriodNumber">Int32</param>
        /// <param name="startDate">Date</param>
        /// <param name="endDate">Date</param>
        /// <param name="countingDate">Date</param>
        /// <param name="contribution">Decimal</param>
        /// <param name="contributionDays">Decimal</param>
        /// <param name="qualificationDate">Date on which students are
        /// qualified for their education</param>
        /// <param name="remainingContribution">The remaining
        /// contribution</param>
        public ActivityContributionPeriodResponse(System.Guid studentId, int countingPeriodNumber, System.DateTime startDate, System.DateTime endDate, System.DateTime countingDate, double contribution, double contributionDays, System.DateTime? qualificationDate = default(System.DateTime?), double? remainingContribution = default(double?))
        {
            StudentId = studentId;
            CountingPeriodNumber = countingPeriodNumber;
            StartDate = startDate;
            EndDate = endDate;
            CountingDate = countingDate;
            QualificationDate = qualificationDate;
            Contribution = contribution;
            RemainingContribution = remainingContribution;
            ContributionDays = contributionDays;
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
        /// Id of student
        /// </remarks>
        [JsonProperty(PropertyName = "studentId")]
        public System.Guid StudentId { get; set; }

        /// <summary>
        /// Gets or sets int32
        /// </summary>
        /// <remarks>
        /// The sequential counting period
        /// </remarks>
        [JsonProperty(PropertyName = "countingPeriodNumber")]
        public int CountingPeriodNumber { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// Date the contribution period starts
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// Date the contribution period ends
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// Date on which students are accounted for this contribution period
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "countingDate")]
        public System.DateTime CountingDate { get; set; }

        /// <summary>
        /// Gets or sets date on which students are qualified for their
        /// education
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "qualificationDate")]
        public System.DateTime? QualificationDate { get; set; }

        /// <summary>
        /// Gets or sets decimal
        /// </summary>
        /// <remarks>
        /// The contribution
        /// </remarks>
        [JsonProperty(PropertyName = "contribution")]
        public double Contribution { get; set; }

        /// <summary>
        /// Gets or sets the remaining contribution
        /// </summary>
        [JsonProperty(PropertyName = "remainingContribution")]
        public double? RemainingContribution { get; set; }

        /// <summary>
        /// Gets or sets decimal
        /// </summary>
        /// <remarks>
        /// The contribution days
        /// </remarks>
        [JsonProperty(PropertyName = "contributionDays")]
        public double ContributionDays { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
