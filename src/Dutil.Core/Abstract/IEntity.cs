namespace Dutil.Core.Abstract
{
    /// <summary>
    ///     All entities classes with a simple int Id can extend this interface
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        ///     The primary key (Id) of the entity
        /// </summary>
        int Id { get; set; }
    }
}