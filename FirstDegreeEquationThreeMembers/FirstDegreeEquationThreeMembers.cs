
namespace FirstDegreeEquation 
{   
    static class Mainclass
    {
        static int ix;
        static int iOperator;
        static char[] operators = {'+','-','*','/'};
        static int iEqual;
        static float result = 0;
        static string firstMember;
        static string firstPlusSecondMember;
        static string secondMember;
        static string thirdMember;

        public static string XFirstMember(string str)
        {
            if(firstMember.ToLower().Contains('x'))
            {
                if(firstMember.ToLower() == "x")
                {
                    if(str.Contains('+'))
                    {
                        result = (float.Parse(thirdMember) - float.Parse(secondMember));
                    }

                    else if(str.Contains('-'))
                    {
                        result = float.Parse(thirdMember) + float.Parse(secondMember);
                    }

                    else if(str.Contains('*'))
                    {
                        result = float.Parse(thirdMember) / float.Parse(secondMember);
                    }

                    else if(str.Contains('/'))
                    {
                        result = float.Parse(thirdMember) * float.Parse(secondMember);
                    }

                    else
                    {
                        return " Operador inválido.";
                    }
                }

                if(firstMember.ToLower() != "x")
                {
                    if(str.Contains('+'))
                    {
                        result = (float.Parse(thirdMember) - float.Parse(secondMember))/(float.Parse(firstMember.Trim('x')));
                    }

                    else if(str.Contains('-'))
                    {
                        result = (float.Parse(thirdMember) + float.Parse(secondMember))/(float.Parse(firstMember.Trim('x')));
                    }

                    else if(str.Contains('*'))
                    {
                        result = (float.Parse(thirdMember) / float.Parse(secondMember))/(float.Parse(firstMember.Trim('x')));
                    }

                    else if(str.Contains('/'))
                    {
                        result = (float.Parse(thirdMember) * float.Parse(secondMember))/(float.Parse(firstMember.Trim('x')));
                    }

                    else
                    {
                        return " Operador inválido.";
                    }
                }
            }

            return result.ToString();
        }

        public static string XSecondMember(string str)
        {
            if(secondMember.ToLower().Contains('x'))
                {
                    if(secondMember.ToLower() == "x")
                    {
                        if(str.Contains('+'))
                        {
                            result = float.Parse(thirdMember) - float.Parse(firstMember);
                        }

                        else if(str.Contains('-'))
                        {
                            result = float.Parse(firstMember) - float.Parse(thirdMember);
                        }

                        else if(str.Contains('*'))
                        {
                            result = float.Parse(thirdMember) / float.Parse(firstMember);
                        }

                        else if(str.Contains('/'))
                        {
                            result = float.Parse(thirdMember) * float.Parse(firstMember);
                        }

                        else
                        {
                            return "operador inválido.";
                        }
                    }

                    if(secondMember.ToLower() != "x")
                    {
                        if(str.Contains('+'))
                        {
                            result = (float.Parse(thirdMember) - float.Parse(firstMember))/float.Parse(secondMember.Trim('x'));
                        }

                        else if(str.Contains('-'))
                        {
                            result = float.Parse(firstMember) - float.Parse(thirdMember)/float.Parse(secondMember.Trim('x'));
                        }

                        else if(str.Contains('*'))
                        {
                            result = (float.Parse(thirdMember) / float.Parse(firstMember))/float.Parse(secondMember.Trim('x'));  
                        }

                        else if(str.Contains('/'))
                        {
                            result = (float.Parse(thirdMember) * float.Parse(firstMember))/float.Parse(secondMember.Trim('x'));  
                        }

                        else
                        {
                            return "operador inválido";
                        }
                    }
                }
            
            return result.ToString();

        }

         public static string XThirdMember(string str)
        {
            if(thirdMember.ToLower().Contains('x'))
                {
                    if(thirdMember.ToLower() == "x")
                    {
                        if(str.Contains('+'))
                        {
                            result = float.Parse(firstMember) + float.Parse(secondMember);
                        }

                        else if(str.Contains('-'))
                        {
                            result = float.Parse(firstMember) - float.Parse(secondMember);
                        }

                        else if(str.Contains('*'))
                        {
                            result = float.Parse(firstMember) * float.Parse(secondMember);
                        }

                        else if(str.Contains('/'))
                        {
                            result = float.Parse(firstMember) / float.Parse(secondMember);
                        }

                        else
                        {
                            return "operador inválido.";
                        }
                    }

                    if(thirdMember.ToLower() != "x")
                    {
                        if(str.Contains('+'))
                        {
                            result = (float.Parse(firstMember) + float.Parse(secondMember))/float.Parse(thirdMember.Trim('x'));
                        }

                        else if(str.Contains('-'))
                        {
                            result = (float.Parse(firstMember) - float.Parse(secondMember))/float.Parse(thirdMember.Trim('x'));
                        }

                        else if(str.Contains('*'))
                        {
                            result = (float.Parse(firstMember) * float.Parse(secondMember))/float.Parse(thirdMember.Trim('x'));
                        }

                        else if(str.Contains('/'))
                        {
                            result = (float.Parse(firstMember) / float.Parse(secondMember))/float.Parse(thirdMember.Trim('x'));
                        }

                        else
                        {
                            return "operador inválido.";
                        }
                    }
                }
                
            return result.ToString();
        }
        

        public static string MissingDigit(string str)
        {
            //x+10=20 x = 10 2x+10=20 x= 5 2+x=20 x=18 2+10x=20 x=1.8 2+10=x x=12 2+10= 10x x=1.2
            ix = str.IndexOf("x");
            iEqual = str.IndexOf("=");

            if(str.Contains('+'))
            {
                iOperator = str.IndexOf("+");
            }

            else if(str.Contains('-'))
            {
                iOperator = str.IndexOf("-");
            }

            else if(str.Contains('*'))
            {
                iOperator = str.IndexOf("*");
            }

            else if(str.Contains('/'))
            {
                iOperator = str.IndexOf("-");
            }

            else
            {
                return "Falta operador dos tipos (+,-,*,/) para a operação.";
            }

            /*Importante notar que o indice  = comprimento - 1, ou seja, o comprimento total de uma cadeia
              de strings é igual ao número do último indice + 1.*/

            firstMember = (str.Remove(iOperator)).Trim();
            firstPlusSecondMember = str.Substring(0,iEqual).Trim();
            secondMember = ((firstPlusSecondMember.Substring(iOperator)).Trim(operators)).Trim();
            thirdMember = ((str.Substring(iEqual)).Trim('=')).Trim();

            if(firstMember.Contains('x'))
            {
                return XFirstMember(str);
            }
            
            else if(secondMember.Contains('x'))
            {
                return XSecondMember(str);
            }

            else if (thirdMember.Contains('x'))
            {
                return XThirdMember(str);
            }
            
            else
            {
                return "Faltou evidenciar o x.";
            }
        }

        static void Main() 
        {  
            string Equation = System.Console.ReadLine();
            // keep this function call here
            try
            {
                Console.WriteLine(MissingDigit(Equation));
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Equação não suportada! \nTalvez voce tenha colocado mais de um operador como por exemplo: 5 + x * 10 = 3, como pode se ver temos dois operadores o + e o *. \nTalvez voce tenha colocado mais de três membros na equação, como por exemplo 10x + 10 + 3 + 5 + 10x = 3. \nUm exemplo certo seria 5 + x10 = 3. \n A equação tbm não suporta logaritmos ou potência. \n Mude sua equação e tente novamente.");
            }
        } 
    }
}



