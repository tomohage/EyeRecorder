using System;
using System.IO;
using TobiiEyexArrangeTool;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeRecorder
{
    class FileIO
    {
        private StreamWriter sw = null;
        public FileIO(string filePath, double monitorHeight, double monitorWidth)
        {
            sw = new StreamWriter(filePath);
            sw.WriteLine("Monitor Size");
            sw.WriteLine("Height,{0:F0},Width,{1:F0}", monitorHeight, monitorWidth);
            sw.WriteLine("");
            sw.WriteLine("Time, x, y, Trigger");
        }

        public void InputEyePositionData(string time, double x, double y, bool triggerOn)
        {
            if (triggerOn)
            {
                sw.WriteLine("{0:F0},{1:F1},{2:F1}, T", time, x, y);
            }
            else
            {
                sw.WriteLine("{0:F0},{1:F1},{2:F1}", time, x, y);
            }
        }

        public void Close()
        {
            sw.Close();
        }
    }
}
