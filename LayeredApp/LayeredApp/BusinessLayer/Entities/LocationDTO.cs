using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredApp.BL.Entities
{
	public class LocationDTO
	{
		public Place Type {
			get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public double[] Position { get; set; }
		public enum Place
		{
			Hospital = 1,
			Taller = 2,
			Oficina = 3
		}
		
	}
}
