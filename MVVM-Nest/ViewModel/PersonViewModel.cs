using System.Collections.ObjectModel;
using System.Windows.Input;
using MVVM_Nest.Model;
using MVVM_Nest.ViewModel;

namespace MVVM_Nest.ViewModel
{
    public class PersonViewModel : BaseViewModel
    {
        public ObservableCollection<Person> People { get; set; }
        private ObservableCollection<Person> _filteredPeople;
        public ObservableCollection<Person> FilteredPeople
        {
            get => _filteredPeople;
            set
            {
                _filteredPeople = value;
                OnPropertyChanged(nameof(FilteredPeople));
            }
        }

        private bool _showFirstNames;
        public bool ShowFirstNames
        {
            get => _showFirstNames;
            set
            {
                _showFirstNames = value;
                OnPropertyChanged(nameof(ShowFirstNames));
                UpdateFilteredPeople();
            }
        }

        public ICommand ShowFirstNamesCommand { get; }
        public ICommand ShowLastNamesCommand { get; }

        public PersonViewModel()
        {
            People = new ObservableCollection<Person>
            {
                new Person { FirstName = "John", LastName = "Doe" },
                new Person { FirstName = "Jane", LastName = "Smith" }
            };
            FilteredPeople = new ObservableCollection<Person>(People);
            ShowFirstNames = true; // Default view

            ShowFirstNamesCommand = CreateCommand(() => ShowFirstNames = true);
            ShowLastNamesCommand = CreateCommand(() => ShowFirstNames = false);
        }

        private void UpdateFilteredPeople()
        {
            FilteredPeople = new ObservableCollection<Person>(
                People.Select(p => ShowFirstNames ? p : new Person { FirstName = "", LastName = p.LastName }));
        }
    }
}

