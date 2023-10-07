namespace PutridParrot.IO;

/// <summary>
/// Implementation of IFileSystem which essentially wraps
/// the core "file system" classes in a single class.
/// Unless implementations of IPath, IDirectory and/or IFile are supplied
/// this will default to using the default implementations.
/// </summary>
public class FileSystem : IFileSystem
{
    private static readonly Lazy<IFileSystem> Lazy = new(() => new FileSystem());

    public static IFileSystem Default => Lazy.Value;

    private readonly IPath _path;
    private readonly IDirectory _directory;
    private readonly IFile _file;

    public FileSystem(IPath? path = null, IDirectory? directory = null, IFile? file = null)
    {
        _path = path ?? IO.Path.Default;
        _directory = directory ?? IO.Directory.Default;
        _file = file ?? IO.File.Default;
    }

    IPath IFileSystem.Path => _path;
    IFile IFileSystem.File => _file;
    IDirectory IFileSystem.Directory => _directory;
}