﻿namespace Oneiros.Data.Model
{
    public class PlayerSkill
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }
        public int SkillId { get; set; }
        public int RoanokeId { get; set; }

        public int Niveau { get; set; }
        public string Notes { get; set; }

        public virtual Player Player { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual Roanoke Roanoke { get; set; }
    }
}