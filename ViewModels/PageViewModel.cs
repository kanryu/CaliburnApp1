using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnApp1.ViewModels
{
    public class BodyViewModel
    {
        public bool BodyEnable { get; set; } = true;
    }
    public class PageViewModel : Screen
    {
        public bool DayEnable { get; set; } = true;
        public ObservableCollection<BodyViewModel> BodiesModel { get; set; }

        private readonly INavigationService navigationService;
        public PageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            BodiesModel = new ObservableCollection<BodyViewModel>() {
                new BodyViewModel()
            };

            NotifyOfPropertyChange(() => DayEnable);
            NotifyOfPropertyChange(() => BodiesModel);

        }
    }
}
