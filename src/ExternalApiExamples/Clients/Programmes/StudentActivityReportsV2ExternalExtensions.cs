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
    /// Extension methods for StudentActivityReportsV2External.
    /// </summary>
    public static partial class StudentActivityReportsV2ExternalExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='schoolCode'>
            /// The school code for which to get data.
            /// </param>
            /// <param name='periodFrom'>
            /// Includes reports for periods with a transmission period start date no
            /// earlier than `PeriodFrom`
            /// </param>
            /// <param name='periodTo'>
            /// Includes reports for periods with a transmission period start date no later
            /// than `PeriodFromTo`
            /// </param>
            public static IList<ActivityGroup2Dto> Get(this IStudentActivityReportsV2External operations, string schoolCode, System.DateTime? periodFrom = default(System.DateTime?), System.DateTime? periodTo = default(System.DateTime?))
            {
                return operations.GetAsync(schoolCode, periodFrom, periodTo).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='schoolCode'>
            /// The school code for which to get data.
            /// </param>
            /// <param name='periodFrom'>
            /// Includes reports for periods with a transmission period start date no
            /// earlier than `PeriodFrom`
            /// </param>
            /// <param name='periodTo'>
            /// Includes reports for periods with a transmission period start date no later
            /// than `PeriodFromTo`
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ActivityGroup2Dto>> GetAsync(this IStudentActivityReportsV2External operations, string schoolCode, System.DateTime? periodFrom = default(System.DateTime?), System.DateTime? periodTo = default(System.DateTime?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(schoolCode, periodFrom, periodTo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
