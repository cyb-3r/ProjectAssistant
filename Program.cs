using System.Runtime.InteropServices;

namespace CLI2DE {
    class Program {
        static ArgumentParser parser = new ArgumentParser();
        static string[] Help = { "-?", "-h", "-help", "help" };
        public static bool IsHelp(string arg) {
            foreach (string str in Help) if (arg == str) return true;
            return false;
        }

        static int Main(string[] args) {
            // parser.ParseArgs(args); // reads entered arguments
            Helper h = new Helper(
                "This is a dummy description to test the Helper object.",
                "proja new project [options]",
                new List<Options>()
            );
            h.Opt.Add(new Options(new string[] {"-t", "--test"}, new string[] {""}, "this is a test description of the option."));
            Console.WriteLine(h);
            return 0;
        }
    }
}