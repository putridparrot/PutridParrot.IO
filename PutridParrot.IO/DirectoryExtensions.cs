
namespace PutridParrot.IO;

public static class DirectoryExtensions
{
    public static void IfExistsDelete(this Directory directory, string path, bool recursive = false)
    {
        if (directory.Exists(path))
        {
            directory.Delete(path, recursive);
        }
    }

    public static IEnumerable<string> EnumerateDirectories(this Directory directory, string path, DateTime startDateTime,
        DateTime endDateTime)
    {
        foreach (var dir in directory.EnumerateDirectories(path))
        {
            var creationDateTime = directory.GetCreationTime(dir);
            if (creationDateTime >= startDateTime && creationDateTime <= endDateTime)
            {
                yield return dir;
            }
        }
    }

    public static IEnumerable<string> EnumerateDirectories(this Directory directory, string path, string searchPattern, DateTime startDateTime,
        DateTime endDateTime)
    {
        foreach (var dir in directory.EnumerateDirectories(path, searchPattern))
        {
            var creationDateTime = directory.GetCreationTime(dir);
            if (creationDateTime >= startDateTime && creationDateTime <= endDateTime)
            {
                yield return dir;
            }
        }
    }

    public static IEnumerable<string> EnumerateDirectories(this Directory directory, string path, string searchPattern, EnumerationOptions enumerationOptions, DateTime startDateTime,
        DateTime endDateTime)
    {
        foreach (var dir in directory.EnumerateDirectories(path, searchPattern, enumerationOptions))
        {
            var creationDateTime = directory.GetCreationTime(dir);
            if (creationDateTime >= startDateTime && creationDateTime <= endDateTime)
            {
                yield return dir;
            }
        }
    }

    public static IEnumerable<string> EnumerateDirectories(this Directory directory, string path, string searchPattern, SearchOption searchOption, DateTime startDateTime,
        DateTime endDateTime)
    {
        foreach (var dir in directory.EnumerateDirectories(path, searchPattern, searchOption))
        {
            var creationDateTime = directory.GetCreationTime(dir);
            if (creationDateTime >= startDateTime && creationDateTime <= endDateTime)
            {
                yield return dir;
            }
        }
    }

}