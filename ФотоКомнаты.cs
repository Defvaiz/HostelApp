//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostelApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class ФотоКомнаты
    {
        public int Код { get; set; }
        public int КодКомната { get; set; }
        public byte[] ИсточникИзображения { get; set; }
    
        public virtual Комната Комната { get; set; }
    }
}
