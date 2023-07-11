namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }

    public int? temperature { get; set; }

    public int? humidity { get; set; }

    public bool? occupancy { get; set; }

    public PayLoad? data { get; set; }   

}