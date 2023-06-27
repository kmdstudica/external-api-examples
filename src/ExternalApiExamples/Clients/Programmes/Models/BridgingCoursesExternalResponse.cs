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
    /// BridgingCoursesExternalResponse
    /// </summary>
    public partial class BridgingCoursesExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the BridgingCoursesExternalResponse
        /// class.
        /// </summary>
        public BridgingCoursesExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BridgingCoursesExternalResponse
        /// class.
        /// </summary>
        /// <param name="id">Guid</param>
        /// <param name="startDate">Date</param>
        /// <param name="endDate">Date</param>
        /// <param name="isCancelled">Boolean</param>
        /// <param name="isManualCreated">Boolean</param>
        /// <param name="name">String</param>
        /// <param name="departmentId">Id of department hosting the
        /// course</param>
        /// <param name="responsibleName">String</param>
        /// <param name="dayCalendarId">The id of the day calendar used for
        /// this bridging course</param>
        /// <param name="educationalProgrammeId">Id of the educational
        /// programme this course is associated with</param>
        /// <param name="areaOfResponsibilityId">Id of the area of
        /// responsibility for the course</param>
        /// <param name="uvmDepartmentNumber">String</param>
        /// <param name="dsDepartmentNumber">String</param>
        /// <param name="address">String</param>
        /// <param name="postalCode">String</param>
        /// <param name="uvmSubject">Information about the UVM subject</param>
        /// <param name="requestorType">String</param>
        /// <param name="participants">List of student ids participating in the
        /// bridging course</param>
        /// <param name="insertedAt">When it was created</param>
        /// <param name="updatedAt">Last update of the bridging course's basic
        /// information</param>
        public BridgingCoursesExternalResponse(System.Guid id, System.DateTime startDate, System.DateTime endDate, bool isCancelled, bool isManualCreated, string name = default(string), System.Guid? departmentId = default(System.Guid?), string responsibleName = default(string), System.Guid? dayCalendarId = default(System.Guid?), System.Guid? educationalProgrammeId = default(System.Guid?), System.Guid? areaOfResponsibilityId = default(System.Guid?), string uvmDepartmentNumber = default(string), string dsDepartmentNumber = default(string), string address = default(string), string postalCode = default(string), BridgingCoursesExternalResponseUvmSubject uvmSubject = default(BridgingCoursesExternalResponseUvmSubject), string requestorType = default(string), IList<System.Guid> participants = default(IList<System.Guid>), System.DateTime? insertedAt = default(System.DateTime?), System.DateTime? updatedAt = default(System.DateTime?))
        {
            Id = id;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            IsCancelled = isCancelled;
            IsManualCreated = isManualCreated;
            DepartmentId = departmentId;
            ResponsibleName = responsibleName;
            DayCalendarId = dayCalendarId;
            EducationalProgrammeId = educationalProgrammeId;
            AreaOfResponsibilityId = areaOfResponsibilityId;
            UvmDepartmentNumber = uvmDepartmentNumber;
            DsDepartmentNumber = dsDepartmentNumber;
            Address = address;
            PostalCode = postalCode;
            UvmSubject = uvmSubject;
            RequestorType = requestorType;
            Participants = participants;
            InsertedAt = insertedAt;
            UpdatedAt = updatedAt;
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
        /// Identifier of the bridging course
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Name of the bridging course
        /// </remarks>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// Start date of the bridging course
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets date
        /// </summary>
        /// <remarks>
        /// End date for the bridging course
        /// </remarks>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Has the school cancelled the course
        /// </remarks>
        [JsonProperty(PropertyName = "isCancelled")]
        public bool IsCancelled { get; set; }

        /// <summary>
        /// Gets or sets boolean
        /// </summary>
        /// <remarks>
        /// Has the school manually created the course
        /// (If false the course has been imported from external system)
        /// </remarks>
        [JsonProperty(PropertyName = "isManualCreated")]
        public bool IsManualCreated { get; set; }

        /// <summary>
        /// Gets or sets id of department hosting the course
        /// </summary>
        [JsonProperty(PropertyName = "departmentId")]
        public System.Guid? DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Name of the person responsible for the course
        /// </remarks>
        [JsonProperty(PropertyName = "responsibleName")]
        public string ResponsibleName { get; set; }

        /// <summary>
        /// Gets or sets the id of the day calendar used for this bridging
        /// course
        /// </summary>
        [JsonProperty(PropertyName = "dayCalendarId")]
        public System.Guid? DayCalendarId { get; set; }

        /// <summary>
        /// Gets or sets id of the educational programme this course is
        /// associated with
        /// </summary>
        [JsonProperty(PropertyName = "educationalProgrammeId")]
        public System.Guid? EducationalProgrammeId { get; set; }

        /// <summary>
        /// Gets or sets id of the area of responsibility for the course
        /// </summary>
        [JsonProperty(PropertyName = "areaOfResponsibilityId")]
        public System.Guid? AreaOfResponsibilityId { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// UVM department hosting the course (activity report)
        /// </remarks>
        [JsonProperty(PropertyName = "uvmDepartmentNumber")]
        public string UvmDepartmentNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// DS department hosting the course (location)
        /// </remarks>
        [JsonProperty(PropertyName = "dsDepartmentNumber")]
        public string DsDepartmentNumber { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Address of the course
        /// </remarks>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// Postal code of the course
        /// </remarks>
        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets information about the UVM subject
        /// </summary>
        [JsonProperty(PropertyName = "uvmSubject")]
        public BridgingCoursesExternalResponseUvmSubject UvmSubject { get; set; }

        /// <summary>
        /// Gets or sets string
        /// </summary>
        /// <remarks>
        /// The course's requestor type
        /// </remarks>
        [JsonProperty(PropertyName = "requestorType")]
        public string RequestorType { get; set; }

        /// <summary>
        /// Gets or sets list of student ids participating in the bridging
        /// course
        /// </summary>
        [JsonProperty(PropertyName = "participants")]
        public IList<System.Guid> Participants { get; set; }

        /// <summary>
        /// Gets or sets when it was created
        /// </summary>
        [JsonProperty(PropertyName = "insertedAt")]
        public System.DateTime? InsertedAt { get; set; }

        /// <summary>
        /// Gets or sets last update of the bridging course's basic information
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
            if (UvmSubject != null)
            {
                UvmSubject.Validate();
            }
        }
    }
}