using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schv3.Models
{
    public class Schedule
    {
        [Key][Required] public int Id { get; set; }
        [Required] public string date { get; set; }
        public int Id_1Class { get; set; }
        public int Id_2Class { get; set; }
        public int Id_3Class { get; set; }
        public int Id_4Class { get; set; }
        public int Id_5Class { get; set; }
        public int Id_6Class { get; set; }
        public int Id_7Class { get; set; }
        public int Id_8Class { get; set; }
        [Required] public int week { get; set; }
        [Required] public int Group_id { get; set; }
    }
}
