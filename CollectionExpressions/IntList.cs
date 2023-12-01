using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExpressions
{
    internal class IntList : IEnumerable<int>
    {
        private readonly List<int> _list = [];

        public void Add(int val) => _list.Add(val);

        public IEnumerator<int> GetEnumerator()
        {
            return ((IEnumerable<int>)_list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_list).GetEnumerator();
        }
    }
}
