using System;

class program
{
	static void Main()

	{
		//implicit conversion when changing from a smaller datatype to a bigger and there is no loss of info
		//int i = 100;

		//float f = i;
		//Console.WriteLine(f);

		//explicit conversion when there is a loss of information
		//float f = 123.35F;
		//int i = (int)f; //<-- type cast() operator  // or int i = Convert.Toint32(f); which is the convert class
		//Console.WriteLine(i);

		//parse method from string to integer
		//string strnumber = "100";
		//int i = int.Parse(strnumber);
		//Console.WriteLine(i);


		//tryparse method. return type is boolean.
		//string strnumber = "100fg";
		//int result = 0;
		//bool isconvseccessful = int.TryParse(strnumber, out result);
		//if (isconvseccessful)
		//{
			//Console.WriteLine(result);
		//}
		//else
        //{
			//Console.WriteLine("enter a valid number");
        //}
	//}
}
