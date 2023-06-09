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
    /// Extension methods for Start.
    /// </summary>
    public static partial class StartExtensions
    {
            /// <summary>
            /// start a new user quota scan
            /// </summary>
            /// <remarks>
            /// A quota scan update the number of files and their total size for the
            /// specified user
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static ApiResponse Scan(this IStart operations, User body)
            {
                return operations.ScanAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// start a new user quota scan
            /// </summary>
            /// <remarks>
            /// A quota scan update the number of files and their total size for the
            /// specified user
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApiResponse> ScanAsync(this IStart operations, User body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ScanWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// start a new folder quota scan
            /// </summary>
            /// <remarks>
            /// A quota scan update the number of files and their total size for the
            /// specified folder
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            public static ApiResponse Scan1(this IStart operations, BaseVirtualFolder body)
            {
                return operations.Scan1Async(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// start a new folder quota scan
            /// </summary>
            /// <remarks>
            /// A quota scan update the number of files and their total size for the
            /// specified folder
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApiResponse> Scan1Async(this IStart operations, BaseVirtualFolder body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.Scan1WithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
