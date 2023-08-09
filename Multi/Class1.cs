namespace Multi
{
    #if NET6_0
    public class Acount
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Acount(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }

    class MyClass
    {
        public void UseAcountTest(Acount acount1)
        {
            // This acount is different than acount1.
            var acount = new Acount(1, "");
        }

        public void Test()
        {
            var ints = new List<int>();
            
        }
    }

    // stdafx.razor will contain the pre-compiled type information
    // stdafx.vb will contain the pre-compiled type information

    #endif


}