using System;

//namespace is the name of the application and another way of organizing code.
namespace FLDevelopers
{
    class Program
        // class is a container of all the methods of your application.  Keep methods in separate classes.  Each class can have unique
        // methods.  Class can organize your methods.
    {
        // static void is a method.  Having a method "Main" allows you to call the method name in future code
        static void Main(string[] args)
        // the brackets below are the code block for Main.  First method called in the application
        {

            //Console.WriteLine("This is the beginning of the FL Developers Tutorial - https://www.youtube.com/watch?v=FPeGkedZykA");
            ////The Write method is used to print one or more objects on a single line without
            //// inserting a new line character at the end. Similiar to a function in javascript
            //Console.ReadLine();

            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
