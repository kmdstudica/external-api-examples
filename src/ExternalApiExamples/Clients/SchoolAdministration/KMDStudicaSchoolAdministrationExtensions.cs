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
    /// Extension methods for KMDStudicaSchoolAdministration.
    /// </summary>
    public static partial class KMDStudicaSchoolAdministrationExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static PagedResponseAreaOfResponsibilityExternalResponse Post(this IKMDStudicaSchoolAdministration operations, AreasOfResponsibilityExternalRequest body = default(AreasOfResponsibilityExternalRequest))
            {
                return operations.PostAsync(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseAreaOfResponsibilityExternalResponse> PostAsync(this IKMDStudicaSchoolAdministration operations, AreasOfResponsibilityExternalRequest body = default(AreasOfResponsibilityExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static PagedResponseDayCalendarsExternalResponse Post1(this IKMDStudicaSchoolAdministration operations, DayCalendarsExternalRequest body = default(DayCalendarsExternalRequest))
            {
                return operations.Post1Async(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseDayCalendarsExternalResponse> Post1Async(this IKMDStudicaSchoolAdministration operations, DayCalendarsExternalRequest body = default(DayCalendarsExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post1WithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static PagedResponseDepartmentsExternalResponse Post2(this IKMDStudicaSchoolAdministration operations, DepartmentsExternalRequest body = default(DepartmentsExternalRequest))
            {
                return operations.Post2Async(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseDepartmentsExternalResponse> Post2Async(this IKMDStudicaSchoolAdministration operations, DepartmentsExternalRequest body = default(DepartmentsExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post2WithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static PagedResponseEmployeeExternalResponse Post3(this IKMDStudicaSchoolAdministration operations, EmployeesExternalRequest body = default(EmployeesExternalRequest))
            {
                return operations.Post3Async(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseEmployeeExternalResponse> Post3Async(this IKMDStudicaSchoolAdministration operations, EmployeesExternalRequest body = default(EmployeesExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post3WithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static PagedResponseRoomExternalResponse Post4(this IKMDStudicaSchoolAdministration operations, RoomsExternalRequest body = default(RoomsExternalRequest))
            {
                return operations.Post4Async(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseRoomExternalResponse> Post4Async(this IKMDStudicaSchoolAdministration operations, RoomsExternalRequest body = default(RoomsExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post4WithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static PagedResponseSchoolHourEntryExternalResponse Post5(this IKMDStudicaSchoolAdministration operations, SchoolHourEntriesExternalRequest body = default(SchoolHourEntriesExternalRequest))
            {
                return operations.Post5Async(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseSchoolHourEntryExternalResponse> Post5Async(this IKMDStudicaSchoolAdministration operations, SchoolHourEntriesExternalRequest body = default(SchoolHourEntriesExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post5WithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static PagedResponseSchoolHoursPlanExternalResponse Post6(this IKMDStudicaSchoolAdministration operations, SchoolHoursPlansExternalRequest body = default(SchoolHoursPlansExternalRequest))
            {
                return operations.Post6Async(body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseSchoolHoursPlanExternalResponse> Post6Async(this IKMDStudicaSchoolAdministration operations, SchoolHoursPlansExternalRequest body = default(SchoolHoursPlansExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post6WithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
