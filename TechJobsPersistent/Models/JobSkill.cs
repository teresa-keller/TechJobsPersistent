using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechJobsPersistent.Models
{
    public class JobSkill
    {
        [Required(ErrorMessage="Job is required.")]
        public int JobId { get; set; }
        public Job Job { get; set; }
        [Required(ErrorMessage="Skill is required.")]
        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        public JobSkill()
        {
        }
    }
}