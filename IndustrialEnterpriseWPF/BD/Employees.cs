//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IndustrialEnterpriseWPF.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employees
    {
        public int employee_id { get; set; }
        public string employee_name { get; set; }
        public string employee_lastname { get; set; }
        public string employee_position { get; set; }
        public string employee_email { get; set; }
        public string employee_qualifications { get; set; }
        public int plant_id { get; set; }
    
        public virtual PowerPlants PowerPlants { get; set; }
    }
}
