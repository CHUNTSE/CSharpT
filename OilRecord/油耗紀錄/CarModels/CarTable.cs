namespace 油耗紀錄.CarModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarTable")]
    public partial class CarTable
    {
        public int Id { get; set; }

        public DateTime RefuelingDate { get; set; }

        public double Liter { get; set; }

        public double Kilometer { get; set; }
    }
}
