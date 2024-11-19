using System;

public interface IProduct
{
    void DisplayInfo();
}

public class ProductA : IProduct
{
    public void DisplayInfo()
    {
        Console.WriteLine("This is Product A.");
    }
}

public class ProductB : IProduct
{
    public void DisplayInfo()
    {
        Console.WriteLine("This is Product B.");
    }
}
public interface ProductFactory
{
    
  public IProduct CreateProduct();
}
public class ProductAFactory : ProductFactory
{
    
    public IProduct CreateProduct()
    {
        return new ProductA();
    }
}

public class ProductBFactory : ProductFactory
{

    public IProduct CreateProduct()
    {
        return new ProductB();
    }
}


// Violating Factory Pattern: Direct instantiation in the client code


public class Program
{
    public static void Main()
    {
      ProductFactory factory = new ProductAFactory();
      IProduct product = factory.CreateProduct();
      product.DisplayInfo();
      factory = new ProductBFactory();
      product = factory.CreateProduct();
      product.DisplayInfo();
    }
}