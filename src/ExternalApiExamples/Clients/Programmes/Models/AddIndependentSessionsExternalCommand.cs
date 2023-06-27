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
    /// AddIndependentSessionsExternalCommand
    /// </summary>
    /// <remarks>
    /// Add new independent sessions.
    /// </remarks>
    public partial class AddIndependentSessionsExternalCommand
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AddIndependentSessionsExternalCommand class.
        /// </summary>
        public AddIndependentSessionsExternalCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AddIndependentSessionsExternalCommand class.
        /// </summary>
        /// <param name="sessions">New sessions to create.</param>
        /// <param name="schoolCode">String</param>
        public AddIndependentSessionsExternalCommand(IList<ExternalIndependentSessionDto> sessions, string schoolCode)
        {
            Sessions = sessions;
            SchoolCode = schoolCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets new sessions to create.
        /// </summary>
        [JsonProperty(PropertyName = "sessions")]
        public IList<ExternalIndependentSessionDto> Sessions { get; set; }

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
            if (Sessions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sessions");
            }
            if (SchoolCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SchoolCode");
            }
            if (Sessions != null)
            {
                foreach (var element in Sessions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
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