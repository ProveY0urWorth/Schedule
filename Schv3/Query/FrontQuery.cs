using Microsoft.CodeAnalysis.Elfie.Extensions;
using Microsoft.EntityFrameworkCore;
using Schv3.Data;
using Schv3.Interfaces;
using Schv3.Models;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Schv3.Query
{
    public class FrontQuery
    {
        public static List<FrontDataModel> GetClassForFront (string date, string groupcode)
        {
            using (var db = new AppDataDbContext())
            {
                var query = from Schedules in db.Schedules
                            where Schedules.date == date &&
                            Schedules.Group_id == groupcode
                            select Schedules;
                var query2 = from Classes in db.Classes
                           where 
                           Classes.Id == query.FirstOrDefault().Id_1Class||
                           Classes.Id == query.FirstOrDefault().Id_2Class ||
                           Classes.Id == query.FirstOrDefault().Id_3Class ||
                           Classes.Id == query.FirstOrDefault().Id_4Class ||
                           Classes.Id == query.FirstOrDefault().Id_5Class ||
                           Classes.Id == query.FirstOrDefault().Id_6Class ||
                           Classes.Id == query.FirstOrDefault().Id_7Class ||
                           Classes.Id == query.FirstOrDefault().Id_8Class
                           select Classes;
                var classesforday = query2.ToList();
                int [] sch =
                {
                    query.FirstOrDefault().Id_1Class,
                    query.FirstOrDefault().Id_2Class,
                    query.FirstOrDefault().Id_3Class,
                    query.FirstOrDefault().Id_4Class,
                    query.FirstOrDefault().Id_5Class,
                    query.FirstOrDefault().Id_6Class,
                    query.FirstOrDefault().Id_7Class,
                    query.FirstOrDefault().Id
                };

                string para = "N/A";
                var help = sch.ElementAt(0);
                foreach(var lesson in classesforday)
                {
                    switch (lesson.Id)
                    {
                        case var value when value == sch[0]:
                            para = "8:30 - 10:00";
                            break;
                        case var value when value == sch[1]:
                            para = "10:10 - 11:40";
                            break;
                        case var value when value == sch[2]:
                            para = "1:50 - 13:20";
                            break;
                        case var value when value == sch[3]:
                            para = "14:00 - 15:30";
                            break;
                        case var value when value == sch[4]:
                            para = "15:40 - 17:10";
                            break;
                        case var value when value == sch[5]:
                            para = "17:20 - 18:50";
                            break;
                        case var value when value == sch[6]:
                            para = "19:00 - 20:30";
                            break;
                        case var value when value == sch[7]:
                            para = "20:40 - 22:10";
                            break;
                        default: break;
                    }
                }
                // 1 лекция
                // 2 практика
                // 3 лз
                string lessonType = "";
                foreach (var item in classesforday)
                {
                    switch (item.ClassType)
                    {
                            case 1: lessonType = "Л"; break;
                            case 2: lessonType = "ПЗ"; break;
                            case 3: lessonType = "ПЗ"; break;
                            default: lessonType = "ПЗ"; break;
                    }
                }
                List<FrontDataModel> ret = new List<FrontDataModel>();
                for(var i = 0; i < classesforday.Count; i++)
                {
                    var s = Requests.GetSubjectOnId(classesforday.ElementAt(i).Id_Subject);
                    var teacher = Requests.GetTeacherOnId(classesforday.ElementAt(i).Id_Teacher);
                    FrontDataModel st = new FrontDataModel(
                       classesforday.ElementAt(i).Id,
                       s.Name,
                       classesforday.ElementAt(i).Group_Code,
                       teacher.LName+" "+teacher.FName+" "+teacher.MName,
                       RoomName(classesforday.ElementAt(i)),
                       lessonType,
                       query.FirstOrDefault().date,
                       para
                   );
                    ret.Add( st );
                }
                return ret;
            }
        }

        public static string RoomName(Class el)
        {

            using (var db = new AppDataDbContext())
            {
                var query3 = from ClassRooms in db.Classrooms
                             where ClassRooms.Id == el.Id_Classroom
                             select ClassRooms.Name;

                return query3.FirstOrDefault();
            }
        }
    }
}
