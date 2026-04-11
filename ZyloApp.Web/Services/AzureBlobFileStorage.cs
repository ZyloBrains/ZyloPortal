using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace ZyloApp.Web.Services;
public class AzureBlobFileStorage : IFileStorageService
{
    private readonly BlobServiceClient _blobServiceClient;
    private readonly ILogger<AzureBlobFileStorage> _logger;

    public AzureBlobFileStorage(BlobServiceClient blobServiceClient, ILogger<AzureBlobFileStorage> logger)
    {
        _blobServiceClient = blobServiceClient;
        _logger = logger;
    }

    public async Task<(bool, string)> UploadFileAsync(IBrowserFile file, string containerName, CancellationToken cancellationToken = default)
    {
        if (file is null)
            return (false, "No iamge selected to upload.");
        
        // validate allowed size or type here if needed
        var containerClient = _blobServiceClient.GetBlobContainerClient(containerName);
        await containerClient.CreateIfNotExistsAsync(PublicAccessType.Blob, cancellationToken: cancellationToken);

        // generate unique blob name
        var uniqueName = Path.GetRandomFileName();
        var fullFileName = $"{uniqueName}_{file.Name}";
        var blobClient = containerClient.GetBlobClient(fullFileName);

        await using (var stream = file.OpenReadStream(cancellationToken: cancellationToken))
        {
            await blobClient.UploadAsync(stream, cancellationToken: cancellationToken);
        }

        // return the absolute URI to save in DB
        return (true, blobClient.Uri.ToString());
    }

    public async Task<(bool, string)> UploadProfileAsync(IBrowserFile file, string containerName, CancellationToken cancellationToken = default)
    {        
        if (file is null)
            return (false, "No iamge selected, please update clear face shot later on or ignore this message if already uploaded.");

        if (file.Size > 200000) // image greater than 200kb
            return (false, "Image should be less than 200KB. Please crop/resize clear face photo and reselect.");

        // validate allowed size or type here if needed
        var containerClient = _blobServiceClient.GetBlobContainerClient(containerName);
        await containerClient.CreateIfNotExistsAsync(PublicAccessType.Blob, cancellationToken: cancellationToken);

        // generate unique blob name
        var uniqueName = Path.GetRandomFileName();
        var fullFileName = $"{uniqueName}_{file.Name}";
        var blobClient = containerClient.GetBlobClient(fullFileName);
        
        await using (var stream = file.OpenReadStream(cancellationToken: cancellationToken))
        {
            await blobClient.UploadAsync(stream, cancellationToken: cancellationToken);
        }

        // return the absolute URI to save in DB
        return (true, blobClient.Uri.ToString());
    }
}