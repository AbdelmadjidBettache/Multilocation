//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultiLocation
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblVehicule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblVehicule()
        {
            this.tblLocations = new HashSet<tblLocation>();
        }
    
        public string NIVVehicule { get; set; }
        public Nullable<System.DateTime> Annee { get; set; }
        public Nullable<decimal> KilometrageSurOdometre { get; set; }
        public Nullable<decimal> ValeurLivre { get; set; }
        public Nullable<bool> TransmissionAuto { get; set; }
        public Nullable<bool> A_C { get; set; }
        public Nullable<bool> AntiDemarreur { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLocation> tblLocations { get; set; }
    }
}
