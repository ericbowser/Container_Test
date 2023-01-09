namespace Container_Test;

public class ContainerTest
{
    [Fact]
    public void TestContainer_Motorcycle()
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
    
    [Fact]
    public void TestContainer_Car()
    {
        // Arrange
        var container = new Container.Container();
        container.Register<IMotorcycle, Motorcycle>();
        container.Register<ICar, Car>();
        
        // Act
        var result = (Car)container.GetInstance<ICar, Car>();


        //Assert
        Assert.Contains(result.Handlebars, "Car Steering Wheel");
    }

    public class Car : ICar
    {
        public string Handlebars => "Car Steering Wheel";
    }

    public class Motorcycle : IMotorcycle
    {
        public string Handlebars => "Motorcycle handlebars";
    }

    public interface ICar
    {
    }

    public interface IMotorcycle
    {
    }
}
