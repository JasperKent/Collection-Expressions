using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExpressions
{
    [CollectionBuilder(typeof(ImmutableIntListBuilder), nameof(ImmutableIntListBuilder.Create))]
    internal class ImmutableIntList(params int[] values) : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return ((IEnumerable<int>)values).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return values.GetEnumerator();
        }
    }

    internal static class ImmutableIntListBuilder
    {
        public static ImmutableIntList Create(ReadOnlySpan<int> values)
        {
            return new ImmutableIntList(values.ToArray());
        }
    }
}
