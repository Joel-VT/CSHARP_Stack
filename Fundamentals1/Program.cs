for(int i=1; i<=255; i++){
    Console.WriteLine(i);
}

Random value = new Random();
for(int i=0; i<5; i++){
    Console.WriteLine(value.Next(10,21));
}


for( int i = 1; i <= 100; i++ ){
    if(i%3==0 && i%5==0){
        Console.WriteLine("FizzBuzz");
    }
    else if(i%5==0){
        Console.WriteLine("Buzz");
    }
    else if(i%3==0){
        Console.WriteLine("Fizz");
    }
}

int x = 1;
while(x<=255){
    Console.WriteLine(x);
    x++;
}

x = 0;
while(x<5){
    Console.WriteLine(value.Next(10,21));
    x++;
}

x = 1;
while(x <= 100){
    if(x%3==0 && x%5==0){
        Console.WriteLine("FizzBuzz");
    }
    else if(x%5==0){
        Console.WriteLine("Buzz");
    }
    else if(x%3==0){
        Console.WriteLine("Fizz");
    }
    x++;
}