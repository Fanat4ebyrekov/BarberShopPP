//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarberShop.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Record
    {
        public int IdRecord { get; set; }
        public int idClient { get; set; }
        public int IdPersonnel { get; set; }
        public int IdServices { get; set; }
        public System.DateTime RecordTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public bool Completed { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Personnel Personnel { get; set; }
        public virtual Services Services { get; set; }
    }
}