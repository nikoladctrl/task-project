using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.DTOs.Projects;
using Core.DTOs.Tasks;
using Core.Entities;

namespace BusinessLayer.Mappings
{
    public class MappingProjects : Profile
    {
        public MappingProjects()
        {
            CreateMap<Project, ProjectDto>()
                .ForMember(dest => dest.ProjectStatus, opt => opt.MapFrom(src => Enum.GetName(src.ProjectStatus.GetType(), src.ProjectStatus)));
                
        }
    }
}