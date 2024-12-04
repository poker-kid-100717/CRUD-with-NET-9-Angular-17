namespace CRUD_with_NET_9_Angular_17.Server.Models
{
    public class AddCaseRequestDto
    {
        public string CaseNumber { get; set; }
        public string Defendant { get; set; }
        public string Plaintiff { get; set; }
        public string Officer { get; set; }
        public int BadgeNumber { get; set; }
        public string DescriptionOfIncident { get; set; }
    }
}
