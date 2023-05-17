// ReSharper disable once CheckNamespace
namespace FolkerKinzel.CsvTools
{
    public class Class1
    {
        /// <summary>
        /// Initializes in <paramref name="source"/> so <see cref="Class1"/>'s
        /// properties are set to <paramref name="source"/>'s values.
        /// </summary>
        public void Test(string source)
        {
            Source = source;
        }

        public string Source { get; set; }
    }

    public class Galego
    {
        // Vén xusto detrás miña.   

        /// <summary>
        /// Vén xusto detrás miña.   
        /// </summary>
        /// <param name="name">
        ///     Vén xusto detrás miña.   
        ///     Vén xusto detrás miña.   
        /// </param>
        public void Test(string name) { }

        //Sucht eine lokalisierte Zeichenfolge, die
        //ähnet.
        public static readonly a propertyNameProperty = a.RegisterAttached(
            "propertyName", typeof(propertyType), typeof(Galego), new PropertyMetadata(default(propertyType)));

        public static void SetpropertyName(DependencyObject element, propertyType value)
        {
            element.SetValue(propertyNameProperty, value);
        }

        public static propertyType GetpropertyName(DependencyObject element)
        {
            return (propertyType)element.GetValue(propertyNameProperty);
        }
        // This is a
        // coment.
    }

}