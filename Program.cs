namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[3]; //declare an array of int type
            arrayNumbers[0] = 11; //initializing index 0
            arrayNumbers[1] = 22;
            arrayNumbers[2] = 33;

            arrayNumbers[1] = 44; //element of array can be change by re-initializing
         
            Console.WriteLine(arrayNumbers[1]);

            //Display elements of an array
            for(int i=0; i<arrayNumbers.Length; i++)
            {
                Console.WriteLine(arrayNumbers[i]);
            }

            string[] arrayStrings = new string[3]; //declare an array of string type
            arrayStrings[0] = "abc";
            arrayStrings[1] = "def";
            arrayStrings[2] = "ghi";

            //taking multiple input from user at once for all index
            string[] arrayOfNames = new string[3];

            Console.Write("Enter your name by giving space in between: "); //split the string by checking the space
            string strName = Console.ReadLine();  //storing
            string[] names = strName.Split(' '); //Split is inbuilt method in string data type

            //to display all the elements of an array
            for (int i = 0; i < arrayStrings.Length; i++)
            {
                Console.WriteLine("Names" + arrayOfNames[i]);
            }


            //taking multiple input from user in loop for all index
            for (int i=0; i<arrayStrings.Length; i++)
            {
                Console.Write("Enter your name : ");
                arrayOfNames[i] = Console.ReadLine();
                Console.WriteLine("Hello " + arrayOfNames[i]);
            }


            //Taking Multiple Inputs (array elements) of INT data type
            Console.Write("Enter your Numbers : ");
            string[] numbs = Console.ReadLine().Split(' '); //Spliting

            int[] arrOfNums = new int[numbs.Length]; //creating an array
            for(int i=0; i<numbs.Length; i++)
            {
                arrOfNums[i] = Convert.ToInt32(numbs[i]); //conerting it into int data type
            }



        }
    }
}