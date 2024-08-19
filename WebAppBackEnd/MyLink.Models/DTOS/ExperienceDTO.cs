﻿using System.ComponentModel.DataAnnotations;

namespace MyLink.Models.DTOS
{
    public class ExperienceDTO
    {
        [Required]
        public string? Username { get; set; }
        public string Title { get; set; }
        public string? EmploymentType { get; set; }
        public string CompanyName { get; set; }
        public string? Location { get; set; }
        public string? LocationType { get; set; }
        public string StartDate { get; set; }
        public string? EndDate { get; set; }
        public bool CurrentJob { get; set; }
        public string? Description { get; set; }
    }
}
