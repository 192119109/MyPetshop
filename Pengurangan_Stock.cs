//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pengurangan_Stock
    {
        public string id_pengurangan { get; set; }
        public string id_barang { get; set; }
        public string id_pembelian { get; set; }
        public Nullable<System.DateTime> tglPengurangan { get; set; }
        public Nullable<int> qtyAwal { get; set; }
        public Nullable<int> qtyAkhir { get; set; }
        public Nullable<int> jlhPengurangan { get; set; }
        public string Keterangan { get; set; }
    
        public virtual Barang Barang { get; set; }
        public virtual Pembelian Pembelian { get; set; }
    }
}