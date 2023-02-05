

namespace TPF.FFTools.Models
{
    public class BackOrder
    {
        // GET: BackOrder
        public class BackOrderChangeAddressRequest
        {
            public string ClubCode;
            public long UploadID;
            public string RecordIDList;
            public string Street1;
            public string Street2;
            public string Suburb;
            public string State;
            public string Postcode;
            public string Country;
            public string CompanyName;
            public string Phone;
            public string Email;
            public string Note;
            public bool IsRun;
        }
        public class BackOrderChangeAddressResponse
        {
            public long UploadID { get; set; }
            public string Status { get; set; }
            public string StatusNotes { get; set; }
            public string TPF_notes { get; set; }
            public long RecordID { get; set; }
            public string CompanyName { get; set; }
            public string Phone_No { get; set; }
            public string Street1 { get; set; }
            public string Street2 { get; set; }
            public string Suburb { get; set; }
            public string State { get; set; }
            public string Postcode { get; set; }
            public string Country { get; set; }
            public string DPID { get; set; }
            public string BSPNumber { get; set; }
            public string BSPState { get; set; }
        }

        public class BackOrderChangeReplaceItemRequest
        {
            public string ClubCode;
            public int UploadID;
            public string GroupIDList;
            public string RecordIDList;
            public string ItemType;
            public string FromItemID;
            public string ToItemID;
            public string Note;
            public bool IsRun;
        }
        public class BackOrderChangeReplaceItemResponse
        {
            public string TPF_notes { get; set; }
            public long RecordID { get; set; }
            public int GroupID { get; set; }
            public string MemberID { get; set; }
            public string PackType { get; set; }
            public string CardTypeFace { get; set; }
            public string LetterType { get; set; }
            public string EnvelopeType { get; set; }
            public string Status { get; set; }
        }

        public class BackOrderAddItemRequest
        {
            public string ClubCode;
            public int UploadID;
            public string GroupIDList;
            public string RecordIDList;
            public string ItemType;
            public string ItemID;
            public string Note;
            public bool IsRun;
        }
        public class BackOrderAddItemResponse
        {
            public string TPF_notes { get; set; }
            public long RecordID { get; set; }
            public int GroupID { get; set; }
            public string MemberID { get; set; }
            public string PackType { get; set; }
            public string CardTypeFace { get; set; }
            public string LetterType { get; set; }
            public string EnvelopeType { get; set; }
            public string Status { get; set; }
        }

        public class BackOrderRemoveItemRequest
        {
            public string ClubCode;
            public int UploadID;
            public string GroupIDList;
            public string RecordIDList;
            public string ItemType;
            public string ItemIDList;
            public string Note;
            public bool IsRun;
        }
        public class BackOrderRemoveItemResponse
        {
            public string TPF_notes { get; set; }
            public long UploadID { get; set; }
            public long RecordID { get; set; }
            public int GroupID { get; set; }
            public string MemberID { get; set; }
            public string PackType { get; set; }
            public string CardTypeFace { get; set; }
            public string LetterType { get; set; }
            public string EnvelopeType { get; set; }
            public string Status { get; set; }
        }
    }
}