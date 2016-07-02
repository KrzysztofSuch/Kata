using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryAutoFac
{
    class TodayWriter : IDataWriter
    {
        private readonly IOutput _output;

        public TodayWriter(IOutput output)
        {
            _output = output;
        }

        public void WriteData()
        {
            _output.Write(DateTime.Today.ToShortDateString());
        }
    }
}
