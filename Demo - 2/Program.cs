using System.Text;
using System.Threading.Channels;

namespace Demo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region String format


            // String Formatting 
            // Equaltion : X + Y = 12 

            // int X = 3 , Y = 4 ;

            // 1- String cocatnation

            // string Message = "Equaltion : " + X + " + " + Y + " = " + (X+Y);

            //Console.WriteLine(Message);

            // String : Immutable -> Can't change its value after creation

            // 2- String format 

            //string Message = string.Format("Equaltion : {0} + {1} = {2}" , X , Y , X+ Y);
            //Console.WriteLine(Message);

            // 3- String interpolution
            // $ :

            //string Message = $"Equaltion : {X} + {Y} = { X + Y }";
            //
            //Console.WriteLine(Message);

            #endregion

            #region 1- conditional control statements  ( if , Switch case )
            #region IF & Switch Ex 01

            // Control statements 
            // control statements : 1- conditional control statements  ( if , Switch case )
            // control statements : 2- Loop control statements ( for , foreach , while , do while )

            // Console.WriteLine("hellow world");
            // Console.WriteLine("hellow world");
            // Console.WriteLine("hellow world");
            // Console.WriteLine("hellow world");

            // control statements : 1- conditional control statements  ( if , Switch case )

            // 1- Using If

            // Console.Write("Enter The Number OF Mounth in The First 1st Quarter : ");
            // int MounthNum = int.Parse(Console.ReadLine());

            // 1-- Jan
            // 2-- Feb 
            // 3-- Feb

            // Console.WriteLine("Jan");
            // Console.WriteLine("Feb");
            // Console.WriteLine("Mar");

            // if (/*Expression*/ )
            // {
            //     // code 
            //     // This code will be executed when the condition is true 
            // }

            // if (MounthNum == 1) 
            // {
            //     Console.WriteLine("Jan");
            // }
            // 
            // if (MounthNum == 2) 
            // {
            //     Console.WriteLine("Feb");
            // }
            // 
            // if (MounthNum == 3) 
            // {
            //     Console.WriteLine("Mar");
            // }


            // if (MounthNum == 1)
            // {
            //     Console.WriteLine("Jan");
            // }
            // 
            // else if (MounthNum == 2)
            // {
            //     Console.WriteLine("Feb");
            // }
            // 
            // else if (MounthNum == 3)
            // {
            //     Console.WriteLine("Mar");
            // }
            // 
            // else {
            // 
            //     Console.WriteLine("invalid Number !");
            // }


            /////////
            /// 2- Using Switch  


            // switch (/*Expression*/ )
            // {
            //     case 
            //
            // }


            //  Console.Write("Enter The Number OF Mounth in The First 1st Quarter : ");
            //  int MounthNum = int.Parse(Console.ReadLine());
            // 
            //  // Jump Table
            // 
            //  switch (MounthNum)
            //  {
            // 
            //      case 1:
            //          Console.WriteLine("Jun");
            //          break;
            // 
            //      case 2:
            //          Console.WriteLine("Feb");
            //          break;
            // 
            //      case 3:
            //          Console.WriteLine("Mar");
            //          break;
            // 
            //      default:
            //          Console.WriteLine("Invalid Number ! ");
            //          break;
            //  } 
            #endregion

            #region if & sWITCH ex 02 
            // Console.Write("Enter You Name : ");
            // string Name = Console.ReadLine();

            // Hi Ahmed 

            // if (Name == "Ahmed" || /* && */ Name == "ahmed")
            // {
            //     Console.WriteLine("Hi Ahmed ");
            // }
            // else if (Name == "Omar")
            // {
            //     Console.WriteLine("Hi Omar ");
            // }
            // else if (Name == "Ali")
            // {
            //     Console.WriteLine("Hi Ali "); 
            // }
            // else if (Name == "Mariam")
            // {
            //     Console.WriteLine("Hi Mariam "); 
            // }

            // switch (Name) 
            // {
            //     case "Ahmed":
            //     case "ahmed":
            //         Console.WriteLine("Hi Ahmed");
            //         break;
            // 
            //     case "Ali":
            //         Console.WriteLine("Hi Ali");
            //         break;
            // 
            //     case "Mariam":
            //         Console.WriteLine("Hi Mariam");
            //         break;
            // 
            // } 
            #endregion

            #region Ex 03 
            // Console.WriteLine("Enter You Age : ");
            // 
            // int Age = int.Parse(Console.ReadLine());

            // 1- using if : 

            // if (Age > 18)
            // {
            //     Console.WriteLine("Welcom ");
            // }
            // 
            // else if (Age < 18)
            // {
            //     Console.WriteLine("Bye Bye !");
            // }
            // else {
            //     Console.WriteLine("Equal !!");
            // 
            // }

            // 2- Switch 

            // switch (Age)
            // {
            //     case > 18:
            //         Console.WriteLine("Welcom");
            //             break;
            //     case < 18:
            //         Console.WriteLine("Bye Bye ");
            //             break;
            //     default:
            //         Console.WriteLine("Equal");
            //             break;
            // } 

            #endregion

            #region C# 7.0 
            // object Object = new object();
            // 
            // Object = "Ahmed";
            // // Object = 1;
            // 
            // switch (Object)
            // {
            //     case int X when X > -12:
            //         Console.WriteLine("Int Object ");
            //         break;
            // 
            //     case string X when X.Length > 4:
            //         Console.WriteLine("String Object ");
            //         break;
            // } 
            #endregion


            #region C# 8.0
            // string Input = Console.ReadLine();
            // // 1 
            // // 2
            // // 3
            // 
            // 
            // 
            // string Output = Input switch 
            // {
            //     "1" => "Option 1",
            //     "2" => "Option 2",
            //     "3" => "Option 3", 
            //     _ => "Unsupport Option !!"
            // 
            // };
            // 
            // Console.WriteLine(Output); 
            #endregion

            #endregion

            #region 2- Loop control statements ( for , foreach , while , do while )

            #region For - Foreach
            // 2 - Loop control statements( for , foreach , while , do while )

            //  Console.WriteLine("Hello World ");

            // 1- For loop

            // for (/* statement ; Expression ; Statement */ )
            // {
            //     // Code 
            //     // That Code will be repeated
            // }

            // for (int i = 0; i <= 10; i++)
            // {
            //     Console.WriteLine("Hello World " );
            // 
            // }

            // for (int i = 1; i <= 10; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // 2- forEach

            // int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            // // 
            // // for (int i = 0; i < Numbers.Length; i++) {
            // //     Console.WriteLine(Numbers[i]);
            // // }
            // 
            // foreach (int N in Numbers)
            // {
            //     Console.WriteLine(N);
            // } 
            #endregion

            #region While - do While
            // While

            // while (/*Expression*/) 
            // { 
            //     // Code
            //     // that code will be repeated while the expression is true
            // }


            // while (true) {
            //     Console.WriteLine("HHHHH");
            // }
            // int i = 1;
            // while (i <=10 )
            // {
            //     Console.WriteLine("Hello world");
            //     i++;
            // }
            // Console.WriteLine(i);



            // do  while

            // do 
            // { 
            //         // code 
            //         //this code will be executed first
            // }
            // while (/*Expression*/);

            // int i = 11;
            // 
            // do 
            // {
            //     Console.WriteLine("hello world ");
            //     i++;
            // }
            // while (i <=10);


            // int Number01;
            // bool Flag;
            // do
            // {
            //     Console.Write("Even Num : ");
            //     Flag = int.TryParse(Console.ReadLine() , out Number01);
            // }
            // while (Number01 % 2 != 0 || Flag == false);
            // 
            // Console.WriteLine(Number01); 
            #endregion







            #endregion

            #region String
            // string : reference type : HEAP (Class)
            // Immutable type : Can't Change its value after creatation

            // string S01;

            // Declare for reference (Pointer) from type 'Strin'
            // S01 : can refer to object from 'String'
            // S01 : Refer to Null

            // 8 Bytes will be allocated at Stack for reference 'S01'
            // 8 Bytes will be allocated at HEAP


            // S01 = new string("Ahmed");

            // S01 = "Ahmed"; // Syntax sugar 

            // new :

            // 1- Allocate the number of required bytes for the object at HEAP 
            // 2- Initialized the allocated bytes with the default value 
            // 3- Call user-defined constructor is exists
            // 4- Assign the object to the reference 

            // Console.WriteLine(S01.GetHashCode());  // Id : indicate Address 

            // S01 = "Ali";  // Syntax sugar 

            // new 
            // 1- Allocate the number of required bytes for the object at HEAP 
            // 2- Initialized the allocated bytes with the default value 
            // 3- Call user-defined constructor is exists
            // 4- Assign the object to the reference 
            // Console.WriteLine(S01.GetHashCode());


             // string Message = "Hello ";
             // 
             // Console.WriteLine("Message : " + Message);
             // Console.WriteLine("HashCode : " + Message.GetHashCode());
             // Console.WriteLine();
             // 
             // Message += "Ahmed";
             // Console.WriteLine("Message : " + Message);
             // Console.WriteLine("HashCode : " + Message.GetHashCode()); 
            #endregion

            #region StringBuillder
            // StringBuillder : Class (Reference Type ) : HEAP 
            // Mutable DataType : Can Change its value after creatation
            // StringBuilder S01;

            // Declare for reference (Pointer) from type 'StringBillding'
            // S01 : can refer to object from 'StringBillding'
            // S01 : Refer to Null

            // S01 = new StringBuilder("Hello ");

            // New :
            // 1- Allocate the number of required bytes for the object at HEAP 
            // 2- Initialized the allocated bytes with the default value 
            // 3- Call user-defined constructor is exists
            // 4- Assign the object to the reference 

            //Console.WriteLine("S01 : " + S01);
            //Console.WriteLine("S01 HashCode : " , S01.GetHashCode());
            //Console.WriteLine();
            //
            //S01.Append("Ahmed ");
            //
            //Console.WriteLine("S01 : " + S01);
            //Console.WriteLine("S01 HashCode : ", S01.GetHashCode());
            //Console.WriteLine(); 
            #endregion

            #region String method
            // string S01 = "Hello World ";
            // 
            // string result = S01.Substring(S01.Length);
            // 
            // Console.WriteLine(result); 
            #endregion

        }
    }
}
