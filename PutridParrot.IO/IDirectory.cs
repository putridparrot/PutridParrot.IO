namespace PutridParrot.IO;

/// <summary>
/// Interface representing the methods of the System.IO.Directory class
/// </summary>
public interface IDirectory
{
    DirectoryInfo CreateDirectory(string path);
    IEnumerable<string> EnumerateFiles(string path);
    IEnumerable<string> EnumerateFiles(string path, string searchPattern);
    IEnumerable<string> EnumerateFiles(string path, string searchPattern, EnumerationOptions enumerationOptions);
    IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption);
    IEnumerable<string> EnumerateDirectories(string path);
    IEnumerable<string> EnumerateDirectories(string path, string searchPattern);
    IEnumerable<string> EnumerateDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions);
    IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption);
    DateTime GetLastWriteTime(string path);
    DateTime GetLastWriteTimeUtc(string path);
    DateTime GetCreationTime(string path);
    DateTime GetCreationTimeUtc(string path);
    void SetCreationTime(string path, DateTime creationTime);
    void Delete(string path);
    void Delete(string path, bool recursive);
    bool Exists(string? path);
    string[] GetFiles(string path);
    string[] GetFiles(string path, string searchPattern);
    string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions);
    string[] GetFiles(string path, string searchPattern, SearchOption searchOption);
    string[] GetDirectories(string path);
    string[] GetDirectories(string path, string searchPattern);
    string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions);
    string[] GetDirectories(string path, string searchPattern, SearchOption searchOption);
    IEnumerable<string> EnumerateFileSystemEntries(string path);
    IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern);
    IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions);
    IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption);
    DirectoryInfo? GetParent(string path);
    void SetCreationTimeUtc(string path, DateTime creationTimeUtc);
    void SetLastWriteTime(string path, DateTime lastWriteTime);
    void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);
    void SetLastAccessTime(string path, DateTime lastAccessTime);
    void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);
    DateTime GetLastAccessTime(string path);
    DateTime GetLastAccessTimeUtc(string path);
    string[] GetFileSystemEntries(string path);
    string[] GetFileSystemEntries(string path, string searchPattern);
    string[] GetFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions);
    string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption);
    string GetDirectoryRoot(string path);
    string GetCurrentDirectory();
    void Move(string sourceDirName, string destDirName);
    string[] GetLogicalDrives();
    FileSystemInfo? ResolveLinkTarget(string linkPath, bool returnFinalTarget);
}