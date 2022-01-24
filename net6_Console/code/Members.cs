// lilia.shamsutdinova
// GrazieTest
// net6_Console
// Members.cs
#nullable enable

namespace net6_Console.code;

// typo in Members
// public
/// <summary>
/// typo in Membrs
/// coment
/// </summary>
public class My_Mebers_Tst
{
    protected class Members_Impl_A
    {
    }
    protected internal class Members_Impl_B
    {
    }
    private class Members_Impl_C
    {
    }
    protected private class Members_Impl_D
    {
    }
}

internal interface IMembers_Impl
{
    void MethodComentWithTypo();
    MyTopRecrd MyTopRecrdHere { get; set; }
}

internal class Members_Impl : My_Mebers_Tst, IMembers_Impl
{
    public Members_Impl(MyTopRecrd myTopRecrdHere)
    {
        MyTopRecrdHere = myTopRecrdHere;
    }

    public void MethodComentWithTypo()
    {
        string namePropertyComentWithTypo 
            = NamePropertyComentWithTypo();

        string NamePropertyComentWithTypo()
        {
            return new MyTopRecrd("").NamePropertyComentWithTypo;
        }
    }

    public MyTopRecrd MyTopRecrdHere { get; set; }
}

public record MyTopRecrd(string NamePropertyComentWithTypo);

public struct MyStrucA
{
}


// AFAIR
#region region with typo in coment

[My("dsfsfdsf")]
internal interface IComentInterface
{

}

internal class MyAttribute : Attribute
{
    public MyAttribute(string dsfsfdsf)
    {
        throw new NotImplementedException();
    }
}

#endregion

