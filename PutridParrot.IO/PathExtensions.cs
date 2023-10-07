namespace PutridParrot.IO;

public static class PathExtensions
{
    /// <summary>
    /// Using the Path to get invalid filename characters, converts the supplied file name
    /// to a valid filename replacing characters with the supplied replacementChar
    /// </summary>
    /// <param name="path"></param>
    /// <param name="fileName"></param>
    /// <param name="replacementChar"></param>
    /// <returns></returns>
    public static string ToValidFileName(this IPath path, string fileName, char replacementChar = '_') =>
        path.GetInvalidFileNameChars().Aggregate(fileName, (s, c) => s.Replace(c, replacementChar));

    /// <summary>
    /// Check if the supplied file name is valid for the current OS
    /// </summary>
    /// <param name="path"></param>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public static bool IsValidFileName(this IPath path, string fileName)
    {
        var invalidChars = path.GetInvalidFileNameChars();
        return !fileName.Any(c => invalidChars.Contains(c));
    }

    /// <summary>
    /// Using the Path to get invalid path characters, converts the supplied path name
    /// to a valid path name replacing characters with the supplied replacementChar
    /// </summary>
    /// <param name="path"></param>
    /// <param name="pathName"></param>
    /// <param name="replacementChar"></param>
    /// <returns></returns>
    public static string ToValidPathName(this IPath path, string pathName, char replacementChar = '_') =>
        path.GetInvalidPathChars().Aggregate(pathName, (s, c) => s.Replace(c, replacementChar));

    /// <summary>
    /// Check if the supplied path is valid for the current OS
    /// </summary>
    /// <param name="path"></param>
    /// <param name="pathName"></param>
    /// <returns></returns>
    public static bool IsValidPathName(this IPath path, string pathName)
    {
        var invalidChars = path.GetInvalidPathChars();
        return !pathName.Any(c => invalidChars.Contains(c));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    /// <param name="paths"></param>
    /// <returns></returns>
    public static string Combine(this IPath path, IEnumerable<string> paths)
    {
        var validPaths = paths.Where(p => !string.IsNullOrEmpty(p));
        return validPaths.Aggregate("", path.Combine);
    }
}