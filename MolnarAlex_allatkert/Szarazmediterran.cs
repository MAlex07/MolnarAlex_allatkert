using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolnarAlex_allatkert
{
	internal class Szarazmediterran
	{
		private string faj;
		private string nev;
		private string tipus;
		private int sebesseg;

		public Szarazmediterran(string faj, string nev, string tipus, int sebesseg)
		{
			this.faj = faj;
			this.nev = nev;
			this.tipus = tipus;
			this.sebesseg = sebesseg;
		}

		public string Faj { get => faj; set => faj = value; }
		public string Nev { get => nev; set => nev = value; }
		public string Tipus { get => tipus; set => tipus = value; }
		public int Sebesseg { get => sebesseg; set => sebesseg = value; }
		public override string? ToString()
		{
			return $"{faj} - {nev} - {tipus} - {sebesseg}";
		}
	}
}
