// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.SFTPGo.Client.AutoRest
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Update operations.
    /// </summary>
    public partial interface IUpdate
    {
        /// <summary>
        /// Update an existing user
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='name'>
        /// folder name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ApiResponse>> FolderMethodWithHttpMessagesAsync(BaseVirtualFolder body, string name, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update an existing admin
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='username'>
        /// the admin username
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ApiResponse>> AdminMethodWithHttpMessagesAsync(Admin body, string username, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update an existing user
        /// </summary>
        /// <param name='body'>
        /// </param>
        /// <param name='username'>
        /// the username
        /// </param>
        /// <param name='disconnect'>
        /// Disconnect:
        /// * `0` The user will not be disconnected and it will continue to use
        /// the old configuration until connected. This is the default
        /// * `1` The user will be disconnected after a successful update. It
        /// must login again and so it will be forced to use the new
        /// configuration
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ApiResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<ApiResponse>> UserMethodWithHttpMessagesAsync(User body, string username, int? disconnect = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}