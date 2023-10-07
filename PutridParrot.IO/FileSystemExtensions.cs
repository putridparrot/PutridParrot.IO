namespace PutridParrot.IO;

public static partial class FileSystemExtensions
{
    private static bool IsDateTimeWithinRange(DateTime dateTime, DateTime startDateTime, DateTime endDateTime) =>
        dateTime >= startDateTime && dateTime <= endDateTime;

    public static IEnumerable<string> EnumerateFiles(this IFileSystem fileSystem, string path, DateTime startDateTime,
        DateTime endDateTime) => 
        fileSystem.Directory.EnumerateFiles(path).Where(f => 
            IsDateTimeWithinRange(fileSystem.File.GetCreationTime(f), startDateTime, endDateTime));

    public static IEnumerable<string> EnumerateFiles(this IFileSystem fileSystem, string path, string searchPattern,
        DateTime startDateTime,
        DateTime endDateTime) =>
        fileSystem.Directory.EnumerateFiles(path, searchPattern).Where(f =>
            IsDateTimeWithinRange(fileSystem.File.GetCreationTime(f), startDateTime, endDateTime));

    public static IEnumerable<string> EnumerateFiles(this IFileSystem fileSystem, string path, string searchPattern,
        EnumerationOptions enumerationOptions, DateTime startDateTime,
        DateTime endDateTime) =>
        fileSystem.Directory.EnumerateFiles(path, searchPattern, enumerationOptions).Where(f =>
            IsDateTimeWithinRange(fileSystem.File.GetCreationTime(f), startDateTime, endDateTime));

    public static IEnumerable<string> EnumerateFiles(this IFileSystem fileSystem, string path, string searchPattern,
        SearchOption searchOption, DateTime startDateTime, DateTime endDateTime) =>
        fileSystem.Directory.EnumerateFiles(path, searchPattern, searchOption).Where(f =>
            IsDateTimeWithinRange(fileSystem.File.GetCreationTime(f), startDateTime, endDateTime));

    public static IEnumerable<string> EnumerateDirectories(this IFileSystem fileSystem, string path,
        DateTime startDateTime, DateTime endDateTime) =>
        fileSystem.Directory.EnumerateDirectories(path).Where(f =>
            IsDateTimeWithinRange(fileSystem.Directory.GetCreationTime(f), startDateTime, endDateTime));

    public static IEnumerable<string> EnumerateDirectories(this IFileSystem fileSystem, string path,
        string searchPattern, DateTime startDateTime, DateTime endDateTime) =>
        fileSystem.Directory.EnumerateDirectories(path, searchPattern).Where(f =>
            IsDateTimeWithinRange(fileSystem.Directory.GetCreationTime(f), startDateTime, endDateTime));

    public static IEnumerable<string> EnumerateDirectories(this IFileSystem fileSystem, string path,
        string searchPattern, EnumerationOptions enumerationOptions, DateTime startDateTime, DateTime endDateTime) =>
        fileSystem.Directory.EnumerateDirectories(path, searchPattern, enumerationOptions).Where(f =>
            IsDateTimeWithinRange(fileSystem.Directory.GetCreationTime(f), startDateTime, endDateTime));

    public static IEnumerable<string> EnumerateDirectories(this IFileSystem fileSystem, string path,
        string searchPattern, SearchOption searchOption, DateTime startDateTime, DateTime endDateTime) =>
        fileSystem.Directory.EnumerateDirectories(path, searchPattern, searchOption).Where(f =>
            IsDateTimeWithinRange(fileSystem.Directory.GetCreationTime(f), startDateTime, endDateTime));
}