using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace josef.Data
{
    public class Skill
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TypeEnum Type { get; set; }
    }

    public enum TypeEnum
    {
        [Display(Name = "None")]
        NONE = 0,
        [Display(Name = "Programming language")]
        PROGRAMMING_LANGUAGE = 1,
        [Display(Name = "Database management system")]
        DATABASE_MANAGEMENT_SYSTEM = 2
    }
}
