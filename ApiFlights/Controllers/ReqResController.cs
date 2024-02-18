using System;
using System.Threading.Tasks;
using getAvailabilityRequest;
using getAvailabilityResponse.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFlights.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReqResController : ControllerBase
    {
        private readonly IApiService _apiService;

        public ReqResController(IApiService apiService)
        {
            _apiService = apiService;
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult<string>> CheckAvailability([FromBody] AirAvailRQ request)
        {
            return "hello";

            try
            {
                string username = "WSUSERNAME";
                string password = "password123";
                string terminalId = "TestUser/Test Runner";

                request.EchoToken = "your_echo_token";
                request.PrimaryLangID = "en-us";
                request.SequenceNmbr = 1;
                request.Target = "Test";
                request.TimeStamp = DateTime.UtcNow;
                request.Version = "2006.01";
                request.POS = new POS
                {
                    Source = new Source
                    {
                        TerminalID = terminalId,
                        RequestorID = new RequestorID { ID = username, Type = 1 },
                        BookingChannel = new BookingChannel { Type = 1 }
                    }
                };

                var response = await _apiService.GetAvailability(request);

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }

    public interface IApiService
    {
        Task<AirAvailRS> GetAvailability(AirAvailRQ request);
    }

    public class ApiService : IApiService
    {
        public async Task<AirAvailRS> GetAvailability(AirAvailRQ request)
        {
           
            var response = new AirAvailRS
            {
                EchoToken = request.EchoToken,
                PrimaryLangID = request.PrimaryLangID,
                SequenceNmbr = request.SequenceNmbr.ToString(),
                TransactionIdentifier = "TID$127106902861951458177791",
                Version = request.Version,
                Success = new Success(),
                Warnings = new Warnings(),
                OriginDestinationInformation = new[]
                {
                new OriginDestinationInformation
                {
                    DepartureDateTime = request.OriginDestinationInfo.DepartureDateTime,
                    ArrivalDateTime = request.OriginDestinationInfo.ReturnDateTime,
                    OriginLocation = new OriginLocation { LocationCode = request.OriginDestinationInfo.OriginLocation, Text = "Origin" },
                    DestinationLocation = new DestinationLocation { LocationCode = request.OriginDestinationInfo.DestinationLocation, Text = "Destination" },
                    OriginDestinationOptions = new OriginDestinationOptions
                    {
                        OriginDestinationOption = new OriginDestinationOption
                        {
                            FlightSegment = new FlightSegment
                            {
                                ArrivalDateTime = request.OriginDestinationInfo.ReturnDateTime,
                                DepartureDateTime = request.OriginDestinationInfo.DepartureDateTime,
                                FlightNumber = "G9507",
                                RPH = "221698",
                                DepartureAirport = new DepartureAirport { LocationCode = request.OriginDestinationInfo.OriginLocation, Terminal = "TerminalX" },
                                ArrivalAirport = new ArrivalAirport { LocationCode = request.OriginDestinationInfo.DestinationLocation, Terminal = "TerminalX" }
                            }
                        }
                    }
                }
            },
                AAAirAvailRSExt = new AAAirAvailRSExt(),
                Errors = new Errors()
            };

            return response;
        }
    }

}
