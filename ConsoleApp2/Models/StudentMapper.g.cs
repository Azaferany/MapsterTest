using System;
using System.Linq.Expressions;
using ConsoleApp2;

namespace ConsoleApp2
{
    public static partial class StudentMapper
    {
        public static StudentDto AdaptToDto(this Student p1)
        {
            return p1 == null ? null : new StudentDto()
            {
                Type = p1.Type,
                Type2 = p1.Type2,
                Type3 = p1.Type3,
                Type4 = p1.Type5.ToString()
            };
        }
        public static StudentDto AdaptTo(this Student p2, StudentDto p3)
        {
            if (p2 == null)
            {
                return null;
            }
            StudentDto result = p3 ?? new StudentDto();
            
            result.Type = p2.Type;
            result.Type2 = p2.Type2;
            result.Type3 = p2.Type3;
            result.Type4 = p2.Type5.ToString();
            return result;
            
        }
        public static Expression<Func<Student, StudentDto>> ProjectToDto => p4 => new StudentDto()
        {
            Type = p4.Type,
            Type2 = p4.Type2,
            Type3 = p4.Type3,
            Type4 = p4.Type5.ToString()
        };
    }
}