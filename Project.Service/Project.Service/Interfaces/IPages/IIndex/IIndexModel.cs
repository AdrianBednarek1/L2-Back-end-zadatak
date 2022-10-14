﻿using Microsoft.AspNetCore.Mvc;
using ZaPrav.NetCore;
using ZaPrav.NetCore.VehicleDB;

namespace Project.Service.Interfaces.IPages.IIndex
{
    public interface IIndexModel
    {
        PaginatedList<VehicleMade> PaginatedVehicleMades { get; }
        PaginatedList<VehicleModel> PaginatedVehicleModel { get; }
        List<VehicleMade> vehicleMades { get; }
        List<VehicleModel> vehicleModels { get; }
        SortingHelp SortingMadeHelper { get; }
        SortingHelp SortingModelHelper { get; }
        string? CurrentFilterMade { get; }
        string? CurrentFilterModel { get; }
        string? CurrentSortMade { get; }
        string? CurrentSortModel { get; }
        Task OnGetAsync
            (
            string sortOrderMades,
            string SearchStringMade, string currentFilterMade, int? pageIndexMade,

            string sortOrderModel,
            string SearchStringModel, string currentFilterModel, int? pageIndexModel
            );
        Task VehicleMadeSortingFilteringPaging
            (string sortOrderMades, string SearchStringMade, string currentFilterMade, int? pageIndexMade);
        Task VehicleModelSortingFilteringPaging
            (string sortOrderModel, string SearchStringModel, string currentFilterModel, int? pageIndexModel);
        Task<IActionResult> OnPostDeleteAsync(int Id, bool TrueIfModel);
    }
}