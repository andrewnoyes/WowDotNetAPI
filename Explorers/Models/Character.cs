﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WowDotNetAPI.Models
{
    public class Character
    {
        public string lastModified { get; set; }
        public string name { get; set; }
        public string realm { get; set; }
        public int @class { get; set; }
        public int race { get; set; }
        public int gender { get; set; }
        public int level { get; set; }
        public int achievementPoints { get; set; }
        public string thumbnail { get; set; }

        public CharacterGuild guild { get; set; }
        public CharacterStats stats { get; set; }
        public IEnumerable<CharacterTalent> talents { get; set; }
        public CharacterInventory items { get; set; }
        public IEnumerable<CharacterReputation> reputation { get; set; }
        public IEnumerable<CharacterTitle> titles { get; set; }
        public CharacterProfessions professions { get; set; }
        public CharacterAppearance appearance { get; set; }
        public IEnumerable<int> companions { get; set; }
        public IEnumerable<int> mounts { get; set; }
        public Progression progression { get; set; }


    }
}
