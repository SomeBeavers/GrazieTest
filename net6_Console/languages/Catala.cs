namespace net6_Console;

public class Catala
{
    protected bool Equals(Catala other)
    {
        throw new NotImplementedException();
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Catala)obj);
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// This is metod to do dis so use it wiesely.
    /// </summary>
    public void Test()
    {
        // perquè Deu no va voler.
    }
}