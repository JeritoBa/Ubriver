namespace Ubriver.Models;

using Ubriver.Models.Enums;

public class RequestShipment
{
    public int Id { get; set; }
    public string PickupAddress { get; set; } = string.Empty;
    public string DestinationAddress { get; set; } = string.Empty;
    public RequestShipmentCommodityType CommodityType { get; set; } = RequestShipmentCommodityType.Retail;
    public float Weight { get; set; }
    public string Notes { get; set; } = string.Empty;
    public RequestShipmentState State { get; set; } = RequestShipmentState.Pending;
} 