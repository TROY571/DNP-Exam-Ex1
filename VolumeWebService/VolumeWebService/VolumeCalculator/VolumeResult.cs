using System.ComponentModel.DataAnnotations;

namespace VolumeWebService.VolumeCalculator
{
    public class VolumeResult
    {
        [Key]public int id { get; set; }
        public string type { get; set; }
        public double height { get; set; }
        public double radius { get; set; }
        public double volume { get; set; }
    }
}