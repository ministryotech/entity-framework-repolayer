//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace Ministry.RepoLayer.ObjContext.Abstract
{
     /// <summary>
    /// Base Repository
    /// </summary>
    /// <typeparam name="TContext">The type of the context.</typeparam>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <typeparam name="TEntityBase">The type of the entity base.</typeparam>
    /// <typeparam name="TEntityId">The type of the entity id.</typeparam>
    public abstract class RepositoryBase<TContext, TEntity, TEntityBase, TEntityId> : IRepository<TEntity, TEntityId>
        where TEntityBase : class
        where TEntity : class, TEntityBase
        where TContext : IContextWrapper
    {
        /// <summary>
        /// When called from a child, initializes a new instance of the repository class.
        /// </summary>
        /// <param name="contextWrapper">The context wrapper.</param>
        protected RepositoryBase(TContext contextWrapper)
        {
            Context = contextWrapper;
        }

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        /// <value>
        /// The context.
        /// </value>
        protected TContext Context { get; set; }

        /// <summary>
        /// Gets the entity set.
        /// </summary>
        protected abstract IObjectSet<TEntityBase> EntitySet { get; }

        /// <summary>
        /// Gets the entity set.
        /// </summary>
        protected abstract IQueryable<TEntity> QuerySet { get; }

        /// <summary>
        /// Gets all the relationship types.
        /// </summary>
        /// <returns>Relationship Types</returns>
        public IQueryable<TEntity> All()
        {
            var query = QuerySet;
            return query;
        }

        /// <summary>
        /// Gets the relationship types by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Relationship Types</returns>
        public abstract TEntity ById(TEntityId id);

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Add(TEntity entity)
        {
            EntitySet.AddObject(entity);
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Delete(TEntity entity)
        {
            EntitySet.DeleteObject(entity);
        }

        /// <summary>
        /// Edits the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Edit(TEntity entity)
        {
            Context.ChangeObjectState(entity, EntityState.Modified);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public virtual void Dispose()
        {
            
        }
    }
}
