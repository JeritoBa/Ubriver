using Ubriver.Models.Enums;

namespace Ubriver.DTOs;

public class CreateRequestShipment
{
    public string PickupAddress { get; set; }
    public string DestinationAddress { get; set; }
    public RequestShipmentCommodityType CommodityType { get; set; }
    public float Weight { get; set; }
    public string? Notes { get; set; }
}