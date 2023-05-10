namespace net6_Console;

public class Catala_Valencia
{
    /// <summary>
    ///     This is a c-or for creating instance of type <see cref="Catala_Valencia" />
    /// </summary>
    /// <param name="name">this is a name</param>
    /// <param name="age">age of catala</param>
    /// <code>
    ///     protected bool Equals(Catala_Valencia other)
    /// {
    /// return Name == other.Name &amp;&amp; Age == other.Age;
    /// }
    /// </code>
    public Catala_Valencia(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    /// <summary>
    /// Avis per tempestes arreu del país. Avis de tempesta.
    /// Seguretat alimentaria.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    protected bool Equals(Catala_Valencia other)
    {
        return Name == other.Name && Age == other.Age;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Catala_Valencia)obj);
    }

    public override int GetHashCode()
    {
        // Avis per tempestes arreu del país. Avis de tempesta.
        // Seguretat alimentaria. 
        return HashCode.Combine(Name, Age);
    }

    /// <summary>
    /// </summary>
    public void Test() { }
}