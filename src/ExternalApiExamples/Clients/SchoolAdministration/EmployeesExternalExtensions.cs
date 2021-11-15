// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolAdministration.Client
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EmployeesExternal.
    /// </summary>
    public static partial class EmployeesExternalExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='employmentStartDateTo'>
            /// End of range for start date employment.
            /// </param>
            /// <param name='pageNumber'>
            /// The number of the page to return (1 is the first page).
            /// </param>
            /// <param name='pageSize'>
            /// Number of objects per page.
            /// </param>
            /// <param name='inlineCount'>
            /// A flag indicating if total number of items should be included.
            /// </param>
            /// <param name='schoolCode'>
            /// The school code for which to get data.
            /// </param>
            /// <param name='employmentStartDateFrom'>
            /// Beginning of range for start date employment.
            /// </param>
            /// <param name='areaOfResponsibilityId'>
            /// Option for also querying employees by area of responsibility
            /// </param>
            /// <param name='xSelectedSchoolCode'>
            /// Selected school code, used when multiple impersonation permissions are
            /// available on the token
            /// </param>
            public static PagedResponseEmployeeExternalResponse Get(this IEmployeesExternal operations, System.DateTime employmentStartDateTo, int pageNumber, int pageSize, bool inlineCount, string schoolCode, System.DateTime? employmentStartDateFrom = default(System.DateTime?), System.Guid? areaOfResponsibilityId = default(System.Guid?), string xSelectedSchoolCode = default(string))
            {
                return operations.GetAsync(employmentStartDateTo, pageNumber, pageSize, inlineCount, schoolCode, employmentStartDateFrom, areaOfResponsibilityId, xSelectedSchoolCode).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='employmentStartDateTo'>
            /// End of range for start date employment.
            /// </param>
            /// <param name='pageNumber'>
            /// The number of the page to return (1 is the first page).
            /// </param>
            /// <param name='pageSize'>
            /// Number of objects per page.
            /// </param>
            /// <param name='inlineCount'>
            /// A flag indicating if total number of items should be included.
            /// </param>
            /// <param name='schoolCode'>
            /// The school code for which to get data.
            /// </param>
            /// <param name='employmentStartDateFrom'>
            /// Beginning of range for start date employment.
            /// </param>
            /// <param name='areaOfResponsibilityId'>
            /// Option for also querying employees by area of responsibility
            /// </param>
            /// <param name='xSelectedSchoolCode'>
            /// Selected school code, used when multiple impersonation permissions are
            /// available on the token
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseEmployeeExternalResponse> GetAsync(this IEmployeesExternal operations, System.DateTime employmentStartDateTo, int pageNumber, int pageSize, bool inlineCount, string schoolCode, System.DateTime? employmentStartDateFrom = default(System.DateTime?), System.Guid? areaOfResponsibilityId = default(System.Guid?), string xSelectedSchoolCode = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(employmentStartDateTo, pageNumber, pageSize, inlineCount, schoolCode, employmentStartDateFrom, areaOfResponsibilityId, xSelectedSchoolCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
