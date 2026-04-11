using Microsoft.AspNetCore.Components.Forms;

namespace ZyloApp.Web.Services;
public interface IFileStorageService
{
    /// <summary>
    /// Upload an IFormFile into the specified container and returns the public blob URL.
    /// </summary>
    Task<(bool, string)> UploadProfileAsync(IBrowserFile file, string containerName, CancellationToken cancellationToken = default);
    Task<(bool, string)> UploadFileAsync(IBrowserFile file, string containerName, CancellationToken cancellationToken = default);
}