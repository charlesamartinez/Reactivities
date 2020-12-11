using System;

namespace Domain
{
    public class Exercises
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public Guid AdvisorId { get; set; }
        public string Exercise { get; set; }
        public string ClinicalRecord { get; set; }
        public string Diagnosis { get; set; }
        public string Procedure { get; set; }
        public string Difficulty { get; set; }
        public string Insurance { get; set; }
        public string PatientName { get; set; }
        public string PatientGender { get; set; }
        public string PatientAge { get; set; }
        public DateTime PatientDateOfService { get; set; }
        public DateTime PatientHistory { get; set; }
    }

    public class ExerciseAnswers
    {
        public int Id { get; set; }
        public int ExecriseId { get; set; }
        public int AnswerType { get; set; }
        public string Diagnosis { get; set; }
        public string Procedure { get; set; }
    }
    
}