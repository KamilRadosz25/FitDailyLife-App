using System;

namespace FitDailyLife.Models
{
    public class MeasureDetailsDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int? ChestSize { get; set; }
        public int? ArmSize { get; set; }
        public int? BeltSize { get; set; }
        public int? WaistSize { get; set; }
        public int? ThighSize { get; set; }
    }
}
