// int height = 60;

// if(height>=42 && height <=78){
//     Console.WriteLine("Allowed");
// }
// else
// {
//     Console.WriteLine("Not Allowed");
// }

// bool isCompleted = false;

// if(isCompleted){
//     Console.WriteLine("Order Complete!");
// }
// else
// {
//     Console.WriteLine("Order is still in process");
// }

// string[] food = {"Pizza", "Spaghetti", "Pasta", "Burger"};
// foreach (string item in food)
// {
//     Console.WriteLine(item);
// }
// Random rand = new Random();
// for(int i = 0; i<=10; i++){
//     Console.WriteLine($"{i} : {rand.Next(2,20)}");
// }

// int[] array = new int[5];
// int[] array2 =  {1,2,3,4,5};
// int[] numArray;
// numArray = new int[] {1,2,3,4,5};

// for(int i=0; i<numArray.Length; i++){
//     Console.WriteLine(numArray[i]);
// }
// foreach (int i in numArray)
// {
//     Console.WriteLine(i);
// }

string[] myCars = { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"}; 
foreach (string car in myCars)
{
    // We no longer need the index, because variable 'car' already represents each indexed value
    Console.WriteLine($"I own a {car}");
}