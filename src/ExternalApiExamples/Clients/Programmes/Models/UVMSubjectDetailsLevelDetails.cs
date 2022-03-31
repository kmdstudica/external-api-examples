// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client.Models
{
    using System.Linq;

    /// <summary>
    /// Detailed information about the level the subject
    /// is taken on.
    /// </summary>
    public partial class UVMSubjectDetailsLevelDetails : LevelDetails
    {
        /// <summary>
        /// Initializes a new instance of the UVMSubjectDetailsLevelDetails
        /// class.
        /// </summary>
        public UVMSubjectDetailsLevelDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UVMSubjectDetailsLevelDetails
        /// class.
        /// </summary>
        /// <param name="levelId">Guid</param>
        /// <param name="level">String</param>
        /// <param name="description">String</param>
        /// <param name="levelType">String</param>
        public UVMSubjectDetailsLevelDetails(System.Guid levelId, string level = default(string), string description = default(string), string levelType = default(string))
            : base(levelId, level, description, levelType)
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