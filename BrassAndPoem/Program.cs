
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Trumpet",
        Price = 15.99M,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "Tuba",
        Price = 100.00M,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "French Horn",
        Price = 51.99M,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "Trombone",
        Price = 30.50M,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "Bugle",
        Price = 10.20M,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "Leaves of Grass by Walt Whitman",
        Price = 6.99M,
        ProductTypeId = 2,
    },
    new Product()
    {
       Name = "Love is a Dog from Hell by Charles Bukowski",
       Price = 10.99M,
       ProductTypeId = 2,
    },
    new Product()
    {
        Name = "Ariel by Sylvia Plath",
        Price = 7.99M,
        ProductTypeId = 2,
    },
    new Product()
    {
        Name = "The Iliad by Homer",
        Price = 11.55M,
        ProductTypeId = 2,
    },
    new Product()
    {
        Name = "Shakespeare's Sonnets",
        Price = 5.99M,
        ProductTypeId = 2,
    },
    new Product()
    {
        Name = "The Complete Poems of Emily Dickinson",
        Price = 20.99M,
        ProductTypeId = 2,
    }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 

List<ProductType> productTypes = new List<ProductType>()
{
  new ProductType()
  {
      Id = 1,
      Title = "Brass Instruments",
  },  
  new ProductType()
  {
    Id = 2,
    Title = "Poems"  
  }
};
//put your greeting here

string greeting = @"Welcome to Brass & Poem!";
Console.WriteLine(greeting);

//implement your loop here
string choice = null;
while (choice != "5")
{
    DisplayMenu(products, productTypes);
    choice = Console.ReadLine().Trim();

    if (string.IsNullOrEmpty(choice)) continue;

    if (choice == "1") 
    {
        DisplayAllProducts(products, productTypes);
    }
   else if (choice == "2")
    {
        DeleteProduct(products, productTypes);
    }
    else if (choice == "3")
    {
        AddProduct(products, productTypes);
    }
    /* 
    else if (choice == "4")
    {
        UpdateProduct(products, productTypes);
    }
    */
    else if (choice == "5")
    {
        Console.WriteLine("Bye bye!");
    }
    
}



// functions
void DisplayMenu(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine(@"
1. Display all products
2. Delete a product
3. Add a new product
4. Update product properties
5. Exit");
};
/*
{
    throw new NotImplementedException();
}
*/

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    for (int i = 0; i < products.Count; i++)
    {
        ProductType matchType = null;
        foreach (ProductType type in productTypes)
        {
            if (type.Id == products[i].ProductTypeId)
            {
                matchType = type;
            }
        }
        Console.WriteLine($"{i + 1}. {products[i].Name} costs ${products[i].Price} and is in the category for 5{matchType.Title}");
    }
    //throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);
    
    Console.WriteLine("Enter the number of a product to delete: ");

    int choice = int.Parse(Console.ReadLine().Trim());

    Product removeThis = products[choice - 1];
    products.Remove(removeThis);

    Console.WriteLine($"{removeThis.Name} has been deleted");
    //throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{

    Console.WriteLine("Enter the name of a product to add: ");
    string name = Console.ReadLine().Trim();
    //throw new NotImplementedException();
}

/*

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}
*/

// don't move or change this!
public partial class Program { }