using System;
using System.Runtime.Versioning;
using System.Text;

namespace PutridParrot.IO;

/// <summary>
/// Implements the System.IO.File class in a way that allows us
/// to easily replace with mocks, stubs etc.
/// </summary>
public class File : IFile
{
    private static readonly Lazy<IFile> Lazy = new(() => new File());

    public static IFile Default => Lazy.Value;

    private File()
    {
    }

    public StreamReader OpenText(string path) => 
        System.IO.File.OpenText(path);
    public StreamWriter CreateText(string path) =>
        System.IO.File.CreateText(path);
    public StreamWriter AppendText(string path) =>
        System.IO.File.AppendText(path);
    public void Copy(string sourceFileName, string destFileName) =>
        System.IO.File.Copy(sourceFileName, destFileName);
    public void Copy(string sourceFileName, string destFileName, bool overwrite) =>
        System.IO.File.Copy(sourceFileName, destFileName, overwrite);
    public FileStream Create(string path) =>
        System.IO.File.Create(path);
    public FileStream Create(string path, int bufferSize) =>
        System.IO.File.Create(path, bufferSize);
    public FileStream Create(string path, int bufferSize, FileOptions options) =>
        System.IO.File.Create(path, bufferSize, options);
    public void Delete(string path) =>
        System.IO.File.Delete(path);
    public bool Exists(string? path) =>
        System.IO.File.Exists(path);
    public FileStream Open(string path, FileMode mode) =>
        System.IO.File.Open(path, mode);
    public FileStream Open(string path, FileMode mode, FileAccess access) =>
        System.IO.File.Open(path, mode, access);
    public FileStream Open(string path, FileMode mode, FileAccess access, FileShare share) =>
        System.IO.File.Open(path, mode, access, share);
    public void SetCreationTime(string path, DateTime creationTime) =>
        System.IO.File.SetCreationTime(path, creationTime);
    public void SetCreationTimeUtc(string path, DateTime creationTimeUtc) =>
        System.IO.File.SetCreationTimeUtc(path, creationTimeUtc);
    public DateTime GetCreationTime(string path) =>
        System.IO.File.GetCreationTime(path);
    public DateTime GetCreationTimeUtc(string path) =>
        System.IO.File.GetCreationTimeUtc(path);
    public void SetLastAccessTime(string path, DateTime lastAccessTime) =>
        System.IO.File.SetLastAccessTime(path, lastAccessTime);
    public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc) =>
        System.IO.File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
    public DateTime GetLastAccessTime(string path) =>
        System.IO.File.GetLastAccessTime(path);
    public DateTime GetLastAccessTimeUtc(string path) =>
        System.IO.File.GetLastAccessTimeUtc(path);
    public void SetLastWriteTime(string path, DateTime lastWriteTime) =>
        System.IO.File.SetLastWriteTime(path, lastWriteTime);
    public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) =>
        System.IO.File.SetLastAccessTimeUtc(path, lastWriteTimeUtc);
    public DateTime GetLastWriteTime(string path) =>
        System.IO.File.GetLastWriteTime(path);
    public DateTime GetLastWriteTimeUtc(string path) =>
        System.IO.File.GetLastWriteTimeUtc(path);
    public FileAttributes GetAttributes(string path) =>
        System.IO.File.GetAttributes(path);
    public void SetAttributes(string path, FileAttributes fileAttributes) =>
        System.IO.File.SetAttributes(path, fileAttributes);
    public FileStream OpenRead(string path) =>
        System.IO.File.OpenRead(path);
    public FileStream OpenWrite(string path) =>
        System.IO.File.OpenWrite(path);
    public string ReadAllText(string path) =>
        System.IO.File.ReadAllText(path);
    public string ReadAllText(string path, Encoding encoding) =>
        System.IO.File.ReadAllText(path, encoding);
    public void WriteAllText(string path, string? contents) =>
        System.IO.File.WriteAllText(path, contents);
    public void WriteAllText(string path, string? contents, Encoding encoding) =>
        System.IO.File.WriteAllText(path, contents, encoding);
    public byte[] ReadAllBytes(string path) =>
        System.IO.File.ReadAllBytes(path);
    public void WriteAllBytes(string path, byte[] bytes) =>
        System.IO.File.WriteAllBytes(path, bytes);
    public string[] ReadAllLines(string path) =>
        System.IO.File.ReadAllLines(path);
    public string[] ReadAllLines(string path, Encoding encoding) =>
        System.IO.File.ReadAllLines(path, encoding);
    public IEnumerable<string> ReadLines(string path) =>
        System.IO.File.ReadLines(path);
    public IEnumerable<string> ReadLines(string path, Encoding encoding) =>
        System.IO.File.ReadLines(path, encoding);
    public void WriteAllLines(string path, string[] contents) =>
        System.IO.File.WriteAllLines(path, contents);
    public void WriteAllLines(string path, IEnumerable<string> contents) =>
        System.IO.File.WriteAllLines(path, contents);
    public void WriteAllLines(string path, string[] contents, Encoding encoding) =>
        System.IO.File.WriteAllLines(path, contents, encoding);
    public void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding) =>
        System.IO.File.WriteAllLines(path, contents, encoding);
    public void AppendAllText(string path, string? contents) =>
        System.IO.File.AppendAllText(path, contents);
    public void AppendAllText(string path, string? contents, Encoding encoding) =>
        System.IO.File.AppendAllText(path, contents, encoding);
    public void AppendAllLines(string path, IEnumerable<string> contents) =>
        System.IO.File.AppendAllLines(path, contents);
    public void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding) =>
        System.IO.File.AppendAllLines(path, contents, encoding);
    public void Replace(string sourceFileName, string destinationFileName, string? destinationBackupFileName) =>
        System.IO.File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
    public void Replace(string sourceFileName, string destinationFileName, string? destinationBackupFileName,
        bool ignoreMetadataErrors) =>
        System.IO.File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
    public void Move(string sourceFileName, string destFileName) =>
        System.IO.File.Move(sourceFileName, destFileName);
    public void Move(string sourceFileName, string destFileName, bool overwrite) =>
        System.IO.File.Move(sourceFileName, destFileName, overwrite);
    [SupportedOSPlatform("windows")]
    public void Encrypt(string path) =>
        System.IO.File.Encrypt(path);
    [SupportedOSPlatform("windows")]
    public void Decrypt(string path) =>
        System.IO.File.Decrypt(path);
    public Task<string> ReadAllTextAsync(string path,
        CancellationToken cancellationToken = default) =>
        System.IO.File.ReadAllTextAsync(path, cancellationToken);
    public Task<string> ReadAllTextAsync(string path, Encoding encoding, CancellationToken cancellationToken = default) =>
        System.IO.File.ReadAllTextAsync(path, encoding, cancellationToken);
    public Task WriteAllTextAsync(string path, string? contents,
        CancellationToken cancellationToken = default) =>
        System.IO.File.WriteAllTextAsync(path, contents, cancellationToken);
    public Task WriteAllTextAsync(string path, string? contents, Encoding encoding,
        CancellationToken cancellationToken = default) =>
        System.IO.File.WriteAllTextAsync(path, contents, encoding, cancellationToken);
    public Task<byte[]> ReadAllBytesAsync(string path,
        CancellationToken cancellationToken = default) =>
        System.IO.File.ReadAllBytesAsync(path, cancellationToken);
    public Task WriteAllBytesAsync(string path, byte[] bytes,
        CancellationToken cancellationToken = default) =>
        System.IO.File.WriteAllBytesAsync(path, bytes, cancellationToken);
    public Task<string[]> ReadAllLinesAsync(string path,
        CancellationToken cancellationToken = default) =>
        System.IO.File.ReadAllLinesAsync(path, cancellationToken);
    public Task<string[]> ReadAllLinesAsync(string path, Encoding encoding,
        CancellationToken cancellationToken = default) =>
        System.IO.File.ReadAllLinesAsync(path, encoding, cancellationToken);
    public Task WriteAllLinesAsync(string path, IEnumerable<string> contents,
        CancellationToken cancellationToken = default) =>
        System.IO.File.WriteAllLinesAsync(path, contents, cancellationToken);
    public Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding,
        CancellationToken cancellationToken = default) =>
        System.IO.File.WriteAllLinesAsync(path, contents, encoding, cancellationToken);
    public Task AppendAllTextAsync(string path, string? contents,
        CancellationToken cancellationToken = default) =>
        System.IO.File.AppendAllTextAsync(path, contents, cancellationToken);
    public Task AppendAllTextAsync(string path, string? contents, Encoding encoding,
        CancellationToken cancellationToken = default) =>
        System.IO.File.AppendAllTextAsync(path, contents, encoding, cancellationToken);
    public Task AppendAllLinesAsync(string path, IEnumerable<string> contents,
        CancellationToken cancellationToken = default) =>
        System.IO.File.AppendAllLinesAsync(path, contents, cancellationToken);
    public Task AppendAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding,
        CancellationToken cancellationToken = default) =>
        System.IO.File.AppendAllLinesAsync(path, contents, encoding, cancellationToken);
    public FileSystemInfo CreateSymbolicLink(string path, string pathToTarget) =>
        System.IO.File.CreateSymbolicLink(path, pathToTarget);
    public FileSystemInfo? ResolveLinkTarget(string linkPath, bool returnFinalTarget) =>
        System.IO.File.ResolveLinkTarget(linkPath, returnFinalTarget);
}