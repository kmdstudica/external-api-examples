// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client.Models
{
    using System.Linq;

    /// <summary>
    /// School period of the school course
    /// </summary>
    public partial class SchoolCourseExternalResponseSchoolPeriod : SchoolCourseSchoolPeriodDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SchoolCourseExternalResponseSchoolPeriod class.
        /// </summary>
        public SchoolCourseExternalResponseSchoolPeriod()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SchoolCourseExternalResponseSchoolPeriod class.
        /// </summary>
        /// <param name="name">String</param>
        /// <param name="typeName">String</param>
        /// <param name="typeCode">String</param>
        public SchoolCourseExternalResponseSchoolPeriod(string name = default(string), string typeName = default(string), string typeCode = default(string))
            : base(name, typeName, typeCode)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
