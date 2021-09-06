using DL.Contract.Interface;
using DL.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace DL
{
    public static class ModuleInitializer
    {
        // ReSharper disable once InconsistentNaming
        public static IServiceCollection AddServicesForDL(this IServiceCollection services)
        {
            return services.AddTransient<IMarkdownDocumentRepository, MarkdownDocumentRepository>();
        }
    }
}