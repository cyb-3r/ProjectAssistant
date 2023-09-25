namespace CLI2DE {
    class Program {
        static ArgumentParser parser = new ArgumentParser();
        static string[] Help = { "-?", "-h", "-help", "help" };
        public static bool IsHelp(string arg) {
            foreach (string str in Help) if (arg == str) return true;
            return false;
        }

        static int Main(string[] args) {
            parser.ParseArgs(args); // reads entered arguments
            return 0;
        }
    }
}