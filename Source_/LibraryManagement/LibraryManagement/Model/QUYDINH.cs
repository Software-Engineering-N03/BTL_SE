//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagement.Model
{
    using LibraryManagement.ViewModel;
    using System;
    using System.Collections.Generic;
    
    public partial class QUYDINH:BaseViewModel
    {
        public int MaQD { get; set; }
        public string TenQD { get; set; }
        public string KieuDL { get; set; }

        private string _GiaTri;
        public string GiaTri { get => _GiaTri; set { _GiaTri = value; OnPropertyChanged(); } }
        public string TinhTrang { get; set; }
    }
}
