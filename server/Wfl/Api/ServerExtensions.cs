using HotChocolate.AspNetCore;
using HotChocolate.Types.Pagination;
using Wfl.Api.Descriptors;
using Wfl.Domain;

namespace Wfl.Api
{
    public static class ServerExtensions
    {
        public static void AddApi(this WebApplicationBuilder builder)
        {
            builder.Services
                .AddHttpContextAccessor()
                .AddScoped<Query>()
                .AddScoped<Mutation>()
                .AddGraphQLServer()
                .ModifyOptions(x =>
                {
                    x.DefaultBindingBehavior = BindingBehavior.Explicit;
                    x.SortFieldsByName = true;
                    x.ValidatePipelineOrder = true;
                })
                .ModifyRequestOptions(x =>
                {
                    x.IncludeExceptionDetails = builder.Environment.IsDevelopment();
                    x.ExecutionTimeout = TimeSpan.FromSeconds(60);
                })
                .RegisterService<ISampleDomainService>(ServiceKind.Synchronized)
                .AddQueryType<QueryType>()
                .AddMutationType<MutationType>()
                .SetPagingOptions(new PagingOptions
                {
                    IncludeTotalCount = true,
                    DefaultPageSize = 20,
                    MaxPageSize = 20,
                    InferConnectionNameFromField = true
                })
                .AddSorting()
                .AddFiltering()
                .AddProjections()
                .AddGlobalObjectIdentification(false)
                .InitializeOnStartup();
        }

        public static void UseApi(this WebApplication app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints => endpoints
                .MapGraphQL()
                .WithOptions(new GraphQLServerOptions
                {
                    Tool =
                    {
                        Enable = true
                    }
                }));
        }
    }
}
