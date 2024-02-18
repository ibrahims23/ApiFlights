using System;
using System.Xml.Serialization;

namespace getAvailabilityResponse.Models
{
    public class SoapEnvelope
    {
        public SoapBody Body { get; set; }
    }

    public class SoapBody
    {
        public AirAvailRS AirAvailRS { get; set; }
    }

    public class AirAvailRS
    {
        public string EchoToken { get; set; }
        public string PrimaryLangID { get; set; }
        public string SequenceNmbr { get; set; }
        public string TransactionIdentifier { get; set; }
        public string Version { get; set; }
        public Success Success { get; set; }
        public Warnings Warnings { get; set; }
        public OriginDestinationInformation[] OriginDestinationInformation { get; set; }
        public AAAirAvailRSExt AAAirAvailRSExt { get; set; }
        public Errors Errors { get; set; }
    }

    public class Success { }

    public class Warnings { }

    public class OriginDestinationInformation
    {
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public OriginLocation OriginLocation { get; set; }
        public DestinationLocation DestinationLocation { get; set; }
        public OriginDestinationOptions OriginDestinationOptions { get; set; }
    }

    public class OriginLocation
    {
        public string LocationCode { get; set; }
        public string Text { get; set; }
    }

    public class DestinationLocation
    {
        public string LocationCode { get; set; }
        public string Text { get; set; }
    }

    public class OriginDestinationOptions
    {
        public OriginDestinationOption OriginDestinationOption { get; set; }
    }

    public class OriginDestinationOption
    {
        public FlightSegment FlightSegment { get; set; }
    }

    public class FlightSegment
    {
        public DateTime ArrivalDateTime { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public string FlightNumber { get; set; }
        public string RPH { get; set; }
        public DepartureAirport DepartureAirport { get; set; }
        public ArrivalAirport ArrivalAirport { get; set; }
    }

    public class DepartureAirport
    {
        public string LocationCode { get; set; }
        public string Terminal { get; set; }
    }

    public class ArrivalAirport
    {
        public string LocationCode { get; set; }
        public string Terminal { get; set; }
    }

    public class AAAirAvailRSExt
    {
        public PricedItineraries PricedItineraries { get; set; }
    }

    public class PricedItineraries
    {
        public PricedItinerary PricedItinerary { get; set; }
    }

    public class PricedItinerary
    {
        public string SequenceNumber { get; set; }
        public AirItinerary AirItinerary { get; set; }
        public AirItineraryPricingInfo AirItineraryPricingInfo { get; set; }
    }

    public class AirItinerary
    {
        public OriginDestinationOptions OriginDestinationOptions { get; set; }
    }

    public class AirItineraryPricingInfo
    {
        public string PricingSource { get; set; }
        public ItinTotalFare ItinTotalFare { get; set; }
        public PTC_FareBreakdowns PTC_FareBreakdowns { get; set; }
    }

    public class ItinTotalFare
    {
        public BaseFare BaseFare { get; set; }
        public TotalFare TotalFare { get; set; }
    }

    public class BaseFare
    {
        public string Amount { get; set; }
        public string CurrencyCode { get; set; }
        public string DecimalPlaces { get; set; }
    }

    public class TotalFare
    {
        public string Amount { get; set; }
        public string CurrencyCode { get; set; }
        public string DecimalPlaces { get; set; }
    }

    public class PTC_FareBreakdowns
    {
        public PTC_FareBreakdown PTC_FareBreakdown { get; set; }
    }

    public class PTC_FareBreakdown
    {
        public string PricingSource { get; set; }
        public PassengerTypeQuantity PassengerTypeQuantity { get; set; }
        public FareBasisCodes FareBasisCodes { get; set; }
        public PassengerFare PassengerFare { get; set; }
    }

    public class PassengerTypeQuantity
    {
        public string Code { get; set; }
        public string Quantity { get; set; }
    }

    public class FareBasisCodes
    {
        public string FareBasisCode { get; set; }
    }

    public class PassengerFare
    {
        public BaseFare BaseFare { get; set; }
        public Taxes Taxes { get; set; }
        public Fees Fees { get; set; }
        public TotalFare TotalFare { get; set; }
    }

    public class Taxes
    {
        public Tax[] Tax { get; set; }
    }

    public class Tax
    {
        public string Amount { get; set; }
        public string CurrencyCode { get; set; }
        public string DecimalPlaces { get; set; }
        public string TaxCode { get; set; }
        public string TaxName { get; set; }
    }

    public class Fees
    {
        public Fee[] Fee { get; set; }
    }

    public class Fee
    {
        public string Amount { get; set; }
        public string CurrencyCode { get; set; }
        public string DecimalPlaces { get; set; }
        public string FeeCode { get; set; }
    }

    public class Errors { }
}
