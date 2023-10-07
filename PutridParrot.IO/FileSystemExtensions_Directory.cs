using System.Diagnostics.CodeAnalysis;

namespace PutridParrot.IO;

public static partial class FileSystemExtensions
{
    public static DirectoryInfo CreateDirectory(this IFileSystem fileSystem, string path) =>
        fileSystem.Directory.CreateDirectory(path);
    public static IEnumerable<string> EnumerateFiles(this IFileSystem fileSystem, string path) =>
        fileSystem.Directory.EnumerateFiles(path);
    public static IEnumerable<string> EnumerateFiles(this IFileSystem fileSystem, string path, string searchPattern) =>
        fileSystem.Directory.EnumerateFiles(path, searchPattern);
    public static IEnumerable<string> EnumerateFiles(this IFileSystem fileSystem, string path, string searchPattern, EnumerationOptions enumerationOptions) =>
        fileSystem.Directory.EnumerateFiles(path, searchPattern, enumerationOptions);
    public static IEnumerable<string> EnumerateFiles(this IFileSystem fileSystem, string path, string searchPattern, SearchOption searchOption) =>
        fileSystem.Directory.EnumerateFiles(path, searchPattern, searchOption);
    public static DateTime GetDirectoryLastWriteTime(this IFileSystem fileSystem, string path) =>
        fileSystem.Directory.GetLastWriteTime(path);
    public static DateTime GetDirectoryLastWriteTimeUtc(this IFileSystem fileSystem, string path) =>
        fileSystem.Directory.GetLastWriteTimeUtc(path);
    public static DateTime GetDirectoryCreationTime(this IFileSystem fileSystem, string path) =>
        fileSystem.Directory.GetCreationTime(path);
    public static DateTime GetDirectoryCreationTimeUtc(this IFileSystem fileSystem, string path) =>
        fileSystem.Directory.GetCreationTimeUtc(path);
    public static void DeleteDirectory(this IFileSystem fileSystem, string path) =>
        fileSystem.Directory.Delete(path);
    public static void DeleteDirectory(this IFileSystem fileSystem, string path, bool recursive) =>
        fileSystem.Directory.Delete(path, recursive);
    public static bool DirectoryExists(this IFileSystem fileSystem, [NotNullWhen(true)] string? path) =>
        fileSystem.Directory.Exists(path);
    public static IEnumerable<string> EnumerateDirectories(this IFileSystem fileSystem, string path) =>
        fileSystem.Directory.EnumerateDirectories(path);
    public static IEnumerable<string> EnumerateDirectories(this IFileSystem fileSystem, string path, string searchPattern) =>
        fileSystem.Directory.EnumerateDirectories(path, searchPattern);
    public static IEnumerable<string> EnumerateDirectories(this IFileSystem fileSystem, string path, string searchPattern, EnumerationOptions enumerationOptions) =>
        fileSystem.Directory.EnumerateDirectories(path, searchPattern, enumerationOptions);
    public static IEnumerable<string> EnumerateDirectories(this IFileSystem fileSystem, string path, string searchPattern, SearchOption searchOption) =>
        fileSystem.Directory.EnumerateDirectories(path, searchPattern, searchOption);
    public static string[] GetFiles(this IFileSystem fileSystem, string path) =>
        fileSystem.Directory.GetFiles(path);
    public static string[] GetFiles(this IFileSystem fileSystem, string path, string searchPattern) =>
        fileSystem.Directory.GetFiles(path, searchPattern);
    public static string[] GetFiles(this IFileSystem fileSystem, string path, string searchPattern, EnumerationOptions enumerationOptions) =>
        fileSystem.Directory.GetFiles(path, searchPattern, enumerationOptions);
    public static string[] GetFiles(this IFileSystem fileSystem, string path, string searchPattern, SearchOption searchOption) =>
        fileSystem.Directory.GetFiles(path, searchPattern, searchOption);
    public static FileSystemInfo CreateDirectorySymbolicLink(this IFileSystem fileSystem, string path, string pathToTarget) =>
        fileSystem.Directory.CreateSymbolicLink(path, pathToTarget);
    public static IEnumerable<string> EnumerateFileSystemEntries(this IFileSystem fileSystem, string path) =>
        fileSystem.Directory.EnumerateFileSystemEntries(path);
    public static IEnumerable<string> EnumerateFileSystemEntries(this IFileSystem fileSystem, string path, string searchPattern) =>
        fileSystem.Directory.EnumerateFileSystemEntries(path, searchPattern);
    public static IEnumerable<string> EnumerateFileSystemEntries(this IFileSystem fileSystem, string path, string searchPattern, EnumerationOptions enumerationOptions) =>
        fileSystem.Directory.EnumerateFileSystemEntries(path, searchPattern, enumerationOptions);
    public static IEnumerable<string> EnumerateFileSystemEntries(this IFileSystem fileSystem, string path, string searchPattern, SearchOption searchOption) =>
        fileSystem.Directory.EnumerateFileSystemEntries(path, searchPattern, searchOption);
    public static DirectoryInfo? GetParentDirectory(this IFileSystem fileSystem, string path) =>
        fileSystem.Directory.GetParent(path);
    public static void SetDirectoryCreationTime(this IFileSystem fileSystem, string path, DateTime creationTime) =>
        fileSystem.Directory.SetCreationTime(path, creationTime);
    public static void SetDirectoryCreationTimeUtc(this IFileSystem fileSystem, string path, DateTime creationTimeUtc) =>
        fileSystem.Directory.SetCreationTimeUtc(path, creationTimeUtc);
    public static void SetDirectoryLastWriteTime(this IFileSystem fileSystem, string path, DateTime lastWriteTime) =>
        fileSystem.Directory.SetLastWriteTime(path, lastWriteTime);
    public static void SetDirectoryLastWriteTimeUtc(this IFileSystem fileSystem, string path, DateTime lastWriteTimeUtc) =>
        fileSystem.Directory.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
    public static void SetDirectoryLastAccessTime(this IFileSystem fileSystem, string path, DateTime lastAccessTime) =>
        fileSystem.Directory.SetLastAccessTime(path, lastAccessTime);
    public static void SetDirectoryLastAccessTimeUtc(this IFileSystem fileSystem, string path, DateTime lastAccessTimeUtc) =>
        fileSystem.Directory.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
    public static DateTime GetDirectoryLastAccessTime(this IFileSystem fileSystem, string path) =>
        fileSystem.Directory.GetLastAccessTime(path);
    public static DateTime GetDirectoryLastAccessTimeUtc(this IFileSystem fileSystem, string path) =>
        fileSystem.Directory.GetLastAccessTimeUtc(path);
    public static string[] GetDirectories(this IFileSystem fileSystem, string path) =>
        fileSystem.Directory.GetDirectories(path);
    public static string[] GetDirectories(this IFileSystem fileSystem, string path, string searchPattern) =>
        fileSystem.Directory.GetDirectories(path, searchPattern);
    public static string[] GetDirectories(this IFileSystem fileSystem, string path, string searchPattern, EnumerationOptions enumerationOptions) =>
        fileSystem.Directory.GetDirectories(path, searchPattern, enumerationOptions);
    public static string[] GetDirectories(this IFileSystem fileSystem, string path, string searchPattern, SearchOption searchOption) =>
        fileSystem.Directory.GetDirectories(path, searchPattern, searchOption);
    public static string[] GetFileSystemEntries(this IFileSystem fileSystem, string path) =>
        fileSystem.Directory.GetFileSystemEntries(path);
    public static string[] GetFileSystemEntries(this IFileSystem fileSystem, string path, string searchPattern) =>
        fileSystem.Directory.GetFileSystemEntries(path, searchPattern);
    public static string[] GetFileSystemEntries(this IFileSystem fileSystem, string path, string searchPattern, EnumerationOptions enumerationOptions) =>
        fileSystem.Directory.GetFileSystemEntries(path, searchPattern, enumerationOptions);
    public static string[] GetFileSystemEntries(this IFileSystem fileSystem, string path, string searchPattern, SearchOption searchOption) =>
        fileSystem.Directory.GetFileSystemEntries(path, searchPattern, searchOption);
    public static string GetDirectoryRoot(this IFileSystem fileSystem, string path) =>
        fileSystem.Directory.GetDirectoryRoot(path);
    public static string GetCurrentDirectory(this IFileSystem fileSystem) =>
        fileSystem.Directory.GetCurrentDirectory();
    public static void MoveDirectory(this IFileSystem fileSystem, string sourceDirName, string destDirName) =>
        fileSystem.Directory.Move(sourceDirName, destDirName);
    public static string[] GetLogicalDrives(this IFileSystem fileSystem) =>
        fileSystem.Directory.GetLogicalDrives();
    public static FileSystemInfo? ResolveDirectoryLinkTarget(this IFileSystem fileSystem, string linkPath, bool returnFinalTarget) =>
        fileSystem.Directory.ResolveLinkTarget(linkPath, returnFinalTarget);
}