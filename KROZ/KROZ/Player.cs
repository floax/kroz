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
    
    public partial class Player
    {
        public int ID { get; set; }
        public int XP { get; set; }
    
        public virtual Character Character { get; set; }
    }
}