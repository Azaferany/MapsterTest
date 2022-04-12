using System;
using System.Linq.Expressions;
using ConsoleApp2;

namespace ConsoleApp2
{
    public static partial class StudentDtoMapper
    {
        public static Student AdaptToStudent(this StudentDto p1)
        {
            return p1 == null ? null : new Student()
            {
                Type = p1.Type,
                Type2 = p1.Type2,
                Type3 = p1.Type3,
                Type5 = p1.Type4 == null ? default(DateTime) : DateTime.Parse(p1.Type4)
            };
        }
        public static Student AdaptTo(this StudentDto p2, Student p3)
        {
            if (p2 == null)
            {
                return null;
            }
            Student result = p3 ?? new Student();
            
            result.Type = p2.Type;
            result.Type2 = p2.Type2;
            result.Type3 = p2.Type3;
            result.Type5 = p2.Type4 == null ? default(DateTime) : DateTime.Parse(p2.Type4);
            return result;
            
        }
        public static Expression<Func<StudentDto, Student>> ProjectToStudent => p4 => new Student()
        {
            Type = p4.Type,
            Type2 = p4.Type2,
            Type3 = p4.Type3,
            Type5 = p4.Type4 == null ? default(DateTime) : DateTime.Parse(p4.Type4)
        };
    }
}