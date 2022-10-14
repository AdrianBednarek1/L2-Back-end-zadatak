﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Project.Service.Interfaces
{
    public interface IModelCreator
    {       
        List<SelectListItem> VehicleMadesInList { get; }
        
        int Id { get; }
        
        string name { get; }
        
        string abrv { get; }

        Task<IActionResult> OnPostAsync();
        Task OnGetAsync();
    }
}
