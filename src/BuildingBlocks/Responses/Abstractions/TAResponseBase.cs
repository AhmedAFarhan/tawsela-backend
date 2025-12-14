namespace BuildingBlocks.Responses.Abstractions
{
    public abstract class TAResponseBase
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public List<string> Errors { get; set; } = new();
        public string? TraceId { get; set; }
        public int Code { get; set; }
    }

    /*
     {
        "Code"    : 200
        "Success" : true/false,
        "Message" : "Loggedin Successfully",
        "Errors"  : [ "Invalid username or password" , ""],
        "TraceId" : ""ksdfkjsjdf-dsffdgdfg-fg22654-4556445,
        "Data"    : [ {id:1, name: cat1}, {id:2, name: cat2} ],,,  "dskljfhgkdjhgnkldffd5hgf5h465ghf4h65fgf;jgflhjkgfhklgfhlkjgfklhjgflkhlghlfghljlgfkh", {"PageIndex" : 3,"PageSize" : 10, "Count" : 1000,"Data" : [ {}, {}, {} ],}
     }
     */

}
