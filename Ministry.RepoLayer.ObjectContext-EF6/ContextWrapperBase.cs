//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq.Expressions;
using System.Runtime;

namespace Ministry.RepoLayer.ObjContext.Abstract
{
    /// <summary>
    /// Wraps the context object.
    /// </summary>
    public abstract class ContextWrapperBase<TContext> : IContextWrapper where TContext : ObjectContext
    {
        protected TContext Context { get; set; }

        /// <summary>
        /// Accepts all changes.
        /// </summary>
        public void AcceptAllChanges()
        {
            Context.AcceptAllChanges();
        }

        /// <summary>
        /// Adds the object.
        /// </summary>
        /// <param name="entitySetName">Name of the entity set.</param>
        /// <param name="entity">The entity.</param>
        public void AddObject(string entitySetName, object entity)
        {
            Context.AddObject(entitySetName, entity);
        }

        /// <summary>
        /// Applies the current values.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entitySetName">Name of the entity set.</param>
        /// <param name="currentEntity">The current entity.</param>
        /// <returns></returns>
        public TEntity ApplyCurrentValues<TEntity>(string entitySetName, TEntity currentEntity) where TEntity : class
        {
            return Context.ApplyCurrentValues(entitySetName, currentEntity);
        }

        /// <summary>
        /// Applies the original values.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entitySetName">Name of the entity set.</param>
        /// <param name="originalEntity">The original entity.</param>
        /// <returns></returns>
        public TEntity ApplyOriginalValues<TEntity>(string entitySetName, TEntity originalEntity) where TEntity : class
        {
            return Context.ApplyOriginalValues(entitySetName, originalEntity);
        }

        /// <summary>
        /// Attaches the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Attach(IEntityWithKey entity)
        {
            Context.Attach(entity);
        }

        /// <summary>
        /// Attaches to.
        /// </summary>
        /// <param name="entitySetName">Name of the entity set.</param>
        /// <param name="entity">The entity.</param>
        public void AttachTo(string entitySetName, object entity)
        {
            Context.AttachTo(entitySetName, entity);
        }

        /// <summary>
        /// Changes the state of the object.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entity">The entity.</param>
        /// <param name="state">The state.</param>
        public void ChangeObjectState<TEntity>(TEntity entity, EntityState state)
        {
            Context.ObjectStateManager.ChangeObjectState(entity, state);
        }

        /// <summary>
        /// Creates the database.
        /// </summary>
        public void CreateDatabase()
        {
            Context.CreateDatabase();
        }

        /// <summary>
        /// Creates the database script.
        /// </summary>
        /// <returns>The database as a script</returns>
        public string CreateDatabaseScript()
        {
            return Context.CreateDatabaseScript();
        }

        /// <summary>
        /// Creates the entity key.
        /// </summary>
        /// <param name="entitySetName">Name of the entity set.</param>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public EntityKey CreateEntityKey(string entitySetName, object entity)
        {
            return Context.CreateEntityKey(entitySetName, entity);
        }

        /// <summary>
        /// Creates the object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T CreateObject<T>() where T : class
        {
            return Context.CreateObject<T>();
        }

        /// <summary>
        /// Creates the object set.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <returns></returns>
        public ObjectSet<TEntity> CreateObjectSet<TEntity>() where TEntity : class
        {
            return Context.CreateObjectSet<TEntity>();
        }

        /// <summary>
        /// Creates the object set.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entitySetName">Name of the entity set.</param>
        /// <returns></returns>
        public ObjectSet<TEntity> CreateObjectSet<TEntity>(string entitySetName) where TEntity : class
        {
            return Context.CreateObjectSet<TEntity>(entitySetName);
        }

        /// <summary>
        /// Creates the proxy types.
        /// </summary>
        /// <param name="types">The types.</param>
        public void CreateProxyTypes(IEnumerable<Type> types)
        {
            Context.CreateProxyTypes(types);
        }

        /// <summary>
        /// Creates the query.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryString">The query string.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public ObjectQuery<T> CreateQuery<T>(string queryString, params ObjectParameter[] parameters)
        {
            return Context.CreateQuery<T>(queryString, parameters);
        }

        /// <summary>
        /// Databases the exists.
        /// </summary>
        /// <returns></returns>
        public bool DatabaseExists()
        {
            return Context.DatabaseExists();
        }

        /// <summary>
        /// Deletes the database.
        /// </summary>
        public void DeleteDatabase()
        {
            Context.DeleteDatabase();
        }

        /// <summary>
        /// Deletes the object.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void DeleteObject(object entity)
        {
            Context.DeleteObject(entity);
        }

        /// <summary>
        /// Detaches the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Detach(object entity)
        {
            Context.Detach(entity);
        }

        /// <summary>
        /// Detects the changes.
        /// </summary>
        public void DetectChanges()
        {
            Context.DetectChanges();
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources
        /// </summary>
        public void Dispose()
        {
            Context.Dispose();
        }

        /// <summary>
        /// Executes the function.
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public int ExecuteFunction(string functionName, params ObjectParameter[] parameters)
        {
            return Context.ExecuteFunction(functionName, parameters);
        }

        /// <summary>
        /// Executes the function.
        /// </summary>
        /// <typeparam name="TElement">The type of the element.</typeparam>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public ObjectResult<TElement> ExecuteFunction<TElement>(string functionName, params ObjectParameter[] parameters)
        {
            return Context.ExecuteFunction<TElement>(functionName, parameters);
        }

        /// <summary>
        /// Executes the function.
        /// </summary>
        /// <typeparam name="TElement">The type of the element.</typeparam>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="mergeOption">The merge option.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public ObjectResult<TElement> ExecuteFunction<TElement>(string functionName, MergeOption mergeOption, params ObjectParameter[] parameters)
        {
            return Context.ExecuteFunction<TElement>(functionName, mergeOption, parameters);
        }

        /// <summary>
        /// Executes the store command.
        /// </summary>
        /// <param name="commandText">The command text.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public int ExecuteStoreCommand(string commandText, params object[] parameters)
        {
            return Context.ExecuteStoreCommand(commandText, parameters);
        }

        /// <summary>
        /// Executes the store query.
        /// </summary>
        /// <typeparam name="TElement">The type of the element.</typeparam>
        /// <param name="commandText">The command text.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public ObjectResult<TElement> ExecuteStoreQuery<TElement>(string commandText, params object[] parameters)
        {
            return Context.ExecuteStoreQuery<TElement>(commandText, parameters);
        }

        /// <summary>
        /// Executes the store query.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="commandText">The command text.</param>
        /// <param name="entitySetName">Name of the entity set.</param>
        /// <param name="mergeOption">The merge option.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public ObjectResult<TEntity> ExecuteStoreQuery<TEntity>(string commandText, string entitySetName, MergeOption mergeOption, params object[] parameters)
        {
            return Context.ExecuteStoreQuery<TEntity>(commandText, entitySetName, mergeOption, parameters);
        }

        /// <summary>
        /// Gets the object by key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public object GetObjectByKey(EntityKey key)
        {
            return Context.GetObjectByKey(key);
        }

        /// <summary>
        /// Loads the property.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="navigationProperty">The navigation property.</param>
        public void LoadProperty(object entity, string navigationProperty)
        {
            Context.LoadProperty(entity, navigationProperty);
        }

        /// <summary>
        /// Loads the property.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entity">The entity.</param>
        /// <param name="selector">The selector.</param>
        public void LoadProperty<TEntity>(TEntity entity, Expression<Func<TEntity, object>> selector)
        {
            Context.LoadProperty<TEntity>(entity, selector);
        }

        /// <summary>
        /// Loads the property.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="navigationProperty">The navigation property.</param>
        /// <param name="mergeOption">The merge option.</param>
        public void LoadProperty(object entity, string navigationProperty, MergeOption mergeOption)
        {
            Context.LoadProperty(entity, navigationProperty, mergeOption);
        }

        /// <summary>
        /// Loads the property.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="entity">The entity.</param>
        /// <param name="selector">The selector.</param>
        /// <param name="mergeOption">The merge option.</param>
        public void LoadProperty<TEntity>(TEntity entity, Expression<Func<TEntity, object>> selector, MergeOption mergeOption)
        {
            Context.LoadProperty<TEntity>(entity, selector, mergeOption);
        }

        /// <summary>
        /// Refreshes the specified refresh mode.
        /// </summary>
        /// <param name="refreshMode">The refresh mode.</param>
        /// <param name="collection">The collection.</param>
        public void Refresh(RefreshMode refreshMode, IEnumerable collection)
        {
            Context.Refresh(refreshMode, collection);
        }

        /// <summary>
        /// Refreshes the specified refresh mode.
        /// </summary>
        /// <param name="refreshMode">The refresh mode.</param>
        /// <param name="entity">The entity.</param>
        public void Refresh(RefreshMode refreshMode, object entity)
        {
            Context.Refresh(refreshMode, entity);
        }

        /// <summary>
        /// Saves the changes.
        /// </summary>
        /// <returns></returns>
        [TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        /// <summary>
        /// Saves the changes.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        public int SaveChanges(SaveOptions options)
        {
            return Context.SaveChanges(options);
        }

        /// <summary>
        /// Translates the specified reader.
        /// </summary>
        /// <typeparam name="TElement">The type of the element.</typeparam>
        /// <param name="reader">The reader.</param>
        /// <returns></returns>
        public ObjectResult<TElement> Translate<TElement>(DbDataReader reader)
        {
            return Context.Translate<TElement>(reader);
        }

        /// <summary>
        /// Translates the specified reader.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity.</typeparam>
        /// <param name="reader">The reader.</param>
        /// <param name="entitySetName">Name of the entity set.</param>
        /// <param name="mergeOption">The merge option.</param>
        /// <returns></returns>
        public ObjectResult<TEntity> Translate<TEntity>(DbDataReader reader, string entitySetName, MergeOption mergeOption)
        {
            return Context.Translate<TEntity>(reader, entitySetName, mergeOption);
        }

        /// <summary>
        /// Tries the get object by key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public bool TryGetObjectByKey(EntityKey key, out object value)
        {
            return Context.TryGetObjectByKey(key, out value);
        }
    }
}
