using dotnetwithmongodb.BusinessEntities.Entities;
using dotnetwithmongodb.Contracts.DTO;
using AutoMapper;

public class MappingFile : Profile
{
    public MappingFile()
    {
        // Mapping variables
		CreateMap<Student , StudentDto>(); 
    }
}
