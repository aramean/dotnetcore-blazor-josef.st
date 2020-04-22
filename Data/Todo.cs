using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace josef.Data
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TodoCategory Category { get; set; }
        public TodoType Type { get; set; }
    }

    public enum TodoType
    {
        [Display(Name = "None")]
        NONE = 0,
    }

    public enum TodoCategory
    {
        [Display(Name = "Health")]
        HEALTH = 1,
        [Display(Name = "School")]
        SCHOOL = 2,
        [Display(Name = "Work")]
        WORK = 3,
    }
}
