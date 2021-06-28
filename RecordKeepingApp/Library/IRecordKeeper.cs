using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeepingApp.Library
{
    interface IRecordKeeper<T1, T2>
    {

        void AcceptInput(T1 key, T2 value);

        T2 FetchOne(T1 key);

        List<T2> FetchAll();

        int Count { get; }
    }
}
