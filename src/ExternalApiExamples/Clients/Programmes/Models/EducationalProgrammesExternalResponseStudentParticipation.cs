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
    /// EducationalProgrammesExternalResponse_StudentParticipation
    /// </summary>
    public partial class EducationalProgrammesExternalResponseStudentParticipation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// EducationalProgrammesExternalResponseStudentParticipation class.
        /// </summary>
        public EducationalProgrammesExternalResponseStudentParticipation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// EducationalProgrammesExternalResponseStudentParticipation class.
        /// </summary>
        /// <param name="usePeriodFromEducationalProgramme">Boolean</param>
        /// <param name="startDate">Date</param>
        /// <param name="endDate">Date</param>
        public EducationalProgrammesExternalResponseStudentParticipation(System.Guid studentId, bool usePeriodFromEducationalProgramme, System.DateTime startDate, System.DateTime endDate)
        {
            StudentId = studentId;
            UsePeriodFromEducationalProgramme = usePeriodFromEducationalProgramme;
            StartDate = startDate;
            EndDate = endDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "studentId")]
        public System.Guid StudentId { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Flag indicating, whether period should be taken from the
        /// educational programme.
        /// </remarks>
        [JsonProperty(PropertyName = "usePeriodFromEducationalProgramme")]
        public bool UsePeriodFromEducationalProgramme { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// Start date of the period.
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// End date of the period.
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime EndDate { get; set; }

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
