//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PractMysql
{
    using System;
    using System.Collections.Generic;
    
    public partial class productes
    {
        public int idProducte { get; set; }
        public string Producte { get; set; }
        public Nullable<float> Preu { get; set; }
    
        public virtual factures_detall factures_detall { get; set; }
    }
}
