using CollectionSampleApp.Model;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace CollectionSampleApp.ViewModels
{
    public class MainWindowViewModel : BindableBase, INotifyCollectionChanged
    {
        private string _title = "Prism Unity Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        private ObservableCollection<Person> myData;

        /// <summary>
        /// Gets the list of persons to show in the UI
        /// </summary>
        public ObservableCollection<Person> MyData
        {
            get { return myData; }
        }

        SampleModel model;

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        
        public MainWindowViewModel()
        {
            this.model = new SampleModel();

            myData = new ObservableCollection<Person>(model.GenerateSampleData());

        }

    }
}