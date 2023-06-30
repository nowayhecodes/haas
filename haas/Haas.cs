using System;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;

using Haas.Utils;

static void Main(String[] args)
{
    if (args.Length > 1)
    {
        Console.WriteLine("Usage: haas [script]");
        System.Environment.Exit(64);
    }
    else if (args.Length == 1)
    {
        runFile(args[0]);
    }
    else
    {
        runPrompt();
    }
}

static void runFile(String path)
{
    byte[] bytes = File.ReadAllBytes(Path.GetFullPath(path));
    char[] chars = Encoding.Unicode.GetString(bytes).ToCharArray();
    run(new String(chars));
}

static void runPrompt()
{
    string? line = Console.ReadLine();
    byte[] bytes = Encoding.Unicode.GetBytes(line!);

    MemoryStream memoryStream = new MemoryStream(bytes);
    StreamReader reader = new StreamReader(memoryStream);

    for (; ; )
    {
        Console.WriteLine("Haas > ");
        string? code = reader.ReadLine();
        if (code == null)
        {
            break;
        }
        run(code);
    }
}

static void run(string source)
{
    Scan scan = new Scan(source);
    List<char> tokens = scan.ReadToEnd().ToList();

    foreach (var token in tokens)
    {
        Console.WriteLine(token);
    }
}

static void error(int line, string message)
{
    report(line, "", message);
}

static void report(int line, string where, string message)
{
    Console.Error.WriteLine($"[line {line} ] Error {where}: {message}");
    System.Environment.Exit(65);
}