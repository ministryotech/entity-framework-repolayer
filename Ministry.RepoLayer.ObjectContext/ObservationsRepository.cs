//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Linq;
using Ministry.RepoLayer.ObjContext.Abstract;

namespace Ministry.RepoLayer.ObjContext.Repositories
{
	/// <summary>
	/// Provides access to the Observations from the data source.
	/// </summary>
	public partial class ObservationsRepository : RepositoryBase<IEdmxContextWrapper, Observation, Response, System.Guid>, IObservationsRepository
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationsRepository"/> class.
        /// </summary>
        /// <param name="contextWrapper">The context wrapper.</param>
        public ObservationsRepository(IEdmxContextWrapper contextWrapper)
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
        protected override IQueryable<Observation> QuerySet
        {
            get { return EntitySet.OfType<Observation>(); }
        }

        /// <summary>
        /// Gets the Observation by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Observation</returns>
        public override Observation ById(System.Guid id)
        {
            var query = QuerySet.FirstOrDefault(x => x.Id == id);
            return query;
        }
	}
}
