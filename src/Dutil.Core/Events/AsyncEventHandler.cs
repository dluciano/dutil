using System;
using System.Threading;
using System.Threading.Tasks;

namespace Dutil.Core.Events
{
    /// <summary>
    ///     A delegate to handle async events
    /// </summary>
    /// <typeparam name="T">The type of the data sent</typeparam>
    /// <param name="sender">The sender of the message</param>
    /// <param name="args">The data produced by the event</param>
    /// <param name="token">A cancellation token of the thread</param>
    /// <returns>A empty task</returns>
    public delegate Task AsyncEventHandler<in T>(object sender, T args,
        CancellationToken token = default(CancellationToken))
        where T : EventArgs;
}