using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStruct
{
    public interface IDataProvider
    {
        string GetData();
    }

    public interface IDataProcessor
    {
        void ProcessData(IDataProvider provider);
    }
}
