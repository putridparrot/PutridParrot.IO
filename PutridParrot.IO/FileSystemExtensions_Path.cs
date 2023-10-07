using System.Diagnostics.CodeAnalysis;

namespace PutridParrot.IO;

public static partial class FileSystemExtensions
{
    public static char GetDirectorySeparatorChar(this IFileSystem fileSystem) =>
        fileSystem.Path.DirectorySeparatorChar;
    public static char GetAltDirectorySeparatorChar(this IFileSystem fileSystem) =>
        fileSystem.Path.AltDirectorySeparatorChar;
    public static char GetVolumeSeparatorChar(this IFileSystem fileSystem) =>
        fileSystem.Path.VolumeSeparatorChar;
    public static char GetPathSeparator(this IFileSystem fileSystem) =>
        fileSystem.Path.PathSeparator;
    public static string? ChangeExtension(this IFileSystem fileSystem, string? path, string? extension) =>
        fileSystem.Path.ChangeExtension(path, extension);
    public static string? GetDirectoryName(this IFileSystem fileSystem, string? path) =>
        fileSystem.Path.GetDirectoryName(path);
    public static ReadOnlySpan<char> GetDirectoryName(this IFileSystem fileSystem, ReadOnlySpan<char> path) =>
        fileSystem.Path.GetDirectoryName(path);
    public static string? GetExtension(this IFileSystem fileSystem, string? path) => 
        fileSystem.Path.GetExtension(path);
    public static ReadOnlySpan<char> GetExtension(this IFileSystem fileSystem, ReadOnlySpan<char> path) => 
        fileSystem.Path.GetExtension(path);
    public static string? GetFileName(this IFileSystem fileSystem, string? path) => 
        fileSystem.Path.GetFileName(path);
    public static ReadOnlySpan<char> GetFileName(this IFileSystem fileSystem, ReadOnlySpan<char> path) => 
        fileSystem.Path.GetFileName(path);
    public static string? GetFileNameWithoutExtension(this IFileSystem fileSystem, string? path) => 
        fileSystem.Path.GetFileNameWithoutExtension(path);
    public static ReadOnlySpan<char> GetFileNameWithoutExtension(this IFileSystem fileSystem, ReadOnlySpan<char> path) => 
        fileSystem.Path.GetFileNameWithoutExtension(path);
    public static string GetRandomFileName(this IFileSystem fileSystem) => 
        fileSystem.Path.GetRandomFileName();

    public static bool IsPathFullyQualified(this IFileSystem fileSystem, string path) =>
        fileSystem.Path.IsPathFullyQualified(path);

    public static bool IsPathFullyQualified(this IFileSystem fileSystem, ReadOnlySpan<char> path) =>
        fileSystem.Path.IsPathFullyQualified(path);
    public static bool HasExtension(this IFileSystem fileSystem, [NotNullWhen(true)] string? path) => 
        fileSystem.Path.HasExtension(path);
    public static bool HasExtension(this IFileSystem fileSystem, ReadOnlySpan<char> path) => 
        fileSystem.Path.HasExtension(path);
    public static string Combine(this IFileSystem fileSystem, string path1, string path2) => 
        fileSystem.Path.Combine(path1, path2);
    public static string Combine(this IFileSystem fileSystem, string path1, string path2, string path3) =>
        fileSystem.Path.Combine(path1, path2, path3);

    public static string Combine(this IFileSystem fileSystem, string path1, string path2, string path3, string path4) =>
        fileSystem.Path.Combine(path1, path2, path3, path4);
    public static string Combine(this IFileSystem fileSystem, params string[] paths) => 
        fileSystem.Path.Combine(paths);
    public static string Join(this IFileSystem fileSystem, ReadOnlySpan<char> path1, ReadOnlySpan<char> path2) => 
    fileSystem.Path.Join(path1, path2);

    public static string Join(this IFileSystem fileSystem, ReadOnlySpan<char> path1, ReadOnlySpan<char> path2,
        ReadOnlySpan<char> path3) =>
        fileSystem.Path.Join(path1, path2, path3);

    public static string Join(this IFileSystem fileSystem, ReadOnlySpan<char> path1, ReadOnlySpan<char> path2,
        ReadOnlySpan<char> path3, ReadOnlySpan<char> path4) =>
        fileSystem.Path.Join(path1, path2, path3, path4);

    public static string Join(this IFileSystem fileSystem, string? path1, string? path2) =>
        fileSystem.Path.Join(path1, path2);

    public static string Join(this IFileSystem fileSystem, string? path1, string? path2, string? path3) =>
        fileSystem.Path.Join(path1, path2, path3);

    public static string Join(this IFileSystem fileSystem, string? path1, string? path2, string? path3, string? path4) =>
        fileSystem.Path.Join(path1, path2, path3, path4);
    public static string Join(this IFileSystem fileSystem, params string?[] paths) => 
    fileSystem.Path.Join(paths);
    public static bool TryJoin(this IFileSystem fileSystem, ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten) =>
    fileSystem.Path.TryJoin(path1, path2, destination, out charsWritten);

    public static bool TryJoin(this IFileSystem fileSystem, ReadOnlySpan<char> path1, ReadOnlySpan<char> path2,
        ReadOnlySpan<char> path3, Span<char> destination,
        out int charsWritten) => fileSystem.Path.TryJoin(path1, path2, path3, destination, out charsWritten);

    public static string GetRelativePath(this IFileSystem fileSystem, string relativeTo, string path) =>
        fileSystem.Path.GetRelativePath(relativeTo, path);

    public static string TrimEndingDirectorySeparator(this IFileSystem fileSystem, string path) =>
        fileSystem.Path.TrimEndingDirectorySeparator(path);

    public static ReadOnlySpan<char>
        TrimEndingDirectorySeparator(this IFileSystem fileSystem, ReadOnlySpan<char> path) =>
        fileSystem.Path.TrimEndingDirectorySeparator(path);

    public static bool EndsInDirectorySeparator(this IFileSystem fileSystem, ReadOnlySpan<char> path) =>
        fileSystem.Path.EndsInDirectorySeparator(path);

    public static bool EndsInDirectorySeparator(this IFileSystem fileSystem, string path) =>
        fileSystem.Path.EndsInDirectorySeparator(path);

    public static char[] GetInvalidFileNameChars(this IFileSystem fileSystem) =>
        fileSystem.Path.GetInvalidFileNameChars();
    public static char[] GetInvalidPathChars(this IFileSystem fileSystem) =>
        fileSystem.Path.GetInvalidPathChars();
}