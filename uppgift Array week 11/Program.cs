//Create empty list of products
string[] productArray = new string[0];
int index = 0;
//Create loop asking user to add the product
while (true)
{
    Console.WriteLine("Input product: ");
    string data = Console.ReadLine();
    //If user input exit, break the loop, change to small leters, remove spaces
    if (data.ToLower().Trim() == "exit")
    {
        break;
    }
    //Expend the array with one product
    Array.Resize(ref productArray, productArray.Length + 1);
    productArray[index] = data;
    index++;
}
//Print the list of products
Console.WriteLine("Product list: ");
foreach (var item in productArray)
{
    Console.WriteLine(item);
}

// This is comment

