using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;

namespace PDC03_MODULE02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity5 : ContentPage
    {
        ObservableCollection<employee> employees = new ObservableCollection<employee>();

        public ObservableCollection<employee> Employees { get { return employees; } }

        public activity5()
        {
            InitializeComponent();
            {
                lst.ItemsSource = employees;

                employees.Add(new employee { DisplayName = "Bobby Marcko Cruz", Position = "President", ProfileImage = "image1.jpg" } );
                employees.Add(new employee { DisplayName = "Jell-o Mangune", Position = "Vice President", ProfileImage = "image2.jpeg" });
                employees.Add(new employee { DisplayName = "Calvin Klein Pangilinan", Position = "Secretary", ProfileImage = "image3.jpg" });
                employees.Add(new employee { DisplayName = "Ross Weasley", Position = "Treasurer", ProfileImage = "https://th.bing.com/th/id/OIP.hGIKluXLZvu4xwPMgCdImAHaJr?w=185&h=242&c=7&r=0&o=5&pid=1.7" });
                employees.Add(new employee { DisplayName = "Aaron Echon", Position = "Auditor" });
            }
        }
    }
}