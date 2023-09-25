namespace CLI2DE;

public class Helper
{
    private struct options {
        private string[] flags;
        private string[] types;
        private string description;

        public override string ToString()
        {
            string flaglist = ""; for (int i = 0; i < flags.Length; i++) { flaglist += (i < flags.Length-1) ? $"{flags[i]}, " : $"{flags[i]}"; }
            string typelist = ""; for (int i = 0; i < flags.Length; i++) { typelist += (i < types.Length-1) ? $"{types[i]}, " : $"{types[i]}"; }
            return $"\v{flaglist} {typelist} {description}";
        }
    }

    private string author;
    private string description;
    private string usage;
    private string opt;
}
