using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace CLI2DE;

public struct Options {
    private string[] flags = {"(No flags)"};
    private string[] types = {""};
    private string description = "No description";
    
    #region constructors
        public Options() {}
        public Options(string[] f, string[] t, string d) {
            flags = f;
            types = t;
            description = d;
        }
    #endregion
    
    public override string ToString()
    {
        string flaglist = ""; 
        string typelist = "";
        for (int i = 0; i < flags.Length; i++) { flaglist += (i < flags.Length-1) ? $"{flags[i]}, " : $"{flags[i]}"; }
        for (int i = 0; i < types.Length; i++) { typelist += (i < types.Length-1) ? $"{types[i]}, " : $"{types[i]}"; }
        return $"  {flaglist} {typelist} {description}";
    }
}

public class Helper
{
    private string description = "No description";
    private string usage = "Undefined";
    private List<Options> opt;

    public List<Options> Opt {
        get => opt;
        set => opt = value;
    }

    #region constructors
        public Helper(string d, string u, List<Options> o) {
            description = d;
            usage = u;
            opt = o;
            opt.Add(new Options(new string[] {"-?", "-h", "--help"}, new string[] {""}, "Display help informations."));
        }
    #endregion

    public override string ToString()
    {
        string optList = "";
        foreach(Options o in Opt) {optList += $"{o}\n";}
        return $"Description:\n  {description}\nUsage:\n  {usage}\nOption:\n{optList}";
    }
}
