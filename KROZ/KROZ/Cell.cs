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
    
    public partial class Cell
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cell()
        {
            this.Character = new HashSet<Character>();
            this.Map = new HashSet<Map>();
        }
    
        public int ID { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public bool MoveTo { get; set; }
        public int MonsterRate { get; set; }
        public string Description { get; set; }
        public int MonsterGroup { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Character> Character { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Map> Map { get; set; }
    }
}
