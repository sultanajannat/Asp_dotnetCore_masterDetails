﻿using System.ComponentModel.DataAnnotations;

namespace Asp_dotnetCore_masterDetails.Models.ViewModels
{
    public class CandidateVM
    {
        public CandidateVM()
        {
            this.SkillList = new List<int>();
        }
        public int CandidateId { get; set; }
        public string CandidateName { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        [Display(Name ="Image")]
        public IFormFile ImagePath { get; set; }
        public string? Image { get; set; }
        public bool Fresher { get; set; }
        public List<int> SkillList { get; set; }
    }
}
