//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PianoProject.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class cart
    {
        public int IDCart { get; set; }
        public int PianoID { get; set; }
        public int IDUser { get; set; }
    
        public virtual Piano Piano { get; set; }
        public virtual Users Users { get; set; }
    }
}