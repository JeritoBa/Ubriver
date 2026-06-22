using Ubriver.Data;
using Ubriver.DTOs;
using Ubriver.Models;
using Ubriver.Responses;
using Ubriver.Models.Enums;

namespace Ubriver.Services.Application;

public class ShimpentRequestService
{
    // DB initializing
    private readonly ApplicationDbContext _context;

    public ShipmentRequestService(ApplicationDbContext context)
    {
        _context = context;
    }

    public ServiceResponse<RequestShipment> Create(CreateRequestShipment requestDto)
    {   
        // Create the shipment request
        RequestShipment newRequest = new RequestShipment
        {
            PickupAddress = requestDto.PickupAddress,
            DestinationAddress = requestDto.DestinationAddress,
            CommodityType = requestDto.CommodityType,
            Weight = requestDto.Weight,
            Notes = requestDto.Notes,
            State = RequestShipmentState.Pending  
        };

        var requestCreated = _context.RequestShipments.Add(newRequest);

        // Return response 
    }
}