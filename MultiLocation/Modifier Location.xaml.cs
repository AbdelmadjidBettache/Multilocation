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
using System.Windows.Shapes;

namespace MultiLocation
{
    /// <summary>
    /// Logique d'interaction pour Modifier_Location.xaml
    /// </summary>
    public partial class Modifier_Location : Window
    {
        MultilocationEntities entities;
        public Modifier_Location()
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
            cmbIDLocation.DataContext = entities.tblLocations.ToList();

        }

        private void cmbIDLocation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tblLocation selectedLocation = cmbIDLocation.SelectedItem as tblLocation;
            dateDebut.SelectedDate = selectedLocation.DateDebutLocation;
            datePremier.SelectedDate = selectedLocation.DatePremierPaiment;
            cmbTerme.Text =selectedLocation.IDTerme.ToString();
            cmbNIV.Text = selectedLocation.NIVVehicule.ToString();
            cbmClient.Text = selectedLocation.IDClient.ToString();
            cmbPay.Text = selectedLocation.NombrePaimentMensuel.ToString();
            txt_montant.Text = selectedLocation.MontantPaimentMensuel.ToString();
        }

        private void btnModifierLocation_Click(object sender, RoutedEventArgs e)
        {
            tblLocation selectedLocation = cmbIDLocation.SelectedItem as tblLocation;
            selectedLocation.DateDebutLocation= dateDebut.SelectedDate;
            selectedLocation.DatePremierPaiment = datePremier.SelectedDate;
            selectedLocation.IDTerme= int.Parse( cmbTerme.Text);
            selectedLocation.NIVVehicule = cmbNIV.Text ;
            selectedLocation.IDClient = int.Parse(cbmClient.Text);
            selectedLocation.NombrePaimentMensuel = int.Parse(cmbPay.Text);
            selectedLocation.MontantPaimentMensuel = decimal.Parse(txt_montant.Text);

            entities.SaveChanges();
            MessageBox.Show("Location Modifier avec succes");
        }
    }
}
