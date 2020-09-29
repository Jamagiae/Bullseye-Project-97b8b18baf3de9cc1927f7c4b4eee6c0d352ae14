using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;


namespace Bullseye
{
    class Program


    {
        static int _x, _y;

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out POINT lpPoint);

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            while (!Console.KeyAvailable)
            {
                ShowMousePosition();
            }
            Console.CursorVisible = true;

            
        }

        static void ShowMousePosition()
        {
            POINT point;
            if (GetCursorPos(out point) && point.X != _x && point.Y != _y)
            {
                Console.Clear();
                Console.WriteLine("({0},{1})", point.X, point.Y);
                _x = point.X;
                _y = point.Y;

                Random rnd = new Random();
                int xAxis = rnd.Next(0, 1920);
                int yAxis = rnd.Next(0, 1080);




                Console.WriteLine($"The xAxis Cordinate is: {xAxis} / The yAxis Cordinate is:  {yAxis}");
                //Console.WriteLine(yAxis);
                //Console.ReadLine();
            }


        }

     }
}
