using Microsoft.VisualBasic;

namespace LearningApp.Models
{
    public class Departments
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string? short_name { get; set; }
        public string code { get; set; }
        public string? createBy { get; set; }
        public DateTime  createAt { get; set; }
        public string? updateBy { get; set; }
        public DateTime? updateAt { get; set; }
        public string? deleteBy { get; set; }
        public DateTime? deleteAt { get; set; }
        public bool isDEleted { get; set; }
    }
}
