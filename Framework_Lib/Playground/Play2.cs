using System.Collections.Generic;

namespace Framework_Lib.Playground
{
    public class Play2
    {
        public class Point
        {
            /// <summary>This constructor initializes the new Point to
            /// (<paramref name="xPosition"/>,<paramref name="yPosition"/>).
            /// </summary>
            /// <param name="xPosition">the new Point's x-coordinate.</param>
            /// <param name="yPosition">the new Point's y-coordinate.</param>
            public Point(int xPosition, int yPosition)
            {
            }
        }
    }

    class MasterFileFormatCorruptException : System.Exception { }
class MasterFileLockedOpenException : System.Exception { }

    /// <summary>
    /// Class <c>Point</c> models a point in a two-dimensional plane.
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Method <c>Draw</c> renders the point.
        /// </summary>
        void Draw()
        {

        }

        /// <summary>
        /// This method changes the point's location by the given x- and y-offsets.
        /// <example>
        /// For example:
        /// <code>
        /// Point p = new Point(3,5);
        /// p.Translate(-1,3);
        /// </code>
        /// results in <c>p</c>'s having the value (2,8).
        /// </example>
        /// </summary>
        /// <exception cref="MasterFileFormatCorruptException">
        /// Thrown when the master file is corrupted.
        /// </exception>
        /// <exception cref="MasterFileLockedOpenException">
        /// Thrown when the master file is already open.
        /// </exception>
        public void Translate(int dx, int dy) { }
    }

    /// <include file="docs.xml" path='extradoc/class[@name="IntList"]/*' />
    public class IntList
    {

    }

    public class MyClass
    {
        public class Point
        {
            public class MyClass
            {
                /// <permission cref="System.Security.PermissionSet">
                /// Everyone can access this method.
                /// </permission>
                /// <remarks>
                /// Uses polar coordinates
                /// </remarks>
                public static void Test()
                {
                }
                /// <summary>
                /// Report a point's location as a string. <see cref="X"/>
                /// </summary>
                /// <returns>
                /// A string representing a point's location, in the form (x,y),
                /// without any leading, trailing, or embedded whitespace.
                /// </returns>
                /// <seealso cref="operator=="/>
                /// <seealso cref="operator!="/>
                public override string ToString() => $"({X},{Y})";

                public int X { get; set; }
                public int Y { get; set; }
            }

            /// <summary>A generic list class.</summary>
            /// <typeparam name="T">The type stored by the list.</typeparam>
            public class MyList<T>
            {
            }

            public class MyClass111
            {
                /// <summary>
                /// This method fetches data and returns a list of
                /// <typeparamref name="T"/>.
                /// </summary>
                /// <param name="string">query to execute</param>
                public List<T> FetchData<T>(string query)
                {
                }

                public class Point
                {
                    /// <value>Property <c>X</c> represents the point's x-coordinate.</value>
                    public int X { get; set; }
                }
            }

            /// <summary>
            /// This method changes the point's location to
            /// the given coordinates.
            /// </summary>
            /// <param name="xPosition">the new x-coordinate.</param>
            /// <param name="yPosition">the new y-coordinate.</param>
            public void Move(int xPosition, int yPosition)
            {

            }
        }

        /// <summary>
        ///
        /// <para>
        /// This program tests each method and operator, and
        /// is intended to be run after any non-trivial maintenance has
        /// been performed on the Point class.
        /// </para>
        /// Here is an example of a bulleted list:
        /// <list type="bullet">
        /// <item>
        /// <description>Item 1.</description>
        /// </item>
        /// <item>
        /// <description>Item 2.</description>
        /// </item>
        /// </list>
        /// </summary>
        public static void Main()
        {
        }
    }
}