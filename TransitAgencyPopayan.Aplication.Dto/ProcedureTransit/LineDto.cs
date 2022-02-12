namespace TransitAgencyPopayan.Aplication.Dto.ProcedureTransit
{
    public class LineDto : ProcedureTransitBaseDto
    {
        public int LineId { get; set; }

        public int BrandId { get; set; }

        public BrandDto Brand { get; set; }
    }
}
