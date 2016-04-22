using System.Drawing;
using System.IO;

namespace SCFS
{
    class Process
    {
        private string m_NameProcess;

        public string NameProcess
        {
            get { return m_NameProcess; }
        }

        private int m_CpuBurst;

        public int CpuBurst
        {
            get { return m_CpuBurst; }
        }

        public void Load(StreamReader sr)
        {
            m_NameProcess = sr.ReadLine();
            m_CpuBurst = int.Parse(sr.ReadLine());
        }

        public void Draw(Graphics gr, Pen pen, Point position)
        {
            int startX = position.X;
            position.Offset(m_CpuBurst, 0);
            int endX = position.X;
            int Y = position.Y;
            gr.DrawLine(pen, startX, Y, endX, Y);
        }
    }
}
