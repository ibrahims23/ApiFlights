using getAvailabilityRequest;
using getAvailabilityResponse.Models;
namespace ApiFlights.Controllers
{

    public interface IApiServices
    {
        Task<AirAvailRS> GetAvailability(AirAvailRQ request);
    }

    public class ApiServices : IApiService
    {
        public async Task<AirAvailRS> GetAvailability(AirAvailRQ request)
        {

            return new AirAvailRS
            {
                EchoToken = "your_echo_token",
                PrimaryLangID = "en-us",
                SequenceNmbr = "1",
                TransactionIdentifier = "TID$127106902861951458177791",
                Version = "2006.01",
                Success = new Success(),
                Warnings = new Warnings(),
                OriginDestinationInformation = new[]
                {
                    new OriginDestinationInformation
                    {
                        DepartureDateTime = DateTime.Parse("2010-10-15T13:10:00"),
                        ArrivalDateTime = DateTime.Parse("2010-10-15T19:10:00"),
                        OriginLocation = new OriginLocation { LocationCode = "SHJ", Text = "Sharjah" },
                        DestinationLocation = new DestinationLocation { LocationCode = "CMB", Text = "Colombo" },
                        OriginDestinationOptions = new OriginDestinationOptions
                        {
                            OriginDestinationOption = new OriginDestinationOption
                            {
                                FlightSegment = new FlightSegment
                                {
                                    ArrivalDateTime = DateTime.Parse("2010-10-15T19:10:00"),
                                    DepartureDateTime = DateTime.Parse("2010-10-15T13:10:00"),
                                    FlightNumber = "G9507",
                                    RPH = "221698",
                                    DepartureAirport = new DepartureAirport { LocationCode = "SHJ", Terminal = "TerminalX" },
                                    ArrivalAirport = new ArrivalAirport { LocationCode = "CMB", Terminal = "TerminalX" }
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
