//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantFinder
{
    using System;
    using System.Collections.Generic;
    
    public partial class Store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Store()
        {
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int StoreId { get; set; }
        public string Name { get; set; }
        public int FoodTypeId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string Outline { get; set; }
    
        public virtual City City { get; set; }
        public virtual FoodType FoodType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual State State { get; set; }
    }
}
