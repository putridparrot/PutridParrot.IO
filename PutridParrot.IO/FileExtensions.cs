namespace PutridParrot.IO;

public static class FileExtensions
{
    public static string ReadChars(this File file, string fileName, int count)
    {
        using var stream = file.OpenRead(fileName);
        using var reader = new StreamReader(stream);
        var buffer = new char[count];
        var l = reader.ReadBlock(buffer, 0, count);
        return new string(buffer, 0, l);
    }

    public static async Task<string> ReadCharsAsync(this File file, string fileName, int count)
    {
        await using var stream = file.OpenRead(fileName);
        using var reader = new StreamReader(stream);
        var buffer = new char[count];
        var l = await reader.ReadBlockAsync(buffer, 0, count);
        return new string(buffer, 0, l);
    }
}
