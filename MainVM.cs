using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace NavigationBar
{
    //ObservableObject sends viewmodel to view
    public class MainVM : ObservableObject
    {
        private PageId _pageID;

        public PageId PageID
        {
            get { return _pageID; }
            set { SetProperty(ref _pageID, value); } 
        }

        //ICommand is used to send view to viewmodel
        public ICommand CMDChangePage => new RelayCommand<PageId>(ChangePage);

        void ChangePage(PageId newPage)
        {
            PageID = newPage;
        }

        //Here is an example of two-way binding using (text box) values
        private string _test;
   
        public string Test
        {
            get { return _test; }
            set { SetProperty(ref _test, value); }
        }

        public MainVM() 
        { 
            PageID = PageId.A; 
            //Text Box default
            Test = "Hello there..."; 
        }
    }
}
