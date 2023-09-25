using System.Collections.Generic;
using System.ComponentModel.Design;

namespace CLI2DE;

public class ArgumentParser
{
    private Dictionary<string, int> ArgMap = new Dictionary<string, int>();

    public ArgumentParser() {
        ArgMap.Add("new", 1);
    }
    
    // analyses the input commands
    public int ParseArgs(string[] inputs) {
        if (Program.IsHelp(inputs[0])) { Console.WriteLine("Print Help!"); return 0; }
        // acts depending on the command
        if (inputs[0] == "--version" || inputs[0] == "-v") { Console.WriteLine("Project Assistant v0.1"); return 0; }
        int cmdID; // null command by default
        try { cmdID = ArgMap[inputs[0]]; }
        catch(KeyNotFoundException) { Console.WriteLine("This is not a valid command\ntype 'help' to get more information."); return 1; }

        switch(cmdID) {
            default: break;
            case 1 : Console.WriteLine("Do you want to create something?"); break;
        }
        return 0;
    }

    public string Call() {
        return "ok!";
    }
}
