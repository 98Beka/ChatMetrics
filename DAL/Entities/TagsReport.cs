namespace DAL.Entities;
public class TagsReport {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Tag> Tags { get; set; }
}

public class Tag {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Count { get; set; }
    public int TagsReportId { get; set; } 
    public TagsReport TagsReport { get; set; }
}