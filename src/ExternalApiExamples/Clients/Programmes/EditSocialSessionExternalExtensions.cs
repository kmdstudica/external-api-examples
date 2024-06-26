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
    /// Extension methods for EditSocialSessionExternal.
    /// </summary>
    public static partial class EditSocialSessionExternalExtensions
    {
            /// <summary>
            /// EditSocialSessionExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='editSocialSessionExternalCommand'>
            /// </param>
            public static void Post(this IEditSocialSessionExternal operations, EditSocialSessionExternalCommand editSocialSessionExternalCommand = default(EditSocialSessionExternalCommand))
            {
                operations.PostAsync(editSocialSessionExternalCommand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// EditSocialSessionExternal_Post
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='editSocialSessionExternalCommand'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PostAsync(this IEditSocialSessionExternal operations, EditSocialSessionExternalCommand editSocialSessionExternalCommand = default(EditSocialSessionExternalCommand), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PostWithHttpMessagesAsync(editSocialSessionExternalCommand, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}