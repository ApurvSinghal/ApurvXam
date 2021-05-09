using MongoDB.Driver;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApurvXam.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            DbConnection();
        }

        private void DbConnection()
        {
            try
            {
                var client = new MongoClient("mongodb+srv://DatabaseUser0:Brl6nSbMKXIkwmHX@cluster0.xtwhf.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
                var database = client.GetDatabase("test");
            }
            catch (Exception ex)
            {
            }
        }

    }
}
