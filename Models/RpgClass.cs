using System.Text.Json.Serialization;

namespace DotNetCourse.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric
        
    }
}