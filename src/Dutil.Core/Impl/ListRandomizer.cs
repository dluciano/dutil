using System;
using System.Collections.Generic;
using System.Linq;
using Dutil.Core.Abstract;

namespace Dutil.Core.Impl
{
    public class ListRandomizer : IListRandomizer
    {
        public virtual IEnumerable<T> Generate<T>(IEnumerable<T> list)
        {
            list = list ?? Enumerable.Empty<T>();
            var rnd = new Random();
            return list.ToList().OrderBy(x => rnd.Next());
        }
    }
}