using System.Text.Json.Serialization;

namespace RestAPI_CSharp.src.Models
{
    public class Book
    {
        public uint Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsRented { get; set; }

    }
}