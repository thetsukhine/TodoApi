namespace TodoApi.Models
{
    public class PayLoad
    {

        public long Id { get; set; }
        public int? temperature { get; set; }

        public int? humidity { get; set; }

        public bool? occupancy { get; set; }

    }
}
