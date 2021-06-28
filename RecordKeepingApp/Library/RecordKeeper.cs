using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeepingApp.Library
{
    class RecordKeeper<T1, T2> : IRecordKeeper<T1, T2>
    {

        private readonly Dictionary<T1, T2> _datastore;

        public RecordKeeper()
        {
            _datastore = new Dictionary<T1, T2>();
        }
        
        
        public int Count
        {
            get => _datastore.Count;
        }

        public Dictionary<T1,T2> Datastore
        {
            get => _datastore;
            
            
        }

        public void AcceptInput(T1 key, T2 value)
        {
            _datastore.Add( key,  value);
        }

        public List<T2> FetchAll()
        {
            return new List<T2>(_datastore.Values);
        }

        public T2 FetchOne(T1 key)
        {
            return _datastore[key];
        }
    }
}
