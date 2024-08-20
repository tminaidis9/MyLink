﻿using System.ComponentModel.DataAnnotations;

namespace MyLink.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? EmploymentType { get; set; }
        [Required]
        public string? CompanyName { get; set; }
        public string? Location { get; set; }
        public string? LocationType { get; set; }
        [Required]
        public string? StartDate{ get; set; }
        public string? EndDate { get; set; }
        public bool CurrentJob { get; set; }
        public string? Description  { get; set; }
        [Required]
        public string UserId { get; set; }
        public User User { get; set; } = null;
    }
}
