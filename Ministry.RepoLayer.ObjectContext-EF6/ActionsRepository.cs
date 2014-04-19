//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Objects;
using System.Linq;
using Ministry.RepoLayer.ObjContext.Abstract;

namespace Ministry.RepoLayer.ObjContext.Repositories
{
	/// <summary>
	/// Provides access to the Actions from the data source.
	/// </summary>
	public partial class ActionsRepository : RepositoryBase<IEdmxContextWrapper, Action, Response, System.Guid>, IActionsRepository
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsRepository"/> class.
        /// </summary>
        /// <param name="contextWrapper">The context wrapper.</param>
        public ActionsRepository(IEdmxContextWrapper contextWrapper)
            : base(contextWrapper)
        { }
		
        /// <summary>
        /// Gets the entity set.
        /// </summary>
        protected override IObjectSet<Response> EntitySet
        {
            get { return Context.Responses; }
        }
		
        /// <summary>
        /// Gets the set of data to query against.
        /// </summary>
        protected override IQueryable<Action> QuerySet
        {
            get { return EntitySet.OfType<Action>(); }
        }

        /// <summary>
        /// Gets the Action by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Action</returns>
        public override Action ById(System.Guid id)
        {
            var query = QuerySet.FirstOrDefault(x => x.Id == id);
            return query;
        }
	}
}
