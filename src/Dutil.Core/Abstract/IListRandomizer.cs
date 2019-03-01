using System.Collections.Generic;

namespace Dutil.Core.Abstract
{
    public interface IListRandomizer
    {
        /// <summary>
        ///     Represent an abstraction to implement to order a list randomly
        /// </summary>
        /// <typeparam name="T">The type of the list</typeparam>
        /// <param name="list">The values of the list</param>
        /// <returns>The original list ordered randomly</returns>
        IEnumerable<T> Generate<T>(IEnumerable<T> list);
    }
}