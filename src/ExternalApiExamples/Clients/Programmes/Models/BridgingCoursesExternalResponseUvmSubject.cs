// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client.Models
{
    using System.Linq;

    /// <summary>
    /// Information about the UVM subject
    /// </summary>
    public partial class BridgingCoursesExternalResponseUvmSubject : BridgingCoursesExternalResponseUVMSubjectDetails
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BridgingCoursesExternalResponseUvmSubject class.
        /// </summary>
        public BridgingCoursesExternalResponseUvmSubject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BridgingCoursesExternalResponseUvmSubject class.
        /// </summary>
        /// <param name="version">Int32</param>
        /// <param name="subject">String</param>
        /// <param name="description">String</param>
        /// <param name="speciality">String</param>
        public BridgingCoursesExternalResponseUvmSubject(int version, string subject = default(string), string description = default(string), string speciality = default(string))
            : base(version, subject, description, speciality)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}