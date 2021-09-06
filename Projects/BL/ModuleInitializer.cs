using BL.Contract.Interface;
using BL.Manager;
using Microsoft.Extensions.DependencyInjection;

namespace BL
{
    public static class ModuleInitializer
    {
        // ReSharper disable once InconsistentNaming
        public static IServiceCollection AddServicesForBL(this IServiceCollection services)
        {
            return services.AddTransient<IMarkdownDocumentManager, MarkdownDocumentManager>();
        }
    }
}