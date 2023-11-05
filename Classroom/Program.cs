using Classroom;
using Classroom.Exceptions;

#region Indexer
//Library library = new();

//Book book = new();

//book.Id = 1;
//book.Name = "Atomic habits";

//library[0] = book;

//Console.WriteLine(library[0].Name);


//Student student1 = new();

//student1.Id = 1;
//student1.Name = "Nisa";

//Classroom1 classroom = new();

//classroom[0] = student1;

//Console.WriteLine(classroom[0].Name);

#endregion 

#region Exceptions
try
{

    int[] nums = new int[0];
    nums[2] = 100;


    int a = 5;
    int b = 0;

    int result = a / b;

}

catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch(NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}
catch(AggregateException ex)
{
    Console.WriteLine(ex.Message);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}

finally
{
    Console.WriteLine("SALAM");
}


static void Register(string username, string password)
{

    bool isSuccess = false;

    try
    {
        if (username == "Semed123")
        {
            Console.WriteLine("Registered successfully");
            isSuccess = true;
        }
        else
        {
            throw new RegisterFailedExceptions("Register failed custom");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    finally
    {
        SendEmail(isSuccess);
    }
}

Register("Semed12", "Daddssdsd");



static void SendEmail(bool isSuccess)
{
    if (isSuccess)

    {
        Console.WriteLine("Success register email");
    }
    else
    {
        Console.WriteLine("Failed register email");

    }

}

#endregion

