using Shoop.Service.Services.Implementations;

ProductService productService = new ProductService();


ShowMenu();
void ShowMenu()
{
    Console.WriteLine("1-Create Product");
    Console.WriteLine("2-Show Products");
    Console.WriteLine("3-Show Id Product");
    Console.WriteLine("0-close");
}

string request = Console.ReadLine();
while (request != "0")
{
    switch (request) 
    {
        case "1":
            productService.CreateProduct(); 
            break;
        case "2":
            productService.ShowProduct(); 
            break;
        case "3":
            productService.ProductGetById();
            break;
        default:
            Console.WriteLine("Add correct option");
            break;
    }
    ShowMenu();
    request = Console.ReadLine();
}

