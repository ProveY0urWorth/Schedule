using Schv3.Data;
using Schv3.Models;

namespace Schv3.Query
{
    public class Requests
    {
        //get the single schedule for one day
        public static Schedule GetSchedule(string date, string groupcode)
        {
            using (var db = new AppDataDbContext())
            {
                var query = from Schedules in db.Schedules
                            where Schedules.date == date &&
                            Schedules.Group_id.GroupCode == groupcode
                            select Schedules;

                var sch = query.FirstOrDefault<Schedule>();
                if (sch is Schedule)
                    return sch;
                else return null;
            }
        }

        //====================================

        //gets lists of single field

        //FOR FRONTEND DROPLISTS

        //====================================

        //Get list of group names
        public static List<string> GetGroupCodeList()
        {
            using (var db = new AppDataDbContext())
            {
                var query = from Group in db.Groups
                            select Group.GroupCode;
                if (query.ToList<string>() is List<string>)
                    return query.ToList<string>();
                else return null;
            }
        }

        public static List<string> GetGroupCodeListInstSearch(string search)
        {
            using (var db = new AppDataDbContext())
            {
                var query = from Group in db.Groups
                            where Group.Institute == search
                            select Group.GroupCode;
                if (query.ToList<string>() is List<string>)
                    return query.ToList<string>();
                else return null;
            }
        }

        public static List<string> GetGroupCodeListEduSearch(int search)
        {
            using (var db = new AppDataDbContext())
            {
                var query = from Group in db.Groups
                            where Group.education == search
                            select Group.GroupCode;
                if (query.ToList<string>() is List<string>)
                    return query.ToList<string>();
                else return null;
            }
        }

        public static List<string> GetGroupCodeListFormSearch(int search)
        {
            using (var db = new AppDataDbContext())
            {
                var query = from Group in db.Groups
                            where Group.education == search
                            select Group.GroupCode;
                if (query.ToList<string>() is List<string>)
                    return query.ToList<string>();
                else return null;
            }
        }

        public static List<string> GetGroupCodeList(string search)
        {
            using (var db = new AppDataDbContext())
            {
                var query = from Group in db.Groups
                            select Group.GroupCode;
                if (query.ToList<string>() is List<string>)
                    return query.ToList<string>();
                else return null;
            }
        }


        public static List<Teacher> GetTeacherList()
        {
            using (var db = new AppDataDbContext())
            {
                var query = from Teacher in db.Teachers
                            select Teacher;
                if (query.ToList<Teacher>() is List<Teacher>)
                    return query.ToList<Teacher>();
                else return null;
            }
        }

        public static List<Class> GetClassList()
        {
            using (var db = new AppDataDbContext())
            {
                var query = from Class in db.Classes
                            select Class;
                if (query.ToList<Class>() is List<Class>)
                    return query.ToList<Class>();
                else return null;
            }
        }

        public static List<ClassRoom> GetClassRoomList()
        {
            using (var db = new AppDataDbContext())
            {
                var query = from ClassRoom in db.Classrooms
                            select ClassRoom;
                if (query.ToList<ClassRoom>() is List<ClassRoom>)
                    return query.ToList<ClassRoom>();
                else return null;
            }
        }

        public static List<Subject> GetSubjectList()
        {
            using (var db = new AppDataDbContext())
            {
                var query = from Subject in db.Subjects
                            select Subject;
                if (query.ToList<Subject>() is List<Subject>)
                    return query.ToList<Subject>();
                else return null;
            }
        }

        public static List<Class> GetClassListSchSearchOnSch(Schedule search)
        {
            using (var db = new AppDataDbContext())
            {
                var query = from Class in db.Classes
                            where Class.Id == search.Id_1Class ||
                            Class.Id == search.Id_2Class ||
                            Class.Id == search.Id_3Class ||
                            Class.Id == search.Id_4Class ||
                            Class.Id == search.Id_5Class ||
                            Class.Id == search.Id_6Class ||
                            Class.Id == search.Id_7Class ||
                            Class.Id == search.Id_8Class
                            select Class;
                if (query.ToList<Subject>() is List<Subject>)
                    return query.ToList<Subject>();
                else return null;
            }
        }



    }
}
