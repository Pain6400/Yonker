//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YonkerHN.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        public int empleadoID { get; set; }
        public string nombreemp { get; set; }
        public string contraseña { get; set; }
        public int yonkerID { get; set; }
        public int usuarioID { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual Yonker Yonker { get; set; }
    }
}