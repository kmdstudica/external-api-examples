// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolInternships.Client.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// InternshipDepartmentsExternalResponse
    /// </summary>
    /// <remarks>
    /// Model of internship department.
    /// </remarks>
    public partial class InternshipDepartmentsExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InternshipDepartmentsExternalResponse class.
        /// </summary>
        public InternshipDepartmentsExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InternshipDepartmentsExternalResponse class.
        /// </summary>
        /// <param name="id">Guid</param>
        /// <param name="name">String</param>
        /// <param name="validFrom">Date</param>
        /// <param name="dayCalendarId">Guid</param>
        /// <param name="uvmDepartmentNumber">String</param>
        /// <param name="workWeekHours">All associated work week hours.</param>
        /// <param name="validTo">The date which the department is active to,
        /// if it has been deactivated.</param>
        /// <param name="areaOfResponsibilityId">The id of the associated area
        /// of responsibility.</param>
        public InternshipDepartmentsExternalResponse(System.Guid id, string name, System.DateTime validFrom, System.Guid dayCalendarId, string uvmDepartmentNumber, IList<InternshipDepartmentsExternalWorkWeekHoursDto> workWeekHours, System.DateTime? validTo = default(System.DateTime?), System.Guid? areaOfResponsibilityId = default(System.Guid?))
        {
            Id = id;
            Name = name;
            ValidFrom = validFrom;
            ValidTo = validTo;
            DayCalendarId = dayCalendarId;
            UvmDepartmentNumber = uvmDepartmentNumber;
            AreaOfResponsibilityId = areaOfResponsibilityId;
            WorkWeekHours = workWeekHours;
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
        /// The department id.
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The name of the department.
        /// </remarks>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// The date from which the department is active.
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "validFrom")]
        public System.DateTime ValidFrom { get; set; }

        /// <summary>
        /// Gets or sets the date which the department is active to, if it has
        /// been deactivated.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "validTo")]
        public System.DateTime? ValidTo { get; set; }

        /// <summary>
        /// Gets or sets guid
        /// </summary>
        /// <remarks>
        /// The id of the associated day calendar.
        /// </remarks>
        [JsonProperty(PropertyName = "dayCalendarId")]
        public System.Guid DayCalendarId { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The associated UVM department number.
        /// </remarks>
        [JsonProperty(PropertyName = "uvmDepartmentNumber")]
        public string UvmDepartmentNumber { get; set; }

        /// <summary>
        /// Gets or sets the id of the associated area of responsibility.
        /// </summary>
        [JsonProperty(PropertyName = "areaOfResponsibilityId")]
        public System.Guid? AreaOfResponsibilityId { get; set; }

        /// <summary>
        /// Gets or sets all associated work week hours.
        /// </summary>
        [JsonProperty(PropertyName = "workWeekHours")]
        public IList<InternshipDepartmentsExternalWorkWeekHoursDto> WorkWeekHours { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (UvmDepartmentNumber == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UvmDepartmentNumber");
            }
            if (WorkWeekHours == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WorkWeekHours");
            }
            if (WorkWeekHours != null)
            {
                foreach (var element in WorkWeekHours)
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
