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
    
    public partial class tblTerme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTerme()
        {
            this.tblLocations = new HashSet<tblLocation>();
        }
    
        public int IdTerme { get; set; }
        public Nullable<int> NombreAnnees { get; set; }
        public Nullable<int> KilometrageMax { get; set; }
        public Nullable<decimal> PrimeKmExtra { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblLocation> tblLocations { get; set; }
    }
}
