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
    /// Extension methods for Loaddata.
    /// </summary>
    public static partial class LoaddataExtensions
    {
            /// <summary>
            /// Restore SFTPGo data from a JSON backup file on the server
            /// </summary>
            /// <remarks>
            /// Users, folders and admins will be restored one by one and the restore is
            /// stopped if a user/folder/admin cannot be added or updated, so it could
            /// happen a partial restore
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='inputFile'>
            /// Path for the file to read the JSON serialized data from. This can be an
            /// absolute path or a path relative to the configured "backups_path". The max
            /// allowed file size is 10MB
            /// </param>
            /// <param name='scanQuota'>
            /// Quota scan:
            /// * `0` no quota scan is done, the imported users/folders will have
            /// used_quota_size and used_quota_files = 0 or the existing values if they
            /// already exists. This is the default
            /// * `1` scan quota
            /// * `2` scan quota if the user has quota restrictions
            /// required: false
            /// </param>
            /// <param name='mode'>
            /// Mode:
            /// * `0` New users/admins are added, existing users/admins are updated. This
            /// is the default
            /// * `1` New users/admins are added, existing users/admins are not modified
            /// * `2` New users are added, existing users are updated and, if connected,
            /// they are disconnected and so forced to use the new configuration
            /// </param>
            public static ApiResponse File(this ILoaddata operations, string inputFile, int? scanQuota = default(int?), int? mode = default(int?))
            {
                return operations.FileAsync(inputFile, scanQuota, mode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Restore SFTPGo data from a JSON backup file on the server
            /// </summary>
            /// <remarks>
            /// Users, folders and admins will be restored one by one and the restore is
            /// stopped if a user/folder/admin cannot be added or updated, so it could
            /// happen a partial restore
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='inputFile'>
            /// Path for the file to read the JSON serialized data from. This can be an
            /// absolute path or a path relative to the configured "backups_path". The max
            /// allowed file size is 10MB
            /// </param>
            /// <param name='scanQuota'>
            /// Quota scan:
            /// * `0` no quota scan is done, the imported users/folders will have
            /// used_quota_size and used_quota_files = 0 or the existing values if they
            /// already exists. This is the default
            /// * `1` scan quota
            /// * `2` scan quota if the user has quota restrictions
            /// required: false
            /// </param>
            /// <param name='mode'>
            /// Mode:
            /// * `0` New users/admins are added, existing users/admins are updated. This
            /// is the default
            /// * `1` New users/admins are added, existing users/admins are not modified
            /// * `2` New users are added, existing users are updated and, if connected,
            /// they are disconnected and so forced to use the new configuration
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApiResponse> FileAsync(this ILoaddata operations, string inputFile, int? scanQuota = default(int?), int? mode = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.FileWithHttpMessagesAsync(inputFile, scanQuota, mode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Restore SFTPGo data from a JSON backup
            /// </summary>
            /// <remarks>
            /// Users, folders and admins will be restored one by one and the restore is
            /// stopped if a user/folder/admin cannot be added or updated, so it could
            /// happen a partial restore
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='scanQuota'>
            /// Quota scan:
            /// * `0` no quota scan is done, the imported users/folders will have
            /// used_quota_size and used_quota_files = 0 or the existing values if they
            /// already exists. This is the default
            /// * `1` scan quota
            /// * `2` scan quota if the user has quota restrictions
            /// required: false
            /// </param>
            /// <param name='mode'>
            /// Mode:
            /// * `0` New users/admins are added, existing users/admins are updated. This
            /// is the default
            /// * `1` New users/admins are added, existing users/admins are not modified
            /// * `2` New users are added, existing users are updated and, if connected,
            /// they are disconnected and so forced to use the new configuration
            /// </param>
            public static ApiResponse Body(this ILoaddata operations, BackupData body, int? scanQuota = default(int?), int? mode = default(int?))
            {
                return operations.BodyAsync(body, scanQuota, mode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Restore SFTPGo data from a JSON backup
            /// </summary>
            /// <remarks>
            /// Users, folders and admins will be restored one by one and the restore is
            /// stopped if a user/folder/admin cannot be added or updated, so it could
            /// happen a partial restore
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='scanQuota'>
            /// Quota scan:
            /// * `0` no quota scan is done, the imported users/folders will have
            /// used_quota_size and used_quota_files = 0 or the existing values if they
            /// already exists. This is the default
            /// * `1` scan quota
            /// * `2` scan quota if the user has quota restrictions
            /// required: false
            /// </param>
            /// <param name='mode'>
            /// Mode:
            /// * `0` New users/admins are added, existing users/admins are updated. This
            /// is the default
            /// * `1` New users/admins are added, existing users/admins are not modified
            /// * `2` New users are added, existing users are updated and, if connected,
            /// they are disconnected and so forced to use the new configuration
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApiResponse> BodyAsync(this ILoaddata operations, BackupData body, int? scanQuota = default(int?), int? mode = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BodyWithHttpMessagesAsync(body, scanQuota, mode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
