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
    
    public partial class tblPaiment
    {
        public int IdPaiment { get; set; }
        public Nullable<System.DateTime> DatePaiment { get; set; }
        public Nullable<decimal> MontantPaiment { get; set; }
        public Nullable<int> IdLocation { get; set; }
    
        public virtual tblLocation tblLocation { get; set; }
    }
}