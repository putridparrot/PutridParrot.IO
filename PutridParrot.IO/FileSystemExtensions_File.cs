using System.Diagnostics.CodeAnalysis;
using System.Runtime.Versioning;
using System.Text;

namespace PutridParrot.IO;

public static partial class FileSystemExtensions
{
    public static StreamReader OpenText(this IFileSystem fileSystem, string path) =>
        fileSystem.File.OpenText(path);
    public static StreamWriter CreateText(this IFileSystem fileSystem, string path) =>
        fileSystem.File.CreateText(path);
    public static StreamWriter AppendText(this IFileSystem fileSystem, string path) => 
        fileSystem.File.AppendText(path);
    public static void Copy(this IFileSystem fileSystem, string sourceFileName, string destFileName) =>
        fileSystem.File.Copy(sourceFileName, destFileName);

    public static void Copy(this IFileSystem fileSystem, string sourceFileName, string destFileName, bool overwrite) =>
        fileSystem.File.Copy(sourceFileName, destFileName, overwrite);
    public static FileStream Create(this IFileSystem fileSystem, string path) => 
        fileSystem.File.Create(path);
    public static FileStream Create(this IFileSystem fileSystem, string path, int bufferSize) => 
        fileSystem.File.Create(path, bufferSize);

    public static FileStream Create(this IFileSystem fileSystem, string path, int bufferSize, FileOptions options) =>
        fileSystem.File.Create(path, bufferSize, options);
    public static void Delete(this IFileSystem fileSystem, string path) => 
        fileSystem.File.Delete(path);
    public static bool Exists(this IFileSystem fileSystem, [NotNullWhen(true)] string? path) => 
        fileSystem.File.Exists(path);
    public static FileStream Open(this IFileSystem fileSystem, string path, FileMode mode) =>
        fileSystem.File.Open(path, mode);

    public static FileStream Open(this IFileSystem fileSystem, string path, FileMode mode, FileAccess access) =>
        fileSystem.File.Open(path, mode, access);
    public static FileStream Open(this IFileSystem fileSystem, string path, FileMode mode, FileAccess access, FileShare share) =>
        fileSystem.File.Open(path, mode, access, share);
    public static void SetCreationTime(this IFileSystem fileSystem, string path, DateTime creationTime) =>
        fileSystem.File.SetCreationTime(path, creationTime);
    public static void SetCreationTimeUtc(this IFileSystem fileSystem, string path, DateTime creationTimeUtc) =>
        fileSystem.File.SetCreationTimeUtc(path, creationTimeUtc);
    public static DateTime GetCreationTime(this IFileSystem fileSystem, string path) =>
        fileSystem.File.GetCreationTime(path);
    public static DateTime GetCreationTimeUtc(this IFileSystem fileSystem, string path) =>
        fileSystem.File.GetCreationTimeUtc(path);

    public static void SetLastAccessTime(this IFileSystem fileSystem, string path, DateTime lastAccessTime) =>
        fileSystem.File.SetLastAccessTime(path, lastAccessTime);

    public static void SetLastAccessTimeUtc(this IFileSystem fileSystem, string path, DateTime lastAccessTimeUtc) =>
        fileSystem.File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
    public static DateTime GetLastAccessTime(this IFileSystem fileSystem, string path) =>
        fileSystem.File.GetLastAccessTime(path);

    public static DateTime GetLastAccessTimeUtc(this IFileSystem fileSystem, string path) =>
        fileSystem.File.GetLastAccessTimeUtc(path);
    public static void SetLastWriteTime(this IFileSystem fileSystem, string path, DateTime lastWriteTime) =>
        fileSystem.File.SetLastWriteTime(path, lastWriteTime);

    public static void SetLastWriteTimeUtc(this IFileSystem fileSystem, string path, DateTime lastWriteTimeUtc) =>
        fileSystem.File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
    public static DateTime GetLastWriteTime(this IFileSystem fileSystem, string path) => 
        fileSystem.File.GetLastWriteTime(path);
    public static DateTime GetLastWriteTimeUtc(this IFileSystem fileSystem, string path) => 
        fileSystem.File.GetLastWriteTimeUtc(path);
    public static FileAttributes GetAttributes(this IFileSystem fileSystem, string path) => 
        fileSystem.File.GetAttributes(path);

    public static void SetAttributes(this IFileSystem fileSystem, string path, FileAttributes fileAttributes) =>
        fileSystem.File.SetAttributes(path, fileAttributes);
    public static FileStream OpenRead(this IFileSystem fileSystem, string path) => 
        fileSystem.File.OpenRead(path);
    public static FileStream OpenWrite(this IFileSystem fileSystem, string path) => 
        fileSystem.File.OpenWrite(path);
    public static string ReadAllText(this IFileSystem fileSystem, string path) => 
        fileSystem.File.ReadAllText(path);
    public static string ReadAllText(this IFileSystem fileSystem, string path, Encoding encoding) => 
        fileSystem.File.ReadAllText(path, encoding);

    public static void WriteAllText(this IFileSystem fileSystem, string path, string? contents) =>
        fileSystem.File.WriteAllText(path, contents);
    public static void WriteAllText(this IFileSystem fileSystem, string path, string? contents, Encoding encoding) =>
        fileSystem.File.WriteAllText(path, contents, encoding);
    public static byte[] ReadAllBytes(this IFileSystem fileSystem, string path) => 
        fileSystem.File.ReadAllBytes(path);

    public static void WriteAllBytes(this IFileSystem fileSystem, string path, byte[] bytes) =>
        fileSystem.File.WriteAllBytes(path, bytes);
    public static string[] ReadAllLines(this IFileSystem fileSystem, string path) =>
        fileSystem.File.ReadAllLines(path);
    public static string[] ReadAllLines(this IFileSystem fileSystem, string path, Encoding encoding) =>
        fileSystem.File.ReadAllLines(path, encoding);
    public static IEnumerable<string> ReadLines(this IFileSystem fileSystem, string path) =>
        fileSystem.File.ReadAllLines(path);

    public static IEnumerable<string> ReadLines(this IFileSystem fileSystem, string path, Encoding encoding) =>
        fileSystem.File.ReadAllLines(path, encoding);

    public static void WriteAllLines(this IFileSystem fileSystem, string path, string[] contents) =>
        fileSystem.File.WriteAllLines(path, contents);

    public static void WriteAllLines(this IFileSystem fileSystem, string path, IEnumerable<string> contents) =>
        fileSystem.File.WriteAllLines(path, contents);

    public static void WriteAllLines(this IFileSystem fileSystem, string path, string[] contents, Encoding encoding) =>
        fileSystem.File.WriteAllLines(path, contents, encoding);

    public static void WriteAllLines(this IFileSystem fileSystem, string path, IEnumerable<string> contents,
        Encoding encoding) =>
        fileSystem.File.WriteAllLines(path, contents, encoding);
    public static void AppendAllText(this IFileSystem fileSystem, string path, string? contents) =>
        fileSystem.File.AppendAllText(path, contents);

    public static void AppendAllText(this IFileSystem fileSystem, string path, string? contents, Encoding encoding) =>
        fileSystem.File.AppendAllText(path, contents, encoding);

    public static void AppendAllLines(this IFileSystem fileSystem, string path, IEnumerable<string> contents) =>
        fileSystem.File.AppendAllLines(path, contents);

    public static void AppendAllLines(this IFileSystem fileSystem, string path, IEnumerable<string> contents,
        Encoding encoding) =>
        fileSystem.File.AppendAllLines(path, contents, encoding);

    public static void Replace(this IFileSystem fileSystem, string sourceFileName, string destinationFileName,
        string? destinationBackupFileName) =>
        fileSystem.File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);

    public static void Replace(this IFileSystem fileSystem, string sourceFileName, string destinationFileName, string? destinationBackupFileName,
        bool ignoreMetadataErrors) =>
        fileSystem.File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);

    public static void Move(this IFileSystem fileSystem, string sourceFileName, string destFileName) =>
        fileSystem.File.Move(sourceFileName, destFileName);

    public static void Move(this IFileSystem fileSystem, string sourceFileName, string destFileName, bool overwrite) =>
        fileSystem.File.Move(sourceFileName, destFileName, overwrite);

    [SupportedOSPlatform("windows")]
    public static void Encrypt(this IFileSystem fileSystem, string path) => 
        fileSystem.File.Encrypt(path);

    [SupportedOSPlatform("windows")]
    public static void Decrypt(this IFileSystem fileSystem, string path) => 
        fileSystem.File.Decrypt(path);

    public static Task<string> ReadAllTextAsync(this IFileSystem fileSystem, string path,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        fileSystem.File.ReadAllTextAsync(path, cancellationToken);
    public static Task<string> ReadAllTextAsync(this IFileSystem fileSystem, string path, Encoding encoding,
        CancellationToken cancellationToken = default(CancellationToken)) => 
        fileSystem.File.ReadAllTextAsync(path, encoding, cancellationToken);

    public static Task WriteAllTextAsync(this IFileSystem fileSystem, string path, string? contents,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        fileSystem.File.WriteAllTextAsync(path, contents, cancellationToken);

    public static Task WriteAllTextAsync(this IFileSystem fileSystem, string path, string? contents, Encoding encoding,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        fileSystem.File.WriteAllTextAsync(path, contents, encoding, cancellationToken);

    public static Task<byte[]> ReadAllBytesAsync(this IFileSystem fileSystem, string path,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        fileSystem.File.ReadAllBytesAsync(path, cancellationToken);

    public static Task WriteAllBytesAsync(this IFileSystem fileSystem, string path, byte[] bytes,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        fileSystem.File.WriteAllBytesAsync(path, bytes, cancellationToken);

    public static Task<string[]> ReadAllLinesAsync(this IFileSystem fileSystem, string path, CancellationToken cancellationToken = default(CancellationToken)) =>
        fileSystem.File.ReadAllLinesAsync(path, cancellationToken);

    public static Task<string[]> ReadAllLinesAsync(this IFileSystem fileSystem, string path, Encoding encoding,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        fileSystem.File.ReadAllLinesAsync(path, encoding, cancellationToken);

    public static Task WriteAllLinesAsync(this IFileSystem fileSystem, string path, IEnumerable<string> contents,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        fileSystem.File.WriteAllLinesAsync(path, contents, cancellationToken);

    public static Task WriteAllLinesAsync(this IFileSystem fileSystem, string path, IEnumerable<string> contents,
        Encoding encoding,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        fileSystem.File.WriteAllLinesAsync(path, contents, encoding, cancellationToken);

    public static Task AppendAllTextAsync(this IFileSystem fileSystem, string path, string? contents,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        fileSystem.File.AppendAllTextAsync(path, contents, cancellationToken);

    public static Task AppendAllTextAsync(this IFileSystem fileSystem, string path, string? contents, Encoding encoding,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        fileSystem.File.AppendAllTextAsync(path, contents, encoding, cancellationToken);

    public static Task AppendAllLinesAsync(this IFileSystem fileSystem, string path, IEnumerable<string> contents,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        fileSystem.File.AppendAllLinesAsync(path, contents, cancellationToken);

    public static Task AppendAllLinesAsync(this IFileSystem fileSystem, string path, IEnumerable<string> contents,
        Encoding encoding,
        CancellationToken cancellationToken = default(CancellationToken)) =>
        fileSystem.File.AppendAllLinesAsync(path, contents, encoding, cancellationToken);

    public static FileSystemInfo CreateFileSymbolicLink(this IFileSystem fileSystem, string path, string pathToTarget) =>
        fileSystem.File.CreateSymbolicLink(path, pathToTarget);
    public static FileSystemInfo? ResolveFileLinkTarget(this IFileSystem fileSystem, string linkPath, bool returnFinalTarget) =>
        fileSystem.File.ResolveLinkTarget(linkPath, returnFinalTarget);


}