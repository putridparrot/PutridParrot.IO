using System.Diagnostics.CodeAnalysis;

namespace PutridParrot.IO;

/// <summary>
/// Implements the System.IO.Directory class in a way that allows us
/// to easily drop in mocks, stubs etc.
/// </summary>
public sealed class Directory : IDirectory
{
    public DirectoryInfo CreateDirectory(string path) =>
        System.IO.Directory.CreateDirectory(path);

    public IEnumerable<string> EnumerateFiles(string path) =>
        System.IO.Directory.EnumerateFiles(path);

    public IEnumerable<string> EnumerateFiles(string path, string searchPattern) =>
        System.IO.Directory.EnumerateFiles(path, searchPattern);

    public IEnumerable<string> EnumerateFiles(string path, string searchPattern, EnumerationOptions enumerationOptions) =>
        System.IO.Directory.EnumerateFiles(path, searchPattern, enumerationOptions);

    public IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption) =>
        System.IO.Directory.EnumerateFiles(path, searchPattern, searchOption);

    public DateTime GetLastWriteTime(string path) =>
        System.IO.Directory.GetLastWriteTime(path);

    public DateTime GetLastWriteTimeUtc(string path) =>
        System.IO.Directory.GetLastWriteTimeUtc(path);

    public DateTime GetCreationTime(string path) =>
        System.IO.Directory.GetCreationTime(path);

    public DateTime GetCreationTimeUtc(string path) =>
        System.IO.Directory.GetCreationTimeUtc(path);

    public void Delete(string path) =>
        System.IO.Directory.Delete(path);
    public void Delete(string path, bool recursive) =>
        System.IO.Directory.Delete(path, recursive);

    public bool Exists([NotNullWhen(true)] string? path) =>
        System.IO.Directory.Exists(path);

    public IEnumerable<string> EnumerateDirectories(string path) =>
        System.IO.Directory.EnumerateDirectories(path);

    public IEnumerable<string> EnumerateDirectories(string path, string searchPattern) =>
        System.IO.Directory.EnumerateDirectories(path, searchPattern);

    public IEnumerable<string> EnumerateDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions) =>
        System.IO.Directory.EnumerateDirectories(path, searchPattern, enumerationOptions);

    public IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption) =>
        System.IO.Directory.EnumerateDirectories(path, searchPattern, searchOption);

    public string[] GetFiles(string path) =>
        System.IO.Directory.GetFiles(path);

    public string[] GetFiles(string path, string searchPattern) =>
        System.IO.Directory.GetFiles(path, searchPattern);

    public string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions) =>
        System.IO.Directory.GetFiles(path, searchPattern, enumerationOptions);

    public string[] GetFiles(string path, string searchPattern, SearchOption searchOption) =>
        System.IO.Directory.GetFiles(path, searchPattern, searchOption);

    public FileSystemInfo CreateSymbolicLink(string path, string pathToTarget) =>
        System.IO.Directory.CreateSymbolicLink(path, pathToTarget);

    public IEnumerable<string> EnumerateFileSystemEntries(string path) =>
        System.IO.Directory.EnumerateFileSystemEntries(path);

    public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern) =>
        System.IO.Directory.EnumerateFileSystemEntries(path, searchPattern);

    public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions) =>
        System.IO.Directory.EnumerateFileSystemEntries(path, searchPattern, enumerationOptions);

    public IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption) =>
        System.IO.Directory.EnumerateFileSystemEntries(path, searchPattern, searchOption);

    public DirectoryInfo? GetParent(string path) =>
        System.IO.Directory.GetParent(path);

    public void SetCreationTime(string path, DateTime creationTime) =>
        System.IO.Directory.SetCreationTime(path, creationTime);

    public void SetCreationTimeUtc(string path, DateTime creationTimeUtc) =>
        System.IO.Directory.SetCreationTimeUtc(path, creationTimeUtc);

    public void SetLastWriteTime(string path, DateTime lastWriteTime) =>
        System.IO.Directory.SetLastWriteTime(path, lastWriteTime);
    public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) =>
        System.IO.Directory.SetLastWriteTimeUtc(path, lastWriteTimeUtc);

    public void SetLastAccessTime(string path, DateTime lastAccessTime) =>
        System.IO.Directory.SetLastAccessTime(path, lastAccessTime);
    public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) =>
        System.IO.Directory.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
    public DateTime GetLastAccessTime(string path) =>
        System.IO.Directory.GetLastAccessTime(path);
    public DateTime GetLastAccessTimeUtc(string path) =>
        System.IO.Directory.GetLastAccessTimeUtc(path);
    public string[] GetDirectories(string path) =>
        System.IO.Directory.GetDirectories(path);
    public string[] GetDirectories(string path, string searchPattern) =>
        System.IO.Directory.GetDirectories(path, searchPattern);
    public string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions) =>
        System.IO.Directory.GetDirectories(path, searchPattern, enumerationOptions);
    public string[] GetDirectories(string path, string searchPattern, SearchOption searchOption) =>
        System.IO.Directory.GetDirectories(path, searchPattern, searchOption);
    public string[] GetFileSystemEntries(string path) =>
        System.IO.Directory.GetFileSystemEntries(path);
    public string[] GetFileSystemEntries(string path, string searchPattern) =>
        System.IO.Directory.GetFileSystemEntries(path, searchPattern);
    public string[] GetFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions) =>
        System.IO.Directory.GetFileSystemEntries(path, searchPattern, enumerationOptions);
    public string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption) =>
        System.IO.Directory.GetFileSystemEntries(path, searchPattern, searchOption);
    public string GetDirectoryRoot(string path) =>
        System.IO.Directory.GetDirectoryRoot(path);
    public string GetCurrentDirectory() => 
        System.IO.Directory.GetCurrentDirectory();

    public void Move(string sourceDirName, string destDirName) =>
        System.IO.Directory.Move(sourceDirName, destDirName);

    public string[] GetLogicalDrives() =>
        System.IO.Directory.GetLogicalDrives();
    public FileSystemInfo? ResolveLinkTarget(string linkPath, bool returnFinalTarget) =>
        System.IO.Directory.ResolveLinkTarget(linkPath, returnFinalTarget);
}