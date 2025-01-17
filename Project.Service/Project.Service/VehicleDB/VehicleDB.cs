﻿using System.Data.Entity;
using ZaPrav.NetCore.Interfaces;
using ZaPrav.NetCore.Interfaces.IVehicleDB;

namespace ZaPrav.NetCore.VehicleDB
{
    public class VehicleDB : DbContext, IVehicleDB
    {
        public DbSet<VehicleMake> vehicleMakes { get; set; }
        public DbSet<VehicleModel> vehicleModels { get; set; }
    }
}
