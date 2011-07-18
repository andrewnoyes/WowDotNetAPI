﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WowDotNetAPI.Models
{
	public class CharacterProfession
	{
		public int id { get; set; }
		public string name { get; set; }
		public string icon { get; set; }
		public int rank { get; set; }
		public int max { get; set; }
		public IEnumerable<int> recipes { get; set; }
	}
}
