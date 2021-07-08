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
    
    public partial class Препарат
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Препарат()
        {
            this.Заказ_Препарат = new HashSet<Заказ_Препарат>();
            this.Препарат_Поставка = new HashSet<Препарат_Поставка>();
        }
    
        public int Код_препарата { get; set; }
        public int Код_изготовителя { get; set; }
        public string Название { get; set; }
        public string Группа { get; set; }
        public decimal Закупочная_цена__ { get; set; }
        public decimal Конечная_цена__ { get; set; }
        public Nullable<int> Кол_во { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказ_Препарат> Заказ_Препарат { get; set; }
        public virtual Изготовитель Изготовитель { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Препарат_Поставка> Препарат_Поставка { get; set; }
    }
}
