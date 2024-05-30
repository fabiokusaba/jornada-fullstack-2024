namespace Fina.Core;

public static class Configuration
{
    public const int DefaultSatusCode = 200;
    public const int DefaultPageNumber = 1;
    public const int DefaultPageSize = 25;
    
    public static string BackendUrl { get; set; } = "http://localhost:5248";
    public static string FrontendUrl { get; set; } = "http://localhost:5117";
}