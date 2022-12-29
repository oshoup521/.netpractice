Console.WriteLine("Hello, World!");

string name = "Osho";
Console.WriteLine(name);

bool choice = true;
bool newChoice = false;
Console.WriteLine("choices are {0},{1}",choice,newChoice);

var person = new {
    firstName = "Osho",
    lastName = "Upadhyay"
};
Console.WriteLine(person.firstName+" "+person.lastName);

var student = "ashutosh";
Console.WriteLine("my name is {0}",student);

dynamic address = "shivaji nagar,pune";
Console.WriteLine("address is "+address);

int[] arr = {1,2,3,4,5};
foreach(var i in arr){
    Console.Write(i+" ");
}