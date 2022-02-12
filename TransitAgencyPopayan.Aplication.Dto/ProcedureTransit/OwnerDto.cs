using TransitAgencyPopayan.Aplication.Dto.Base;

namespace TransitAgencyPopayan.Aplication.Dto.ProcedureTransit
{
    public class OwnerDto : DataTransferObjectBase
    {
        public int OwnerId { get; set; }

        public string Identification { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Adress { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}