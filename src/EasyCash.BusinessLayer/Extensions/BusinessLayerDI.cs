using EasyCash.BusinessLayer.ValidationRules.AppUserValidationRules;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;

namespace EasyCash.BusinessLayer.Extensions;

public static class BusinessLayerDI
{
    public static IServiceCollection AddBusinessService(this IServiceCollection services)
    {
        services.AddFluentValidationAutoValidation();
        services.AddFluentValidationClientsideAdapters();
        services.AddValidatorsFromAssemblyContaining<AppUserRegisterValidator>();
        return services;
    }
}
