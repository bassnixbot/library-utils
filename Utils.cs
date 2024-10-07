namespace UtilsLib;

public static class UtilsClient
{
    private static List<Error>? errorList = null;

    public static void InitialSetup()
    {
        string jsonData = File.ReadAllText("data/errorlist.json");
        var tempData = System.Text.Json.JsonSerializer.Deserialize<List<Error>>(jsonData);

        if (tempData != null)
            errorList = tempData;
    }

    public static List<Error> GetErrorList
    {
        get
        {
            if (errorList == null)
            {
                InitialSetup();
                return errorList;
            }
            return errorList;
        }
    }
}
