using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BE;
using BL;
using System.Collections.ObjectModel;

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MyBL bl;
        private ObservableCollection<Speciality> _SpecialityCollection;
        private ObservableCollection<Worker> _WorkersCollection;

        public MainWindow()
        {
            InitializeComponent();
            bl = MyBL.Instance;
            comboBoxDiscpline.DataContext = Enum.GetNames(typeof(Enums.Discipline)).ToList();
           _SpecialityCollection = new ObservableCollection<Speciality>(bl.getSpecsList());
            dgSpecialities.DataContext = _SpecialityCollection;

            _WorkersCollection = new ObservableCollection<Worker>(bl.getWorkersList());
            lbWorkers.DataContext = _WorkersCollection;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Enums.Discipline myDiscipline;
            Enum.TryParse(comboBoxDiscpline.Text, out myDiscipline);
            Speciality sp = new Speciality(myDiscipline, tBname.Text,Convert.ToInt32(tBminRate.Text), Convert.ToInt32(tBmaxRate.Text));
            bl.addSpec(sp);
            _SpecialityCollection.Add(sp);
        }

        private void addWorkerbutton_Click(object sender, RoutedEventArgs e)
        {
            Worker wo = new Worker(tBWorkerID.Text,tBWorkerFirstName.Text,tBWorkerLastname.Text, dpWorkerBirthday.SelectedDate.Value.Date);
            bl.addWorker(wo);
            _WorkersCollection.Add(wo);

            
        }

        private void addEmployersbutton_Click(object sender, RoutedEventArgs e)
        {
            Employer emp = new Employer(int.Parse(tBEmployersID.Text),tBEmployersName.Text);
            bl.addEmployer(emp);
        }

       
    }
}
