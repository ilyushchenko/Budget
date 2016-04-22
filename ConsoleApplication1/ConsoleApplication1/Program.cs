using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace ConsoleApplication1
{
    class Point
    {
        int x;
        int y;

        public void Load(StreamReader sr)
        {
            x = int.Parse(sr.ReadLine());
            y = int.Parse(sr.ReadLine());
        }
        //public override string ToString()
        //{
        //    return string.Format("x : {0} y : {1}", x, y);
        //}
        public string Print()
        {
            return string.Format("x : {0} y : {1}", x, y);
        }
    }

    class vert
    {
        Point ptstart = new Point();
        Point ptfin = new Point();

        public void Load(StreamReader sr)
        {
            ptstart.Load(sr);
            ptfin.Load(sr);
        }

        public string PrintCoord()
        {
            return string.Format("начальная т. : {0}\nконечная т. : {1}", ptstart.Print(), ptfin.Print());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}






//int i = 1;

//g:
//string pth = "file.txt";
//using (StreamWriter sw = new StreamWriter(Convert.ToString(i) + pth))
//{
//    sw.WriteLine("5");
//}
//System.Diagnostics.Process.Start(Convert.ToString(i) + pth);
//i++;
////if (i < 100)
//{
//    goto g;
//}