namespace PutridParrot.IO;

/// <summary>
/// Acts as a wrapper for the core "file system" classes and operations
/// </summary>
public interface IFileSystem
{
    IPath Path { get; }
    IFile File { get; }
    IDirectory Directory { get; }
}