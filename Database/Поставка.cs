//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharm.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Поставка
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Поставка()
        {
            this.Препарат_Поставка = new HashSet<Препарат_Поставка>();
        }
    
        public int Код_поставки { get; set; }
        public int Код_поставщика { get; set; }
        public int Код_склада { get; set; }
        public decimal Стоимость { get; set; }
    
        public virtual Поставщик Поставщик { get; set; }
        public virtual Склад Склад { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Препарат_Поставка> Препарат_Поставка { get; set; }
    }
}
