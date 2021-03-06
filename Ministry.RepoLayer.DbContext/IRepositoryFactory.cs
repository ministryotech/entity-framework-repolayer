//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace Ministry.RepoLayer.DbContext.Abstract
{
    /// <summary>
    /// Provides Repository Implementations
    /// </summary>
    public interface IRepositoryFactory : IDisposable
    {	

        ICategoriesRepository Categories { get; }		
        IProjectsRepository Projects { get; }		
        IResponsesRepository Responses { get; }		
        IActionsRepository Actions { get; }		
        IObservationsRepository Observations { get; }		
        IRisksRepository Risks { get; }		

        /// <summary>
        /// Saves the current state of the entities.
        /// </summary>
        void Save();

        /// <summary>
        /// Accepts all changes made to the underlying context.
        /// </summary>
        void AcceptAllChanges();

		/// <summary>
        /// Dumps and refreshes the underlying context, abandoning any outstanding changes.
        /// </summary>
        void Refresh();
    }
}
