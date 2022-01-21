namespace QuickDoc
{
    public interface IComment
    {
        /// <summary>
        /// You may have some primary information about this class.
        /// </summary>
        void Comment5();
    }

    public class Comment : IComment
    {
        /// <summary>
        /// test
        /// </summary>
        public string Field;

        private string _name;

        /// <summary>The Name property represents the employee's name.</summary>
        /// <value>The Name property gets/sets the value of the string field, <see cref="_name"/>.</value>

        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }


        /// <summary> 
        /// <para>&lt;Encoding&gt;</para>
        /// <para></para>
        /// <para>
        /// The <paramref name="parameter"/> parameter takes a number.
        /// </para>
        /// <c>Comment1</c> is a method.
        /// <list type="bullet">
        /// <item>
        /// <description>Item 1.</description>
        /// </item>
        /// <item>
        /// <description>Item 2.</description>
        /// </item>
        /// </list>
        /// <list type="number">
        /// <item>
        /// <description>Item 1.</description>
        /// </item>
        /// <item>
        /// <description>Item 2.</description>
        /// </item>
        /// </list>
        /// <list type="table">
        /// <listheader>
        /// <term>term</term>
        /// <description>description</description>
        /// </listheader>
        /// <item>
        /// <term>term1</term>
        /// <description>Item 1.</description>
        /// </item>
        /// <item>
        /// <term>term2</term>
        /// <description>Item 2.</description>
        /// </item>
        /// </list>
        /// <see cref="System.Console.WriteLine(System.String)"/> for information about output statements
        /// <see cref="Comment.Field"/>
        /// <seealso cref="Comment.Field"/>
        /// <seealso href="https://github.com">GitHub</seealso>
        /// <see langword="true"/>
        /// </summary>
        /// <example>
        /// This sample shows how to call the <see cref="parameter"/> method.
        /// <code>
        /// class TestClass
        /// {
        ///     static int Main()
        ///     {
        ///         return GetZero();
        ///     }
        /// }
        /// </code>
        /// </example>
        /// <param name="parameter">My cool parameter</param>
        /// <returns>It returns <see cref="string"/> name.</returns>
        /// <remarks>
        /// <para>content</para>
        /// <para>content</para>
        /// This sample shows how to specify the <see cref="parameter"/> method as a cref attribute.
        /// </remarks>
        /// <exception cref="System.Exception">Thrown when 1</exception>
        /// <exception cref="System.NotImplementedException">Thrown when 2</exception>
        /// <permission cref="System.Security.PermissionSet">Everyone can access this method.</permission>
        /// <author>lilia.shamsutdinova</author>
        // a
        public string Comment1(int parameter = 1)
        {
            return null;
        }

        /// <include file='xml_include_tag1.xml' path='MyDocs/MyMembers[@name="test"]/*' />
        private void Comment3()
        {
        }
        /// <include file='xml_include_tag.xml' path='MyDocs/MyMembers[@name="test"]/*' />
        private void Comment4()
        {
        }

        private void Comment2()
        {
            Comment1(2);
            Comment3();
            Comment4();
            Comment5();
        }

        /// <inheritdoc/>
        public void Comment5()
        {
            new TestClass();
            new C<string>();
            mkArray<int>(1);
        }

        /// <summary>
        /// Creates a new array of arbitrary type <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The element type of the array</typeparam>
        public static T[] mkArray<T>(int n)
        {
            return new T[n];
        }
    }

    /// <summary cref="A">
    /// </summary>
    /// <typeparam name="T">my type parameter</typeparam>
    class C<T> { }

    /// <summary cref="C{T}">
    /// </summary>
    class A { }

    /// <summary>
    /// You may have some primary information about this interface.
    /// </summary>
    public interface ITestInterface
    {
    }

    ///<inheritdoc cref="ITestInterface"/>
    public class TestClass : ITestInterface
    {
    }
}