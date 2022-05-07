using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.DTOs.Tasks;
using Core.Entities;

namespace BusinessLayer.Mappings
{
    public class MappingTasks : Profile
    {
        public MappingTasks()
        {
            CreateMap<CreateTaskDto, MyTask>();
            
            CreateMap<UpdateTaskDto, MyTask>();
            
            CreateMap<MyTask, MyTaskDto>()
                .ForMember(dest => dest.TaskStatus, opt => opt.MapFrom(src => Enum.GetName(src.TaskStatus.GetType(), src.TaskStatus)));
            
            CreateMap<MyTask, int>().ConvertUsing(src => src.Id);
        }
    }
}