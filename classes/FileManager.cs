namespace CLI2DE;

public class FileManager
{
    private Dictionary<string, int> ObjMap = new Dictionary<string, int>();
    private string objectType = "class";    // what do you want to create
    private string techno = "C++";          // for which techno / language
    private string location = "./";         // and where?

    public FileManager() {
        ObjMap.Add("project", 0);
        ObjMap.Add("class", 1);
    }
}
