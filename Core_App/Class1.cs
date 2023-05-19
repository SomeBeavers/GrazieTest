namespace Core_App;


public class Class1
{

    public class Class11
    {
        /// <summary>
        /// Initializes <paramref name="source"/>, so <see cref="Class1"/>'s
        /// properties are set to <paramref name="source"/>'s values.
        /// </summary>
        public void Test(string source)
        {
            Source = source;
        }

        public string Source { get; set; }
    }


    //Identifir

    /// <summary>
    ///     этот метод используется для
    /// </summary>
    /// <param name="ints">shamsutdinova Shamsutdinova</param>
    public void Test(int[] ints)
    {
        int[] i = ints[1..1];

        // Тест Комент с опечаткой 
        // shamsutdinova
        //Shamsutdinova

        //I'm
        //bit confused today

        /*
         *                    Am österreichischen
         * Deutsch zeigt sich die pluripotent
         */
    }
}