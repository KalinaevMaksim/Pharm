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
    
    public partial class Заказ_Препарат
    {
        public int Код_заказа_препарата { get; set; }
        public Nullable<int> Код_заказа { get; set; }
        public Nullable<int> Код_препарата { get; set; }
        public int Количество_препарата { get; set; }
    
        public virtual Заказ Заказ { get; set; }
        public virtual Препарат Препарат { get; set; }
    }
}
