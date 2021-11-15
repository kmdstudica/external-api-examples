// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BulkAbsenceRegistrationsExternal.
    /// </summary>
    public static partial class BulkAbsenceRegistrationsExternalExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='studentIds'>
            /// A list of student ids to get absence for.
            /// </param>
            /// <param name='dateFrom'>
            /// Beginning of the range for absence date.
            /// </param>
            /// <param name='dateTo'>
            /// End of the range for absence date.
            /// </param>
            /// <param name='schoolCode'>
            /// The school code for which to get data.
            /// </param>
            /// <param name='onlyAbsenceReports'>
            /// Only retrieve reports of absence or partial absence,
            /// defaults to false (retrieve everything)
            /// </param>
            /// <param name='xSelectedSchoolCode'>
            /// Selected school code, used when multiple impersonation permissions are
            /// available on the token
            /// </param>
            public static IList<AbsenceRegistrationExternalResponse> Get(this IBulkAbsenceRegistrationsExternal operations, IList<System.Guid> studentIds, System.DateTime dateFrom, System.DateTime dateTo, string schoolCode, bool? onlyAbsenceReports = default(bool?), string xSelectedSchoolCode = default(string))
            {
                return operations.GetAsync(studentIds, dateFrom, dateTo, schoolCode, onlyAbsenceReports, xSelectedSchoolCode).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='studentIds'>
            /// A list of student ids to get absence for.
            /// </param>
            /// <param name='dateFrom'>
            /// Beginning of the range for absence date.
            /// </param>
            /// <param name='dateTo'>
            /// End of the range for absence date.
            /// </param>
            /// <param name='schoolCode'>
            /// The school code for which to get data.
            /// </param>
            /// <param name='onlyAbsenceReports'>
            /// Only retrieve reports of absence or partial absence,
            /// defaults to false (retrieve everything)
            /// </param>
            /// <param name='xSelectedSchoolCode'>
            /// Selected school code, used when multiple impersonation permissions are
            /// available on the token
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<AbsenceRegistrationExternalResponse>> GetAsync(this IBulkAbsenceRegistrationsExternal operations, IList<System.Guid> studentIds, System.DateTime dateFrom, System.DateTime dateTo, string schoolCode, bool? onlyAbsenceReports = default(bool?), string xSelectedSchoolCode = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(studentIds, dateFrom, dateTo, schoolCode, onlyAbsenceReports, xSelectedSchoolCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
