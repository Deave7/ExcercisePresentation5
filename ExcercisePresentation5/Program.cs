using System.Data;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace ExcercisePresentation5
{
    internal class Program
    {

        static void Exempel1() //Övning 1 
        {
            int i = 0; //initierar och sätter variablen i till 0 

            Console.WriteLine("Please enter a number: "); //Ber användaren om ett nummer
            int n = Convert.ToInt32(Console.ReadLine()); //initierar och sätter variablen n till det användaren skriver. Konvertarar från en string till en int 

            while (i < n) //Medans i är mindre än n körs loopen
            {
                Console.WriteLine(i + 1); //skriv ut i + 1
                i++; //lägg till 1 på i's värde
            }
        }

        static void Exempel2() //Övning 2 
        {

            Console.WriteLine("This part of the program will print all numbers between 1 and your input number, that you can't divide by 21 ");

            Console.WriteLine("Please enter a number: "); //Ber användaren om ett nummer
            int n = Convert.ToInt32(Console.ReadLine()); //initierar och sätter variablen n till det användaren skriver. Konvertarar från en string till en int 
            Console.WriteLine("");

            for (int i = 1; i <= n; i++) //så länge i är mindre eller likamed n kör vi loopen
            {
                if (i % 21 != 0) //om i dealas med 21 och resten INTE är 0 körs kodblocket
                    Console.WriteLine(i);
            }
        }

        static void Exempel3() //Övning 3 
        {
            Console.WriteLine("This part of the program will read a sequence of numbers and print the lowest and the highest number.");

            Console.WriteLine("How many numbers do you want to input?");
            int amountNums = Convert.ToInt32(Console.ReadLine()); //Initierar och sätter värdet på variablen amountNums till det användaren ger (antalet nummer de vill skriva in) 

            Console.WriteLine($"Please input {amountNums} number(s): "); //Ber användaren skriva i så många nummer de bad om 

            int[] numbers = new int[amountNums]; //Initierar fältet numbers med storleken på variablen amountNums

            for (int i = 0; i < amountNums; i++) //kör loopen sålänge i är midnre än amountNums
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine()); //sätter värdet på fältet numbers på indexplats i (nr på varvet i loopen)
            }

            Array.Sort(numbers); //Sorterar nummren i storleksordning 

            Console.WriteLine($"Smallest number: {numbers[0]}, largest number: {numbers[amountNums - 1]}"); //Skriver ut det högsta och lägsta nummret   
        }

        static void Exempel4() //Övning 4 
        {

            Console.WriteLine("This part of the program will calculate nFactorial / kFactorial. Please input n and k: "); // följande måste stämma 1 < k < n
            Console.WriteLine("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            //matte.... ingen aning om hur men så här kan man tydligen räkna
            BigInteger nFactorial = 1; //sätter variablen nFactorial från klassen BigInteger till 1
            for (int i = 1; i <= n; i++) //kör loopen så länge i är mindre än eller likamed n
            {
                nFactorial *= i; //lägg till gånger värdet på variablen i till nFactorial
            }

            //samma som ovan 
            BigInteger kFactorial = 1;
            for (int i = 1; i <= k; i++)
            {
                kFactorial *= i;
            }

            BigInteger result = nFactorial / kFactorial; //vårat resultat är nFactorial/kFactorial

            Console.WriteLine($"{n}!/{k}! = {result}"); //Skriver ut resultatet
        }

        static void Exempel5()//Övning 5 
        {
            Console.WriteLine("This part of the program will calculate nFactorial * kFactorial. Please input n and k: ");
            Console.WriteLine("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            //matte.... ingen aning om hur men så här kan man tydligen räkna
            BigInteger nFactorial = 1; //sätter variablen nFactorial från klassen BigInteger till 1
            for (int i = 1; i <= n; i++) //kör loopen så länge i är mindre än eller likamed n
            {
                nFactorial *= i; //lägg till gånger värdet på variablen i till nFactorial
            }

            //samma som ovan 
            BigInteger kFactorial = 1;
            for (int i = 1; i <= k; i++)
            {
                kFactorial *= i;
            }

            BigInteger kMinusNFactorial = 1;
            for (int i = 1; i <= k - n; i++)
            {
                kMinusNFactorial *= i;
            }

            BigInteger result = (nFactorial * kFactorial) / kMinusNFactorial; //vårat resultat

            Console.WriteLine($"({n}!*{k}) / {k}-{n}! = {result}"); //Skriver ut resultatet
        }

        static void Exempel6() //Övning 6 
        {
            Console.WriteLine("Please enter tvo integers n and x to preform the calculation: ");
            Console.WriteLine("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x: ");
            int x = Convert.ToInt32(Console.ReadLine());


            //matte.... ingen aning om hur men så här kan man tydligen räkna
            BigInteger sum = 1;
            BigInteger xPower = 1;
            for (int i = 1; i <= n; i++)
            {
                xPower *= x;
                BigInteger factorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }
                sum += factorial / xPower;
            }

            Console.WriteLine($"Sum = {sum}");

        }

        static void Exempel7() //Övning 7 
        {
            //För att skriva ut Fibonacciserien
            Console.WriteLine("Enter the number of elements: ");
            int number = int.Parse(Console.ReadLine());

            int n1 = 0; //första värdet i serien
            int n2 = 1; //andra värdet i serien
            Console.Write(n1 + " " + n2 + " "); //skriver ut första och andra värdet

            int n3 = 0; //intierar och sätter n3 till 0 
            int[] series = new int[number];
            for (int i = 2; i < number; i++) //loopen startar på 2 eftersom de första 2 värdena redan är utskrivna
            {
                //Räknar ut och skriver ut n3 
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                series[i] = n3;
                //Sätter värdet på de n1 och n2 till nästa varv av loopen 
                n1 = n2;
                n2 = n3;
            }


            int result = 0; //intierar variablen result till 0 (vi använder denna för att spara fältets series summa
            for (int i = 2; i < series.Length; i++) //går så många varv som series har värden 
            {
                result += series[i]; //lägg till series [i] till results värde 
            }
            result += 1; //lägger till den ursprungliga ettan som inte finns med i fältet 

            // Hittade en funktion för att få ut just summan ur ett fält t.ex: int result = numbers.Sum(); . den lilla snutten ersätter hela for loopen över.... 

            Console.WriteLine("\nSumman av talen är: " + result);

        }

        static void Exempel8() //Övning 8 
        {
            //Användar input och initiering av variabler
            Console.WriteLine("This part of the program is going to calculate the greates common divisor of two given numbers.");
            Console.WriteLine("Please enter two numbers, a and b: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            while (true) //loopar tills första if satsen blir sann och vi har hittat våran GCD
            {
                if (b == 0) //om b är likamed 0 
                {
                    Console.WriteLine("The GCD is: " + a);
                    return; //avbryter programmet
                }
                else //om inte if satsen blir sann 
                {
                    int c = (a % b); //int c initeras och sätts till modulus (resten) av a / b 
                    a = b;
                    b = c;
                }
            }
        }

        static void Exempel10() //Övning 10 
        {
            //Massa matte igen....

            Console.WriteLine("Please enter the number in the Catalan numbers that you want to show: ");
            int n = Convert.ToInt32(Console.ReadLine());

            BigInteger result = 1; //ett sätt att räkna ut det nte Catalan nummret 
            for (int i = 0; i < n; i++)
            {
                result *= (2 * n - i);
                result /= (i + 1);
            }

            Console.WriteLine($"Catalan number: {n} is: {result}");
        }

        static void Exempel11() //Övning 11 
        {

            //Läste uppgiften för dåligt och löste därför på ett annat sätt. Gjorde om sättet som alla hjärterkort skrivs ut till att passa övningen men behöll mitt orginalsätt för de andra tre färgerna.
            Console.WriteLine("Det här programmet kommer skriva ut alla 52 kort i en vanlig svensk kortlek\n");

            string[] colorName = { "Hjärter", "Klöver", "Spader", "Ruter" };
            string[] specialCards = { "Knäckt", "Dam", "Kung", "Äss" };
            string[] cardNumber = { "Två", "Tre", "Fyra", "Fem", "Sex", "Sju", "Åtta", "Nio", "Tio" };

            for (int i = 0; i <= 7; i++) //Loopen går så länge i är mindre eller likamed 7
            {
                if (i <= 1) //om i är mindre än eller lika med 1
                {
                    for (int j = 0; j < 13; j++) //loopen körs medans j är mindre än 13 
                    {
                        switch (j) //switch sats som 
                        {
                            case 0: //Om j är 0 skriver vi ut raden under
                                Console.WriteLine("Hjärter två");
                                break;

                            case 1:
                                Console.WriteLine("Hjärter tre");
                                break;

                            case 2:
                                Console.WriteLine("Hjärter fyra");
                                break;

                            case 3:
                                Console.WriteLine("Hjärter fem");
                                break;

                            case 4:
                                Console.WriteLine("Hjärter sex");
                                break;

                            case 5:
                                Console.WriteLine("Hjärter sju");
                                break;

                            case 6:
                                Console.WriteLine("Hjärter åtta");
                                break;

                            case 7:
                                Console.WriteLine("Hjärter nio");
                                break;

                            case 8:
                                Console.WriteLine("Hjärter tio");
                                break;

                            case 9:
                                Console.WriteLine("Hjärter knäckt");
                                break;

                            case 10:
                                Console.WriteLine("Hjärter Dam");
                                break;

                            case 11:
                                Console.WriteLine("Hjärter Kung");
                                break;

                            case 12:
                                Console.WriteLine("Hjärter Äss");
                                break;
                        }
                    }
                }
                //Ovan har vi skrivit ut alla hjärter kort, nedan kommer de resterande tre färgerna 

                else if (i <= 2) //om i mindre än eller likamed 2
                {
                    if (i == 1) //Om i är likamed 1
                    {
                        for (int j = 0; j < 9; j++) //loopen körs tills j inte är mindre än 9 (antalet "vanliga kort") inser nu två timmar senare att man skulle kunna använt en foreach loop eftersom fält används.. 
                        {
                            Console.WriteLine($"{colorName[1]} {cardNumber[j]}"); //Skriver ut värdet på indexplats [1] ur fältet colorName och värdet på index plats j (varv som loopen är på) ur fältet cardNumber
                        }
                    }
                    else
                    {
                        for (int k = 0; k < 4; k++) //samma som ovan fast för klädda kort
                        {
                            Console.WriteLine($"{colorName[1]} {specialCards[k]}");
                        }
                    }
                }
                else if (i <= 4)
                {
                    if (i == 3)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            Console.WriteLine($"{colorName[2]} {cardNumber[j]}");
                        }
                    }
                    else
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            Console.WriteLine($"{colorName[2]} {specialCards[k]}");
                        }
                    }
                }
                else if (i <= 6)
                {
                    if (i == 5)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            Console.WriteLine($"{colorName[3]} {cardNumber[j]}");
                        }
                    }
                    else
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            Console.WriteLine($"{colorName[3]} {specialCards[k]}");
                        }
                    }
                }
            }

            Console.WriteLine("Nu har vi skrivit ut alla kort!");
        }

        static void Exempel12() //Övning 12 
        {
            Console.WriteLine("Please input a positive integer n (n<20): ");
            int n = int.Parse(Console.ReadLine());

            //Lösning med "lådor" runt siffrorna.
            for (int i = 0; i < n; i++) //Kör loopen tills i < n (styr raderna)
            {
                for (int j = 0; j < n; j++) //Hjälper till och skriver ut "lådorna" över talen
                {
                    Console.Write("-----");
                }

                Console.Write("\n| "); //Hjälper til loch skriver ut den första väggen till vänster 

                for (int j = 0; j < n; j++) //Skriver ut siffrorna för kolumnerna i den nuvarande raden 
                {
                    Console.Write($"{(i + j + 1),2} | "); //skriver ut talen, förskjuter värdet med 1 genom att plussa på i's värde på j, skriver även ut väggar till höger om varje siffra 
                }
                Console.WriteLine(); //startar en ny rad 
            }

            for (int j = 0; j < n; j++) //efter huvud loopen är klar skriver vi ut det sista "golvet" 
            {
                Console.Write("-----");
            }

            Console.WriteLine();
            Console.ReadLine();

            //Utan lådor

            for (int j = 1; j <= n; j++) //Styr över raderna 
            {
                for (int m = j; m <= j + n - 1; m++) //Styr över kolumnerna i den nuvarande raden 
                {
                    Console.Write("{0,3}", m); //skriver ut m och anger att siffran alltid ska ta up 3 platser 
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void Exempel13() //Övning 13 
        {
            Console.WriteLine("Please input the n! that you wish to check how many zeros it ends on: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int number = n; //denna variablen används senare för att räkna ut hur många nollor vi får 

            BigInteger factorial = 1; //används till uträkningen av n!

            do //Körs minst 1 gång
            {
                factorial *= n; //tar lägger till värdet på factorial * n 
                n--; //tar bort 1 från n's värde 
            }
            while (n > 0); //körs medans n är större än 0 

            Console.WriteLine("n! = " + factorial); //Skriver ut resultatet

            int trailingZeroes = 0; //räknare för hur många 0or vi får 


            for (int i = 5; number / i >= 1; i *= 5) //kör loopen tills number / i är större än eller lika med 1, efter varje varv lägger vi till *5 till i's värde
                trailingZeroes += number / i; //lägger till värdet number / i till trailingZeroes (alltså hur många nollor vi får) 

            Console.WriteLine($"The amount of trailing zeroes are: {trailingZeroes} "); //Skriver ut     
        }

        static void Exempel14() //Övning 14
        {

            //Lösningen har med ett två dimensionellt fält att göra, hänger inte helt med på hur den hittar rätt x) 

            Console.WriteLine("Please input a positive integer n (n<20): ");
            int n = Convert.ToInt32((Console.ReadLine()));

            int[,] spiral = new int[n, n];
            int value = 1;

            int top = 0, bottom = n - 1, left = 0, right = n - 1;

            while (value <= n * n)
            {
                for (int i = left; i <= right; i++)
                    spiral[top, i] = value++;

                top++;

                for (int i = top; i <= bottom; i++)
                    spiral[i, right] = value++;

                right--;

                for (int i = right; i >= left; i--)
                    spiral[bottom, i] = value++;

                bottom--;

                for (int i = bottom; i >= top; i--)
                    spiral[i, left] = value++;

                left++;
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{spiral[i, j],3} ");
                }
                Console.WriteLine();
 
            }
        }

        static void Extra1() //Extra 1
        {
            int loop = 1; //variabel som styr loopen
            while (loop != 0) //kör medans loopen INTE är 0 
            {
                Console.WriteLine("Please input a number: "); 
                int x = Convert.ToInt32(Console.ReadLine()); //användar input 

                Console.WriteLine(x * 10); //skriver ut x gånger 10 
                loop = x; //sätter loops värde till x 
            }

        }

        static void Extra2() //Extra 2
        {
            int loop = 1; 
            do //kör kodblocket minst 1 gång
            {
                Console.WriteLine("Please input a number: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(x * 10);
                loop = x;

            }
            while (loop != 0); //kör inte blocket ovan igen om loop blir 0
        }

        static void Extra3() //Extra 3
        {

            int i = 15; //initierar och sätter variablen i till 15 
            while (i >= 7) //kör loopen medans i är större än eller lika med 7
            {
                if (i % 2 != 0) //om resten av i delat på 2 inte är 0 (alltså om talet är ojämt
                {
                    Console.WriteLine(i); //skriv ut i 
                    i--; //ta bort 1 från i's värde
                }
                else //annars
                {
                    i--; //ta bort 1 från i's värde 
                }
            }
        }

        static void Extra4() //Extra 4
        {
            //intierar variabler att räkna med 
            int numOne = 0;
            int numTwo = 0;

            while (true)
            {
                Console.WriteLine("Please enter a number: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 0) //Om man skriver i 0 slutar loopen 
                {
                    return;
                }

                
                numOne = input; //sätter numOne's värde till det användaren skrev i 
                int result = numOne + numTwo; //variablen result är lika med numOne plus numTwo
                numTwo = result; //sätter numTwo till result för att spara totalen till nästa varv 

                Console.WriteLine(result); //skriver ut resultat 
            }
        }

        static void Main(string[] args)
        {
            Extra4();
        }
    }
}