using System.Diagnostics.CodeAnalysis;

namespace PutridParrot.IO;

/// <summary>
/// Implements the System.IO.Path class in a way that allows us
/// to easily replace with mocks, stubs etc.
/// </summary>
public class Path : IPath
{
    private static readonly Lazy<IPath> Lazy = new(() => new Path());

    public static IPath Default => Lazy.Value;

    private Path()
    {
    }

    public char DirectorySeparatorChar => System.IO.Path.DirectorySeparatorChar;
    public char AltDirectorySeparatorChar => System.IO.Path.AltDirectorySeparatorChar;
    public char VolumeSeparatorChar => System.IO.Path.VolumeSeparatorChar;
    public char PathSeparator => System.IO.Path.PathSeparator;
    public string? ChangeExtension(string? path, string? extension) => 
        System.IO.Path.ChangeExtension(path, extension);
    public string? GetDirectoryName(string? path) =>
        System.IO.Path.GetDirectoryName(path);
    public ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path) =>
        System.IO.Path.GetDirectoryName(path);
    public string? GetExtension(string? path) =>
        System.IO.Path.GetExtension(path);
    public ReadOnlySpan<char> GetExtension(ReadOnlySpan<char> path) =>
        System.IO.Path.GetExtension(path);
    public string? GetFileName(string? path) =>
        System.IO.Path.GetFileName(path);
    public ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path) =>
        System.IO.Path.GetFileName(path);
    public string? GetFileNameWithoutExtension(string? path) =>
        System.IO.Path.GetFileNameWithoutExtension(path);
    public ReadOnlySpan<char> GetFileNameWithoutExtension(ReadOnlySpan<char> path) =>
        System.IO.Path.GetFileNameWithoutExtension(path);
    public string GetRandomFileName() =>
        System.IO.Path.GetRandomFileName();
    public bool IsPathFullyQualified(string path) =>
        System.IO.Path.IsPathFullyQualified(path);
    public bool IsPathFullyQualified(ReadOnlySpan<char> path) =>
        System.IO.Path.IsPathFullyQualified(path);
    public bool HasExtension([NotNullWhen(true)] string? path) =>
        System.IO.Path.HasExtension(path);
    public bool HasExtension(ReadOnlySpan<char> path) =>
        System.IO.Path.HasExtension(path);
    public string Combine(string path1, string path2) =>
        System.IO.Path.Combine(path1, path2);
    public string Combine(string path1, string path2, string path3) =>
        System.IO.Path.Combine(path1, path2, path3);
    public string Combine(string path1, string path2, string path3, string path4) =>
        System.IO.Path.Combine(path1, path2, path3, path4);
    public string Combine(params string[] paths) =>
        System.IO.Path.Combine(paths);
    public string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2) => 
        System.IO.Path.Join(path1, path2);
    public string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3) =>
        System.IO.Path.Join(path1, path2, path3);
    public string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3,
        ReadOnlySpan<char> path4) =>
        System.IO.Path.Join(path1, path2, path3, path4);
    public string Join(string? path1, string? path2) =>
        System.IO.Path.Join(path1, path2);
    public string Join(string? path1, string? path2, string? path3) => 
        System.IO.Path.Join(path1, path2, path3);
    public string Join(string? path1, string? path2, string? path3, string? path4) => 
        System.IO.Path.Join(path1, path2, path3, path4);
    public string Join(params string?[] paths) => 
        System.IO.Path.Join(paths);
    public bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination,
        out int charsWritten) =>
        System.IO.Path.TryJoin(path1, path2, destination, out charsWritten);
    public bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, Span<char> destination, out int charsWritten) =>
        System.IO.Path.TryJoin(path1, path2, path3, destination, out charsWritten);
    public string GetRelativePath(string relativeTo, string path) =>
        System.IO.Path.GetRelativePath(relativeTo, path);
    public string TrimEndingDirectorySeparator(string path) =>
        System.IO.Path.TrimEndingDirectorySeparator(path);
    public ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path) =>
        System.IO.Path.TrimEndingDirectorySeparator(path);
    public bool EndsInDirectorySeparator(ReadOnlySpan<char> path) =>
        System.IO.Path.EndsInDirectorySeparator(path);
    public bool EndsInDirectorySeparator(string path) =>
        System.IO.Path.EndsInDirectorySeparator(path);
    public char[] GetInvalidFileNameChars() =>
        System.IO.Path.GetInvalidFileNameChars();
    public char[] GetInvalidPathChars() =>
        System.IO.Path.GetInvalidPathChars();
}