using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;


namespace TestCongres
{
    public class FavorisModel
    {
		public string Nom { get; set; }
		public string Comment { get; set; }
		public string ImageURL { get; set; }
		public string Type { get; set; }
	}
	public class GroupedFavorisModel : List<FavorisModel>
	{
		public string LongName { get; set; }
		public string ShortName { get; set; }
		public GroupedFavorisModel(string name, List<FavorisModel> favori) : base(favori)
		{
			LongName = name;
		}
	}
}
