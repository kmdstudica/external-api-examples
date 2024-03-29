// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Statistics.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// DeleteHandinsExternalCommand
    /// </summary>
    /// <remarks>
    /// Delete previously uploaded handins
    /// </remarks>
    public partial class DeleteHandinsExternalCommand
    {
        /// <summary>
        /// Initializes a new instance of the DeleteHandinsExternalCommand
        /// class.
        /// </summary>
        public DeleteHandinsExternalCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeleteHandinsExternalCommand
        /// class.
        /// </summary>
        /// <param name="handinIds">IDs of the handins to delete</param>
        /// <param name="schoolCode">String</param>
        public DeleteHandinsExternalCommand(IList<System.Guid> handinIds, string schoolCode)
        {
            HandinIds = handinIds;
            SchoolCode = schoolCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets iDs of the handins to delete
        /// </summary>
        [JsonProperty(PropertyName = "handinIds")]
        public IList<System.Guid> HandinIds { get; set; }

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
            if (HandinIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HandinIds");
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
