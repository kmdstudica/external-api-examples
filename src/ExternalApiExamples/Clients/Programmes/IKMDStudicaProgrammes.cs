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
        /// Gets the IAddLessonsExternal.
        /// </summary>
        IAddLessonsExternal AddLessonsExternal { get; }

        /// <summary>
        /// Gets the IBulkAbsenceRegistrationsExternal.
        /// </summary>
        IBulkAbsenceRegistrationsExternal BulkAbsenceRegistrationsExternal { get; }

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
        Task<HttpOperationResponse<IList<AbsenceRegistrationExternalResponse>>> Post2WithHttpMessagesAsync(BulkAbsenceRegistrationsExternalRequest body = default(BulkAbsenceRegistrationsExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseEducationalProgrammeExternalResponse>> Post3WithHttpMessagesAsync(EducationalProgrammesExternalRequest body = default(EducationalProgrammesExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseLessonExternalResponse>> Post4WithHttpMessagesAsync(LessonsExternalRequest body = default(LessonsExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseSchoolCourseExternalResponse>> Post5WithHttpMessagesAsync(SchoolCoursesExternalRequest body = default(SchoolCoursesExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<StudentInternshipExternalResponse>>> Post6WithHttpMessagesAsync(StudentInternshipExternalRequest body = default(StudentInternshipExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<StudentSchoolCoursesExternalResponse>>> Post7WithHttpMessagesAsync(StudentSchoolCoursesExternalRequest body = default(StudentSchoolCoursesExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseStudentSubjectCoursesExternalResponse>> Post8WithHttpMessagesAsync(StudentSubjectCoursesExternalRequest body = default(StudentSubjectCoursesExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseSubjectCourseExternalResponse>> Post9WithHttpMessagesAsync(SubjectCoursesExternalRequest body = default(SubjectCoursesExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<PagedResponseUnscheduledLessonExternalResponse>> Post10WithHttpMessagesAsync(LessonsExternalRequest body = default(LessonsExternalRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
