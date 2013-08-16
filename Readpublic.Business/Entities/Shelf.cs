﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
	public class Shelf
	{
		public virtual int Id { get; set; }
		public virtual User User { get; set; }
		public virtual DateTime DateCreated { get; set; }
		public virtual IList<int> Books { get; set; }
		public virtual IList<int> Genres { get; set; }
		public virtual string ShelfCoverPath { get; set; }
	}
}
