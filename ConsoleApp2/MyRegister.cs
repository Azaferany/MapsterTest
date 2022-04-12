using Mapster;

namespace ConsoleApp2;

public class MyRegister : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Student, StudentDto>().TwoWays()
            .GenerateMapper(MapType.Map | MapType.MapToTarget | MapType.Projection).Map(dto =>dto.Type4,student => student.Type5);

    }
}