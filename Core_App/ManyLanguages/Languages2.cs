namespace Core_App.ManyLanguages;

public class NamenBelomen
{
    /// <summary>
    /// Diese Methode wird verwendet, um den Namen zu erhalten
    /// .
    /// </summary>
    /// <param name="namen"></param>
    public NamenBelomen(string namen)
    {
        Namen = namen;
    }
    /*
    * Am österreichischen Deutsch zeigt sich die pluripotent
    */

    // AFAIR, this is a comment but FYI it is in German.
    // UPD: not sure if it is a comment, but it is in German.
    // update is needed here, FYI.
    // This is comments, but in German.
    // coment with typo here is SB. SB is an abbreviation for "sehr gut" in German.

    /// <summary>
    /// "test is over here (in the method.
    /// </summary>
    public void Test()
    {
        // het is genoeg, denk ik, om de naam te krijgen. We willen het doen omdat het interessant is.
    }

    public string einen_namen_bekommen()
    {
        return Namen;
    }

    public string Namen { get; set; }
}