using System.Configuration;
using System.Data.EntityClient;

namespace Ministry.RepoLayer.DbContext
{
    /// <summary>
    /// Class to provide extensions to entities.
    /// </summary>
    public static class EntityHelper
    {
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
