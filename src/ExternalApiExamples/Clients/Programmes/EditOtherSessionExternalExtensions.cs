// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EditOtherSessionExternal.
    /// </summary>
    public static partial class EditOtherSessionExternalExtensions
    {
            /// <summary>
            /// EditOtherSessionExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='editOtherSessionExternalCommand'>
            /// </param>
            public static void Post(this IEditOtherSessionExternal operations, EditOtherSessionExternalCommand editOtherSessionExternalCommand = default(EditOtherSessionExternalCommand))
            {
                operations.PostAsync(editOtherSessionExternalCommand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// EditOtherSessionExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='editOtherSessionExternalCommand'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostAsync(this IEditOtherSessionExternal operations, EditOtherSessionExternalCommand editOtherSessionExternalCommand = default(EditOtherSessionExternalCommand), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PostWithHttpMessagesAsync(editOtherSessionExternalCommand, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
