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
    
    public partial class Weapon
    {
        public int ID { get; set; }
        public int AttackRate { get; set; }
        public int MissedRate { get; set; }
    
        public virtual Item Item { get; set; }
    }
}
