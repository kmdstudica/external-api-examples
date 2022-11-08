// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// DeleteSessionsExternalCommand
    /// </summary>
    /// <remarks>
    /// Deletes a number of sessions.
    /// </remarks>
    public partial class DeleteSessionsExternalCommand
    {
        /// <summary>
        /// Initializes a new instance of the DeleteSessionsExternalCommand
        /// class.
        /// </summary>
        public DeleteSessionsExternalCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeleteSessionsExternalCommand
        /// class.
        /// </summary>
        /// <param name="sessionIds">The sessions to delete.</param>
        /// <param name="schoolCode">String</param>
        public DeleteSessionsExternalCommand(IList<System.Guid> sessionIds, string schoolCode)
        {
            SessionIds = sessionIds;
            SchoolCode = schoolCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the sessions to delete.
        /// </summary>
        [JsonProperty(PropertyName = "sessionIds")]
        public IList<System.Guid> SessionIds { get; set; }

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
            if (SessionIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SessionIds");
            }
            if (SchoolCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchoolCode");
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
