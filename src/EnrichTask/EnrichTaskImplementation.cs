using System;
using System.Threading.Tasks;
using EnrichTask.Interfaces;
using EnrichTask.ViewModels;

namespace EnrichTask
{
    public class EnrichTaskImplementation
    {
        private readonly IExternalApiClient _externalApiClient;

        public EnrichTaskImplementation(IExternalApiClient externalApiClient)
        {
            _externalApiClient = externalApiClient;
        }

        /// <summary>
        /// Method enrich input model by description of phone number
        /// </summary>
        /// <param name="inputViewModel"></param>
        /// <returns>Returns model enriched by description of phone number</returns>
        public Task<OutputViewModel> ExecuteAsync(InputViewModel inputViewModel)
        {
            /// The method must be optimized as much as possible, work very fast and without fails.
            /// Use _externalApiClient to get list of unique phone numbers with it descriptions.
            /// If you need you can extend EnrichTaskImplementation class constructor
            /// by any .NET Core framework interfaces to resolve this task.

            throw new NotImplementedException();
        }
    }
}