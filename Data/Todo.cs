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
        [Display(Name = "Travel")]
        TRAVEL = 1,
        [Display(Name = "Relationship")]
        RELATIONSHIPS = 2,
        [Display(Name = "Career")]
        CAREER = 3,
        [Display(Name = "Financial")]
        FINANCIAL = 4,
        [Display(Name = "Entertainment")]
        ENTERTAINMENT = 5,
        [Display(Name = "Adventure")]
        ADVENTURE = 6,
        [Display(Name = "Contribution")]
        CONTRIBUTION = 7,
        [Display(Name = "Creativity")]
        CREATIVITY = 8,
        [Display(Name = "Education")]
        EDUCATION  = 9,
        [Display(Name = "Health")]
        HEALTH = 10,
        [Display(Name = "Possession")]
        POSSESSION = 11,
    }
}
