
namespace Serene1;

public interface IDirectoryService
{
    AppServices.DirectoryEntry Validate(string username, string password);
}