using System;
using System.Collections.Generic;
using AutoMapper;
using BusinessLayer.Services.Projects;
using BusinessLayer.Services.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer
{
    public static class BusinessLayerExtensions
    {
        public static IServiceCollection AddBusinessLayer(this IServiceCollection services)
        {
            var profileList = new List<Profile>();

            // profileList.Add(new MappingOwners());
            // profileList.Add(new MappingDepartments());
            // profileList.Add(new MappingEmployees());
            // profileList.Add(new MappingBusinesses());

            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<IProjectService, ProjectService>();

            services.AddAutoMapper(c => c.AddProfiles(profileList), typeof(List<Profile>));
            
            
            return services;
        }
    }
}
