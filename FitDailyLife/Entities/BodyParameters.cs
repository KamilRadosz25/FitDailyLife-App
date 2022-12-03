using System;

namespace FitDailyLife.Entities
{
    public class BodyParameters
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Weight { get; set; }
        public int? ChestSize { get; set; }
        public int? ArmSize { get; set; }
        public int? BeltSize { get; set; }
        public int? WaistSize { get; set; }
        public int? ThighSize { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
