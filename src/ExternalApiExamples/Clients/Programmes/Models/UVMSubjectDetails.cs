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
    /// UVMSubjectDetails
    /// </summary>
    public partial class UVMSubjectDetails
    {
        /// <summary>
        /// Initializes a new instance of the UVMSubjectDetails class.
        /// </summary>
        public UVMSubjectDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UVMSubjectDetails class.
        /// </summary>
        public UVMSubjectDetails(System.Guid id, bool canOverwriteDuration, string subject = default(string), string description = default(string), System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), double? durationInDays = default(double?), double? durationInHours = default(double?), LevelDetails levelDetails = default(LevelDetails))
        {
            Id = id;
            Subject = subject;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            CanOverwriteDuration = canOverwriteDuration;
            DurationInDays = durationInDays;
            DurationInHours = durationInHours;
            LevelDetails = levelDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canOverwriteDuration")]
        public bool CanOverwriteDuration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "durationInDays")]
        public double? DurationInDays { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "durationInHours")]
        public double? DurationInHours { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "levelDetails")]
        public LevelDetails LevelDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LevelDetails != null)
            {
                LevelDetails.Validate();
            }
        }
    }
}
