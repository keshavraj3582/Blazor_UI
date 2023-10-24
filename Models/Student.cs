using CsvHelper.Configuration.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorUI.Models
{
    public class Student
    {
        [Name("StudentId")]
        [Required(ErrorMessage = "Student ID is Required")]
        [RegularExpression(@"^STDN\d{5}$", ErrorMessage = "Student ID should start with 'STDN' then 5 digits.")]
        public string StudentId { get; set; }
        //  [CustomGenderValidation(ErrorMessage = "Gender should be 'M', 'F', or null.")]
        [DefaultValue(null)]
        public string? Gender { get; set; }
        public string? Nationality { get; set; }
        public string? PlaceOfBirth { get; set; }
        public string? StageId { get; set; }
        public string? GradeId { get; set; }
        public string? SectionId { get; set; }
        public string? Topic { get; set; }
        public string? Semester { get; set; }
        public string? Relation { get; set; }
        public int? RaisedHands { get; set; }
        public int? VisitedResources { get; set; }
        public int? AnnouncementsView { get; set; }
        public int? Discussion { get; set; }
        public string? ParentAnsweringSurvey { get; set; }
        public string? ParentSchoolSatisfaction { get; set; }
        public string? StudentAbsenceDays { get; set; }
        public int? StudentMarks { get; set; }
        public string? Class { get; set; }
    }
    //public class CustomGenderValidationAttribute : ValidationAttribute
    //{
    //    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //    {
    //        if (value == null)
    //        {
    //            return ValidationResult.Success;
    //        }

    //        string gender = value as string;
    //        if (gender == "M" || gender == "F")
    //        {
    //            return ValidationResult.Success;
    //        }

    //        return new ValidationResult(ErrorMessage);
    //    }
    //}

}
