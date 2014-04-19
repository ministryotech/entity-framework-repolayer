using System;
using System.Linq;

namespace Ministry.RepoLayer.DbContext.Abstract
{
    /// <summary>
    /// Generic Read Only Repository
    /// </summary>
    /// <typeparam name="TEntity">The entity type to return</typeparam>
    /// <typeparam name="TEntityId">The type of the id.</typeparam>
    public interface IReadOnlyRepository<out TEntity, in TEntityId> : IDisposable where TEntity : class
    {
        /// <summary>
        /// Gets all of the items.
        /// </summary>
        /// <returns>All of the items.</returns>
        IQueryable<TEntity> All();

        /// <summary>
        /// Gets the item by id.
        /// </summary>
        /// <param name="id">The id of the item.</param>
        /// <returns>The item.</returns>
        TEntity ById(TEntityId id);
    }
}
