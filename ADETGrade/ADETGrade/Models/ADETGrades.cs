using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADETGrade.Models
{
    public class ADETGrades
    {
        public int Id { get; set; }

        [Display(Name = "Student Name")]
        public string StudName { get; set; }
        public string Address { get; set; }
        public string Course { get; set; }
        public string YearSection { get; set; }
        [Display(Name = "Q1")]
        public float PrelimQ1 { get; set; }
        [Display(Name = "Q2")]

        public float PrelimQ2 { get; set; }
        [Display(Name = "Q3")]
        public float PrelimQ3 { get; set; }
        [Display(Name = "A1")]
        public float PrelimA1 { get; set; }
        [Display(Name = "A2")]
        public float PrelimA2 { get; set; }
        [Display(Name = "A3")]
        public float PrelimA3 { get; set; }
        [Display(Name = "Total")]
        public float PrelimTotal { get; set; }
        [Display(Name = "Q1")]
        public float MidtermQ1 { get; set; }
        [Display(Name = "Q2")]
        public float MidtermQ2 { get; set; }
        [Display(Name = "Q3")]
        public float MidtermQ3 { get; set; }
        [Display(Name = "A1")]
        public float MidtermA1 { get; set; }
        [Display(Name = "A2")]
        public float MidtermA2 { get; set; }
        [Display(Name = "A3")]
        public float MidtermA3 { get; set; }
        [Display(Name = "Total")]
        public float MidTermTotal { get; set; }
        [Display(Name = "Q1")]
        public float PreFinalQ1 { get; set; }
        [Display(Name = "Q2")]
        public float PreFinalQ2 { get; set; }
        [Display(Name = "Q3")]
        public float PreFinalQ3 { get; set; }
        [Display(Name = "A1")]
        public float PreFinalA1 { get; set; }
        [Display(Name = "A2")]
        public float PreFinalA2 { get; set; }
        [Display(Name = "A3")]
        public float PreFinalA3 { get; set; }
        [Display(Name = "Total")]
        public float PreFinalTotal { get; set; }
        [Display(Name = "Q1")]

        public float FinalQ1 { get; set; }
        [Display(Name = "Q2")]
        public float FinalQ2 { get; set; }
        [Display(Name = "Q3")]
        public float FinalQ3 { get; set; }
        [Display(Name = "A1")]
        public float FinalA1 { get; set; }
        [Display(Name = "A2")]
        public float FinalA2 { get; set; }
        [Display(Name = "A3")]
        public float FinalA3 { get; set; }
        [Display(Name = "Total")]
        public float FinalTotal { get; set; }

    }
}
