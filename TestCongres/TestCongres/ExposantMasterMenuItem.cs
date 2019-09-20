using System;

namespace TestCongres
{

    public class ExposantMasterMenuItem
    {
        public ExposantMasterMenuItem()
        {
            TargetType = typeof(ExposantMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public string Representant { get; set; }
        public string Courriel { get; set; }
        public string Telephone { get; set; }
        public string Kiosque { get; set; }
        public string LienPhoto { get; set; }

        public Type TargetType { get; set; }
    }
}