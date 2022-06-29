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
    /// Extension methods for StudentActivityReportsExternal.
    /// </summary>
    public static partial class StudentActivityReportsExternalExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='periodFrom'>
            /// Beginning of period for activity report quarters.
            /// The `PeriodFrom` parameter must be a date that is on or before given
            /// activity report period
            /// to include the desired report in the output.
            /// E.g. if specifying PeriodFrom as 2021-01-01 and PeriodTo as 2021-06-30
            /// you will only get the activity report for 2nd period of 2021 (March 16 to
            /// June 15)
            /// </param>
            /// <param name='periodTo'>
            /// End of period for activity report quarters. The `PeriodTo` parameter must
            /// fully encompass
            /// the end date of a given activity report quarter to include the desired
            /// report in the output.
            /// E.g. to get all activity reports for 2020 the PeriodFrom could be
            /// 2019-12-15
            /// and PeriodTo could be 2020-12-30
            /// </param>
            /// <param name='schoolCode'>
            /// The school code for which to get data.
            /// </param>
            public static IList<ActivityGroupDto> Get(this IStudentActivityReportsExternal operations, System.DateTime periodFrom, System.DateTime periodTo, string schoolCode)
            {
                return operations.GetAsync(periodFrom, periodTo, schoolCode).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='periodFrom'>
            /// Beginning of period for activity report quarters.
            /// The `PeriodFrom` parameter must be a date that is on or before given
            /// activity report period
            /// to include the desired report in the output.
            /// E.g. if specifying PeriodFrom as 2021-01-01 and PeriodTo as 2021-06-30
            /// you will only get the activity report for 2nd period of 2021 (March 16 to
            /// June 15)
            /// </param>
            /// <param name='periodTo'>
            /// End of period for activity report quarters. The `PeriodTo` parameter must
            /// fully encompass
            /// the end date of a given activity report quarter to include the desired
            /// report in the output.
            /// E.g. to get all activity reports for 2020 the PeriodFrom could be
            /// 2019-12-15
            /// and PeriodTo could be 2020-12-30
            /// </param>
            /// <param name='schoolCode'>
            /// The school code for which to get data.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ActivityGroupDto>> GetAsync(this IStudentActivityReportsExternal operations, System.DateTime periodFrom, System.DateTime periodTo, string schoolCode, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(periodFrom, periodTo, schoolCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
