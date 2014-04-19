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
	/// Provides access to the Projects from the data source.
	/// </summary>
	public partial class ProjectsRepository : RepositoryBase<IEdmxContextWrapper, Project, Project, System.Guid>, IProjectsRepository
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsRepository"/> class.
        /// </summary>
        /// <param name="contextWrapper">The context wrapper.</param>
        public ProjectsRepository(IEdmxContextWrapper contextWrapper)
            : base(contextWrapper)
        { }
		
        /// <summary>
        /// Gets the entity set.
        /// </summary>
        protected override IObjectSet<Project> EntitySet
        {
            get { return Context.Projects; }
        }
		
        /// <summary>
        /// Gets the set of data to query against.
        /// </summary>
        protected override IQueryable<Project> QuerySet
        {
            get { return EntitySet; }
        }

        /// <summary>
        /// Gets the Project by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Project</returns>
        public override Project ById(System.Guid id)
        {
            var query = QuerySet.FirstOrDefault(x => x.Id == id);
            return query;
        }
	}
}
