using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.IO;

namespace SCFS
{
    public delegate void RunWaitDelegete(string name, int wait, int run);

    class Collection
    {
        List<Process> m_processes = new List<Process>();

        public void Load(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    Process proc = new Process();
                    proc.Load(sr);
                    m_processes.Add(proc);
                }
            }
        }

        public void Draw(Graphics gr)
        {
            Pen pen = new Pen(Color.Black);
            Point startPoint = new Point(50,50);

            for (int i = 0; i < m_processes.Count; i++)
            {
                startPoint.Offset(0, 20);
                m_processes[i].Draw(gr, pen, startPoint);
            }
        }
        public void WaitRunTime(RunWaitDelegete deleg)
        {
            int wait = 0;
            int run = 0;
            foreach (Process proc in m_processes)
            {               
                run += proc.CpuBurst;
                deleg(proc.NameProcess, wait, run);
                wait += proc.CpuBurst;
            }
        }
    }
}
