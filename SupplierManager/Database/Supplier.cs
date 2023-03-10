//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SupplierManager.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            this.Materials = new HashSet<Material>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string INN { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<int> QualityRating { get; set; }
        public int SupplierType { get; set; }
        public string PathString { get; set; }
        public byte[] PictureBytes { get; set; }
    
        public virtual SupplierType SupplierType1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material> Materials { get; set; }
    }
}
