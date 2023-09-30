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

namespace MultiLocation
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MultilocationEntities entities;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            entities = new MultilocationEntities();
            dateDebut.SelectedDate = DateTime.Now;
            datePremier.SelectedDate = DateTime.Now;

            cmbTerme.DataContext = entities.tblTermes.ToList();
            cbmClient.DataContext = entities.tblClients.ToList();
            cmbNIV.DataContext = entities.tblVehicules.ToList();
            cmbPay.DataContext = entities.tblPaiments.ToList();
            
        }

        private void btnAddLocation_Click(object sender, RoutedEventArgs e)
        {
            tblLocation loc = new tblLocation();    
            loc.DateDebutLocation = dateDebut.SelectedDate;
            loc.DateDebutLocation= datePremier.SelectedDate;
            loc.MontantPaimentMensuel = decimal.Parse(txt_montant.Text);
            loc.IDClient = ((tblClient)cbmClient.SelectedItem).IdClient;
            loc.NIVVehicule = cmbNIV.Text;
            loc.IDTerme = int.Parse(cmbTerme.Text);
            loc.NombrePaimentMensuel = int.Parse(cmbPay.Text);

            entities.tblLocations.Add(loc);

            entities.SaveChanges();
            MessageBox.Show("Location ajoutée avec succes");
        }
    }
}
