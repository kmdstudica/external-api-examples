// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    public partial interface IKMDStudicaProgrammes : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IAbsenceRegistrationsExternal.
        /// </summary>
        IAbsenceRegistrationsExternal AbsenceRegistrationsExternal { get; }

        /// <summary>
        /// Gets the IActiveSubjectCoursesExternal.
        /// </summary>
        IActiveSubjectCoursesExternal ActiveSubjectCoursesExternal { get; }

        /// <summary>
        /// Gets the IActivitiesExternal.
        /// </summary>
        IActivitiesExternal ActivitiesExternal { get; }

        /// <summary>
        /// Gets the IAddLessonsExternal.
        /// </summary>
        IAddLessonsExternal AddLessonsExternal { get; }

        /// <summary>
        /// Gets the IBulkAbsenceRegistrationsExternal.
        /// </summary>
        IBulkAbsenceRegistrationsExternal BulkAbsenceRegistrationsExternal { get; }

        /// <summary>
        /// Gets the IBulkBridgingCourseStudentsExternal.
        /// </summary>
        IBulkBridgingCourseStudentsExternal BulkBridgingCourseStudentsExternal { get; }

        /// <summary>
        /// Gets the IBulkEducationalProgrammesExternal.
        /// </summary>
        IBulkEducationalProgrammesExternal BulkEducationalProgrammesExternal { get; }

        /// <summary>
        /// Gets the IBulkLessonsExternal.
        /// </summary>
        IBulkLessonsExternal BulkLessonsExternal { get; }

        /// <summary>
        /// Gets the IBulkSubjectCoursesExternal.
        /// </summary>
        IBulkSubjectCoursesExternal BulkSubjectCoursesExternal { get; }

        /// <summary>
        /// Gets the IDeleteLessonExternal.
        /// </summary>
        IDeleteLessonExternal DeleteLessonExternal { get; }

        /// <summary>
        /// Gets the IDeleteLessonsExternal.
        /// </summary>
        IDeleteLessonsExternal DeleteLessonsExternal { get; }

        /// <summary>
        /// Gets the IEditLessonExternal.
        /// </summary>
        IEditLessonExternal EditLessonExternal { get; }

        /// <summary>
        /// Gets the IEducationalProgrammesExternal.
        /// </summary>
        IEducationalProgrammesExternal EducationalProgrammesExternal { get; }

        /// <summary>
        /// Gets the IHelloWorldExternal.
        /// </summary>
        IHelloWorldExternal HelloWorldExternal { get; }

        /// <summary>
        /// Gets the ILessonsExternal.
        /// </summary>
        ILessonsExternal LessonsExternal { get; }

        /// <summary>
        /// Gets the IRegisterAbsenceExternal.
        /// </summary>
        IRegisterAbsenceExternal RegisterAbsenceExternal { get; }

        /// <summary>
        /// Gets the ISchoolCoursesExternal.
        /// </summary>
        ISchoolCoursesExternal SchoolCoursesExternal { get; }

        /// <summary>
        /// Gets the IStudentActivityReportsExternal.
        /// </summary>
        IStudentActivityReportsExternal StudentActivityReportsExternal { get; }

        /// <summary>
        /// Gets the IStudentActivityReportsV2External.
        /// </summary>
        IStudentActivityReportsV2External StudentActivityReportsV2External { get; }

        /// <summary>
        /// Gets the IStudentInternshipExternal.
        /// </summary>
        IStudentInternshipExternal StudentInternshipExternal { get; }

        /// <summary>
        /// Gets the IStudentSchoolCoursesExternal.
        /// </summary>
        IStudentSchoolCoursesExternal StudentSchoolCoursesExternal { get; }

        /// <summary>
        /// Gets the IStudentSubjectCoursesExternal.
        /// </summary>
        IStudentSubjectCoursesExternal StudentSubjectCoursesExternal { get; }

        /// <summary>
        /// Gets the ISubjectCoursesExternal.
        /// </summary>
        ISubjectCoursesExternal SubjectCoursesExternal { get; }

        /// <summary>
        /// Gets the IUnscheduledLessonsExternal.
        /// </summary>
        IUnscheduledLessonsExternal UnscheduledLessonsExternal { get; }

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseAbsenceRegistrationExternalResponse>> PostWithHttpMessagesAsync(AbsenceRegistrationsExternalRequest body = default(AbsenceRegistrationsExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseSubjectCourseExternalResponse>> Post1WithHttpMessagesAsync(ActiveSubjectCoursesExternalRequest body = default(ActiveSubjectCoursesExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseActivityResponse>> Post2WithHttpMessagesAsync(ActivitiesExternalRequest body = default(ActivitiesExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<AbsenceRegistrationExternalResponse>>> Post3WithHttpMessagesAsync(BulkAbsenceRegistrationsExternalRequest body = default(BulkAbsenceRegistrationsExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseEducationalProgrammeExternalResponse>> Post4WithHttpMessagesAsync(EducationalProgrammesExternalRequest body = default(EducationalProgrammesExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='schoolCode'>
        /// String The school code for which to get data.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<HelloWorldExternalResponse>> Post5WithHttpMessagesAsync(string schoolCode, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseLessonExternalResponse>> Post6WithHttpMessagesAsync(LessonsExternalRequest body = default(LessonsExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseSchoolCourseExternalResponse>> Post7WithHttpMessagesAsync(SchoolCoursesExternalRequest body = default(SchoolCoursesExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<ActivityGroupDto>>> Post8WithHttpMessagesAsync(StudentActivityReportsExternalRequest body = default(StudentActivityReportsExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<ActivityGroup2Dto>>> Post9WithHttpMessagesAsync(StudentActivityReportsV2ExternalRequest body = default(StudentActivityReportsV2ExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<StudentInternshipExternalResponse>>> Post10WithHttpMessagesAsync(StudentInternshipExternalRequest body = default(StudentInternshipExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<StudentSchoolCoursesExternalResponse>>> Post11WithHttpMessagesAsync(StudentSchoolCoursesExternalRequest body = default(StudentSchoolCoursesExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseStudentSubjectCoursesExternalResponse>> Post12WithHttpMessagesAsync(StudentSubjectCoursesExternalRequest body = default(StudentSubjectCoursesExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseSubjectCourseExternalResponse>> Post13WithHttpMessagesAsync(SubjectCoursesExternalRequest body = default(SubjectCoursesExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseUnscheduledLessonExternalResponse>> Post14WithHttpMessagesAsync(LessonsExternalRequest body = default(LessonsExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
