using System;
using System.Configuration;
using System.Data.EntityClient;
using System.Data.Objects;

namespace Ministry.RepoLayer.ObjContext
{
    /// <summary>
    /// Class to provide extensions to entities.
    /// </summary>
    public static class EntityHelper
    {
        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T CreateInstance<T>() where T : ObjectContext
        {
            // return the object
            return Activator.CreateInstance(typeof(T), GetConnectionString<T>()) as T;
        }

        /// <summary>
        /// Gets the connection string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string GetConnectionString<T>()
        {
            // get the connection string from config file
            var connectionString = ConfigurationManager.ConnectionStrings[typeof(T).Name].ConnectionString;

            // parse the connection string
            var csBuilder = new EntityConnectionStringBuilder(connectionString);

            // replace * by the full name of the containing assembly
            csBuilder.Metadata = csBuilder.Metadata.Replace(
                "res://*/",
                string.Format("res://{0}/", typeof(T).Assembly.FullName));

            // return the object
            return csBuilder.ToString();
        }
    }
}
