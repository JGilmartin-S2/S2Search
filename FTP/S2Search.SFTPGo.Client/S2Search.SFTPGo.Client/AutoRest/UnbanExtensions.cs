// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.SFTPGo.Client.AutoRest
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Unban.
    /// </summary>
    public static partial class UnbanExtensions
    {
            /// <summary>
            /// Removes the specified IPv6/IPv6 from the banned ones
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static ApiResponse Host(this IUnban operations, Paths1qq47kldefenderUnbanpostrequestbodycontentapplicationJsonschema body)
            {
                return operations.HostAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes the specified IPv6/IPv6 from the banned ones
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApiResponse> HostAsync(this IUnban operations, Paths1qq47kldefenderUnbanpostrequestbodycontentapplicationJsonschema body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.HostWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
