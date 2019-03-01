namespace Dutil.Core.Abstract
{
    /// <summary>
    ///     Represent an abstraction to object that can change from an state to other using a transition
    /// </summary>
    /// <typeparam name="TState">The type containing the list of the state of the object</typeparam>
    public interface ITransitable<TState>
    {
        /// <summary>
        ///     The current state of the object
        /// </summary>
        TState CurrentState { get; set; }
    }
}