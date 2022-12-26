using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schv3.Models
{
    public class FrontDataModel
    {
        public string SubjectName { get; set; }
        public string GroupName { get; set; }
        public string TeacherFIO { get; set; }
        public string ClassRoomName { get; set; }
        public string ClassType { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int ClassID { get; set; }


        public FrontDataModel(int classID, string subjectName, string groupName, string teacherFIO, string classRoomName, string classType, string date, string time)
        {
            ClassID = classID;
            SubjectName = subjectName;
            GroupName = groupName;
            TeacherFIO = teacherFIO;
            ClassRoomName = classRoomName;
            ClassType = classType;
            Date = date;
            Time = time;
        }
    }
}
