
class Mainclass
{
        public static string MissingDigit(string str) 
    {
        string [] digits;
        string result;

        digits = str.Split(' ');

        if((digits[0]=="x")&&((digits[1]=="+")||(digits[1]=="-")||(digits[1]=="*")||(digits[1]=="/")))
        {
        if(digits[1]=="+")
        {
            result = Convert.ToString(int.Parse(digits[4])-int.Parse(digits[2]));
        }
        else if(digits[1]=="-")
        {
            result = Convert.ToString(int.Parse(digits[4])+int.Parse(digits[2]));
        }
        else if(digits[1]=="*")
        {
            result = Convert.ToString(int.Parse(digits[4])/int.Parse(digits[2]));
        }
        else
        {
            result = Convert.ToString(int.Parse(digits[4])*int.Parse(digits[2]));
        }
        }

        else if((digits[1]=="x")&&((digits[2]=="+")||(digits[2]=="-")||(digits[2]=="*")||(digits[2]=="/")))
        {
        if(digits[2]=="+")
        {
            result = Convert.ToString((int.Parse(digits[5])-int.Parse(digits[3]))/int.Parse(digits[0]));
        }
        else if(digits[2]=="-")
        {
            result = Convert.ToString((int.Parse(digits[5])+int.Parse(digits[3]))/int.Parse(digits[0]));
        }
        else if(digits[2]=="*")
        {
            result = Convert.ToString((int.Parse(digits[5])/int.Parse(digits[3]))/int.Parse(digits[0]));
        }
        else
        {
            result = Convert.ToString((int.Parse(digits[5])*int.Parse(digits[3]))/int.Parse(digits[0]));
        }
        }

        else if((digits[3]=="x")&&((digits[1]=="+")||(digits[1]=="-")||(digits[1]=="*")||(digits[1]=="/")))
        {
        if(digits[1]=="+")
        {
            result = Convert.ToString((int.Parse(digits[5])-int.Parse(digits[0]))/int.Parse(digits[2]));
        }
        else if(digits[1]=="-")
        {
            result = Convert.ToString((int.Parse(digits[5])+int.Parse(digits[0]))/int.Parse(digits[2]));
        }
        else if(digits[1]=="*")
        {
            result = Convert.ToString((int.Parse(digits[5])/int.Parse(digits[0]))/int.Parse(digits[2]));
        }
        else
        {
            result = Convert.ToString((int.Parse(digits[5])*int.Parse(digits[0]))/int.Parse(digits[2]));
        }
        }

        else if((digits[2]=="x")&&((digits[1]=="+")||(digits[1]=="-")||(digits[1]=="*")||(digits[1]=="/")))
        {
        if(digits[1]=="+")
        {
            result = Convert.ToString(int.Parse(digits[4])-int.Parse(digits[0]));
        }
        else if(digits[1]=="-")
        {
            result = Convert.ToString(int.Parse(digits[4])+int.Parse(digits[0]));
        }
        else if(digits[1]=="*")
        {
            result = Convert.ToString(int.Parse(digits[4])/int.Parse(digits[0]));
        }
        else
        {
            result = Convert.ToString(int.Parse(digits[4])*int.Parse(digits[0]));
        }
        }

        else if((digits[4]=="x")&&((digits[1]=="+")||(digits[1]=="-")||(digits[1]=="*")||(digits[1]=="/")))
        {
        if(digits[1]=="+")
        {
            result = Convert.ToString(int.Parse(digits[0])+int.Parse(digits[2]));
        }
        else if(digits[1]=="-")
        {
            result = Convert.ToString(int.Parse(digits[0])-int.Parse(digits[2]));
        }
        else if(digits[1]=="*")
        {
            result = Convert.ToString(int.Parse(digits[0])*int.Parse(digits[2]));
        }
        else
        {
            result = Convert.ToString(int.Parse(digits[0])/int.Parse(digits[2]));
        }
        }

        else if((digits[5]=="x")&&((digits[1]=="+")||(digits[1]=="-")||(digits[1]=="*")||(digits[1]=="/")))
        {
        if(digits[1]=="+")
        {
            result = Convert.ToString((int.Parse(digits[0])+int.Parse(digits[2]))/int.Parse(digits[4]));
        }
        else if(digits[1]=="-")
        {
            result = Convert.ToString((int.Parse(digits[0])-int.Parse(digits[2]))/int.Parse(digits[4]));
        }
        else if(digits[1]=="*")
        {
            result = Convert.ToString((int.Parse(digits[0])*int.Parse(digits[2]))/int.Parse(digits[4]));
        }
        else
        {
            result = Convert.ToString((int.Parse(digits[0])/int.Parse(digits[2]))/int.Parse(digits[4]));
        }
        }

        else
        {
        result = "0";
        }
        
        return result;
    }

    static void Main() 
    {  

        // keep this function call here
        Console.WriteLine(MissingDigit(Console.ReadLine()));
    } 
}



