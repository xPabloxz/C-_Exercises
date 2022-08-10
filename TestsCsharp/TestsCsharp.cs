
namespace TestsCsharp
{
    public class Tests
    {
        static void Main(string[] args) 
        {
            int number= 1;
            string name = "pablo";
            bool logic = false;
            int[] arr= {1,2,3,4,5};
            int a = 20;
            int b = 2;
            int c = 3;
            int d = 4;

            //System.Console.Writeline()

            /*It seems to work just with basic types.*/
            System.Console.WriteLine(number);
            System.Console.WriteLine(name);
            System.Console.WriteLine(logic);

            /*To work with arrays you gotta make a for or foreach statement like showned below.*/
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);    
            }
            
            foreach (int items in arr)
            {
                System.Console.WriteLine(items);
            }

             //System.Console.Readline()

            /*If you wanna put an input into one array from the readline console you gotta do this below*/
            string fruit = System.Console.ReadLine();
            String[] fruits = fruit.Split(' ',',');

            /*It just works with string types, another types you gotta convert to it's type*/
            number = int.Parse(System.Console.ReadLine());
            name = System.Console.ReadLine();
            logic = bool.Parse(System.Console.ReadLine());

            /*How to get a int array through multiple inputs*/
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(System.Console.ReadLine());
            }

            /*How to get a int array in one input, it's through a string splitted to a string array*/
            string ages= System.Console.ReadLine();
            string[] age= ages.Split(' ');

            for (int i =0; i < arr.Length ;i++)
            {
                arr[i]= int.Parse(age[i]);
            }
             
            Conditionals with (&&,||,==) statements

            if((a > b) || (c > d))
            {
                logic = true;
            }
            else if (d > a)
            {
                logic = true;
            }
            else
            {
                logic = false;
            }

            switch (a)
            {
                case 0:
                    a= 10;
                break;

                case 1:
                    a= 20;
                break;

                case 2:
                    a= 30;
                break;

                default:
                a= 50;
                break;
            }

            //Loops
            
            while(a < d)
            {
                a++;
            }

            do
            {
                a++;
                
            } while (a < d);

        }
    }
}