using System;

namespace TheNuggetList.Website.ViewModels
{
    public class HomeNuggetListItemViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PostedBy { get; set; }
        public DateTime Created { get; set; }
    }
}