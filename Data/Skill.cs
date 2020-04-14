using System;using System.ComponentModel.DataAnnotations;using System.Runtime.Serialization;namespace josef.Data{    public class Skill    {        public int Id { get; set; }        public string Title { get; set; }        public SkillCategory Category { get; set; }        public SkillType Type { get; set; }    }    public enum SkillType    {        [Display(Name = "None")]        NONE = 0,        [Display(Name = "Programming language")]        PROGRAMMING_LANGUAGE = 1,        [Display(Name = "Database Management System")]        DATABASE_MANAGEMENT_SYSTEM = 2,
        [Display(Name = "Operating System")]        OS = 3,
        [Display(Name = "User Interface Framework")]        UI_FRAMEWORK = 4,
        [Display(Name = "Platform")]        PLATFORM = 5,
        [Display(Name = "Markup language")]        MARKUP_LANGUAGE = 6,
        [Display(Name = "Web framework")]        WEB_FRAMEWORK = 7,        [Display(Name = "Integrated Development Environment")]        IDE = 8,
        [Display(Name = "Database Management")]        DATABASE_MANAGEMENT = 9,        [Display(Name = "Content Management System")]        CMS = 10,        [Display(Name = "Distributed version control")]        VERSION_CONTROL = 11,
        [Display(Name = "Mobile app framework")]        MOBILE_APP_FRAMEWORK = 12,        [Display(Name = "Graphics editor")]        GRAPHICS_EDITOR = 13,
        [Display(Name = "Command language")]        CMD_LANGUAGE = 14,
        [Display(Name = "Style language")]        STYLE_LANGUAGE = 15,
        [Display(Name = "GUI prototyping tool")]        GUI_PROTOTYPING_TOOL = 16,
        [Display(Name = "Testing Framework")]        TESTING_FRAMEWORK = 17,
        [Display(Name = "JavaScript library")]
        JS_LIBRARY = 18,
        [Display(Name = "Collaborative version control")]
        COLLAB_VERSION_CONTROL = 19,
        [Display(Name = "Project management software")]
        PROJECT_MANAGEMENT_SOFTWARE = 20,
        [Display(Name = "Cloud computing service")]
        CLOUD_COMPUTING = 21,
        [Display(Name = "OS-level virtualization")]
        OS_VIRTUALIZATION = 22,
        [Display(Name = "Testing Tool")]
        TESTING_TOOL = 23,

    }    public enum SkillCategory
    {
        [Display(Name = "Technical")]
        TECHNICAL = 1,        [Display(Name = "Conceptual")]        CONCEPTUAL = 2,        [Display(Name = "Interpersonal")]        INTERPERSONAL = 3,    }}