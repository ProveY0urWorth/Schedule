using Microsoft.CodeAnalysis.Elfie.Extensions;
using Microsoft.EntityFrameworkCore;
using Schv3.Data;
using Schv3.Interfaces;
using Schv3.Models;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Schv3.Query
{
    public class FrontQuery
    {
        public static FrontDataModel GetClassForFront (string date, string groupcode)
        {
            using (var db = new AppDataDbContext())
            {
                var query = from Schedules in db.Schedules
                            where Schedules.date == date &&
                            Schedules.Group_id.GroupCode == groupcode
                            select Schedules;
                var query2 = from Classes in db.Classes
                           where 
                           Classes.Id == query.FirstOrDefault().Id_1Class.Id ||
                           Classes.Id == query.FirstOrDefault().Id_2Class.Id ||
                           Classes.Id == query.FirstOrDefault().Id_3Class.Id ||
                           Classes.Id == query.FirstOrDefault().Id_4Class.Id ||
                           Classes.Id == query.FirstOrDefault().Id_5Class.Id ||
                           Classes.Id == query.FirstOrDefault().Id_6Class.Id ||
                           Classes.Id == query.FirstOrDefault().Id_7Class.Id ||
                           Classes.Id == query.FirstOrDefault().Id_8Class.Id 
                           select Classes;
                var classesforday = query2.ToList();

                
                return OutVal;

            }
            
        }

        /*
        var sch = query.FirstOrDefault();

                var query3 = from ClassRooms in db.Classrooms
                             where ClassRooms.Id == query2.FirstOrDefault().Id_Classroom
                             select ClassRooms;
                string para = "N/A";
                if (query2.FirstOrDefault().Id == sch.Id_1Class.Id)
                { para = "8:30 - 10:00"; } 
                else if (query2.FirstOrDefault().Id == sch.Id_2Class.Id)
                { para = "10:10 - 11:40"; }
                else if (query2.FirstOrDefault().Id == sch.Id_3Class.Id)
                { para = "1:50 - 13:20"; }
                else if (query2.FirstOrDefault().Id == sch.Id_4Class.Id)
                { para = "14:00 - 15:30"; }
                else if (query2.FirstOrDefault().Id == sch.Id_5Class.Id)
                { para = "15:40 - 17:10";  para = "8:30 - 10:10"; }
                else if (query2.FirstOrDefault().Id == sch.Id_6Class.Id)
                { para = "17:20 - 18:50"; }
                else if (query2.FirstOrDefault().Id == sch.Id_7Class.Id)
                { para = "19:00 - 20:30"; }
                else if (query2.FirstOrDefault().Id == sch.Id_8Class.Id)
                { para = "20:40 - 22:10"; }


                // 1 лекция
                // 2 практика
                // 3 лз

                string TypPary;
                switch (query2.FirstOrDefault().ClassType)
                {
                    case 1: TypPary = "Л"; break;
                    case 2: TypPary = "ПЗ"; break;
                    case 3: TypPary = "ПЗ"; break;
                    default: TypPary = "ПЗ"; break;
                }

                 FrontDataModel OutVal = new FrontDataModel(
                        query2.FirstOrDefault().Id,
                        query2.FirstOrDefault().Id_Subject.Name,
                        query2.FirstOrDefault().Group_Code.GroupCode,
                        query2.FirstOrDefault().Id_Teacher.LName,
                        query3.FirstOrDefault().Name,
                        TypPary,
                        query.FirstOrDefault().date,
                        para
                    );
        */
    }
}
