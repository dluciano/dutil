namespace Dutil.Core.Abstract
{
    /// <summary>
    ///     Represents an abstraction for a finite state machine
    /// </summary>
    /// <typeparam name="TState">The tye of values stored in the state machine</typeparam>
    /// <typeparam name="TTransitions">The types representing each transition</typeparam>
    public interface IStateMachineProvider<TState, in TTransitions>
    {
        /// <summary>
        ///     Register a valid transition that change the state from an state to other
        /// </summary>
        /// <param name="from">The current state</param>
        /// <param name="to">The resulting state</param>
        /// <param name="transition">The name of the transition</param>
        /// <returns>Returns the same state machine to allow method chaining</returns>
        IStateMachineProvider<TState, TTransitions> AddTransition(TState from,
            TState to,
            TTransitions transition);

        /// <summary>
        ///     Invoke a transition that would give as a result a new state
        /// </summary>
        /// <param name="transitable">The transitable object</param>
        /// <param name="transition">The transition to apply</param>
        /// <returns>The transitable object with the new state</returns>
        ITransitable<TState> ChangeState(ITransitable<TState> transitable,
            TTransitions transition);
    }
}