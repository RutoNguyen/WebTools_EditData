
namespace TPF.FFTools.Models
{
    public class Order
    {
        // GET: Order
        public class OrderChangeAddressRequest
        {
            public string ClubCode;
            public long OrderID;
            public string Street1;
            public string Street2;
            public string Suburb;
            public string State;
            public string Postcode;
            public string Country;
            public string CompanyName;
            public string Phone;
            public string Note;
            public bool IsRun;
        }
        public class OrderChangeAddressResponse
        {
            public long OrderId { get; set; }
            public long UploadID { get; set; }
            public string Status { get; set; }
            public string StatusNotes { get; set; }
            public string TPF_notes { get; set; }
            public long RecordID { get; set; }
            public string Street1 { get; set; }
            public string Street2 { get; set; }
            public string Suburb { get; set; }
            public string State { get; set; }
            public string Postcode { get; set; }
            public string Country { get; set; }
            public string CompanyName { get; set; }
            public string DPID { get; set; }
            public string BSPNumber { get; set; }
            public string BSPState { get; set; }
            public int CourierMethodID { get; set; }
            public string Phone { get; set; }
        }
        public class OrderChangeEnvelopeRequest
        {
            public string ClubCode;
            public long OrderID;
            public string FromEnvelopeID;
            public string ToEnvelopeID;
            public bool IsAllowFullyDelivered;
            public string Note;
            public bool IsRun;
        }
        public class OrderChangeEnvelopeResponse
        {
            public long ClubID { get; set; }
            public long OrderId { get; set; }
            public string ProductionStatus { get; set; }
            public string EnvelopeType { get; set; }
            public string TPF_notes { get; set; }
            public long LabelID { get; set; }
            public string OrderDetailCode { get; set; }
            public string Status { get; set; }
            public string LabelStatus { get; set; }
            public int CourierMethodID { get; set; }
            public string CourierTrackingNo { get; set; }
        }
        public class OrderManualRemoveItemRequest
        {
            public long clubID;
            public long orderID;
            public string itemType;
            public string clubRefID;
            public long flag;
            public string statusnotes;
            public string TPF_Notes;
            public bool IsRun;
        }
        public class OrderManualRemoveItemResponse
        {
            public long ClubID { get; set; }
            public long OrderId { get; set; }
            public string ProductionStatus { get; set; }
            public string EnvelopeType { get; set; }
            public string TPF_notes { get; set; }
            public long LabelID { get; set; }
            public string OrderDetailCode { get; set; }
            public string Status { get; set; }
            public string LabelStatus { get; set; }
            public int CourierMethodID { get; set; }
            public string CourierTrackingNo { get; set; }
        }

    }
}
