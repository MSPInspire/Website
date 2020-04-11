using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Step
    {
		private string instruction;

		public string Instruction
		{
			get { return instruction; }
			set { instruction = value; }
		}

		private string img;

		public string Img
		{
			get { return img; }
			set { img = value; }
		}

		private string caption;

		public string Caption
		{
			get { return caption; }
			set { caption = value; }
		}


	}
}
