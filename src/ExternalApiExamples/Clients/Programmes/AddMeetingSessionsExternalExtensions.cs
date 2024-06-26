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
    /// Extension methods for AddMeetingSessionsExternal.
    /// </summary>
    public static partial class AddMeetingSessionsExternalExtensions
    {
            /// <summary>
            /// AddMeetingSessionsExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessions'>
            /// New sessions to create.
            /// </param>
            /// <param name='schoolCode'>
            /// String The school code for which to get data.
            /// </param>
            public static void Post(this IAddMeetingSessionsExternal operations, IList<ExternalMeetingSessionDto> sessions, string schoolCode)
            {
                operations.PostAsync(sessions, schoolCode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// AddMeetingSessionsExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sessions'>
            /// New sessions to create.
            /// </param>
            /// <param name='schoolCode'>
            /// String The school code for which to get data.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostAsync(this IAddMeetingSessionsExternal operations, IList<ExternalMeetingSessionDto> sessions, string schoolCode, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PostWithHttpMessagesAsync(sessions, schoolCode, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
