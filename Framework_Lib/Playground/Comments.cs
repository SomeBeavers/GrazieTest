using System;

namespace Graphics
{
    /// <summary>
    /// Class <c>Point</c> models a point in a two-dimensional plane.
    /// </summary>
    public class Point
    {
        /// <value>
        /// Property <c>X</c> represents the point's x-coordinate.
        /// </value>
        public int X { get; set; }

        /// <value>
        /// Property <c>Y</c> represents the point's y-coordinate.
        /// </value>
        public int Y { get; set; }

        /// <summary>
        /// This constructor initializes the new Point to (0,0).
        /// </summary>
        public Point() : this(0, 0) { }

        /// <summary>
        /// This constructor initializes the new Point to
        /// (<paramref name="xPosition"/>,<paramref name="yPosition"/>).
        /// </summary>
        /// <param><c>xPosition</c> is the new Point's x-coordinate.</param>
        /// <param><c>yPosition</c> is the new Point's y-coordinate.</param>
        public Point(int xPosition, int yPosition)
        {


            string csv = "a;b;c" + Environment.NewLine +
                         "Wert1;\"Wert2;" + Environment.NewLine + Environment.NewLine + "Rest\";" + Environment.NewLine +
                         "Wert1;Wert3;Wert4" + Environment.NewLine;

            X = xPosition;
            Y = yPosition;
        }

        /// <summary>
        /// This method changes the point's location to
        /// the given coordinates. <see cref="Translate"/>
        /// </summary>
        /// <param><c>xPosition</c> is the new x-coordinate.</param>
        /// <param><c>yPosition</c> is the new y-coordinate.</param>
        public void Move(int xPosition, int yPosition)
        {
            X = xPosition;
            Y = yPosition;
        }

        /// <summary>
        /// This method changes the point's location by
        /// the given x- and y-offsets.
        /// <example>For example:
        /// <code>
        /// Point p = new Point(3, 5);
        /// p.Translate(-1, 3);
        /// </code>
        /// results in <c>p</c>'s having the value (2, 8).
        /// <see cref="Move"/>
        /// </example>
        /// </summary>
        /// <param><c>dx</c> is the relative x-offset.</param>
        /// <param><c>dy</c> is the relative y-offset.</param>
        public void Translate(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        /// <summary>
        /// This method determines whether two Points have the same location.
        /// </summary>
        /// <param>
        /// <c>o</c> is the object to be compared to the current object.
        /// </param>
        /// <returns>
        /// True if the Points have the same location and they have
        /// the exact same type; otherwise, false.
        /// </returns>
        /// <seealso cref="operator=="/>
        /// <seealso cref="operator!="/>
        public override bool Equals(object o)
        {
            if (o == null) {
                return false;
            }
            if ((object)this == o) {
                return true;
            }
            if (GetType() == o.GetType()) {
                Point p = (Point)o;
                return (X == p.X) && (Y == p.Y);
            }
            return false;
        }

        /// <summary>
        /// This method returns a Point's hashcode.
        /// </summary>
        /// <returns>
        /// The int hashcode.
        /// </returns>
        public override int GetHashCode()
        {
            return X + (Y >> 4);    // a crude version
        }

        /// <summary>Report a point's location as a string.</summary>
        /// <returns>
        /// A string representing a point's location, in the form (x,y),
        /// without any leading, training, or embedded whitespace.
        /// </returns>
        public override string ToString() => $"({X},{Y})";

        /// <summary>
        /// This operator determines whether two Points have the same location.
        /// </summary>
        /// <param><c>p1</c> is the first Point to be compared.</param>
        /// <param><c>p2</c> is the second Point to be compared.</param>
        /// <returns>
        /// True if the Points have the same location and they have
        /// the exact same type; otherwise, false.
        /// </returns>
        /// <seealso cref="Equals"/>
        /// <seealso cref="operator!="/>
        public static bool operator ==(Point p1, Point p2)
        {
            if ((object)p1 == null || (object)p2 == null) {
                return false;
            }
            if (p1.GetType() == p2.GetType()) {
                return (p1.X == p2.X) && (p1.Y == p2.Y);
            }
            return false;
        }

        /// <summary>
        /// This operator determines whether two Points have the same location.
        /// </summary>
        /// <param><c>p1</c> is the first Point to be compared.</param>
        /// <param><c>p2</c> is the second Point to be compared.</param>
        /// <returns>
        /// True if the Points do not have the same location and the
        /// exact same type; otherwise, false.
        /// </returns>
        /// <seealso cref="Equals"/>
        /// <seealso cref="operator=="/>
        public static bool operator !=(Point p1, Point p2) => !(p1 == p2);
    }
}