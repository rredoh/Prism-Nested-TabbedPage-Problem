using AssetKita.Models;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssetKita.ViewModels
{
    class ItemList_Invest_ViewModel : ViewModelChild
    {
        private List<PostItem> postItems = new List<PostItem>()
        {
            new PostItem
            {
                NAME = "Emas 24 Karat",
                    ASKING_INTEREST_RATE = "2%",
                    ASKING_PRICE = "1.000.000",
                    CATEGORY = "Emas",
                    DESCRIPTION = "Berat 3 gram",
                    DURATION = "30 hari",
                    IMAGE_LINK = "https://fm.cnbc.com/applications/cnbc.com/resources/img/editorial/2017/10/02/104748034-GettyImages-90075023.530x298.jpg?v=1506995840"
            },
            new PostItem
                {
                    NAME = "Redmi Note 5",
                    ASKING_INTEREST_RATE = "2%",
                    ASKING_PRICE = "2.000.000",
                    CATEGORY = "Smartphone",
                    DESCRIPTION = "Mulus Like New",
                    DURATION = "30 hari",
                    IMAGE_LINK = "http://st1.bgr.in/wp-content/uploads/2018/02/Xiaomi-Redmi-Note-5-Front.jpg"
                },
                new PostItem
                {
                    NAME = "MacBook Pro 15 inch 2018",
                    ASKING_INTEREST_RATE = "2%",
                    ASKING_PRICE = "20.000.000",
                    CATEGORY = "Elektronik",
                    DESCRIPTION = "Mulus Like New",
                    DURATION = "30 hari",
                    IMAGE_LINK = "https://www.insightmac.com/wp-content/uploads/2018/07/26826-38847-2018-MacBook-Pro-15-inch-l.jpg"
                },
        };
        public List<PostItem> PostItems
        {
            get { return postItems; }
            set { SetProperty(ref postItems, value); }
        }

        public ItemList_Invest_ViewModel(INavigationService navigationService,
            IPageDialogService pageDialog)
        {
            Title = "INVEST";
        }
    }
}
