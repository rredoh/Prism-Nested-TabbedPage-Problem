using System;
using System.Collections.Generic;
using System.Text;

namespace AssetKita.Models
{
    class PostItem
    {
        public string IMAGE_LINK { get; set; }
        public string NAME { get; set; }
        public string WEIGHT { get; set; }
        public string CATEGORY { get; set; }
        public string ASKING_PRICE { get; set; }
        public string ASKING_INTEREST_RATE { get; set; }
        public string DURATION { get; set; }
        public string DESCRIPTION { get; set; }

        public Owner owner { get; set; }
        public string OWNER_LOCATION
        {
            get { return owner.LOCATION; }
            set { owner.LOCATION = value; }
        }
    }
}
