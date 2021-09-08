using System;

public class Login
{
 
    private static string firstname;
	private static string lastname;
	private static int dob;
	private static string roles;
	private static string Gender;



	public static void CollectLoginDetails()
	{
		var UserInput = Validations.IsValidInput(Console.ReadLine());
		if (UserInput !=1 || 2 || 3)
        {
			Console.WriteLine("Please read the instructions and use the appropriate Input");
			Console.Clear();


        }
        else
        {
			switch (UserInput)
			{
				case 1:

					try
					{
						Console.WriteLine("Enter your FirstName");
						firstname = Console.ReadLine();
						Console.WriteLine("Enter your LastName");
						lastname = Console.ReadLine();
						Console.WriteLine("Enter your Date of birth");
						dob = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Enter your Gender");
						Gender = Console.ReadLine();
						Console.WriteLine("Enter your position");
						roles = Console.ReadLine();
						UserService userservice = UserInput.Add(FirstName, LastName, DOB, Gender, Roles)




					}

                    catch
                    
						(FormatException ex)
                    {
						Console.WriteLine(ex.Message);
						Console.ReadKey();
						Console.Clear();

                    }
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
						Console.ReadKey();
						Console.Clear();
							}
					break;
					}




            }

        }



}



}
