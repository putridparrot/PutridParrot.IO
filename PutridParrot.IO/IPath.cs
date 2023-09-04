using System.Diagnostics.CodeAnalysis;

namespace PutridParrot.IO;

/// <summary>
/// Interface representing the methods of the System.IO.Path class
/// </summary>
public interface IPath
{
    char DirectorySeparatorChar { get; }
    char AltDirectorySeparatorChar { get; }
    char VolumeSeparatorChar { get; }
    char PathSeparator { get; }
    string? ChangeExtension(string? path, string? extension);
    string? GetDirectoryName(string? path);
    ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path);
    string? GetExtension(string? path);
    ReadOnlySpan<char> GetExtension(ReadOnlySpan<char> path);
    string? GetFileName(string? path);
    ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path);
    string? GetFileNameWithoutExtension(string? path);
    ReadOnlySpan<char> GetFileNameWithoutExtension(ReadOnlySpan<char> path);
    string GetRandomFileName();
    bool IsPathFullyQualified(string path);
    bool IsPathFullyQualified(ReadOnlySpan<char> path);
    bool HasExtension([NotNullWhen(true)] string? path);
    bool HasExtension(ReadOnlySpan<char> path);
    string Combine(string path1, string path2);
    string Combine(string path1, string path2, string path3);
    string Combine(string path1, string path2, string path3, string path4);
    string Combine(params string[] paths);
    string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2);
    string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3);
    string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, ReadOnlySpan<char> path4);
    string Join(string? path1, string? path2);
    string Join(string? path1, string? path2, string? path3);
    string Join(string? path1, string? path2, string? path3, string? path4);
    string Join(params string?[] paths);
    bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten);
    bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, Span<char> destination,
        out int charsWritten);
    string GetRelativePath(string relativeTo, string path);
    string TrimEndingDirectorySeparator(string path);
    ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path);
    bool EndsInDirectorySeparator(ReadOnlySpan<char> path);
    bool EndsInDirectorySeparator(string path);
}