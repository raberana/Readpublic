﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readpublic.Business
{
	public class Publisher
	{
		public virtual int Id { get; set; }
		public virtual string Name { get; set; }
		public virtual Country Country { get; set; }
	}
}
