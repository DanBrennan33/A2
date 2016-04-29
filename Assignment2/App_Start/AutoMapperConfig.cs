using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// new...
using AutoMapper;

namespace Assignment2
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            // Add map creation statements here
            // Mapper.CreateMap< FROM , TO >();
            Mapper.CreateMap<Controllers.EmployeeAdd, Models.Employee>();
            Mapper.CreateMap<Models.Employee, Controllers.EmployeeBase>();
        }
    }
}