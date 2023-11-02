namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
        [Fact]
        public void WhenCreated_HasCorrectProperties()
        {
            Vehicle megansCar = new Vehicle(4, "Green");

            Assert.Equal(4, megansCar.NumberOfWheels);
            Assert.Equal("Green", megansCar.Color);
            Assert.Equal(0, megansCar.MilesDriven);
        }

        // This test needs some work!
        [Fact]
        public void Summary_ReturnsInfoAboutVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");

            var expected = "This Blue vehicle has 2 wheels, and has driven 0 miles.";
            string actual = andysBike.Summary();

            Assert.Equal(expected, actual);
        }
        // Add more tests here!
        [Fact]
        public void WhenDrivenMilesIncrease()
        {
            Vehicle megansCar = new Vehicle(4, "Green");
            var currentMiles = megansCar.MilesDriven;

            Assert.Equal(currentMiles, megansCar.MilesDriven);

        }

        [Fact]
        public void Paint_WillPaintCarToNewColor()
        {
            Vehicle megansCar = new Vehicle(4, "Green");
            var newColor = "Red";
            megansCar.Paint(newColor);

            Assert.Equal(newColor, megansCar.Color);
        }

    }
}