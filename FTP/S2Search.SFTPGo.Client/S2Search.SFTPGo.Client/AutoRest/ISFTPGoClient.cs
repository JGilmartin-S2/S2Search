// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace S2Search.SFTPGo.Client.AutoRest
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// SFTPGo REST API
    /// </summary>
    public partial interface ISFTPGoClient : System.IDisposable
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
        /// Gets the IGet.
        /// </summary>
        IGet Get { get; }

        /// <summary>
        /// Gets the IChange.
        /// </summary>
        IChange Change { get; }

        /// <summary>
        /// Gets the IClose.
        /// </summary>
        IClose Close { get; }

        /// <summary>
        /// Gets the IUnban.
        /// </summary>
        IUnban Unban { get; }

        /// <summary>
        /// Gets the IStart.
        /// </summary>
        IStart Start { get; }

        /// <summary>
        /// Gets the IQuota.
        /// </summary>
        IQuota Quota { get; }

        /// <summary>
        /// Gets the IFolder.
        /// </summary>
        IFolder Folder { get; }

        /// <summary>
        /// Gets the IAdd.
        /// </summary>
        IAdd Add { get; }

        /// <summary>
        /// Gets the IUpdate.
        /// </summary>
        IUpdate Update { get; }

        /// <summary>
        /// Gets the IDelete.
        /// </summary>
        IDelete Delete { get; }

        /// <summary>
        /// Gets the ILoaddata.
        /// </summary>
        ILoaddata Loaddata { get; }

        /// <summary>
        /// invalidate the access token
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<ApiResponse>> LogoutWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Backup SFTPGo data as data provider independent JSON
        /// </summary>
        /// <remarks>
        /// The backup can be saved in a local file on the server, to avoid
        /// exposing sensitive data over the network, or returned as response
        /// body. The output of dumpdata can be used as input for loaddata
        /// </remarks>
        /// <param name='outputFile'>
        /// Path for the file to write the JSON serialized data to. This path
        /// is relative to the configured "backups_path". If this file already
        /// exists it will be overwritten. To return the backup as response
        /// body set `output_data` to true instead.
        /// </param>
        /// <param name='outputData'>
        /// output_data:
        /// * `0` or any other value != 1, the backup will be saved to a file
        /// on the server, `output_file` is required
        /// * `1` the backup will be returned as response body
        /// </param>
        /// <param name='indent'>
        /// indent:
        /// * `0` no indentation. This is the default
        /// * `1` format the output JSON
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> DumpdataWithHttpMessagesAsync(string outputFile = default(string), int? outputData = default(int?), int? indent = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
