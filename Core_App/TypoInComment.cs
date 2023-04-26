using System.ComponentModel;

namespace Core_App;

public class TypoInComment
{
    public void Test()
    {
        // I'm bit weak today.
    }

    public void Test2()
    {
        // These method
        // are not used
        // anywhere in
        // the code. aftr

        // These method is not used anywhere in the code.

        // Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`, then press Enter. You can now see whitespace characters in your code.

    }
    // These function depend on another function so they should called aftr it.
    public void Test3()
    {
        LocalFunction(1);

        // These function depend on another function, so they should call after it.
        void LocalFunction(int i)
        {

        }
    }

    public class Test1
    {
        public static void Info([Localizable(true)] string message) { }
        public static void Debug([Localizable(false)] string message) { }

        public static void TestMethod()
        {
            Info("something wrnog");
            Debug("something wrnog");
        }
    }

}