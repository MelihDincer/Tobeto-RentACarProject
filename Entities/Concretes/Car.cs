using Core.Entities;

namespace Entities.Concretes
{
    public class Car : BaseEntity<int>
    {
        public int ModelId{ get; set; }
        public int ModelYear { get; set; }
        public string Plate { get; set; }
        public int State { get; set; } // 1-Avaible 2-Rented 3-Under Maitenance
        public double DailyPrice { get; set; }

        public Model Model { get; set; }

        public Car()
        {
            
        }

        public Car(int modelId, int modelYear, string plate, int state, double dailyPrice, Model model)
        {
            Id = modelId;
            ModelId = modelId;
            ModelYear = modelYear;
            Plate = plate;
            State = state;
            DailyPrice = dailyPrice;
        }
    }
}