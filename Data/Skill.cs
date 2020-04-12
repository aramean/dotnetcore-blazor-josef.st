using System;using System.ComponentModel.DataAnnotations;using System.Runtime.Serialization;namespace josef.Data{    public class Skill    {        public int Id { get; set; }        public string Title { get; set; }        public TypeEnum Type { get; set; }    }    public enum TypeEnum    {        [Display(Name = "None")]        NONE = 0,        [Display(Name = "Programming language")]        PROGRAMMING_LANGUAGE = 1,        [Display(Name = "Database Management System")]        DATABASE_MANAGEMENT_SYSTEM = 2,
        [Display(Name = "Operating System")]        OS = 3,
        [Display(Name = "User Interface Framework")]        UI_FRAMEWORK = 4,
        [Display(Name = "Platform")]        PLATFORM = 5,
        [Display(Name = "Markup language")]        MARKUP_LANGUAGE = 6,
        [Display(Name = "Web framework")]        WEB_FRAMEWORK = 7,        [Display(Name = "Integrated Development Environment")]        IDE = 8,
        [Display(Name = "Database Management")]        DATABASE_MANAGEMENT = 9,        [Display(Name = "Content Management System")]        CMS = 10,        [Display(Name = "Distributed version control")]        VERSION_CONTROL = 11,
        [Display(Name = "Mobile app framework")]        MOBILE_APP_FRAMEWORK = 12,    }}