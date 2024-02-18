using System;
using System.Xml.Serialization;

namespace getAvailabilityRequest
{
    public class AirAvailRQ
    {
        public string EchoToken { get; set; }
        public string PrimaryLangID { get; set; }
        public int SequenceNmbr { get; set; }
        public string Target { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Version { get; set; }
        public POS POS { get; set; }
        public OriginDestinationInfo OriginDestinationInfo { get; set; }
        public TravelerInfoSummary TravelerInfoSummary { get; set; }
    }

    public class POS
    {
        public Source Source { get; set; }
    }

    public class Source
    {
        public string TerminalID { get; set; }
        public RequestorID RequestorID { get; set; }
        public BookingChannel BookingChannel { get; set; }
    }

    public class RequestorID
    {
        public string ID { get; set; }
        public int Type { get; set; }
    }

    public class BookingChannel
    {
        public int Type { get; set; }
    }

    public class OriginDestinationInfo
    {
        public DateTime DepartureDateTime { get; set; }
        public DateTime ReturnDateTime { get; set; }
        public string OriginLocation { get; set; }
        public string DestinationLocation { get; set; }
        public int AdultsCount { get; set; }
        public int InfantsCount { get; set; }
        public int DepartureVariance { get; set; }
        public int ReturnVariance { get; set; }
    }

    public class TravelerInfoSummary
    {
        public AirTravelerAvail AirTravelerAvail { get; set; }
    }

    public class AirTravelerAvail
    {
        public PassengerTypeQuantity PassengerTypeQuantity { get; set; }
    }

    public class PassengerTypeQuantity
    {
        public string Code { get; set; }
        public int Quantity { get; set; }
    }
}
