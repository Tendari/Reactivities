using Application.Photos;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Application.Innterfaces
{
    public interface IPhotoAccessor
    {
        Task<PhotoUploadResult> AddPhoto(IFormFile file);
        Task<string> DeletePhoto(string publicId);
    }
}