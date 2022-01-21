#region header

// lilia.shamsutdinova
// GrazieTest
// net6_Console
// Comments.cs

#endregion

namespace net6_Console.code;

public class Comments
{
    #region one line coment with //

    // Simpel one lin comment

    #endregion
    #region multiline coment with //

    // Ok, let's use capitalisation as Grazie wants
    // but use multiline comment, expecting that second line will not produce an error.
    // Ha, you wish.

    #endregion
    #region one line coment with /**/

    /*Simpple one line coment*/

    #endregion
    #region multiline coment with /**/

    /*
     * Miltiline comment starts with capital, as Grazie expects,
     * but continues with lowe case one.
     */

    #endregion
    #region xml doc comment

    /// <summary>
    /// Coment should be recognised
    /// by Grazie.
    /// </summary>
    /// <param name="parameterAnotherInerClassWithTypo1">Coment should be recognised.</param>
    /// <param name="nameWithComent">Coment should be recognised.</param>
    /// <returns>Coment should be recognised.</returns>
    /// <see cref="AnotherInerClassWithTypo"/>
    /// <code>
    ///     public class AnotherInerClassWithTypo
    /// {
    /// }
    /// </code>
    /// <example>
    /// var locaInnerClass = new InnerClass();
    /// return InnerClassProperty ?? locaInnerClass;
    /// </example>
    /// <remarks>
    /// coment
    /// </remarks>
public InnerClass? GetNullableInnerClass(AnotherInerClassWithTypo parameterAnotherInerClassWithTypo1,
        string nameWithComent = null)
    {
        var locaInnerClass = new InnerClass();
        return InnerClassProperty ?? locaInnerClass;
    }

    public InnerClass InnerClassProperty { get; set; } = new();


    /// <summary>
    /// one line coment.
    /// </summary>
    public class InnerClass
    {
    }

    /// <summary>
    /// Witajcie towarzysze. Pamiętasz o zadaniach pokrycia testów.
    /// /// <see cref="AnotherInerClassWithTypo"/>
    /// <code>
    ///     public class AnotherInerClassWithTypo
    /// {
    /// }
    /// </code>
    /// <example>
    /// var locaInnerClass = new InnerClass();
    /// return InnerClassProperty ?? locaInnerClass;
    /// </example>
    /// </summary>
    public class AnotherInerClassWithTypo
    {
    }
    #endregion
}



