//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KROZ
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsableItem
    {
        public int ID { get; set; }
        public int RestoreHP { get; set; }
        public int AttackBoost { get; set; }
        public int DefenseBoost { get; set; }
    
        public virtual Item Item { get; set; }
    }
}
