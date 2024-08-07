namespace DotnetBackendPoc.Moduels
{
    public class ApiResponse
    {
        public int StatusCode;
        public string Message;
        public Result Data;
    }

    public class Result
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}

