using Microsoft.AspNetCore.Components.Forms;

namespace ZyloApp.Web.Helpers;
public class ImageUploader
{
    public static async Task<(bool uploadSuccess, string Message)> Upload(IBrowserFile? file)
    {
        if (file is null)
            return (false, "No iamge selected, please update clear face shot later on or ignore this message if already uploaded.");

        if (file.Size > 100000) // image greater than 100kb
            return (false, "Image should be less than 100KB. Please crop/resize clear face photo and reselect.");

        try
        {
            var folderName = "profile_uploads";
            var currentAppPath = Environment.CurrentDirectory;
            var folderPath = Path.Combine(currentAppPath, "wwwroot", folderName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var uniqueName = Path.GetRandomFileName();
            var fullFileName = $"{uniqueName}_{file.Name}";
            var path = Path.Combine(folderPath, fullFileName);

            await using FileStream fs = new(path, FileMode.Create);
            await file.OpenReadStream().CopyToAsync(fs);

            return (true, $"/{folderName}/{fullFileName}");
        }
        catch(Exception ex)
        {
            return (false, ex.Message ?? ex.InnerException!.Message);
        }

    }
}
