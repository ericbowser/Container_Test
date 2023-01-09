namespace Container_Test;

public class ContainerTest
{
    [Fact]
    public void TestContainer()
    {
        // Arrange
        var container = new Container.Container();
        container.Register<IMotorcycle, Motorcycle>();
        container.Register<ICar, Car>();
        
        // Act
        var result = (Motorcycle)container.GetInstance<IMotorcycle, Motorcycle>();


        //Assert
        Assert.Contains(result.Handlebars, "Motorcycle handlebars");
    }

    public class Car : ICar
    {
        
    }

    public class Motorcycle : IMotorcycle
    {
        public string Handlebars => "Motorcycle handlebars";
    }

    public interface ICar
    {
        public string Handlebars => "Car Steering Wheel";
    }

    public interface IMotorcycle
    {
        
    }
}
