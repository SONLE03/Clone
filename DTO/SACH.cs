//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            this.CT_PHIEUNHAP = new HashSet<CT_PHIEUNHAP>();
            this.CUONSACHes = new HashSet<CUONSACH>();
        }
    
        public int id { get; set; }
        public string MaSach { get; set; }
        public int idTuaSach { get; set; }
        public int SoLuong { get; set; }
        public int SoLuongConLai { get; set; }
        public int DonGia { get; set; }
        public int NamXB { get; set; }
        public string NhaXB { get; set; }
        public int DaAn { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUNHAP> CT_PHIEUNHAP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUONSACH> CUONSACHes { get; set; }
        public virtual TUASACH TUASACH { get; set; }
    }
}
