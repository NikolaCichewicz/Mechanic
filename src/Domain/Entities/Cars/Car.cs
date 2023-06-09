﻿using Mechanic.Domain.Entities.Orders;
using Mechanic.Domain.Entities.Users;

namespace Mechanic.Domain.Entities.Cars;

public class Car : BaseAuditableEntity
{
    public Guid Id { get; set; }

    public string PlateNumber { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string Vin { get; set; } = null!;

    public int Mileage { get; set; }


    public IList<ApplicationUser> Users { get; set; } = null!;

    public IList<Order> Orders { get; set; } = null!;
}