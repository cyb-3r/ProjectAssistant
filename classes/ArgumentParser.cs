using System.Collections.Generic;

namespace CLI2DE;

public class ArgumentParser
{
    private static Dictionary<string, int> ArgMap = new Dictionary<string, int>();
    private static string[] Help = {
        "-?", "-h", "-help", "help"
    };

    public ArgumentParser() {
        ArgMap.Add("new", 1);
    }

    public bool IsHelp(string arg) {
        foreach (string str in Help) if (arg == str) return true;
        return false;
    }
    
    // analyses the input commands
    public int ParseArgs(string[] inputs) {
        if (IsHelp(inputs[0])) Console.WriteLine("Print Help!");
        return 0;
    }

    public string Call() {
        return "ok!";
    }
}
