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
    /// Extension methods for StudicaDemoSchoolAdministration.
    /// </summary>
    public static partial class StudicaDemoSchoolAdministrationExtensions
    {
            /// <summary>
            /// _ActiveDepartmentsExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='activeDepartmentsExternalRequest'>
            /// </param>
            public static PagedResponseDepartmentsExternalResponse Post(this IStudicaDemoSchoolAdministration operations, ActiveDepartmentsExternalRequest activeDepartmentsExternalRequest = default(ActiveDepartmentsExternalRequest))
            {
                return operations.PostAsync(activeDepartmentsExternalRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// _ActiveDepartmentsExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='activeDepartmentsExternalRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseDepartmentsExternalResponse> PostAsync(this IStudicaDemoSchoolAdministration operations, ActiveDepartmentsExternalRequest activeDepartmentsExternalRequest = default(ActiveDepartmentsExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(activeDepartmentsExternalRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// _ActiveEmployeesExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='activeEmployeesExternalRequest'>
            /// </param>
            public static PagedResponseEmployeeExternalResponse Post1(this IStudicaDemoSchoolAdministration operations, ActiveEmployeesExternalRequest activeEmployeesExternalRequest = default(ActiveEmployeesExternalRequest))
            {
                return operations.Post1Async(activeEmployeesExternalRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// _ActiveEmployeesExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='activeEmployeesExternalRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseEmployeeExternalResponse> Post1Async(this IStudicaDemoSchoolAdministration operations, ActiveEmployeesExternalRequest activeEmployeesExternalRequest = default(ActiveEmployeesExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post1WithHttpMessagesAsync(activeEmployeesExternalRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// _AreasOfEducationExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='areasOfEducationExternalRequest'>
            /// </param>
            public static PagedResponseAreaOfEducationExternalResponse Post2(this IStudicaDemoSchoolAdministration operations, AreasOfEducationExternalRequest areasOfEducationExternalRequest = default(AreasOfEducationExternalRequest))
            {
                return operations.Post2Async(areasOfEducationExternalRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// _AreasOfEducationExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='areasOfEducationExternalRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseAreaOfEducationExternalResponse> Post2Async(this IStudicaDemoSchoolAdministration operations, AreasOfEducationExternalRequest areasOfEducationExternalRequest = default(AreasOfEducationExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post2WithHttpMessagesAsync(areasOfEducationExternalRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// _AreasOfResponsibilityExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='areasOfResponsibilityExternalRequest'>
            /// </param>
            public static PagedResponseAreaOfResponsibilityExternalResponse Post3(this IStudicaDemoSchoolAdministration operations, AreasOfResponsibilityExternalRequest areasOfResponsibilityExternalRequest = default(AreasOfResponsibilityExternalRequest))
            {
                return operations.Post3Async(areasOfResponsibilityExternalRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// _AreasOfResponsibilityExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='areasOfResponsibilityExternalRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseAreaOfResponsibilityExternalResponse> Post3Async(this IStudicaDemoSchoolAdministration operations, AreasOfResponsibilityExternalRequest areasOfResponsibilityExternalRequest = default(AreasOfResponsibilityExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post3WithHttpMessagesAsync(areasOfResponsibilityExternalRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// _DayCalendarsExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dayCalendarsExternalRequest'>
            /// </param>
            public static PagedResponseDayCalendarsExternalResponse Post4(this IStudicaDemoSchoolAdministration operations, DayCalendarsExternalRequest dayCalendarsExternalRequest = default(DayCalendarsExternalRequest))
            {
                return operations.Post4Async(dayCalendarsExternalRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// _DayCalendarsExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dayCalendarsExternalRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseDayCalendarsExternalResponse> Post4Async(this IStudicaDemoSchoolAdministration operations, DayCalendarsExternalRequest dayCalendarsExternalRequest = default(DayCalendarsExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post4WithHttpMessagesAsync(dayCalendarsExternalRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// _DepartmentsExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='departmentsExternalRequest'>
            /// </param>
            public static PagedResponseDepartmentsExternalResponse Post5(this IStudicaDemoSchoolAdministration operations, DepartmentsExternalRequest departmentsExternalRequest = default(DepartmentsExternalRequest))
            {
                return operations.Post5Async(departmentsExternalRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// _DepartmentsExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='departmentsExternalRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseDepartmentsExternalResponse> Post5Async(this IStudicaDemoSchoolAdministration operations, DepartmentsExternalRequest departmentsExternalRequest = default(DepartmentsExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post5WithHttpMessagesAsync(departmentsExternalRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// _EmployeesExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='employeesExternalRequest'>
            /// </param>
            public static PagedResponseEmployeeExternalResponse Post6(this IStudicaDemoSchoolAdministration operations, EmployeesExternalRequest employeesExternalRequest = default(EmployeesExternalRequest))
            {
                return operations.Post6Async(employeesExternalRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// _EmployeesExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='employeesExternalRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseEmployeeExternalResponse> Post6Async(this IStudicaDemoSchoolAdministration operations, EmployeesExternalRequest employeesExternalRequest = default(EmployeesExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post6WithHttpMessagesAsync(employeesExternalRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// _RoomsExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='roomsExternalRequest'>
            /// </param>
            public static PagedResponseRoomExternalResponse Post7(this IStudicaDemoSchoolAdministration operations, RoomsExternalRequest roomsExternalRequest = default(RoomsExternalRequest))
            {
                return operations.Post7Async(roomsExternalRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// _RoomsExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='roomsExternalRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseRoomExternalResponse> Post7Async(this IStudicaDemoSchoolAdministration operations, RoomsExternalRequest roomsExternalRequest = default(RoomsExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post7WithHttpMessagesAsync(roomsExternalRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// _SchoolHourEntriesExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='schoolHourEntriesExternalRequest'>
            /// </param>
            public static PagedResponseSchoolHourEntryExternalResponse Post8(this IStudicaDemoSchoolAdministration operations, SchoolHourEntriesExternalRequest schoolHourEntriesExternalRequest = default(SchoolHourEntriesExternalRequest))
            {
                return operations.Post8Async(schoolHourEntriesExternalRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// _SchoolHourEntriesExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='schoolHourEntriesExternalRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseSchoolHourEntryExternalResponse> Post8Async(this IStudicaDemoSchoolAdministration operations, SchoolHourEntriesExternalRequest schoolHourEntriesExternalRequest = default(SchoolHourEntriesExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post8WithHttpMessagesAsync(schoolHourEntriesExternalRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// _SchoolHoursPlanDetailsExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='schoolCode'>
            /// String The school code for which to get data.
            /// </param>
            public static SchoolHoursPlanDetailsExternalResponse Post9(this IStudicaDemoSchoolAdministration operations, System.Guid id, string schoolCode)
            {
                return operations.Post9Async(id, schoolCode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// _SchoolHoursPlanDetailsExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='schoolCode'>
            /// String The school code for which to get data.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SchoolHoursPlanDetailsExternalResponse> Post9Async(this IStudicaDemoSchoolAdministration operations, System.Guid id, string schoolCode, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post9WithHttpMessagesAsync(id, schoolCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// _SchoolHoursPlansExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='schoolHoursPlansExternalRequest'>
            /// </param>
            public static PagedResponseSchoolHoursPlanExternalResponse Post10(this IStudicaDemoSchoolAdministration operations, SchoolHoursPlansExternalRequest schoolHoursPlansExternalRequest = default(SchoolHoursPlansExternalRequest))
            {
                return operations.Post10Async(schoolHoursPlansExternalRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// _SchoolHoursPlansExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='schoolHoursPlansExternalRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponseSchoolHoursPlanExternalResponse> Post10Async(this IStudicaDemoSchoolAdministration operations, SchoolHoursPlansExternalRequest schoolHoursPlansExternalRequest = default(SchoolHoursPlansExternalRequest), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Post10WithHttpMessagesAsync(schoolHoursPlansExternalRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
