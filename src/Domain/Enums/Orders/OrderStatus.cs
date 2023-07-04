namespace Mechanic.Domain.Enums.Orders;

public enum OrderStatus
{
    /// <summary>
    ///     Order was added.
    /// </summary>
    Waiting = 0,

    /// <summary>
    ///     The mechanic started repairing the car.
    /// </summary>
    InProgress = 1,

    /// <summary>
    ///     The mechanic finished repairing the car.
    /// </summary>
    Finished = 2,

    /// <summary>
    ///     The customer picked up the car.
    /// </summary>
    PickedUp = 3,

    /// <summary>
    ///     The customer paid for the service.
    /// </summary>
    Paid = 4
}