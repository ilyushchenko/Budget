using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCFS
{
    class Point
    {
        int m_x;
        int m_y;

        public int X
        {
            get { return m_x; }
        }
        public int Y
        {
            get { return m_y; }
        }
        public Point(int X, int Y)
        {
            m_x = X;
            m_y = Y;
        }

        public void Offset(int dx, int dy)
        {
            m_x += dx;
            m_y += dy;
        }
    }
}
