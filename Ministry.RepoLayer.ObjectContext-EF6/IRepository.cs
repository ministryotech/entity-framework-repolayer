namespace Ministry.RepoLayer.ObjContext.Abstract
{
    /// <summary>
    /// Generic Repository
    /// </summary>
    /// <typeparam name="TEntity">The entity type to return</typeparam>
    /// <typeparam name="TEntityId">The type of the id.</typeparam>
    public interface IRepository<TEntity, TEntityId> : IReadOnlyRepository<TEntity, TEntityId> where TEntity : class
    {
        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Add(TEntity entity);

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Edits the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Edit(TEntity entity);
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

