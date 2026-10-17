public class Post
{
    public string Title{get;set;}=null!;
    public string Description{get;set;}=null!;
    public int LikeCount{get;set;}
    public List<string> Comments = new List<string>();
    public bool IsPublished{get;set;}
    public string Publish()
    {
        IsPublished= true;
        return "The post is published.";
    }
    public void Like()
    {
        LikeCount++;
    }
    public void Coment(string a)
    {
        Comments.Add(a);
    }
    
}