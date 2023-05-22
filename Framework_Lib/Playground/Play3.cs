namespace Framework_Lib.Playground
{
    /// <summary>
    /// 'DateTimeStyles.NoCurrentDateDefault' Ich werde sein.
    /// </summary>
    public class Play3
    {
        // Sucht eine lokalisierte Zeichenfolge,
        // die "The flag &apos;DateTimeStyles.NoCurrentDateDefault&apos; is not supported." ähnelt.
        // Ich werde sein.
        public void Test(string num)
        {
            string s = "version %d.%d.%d.%d.%d";
        }

    }

    /// <summary>
    /// The 'DateTimeStyles.NoCurrentDateDefault' is a good enum. Though typo is not a problem.
    /// </summary>
    enum DateTimeStyles
    {
        NoCurrentDateDefault
    }
    // This is a good enum DateTimeStyles.NoCurrentDateDefault.
    // Though typo is not a problem 
    // so lets check it out.

    // Sucht eine lokalisierte Zeichenfolge,
    // die DateTimeStyles.NoCurrentDateDefault ähnelt.
    // Ich werde sein.
}