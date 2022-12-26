using Microsoft.AspNetCore.Mvc;
using Schv3.Data;
using Schv3.Models;

namespace Schv3.Query
{
    [BindProperties]
    public class EditorQueries
    {
        //Here we input data models of entities 
        //And get nothing on output 
        //DB input methods for construnctor tab
        public static void CreateAny(object par)
        {
            using (var db = new AppDataDbContext { })
            {
                switch (par)
                { 
                    case Class c:
                        db.Classes.Add((Class)par);
                        db.SaveChanges();
                        break;
                    case Subject s:
                        db.Subjects.Add((Subject)par);
                        db.SaveChanges();
                        break;
                    case Teacher t:
                        db.Teachers.Add((Teacher)par);
                        db.SaveChanges();
                        break;
                    case ClassRoom cr:
                        db.Classrooms.Add((ClassRoom)par);
                        db.SaveChanges();
                        break;
                    case Group g:
                        db.Groups.Add((Group)par);
                        db.SaveChanges();
                        break;
                    default:
                        throw new Exception("idinahuy");
                };
            }
        }

    }
}
