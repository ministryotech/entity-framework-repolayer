﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ministry.RepoLayer.DbContext.Abstract;
using Ministry.RepoLayer.DbContext.Repositories;

namespace Ministry.RepoLayer.DbContext
{
	/// <summary>
	/// Provides Repository Implementations
	/// </summary>
	public class EdmRepositoryFactory : RepositoryFactoryBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EdmRepositoryFactory"/> class.
		/// </summary>
		public EdmRepositoryFactory()
		{
		    Context = new EdmContextWrapper();
		    BindRepositories(Context);
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public override void Dispose()
		{
		    base.Dispose();
		    Context.Dispose();
		}
	}
}
