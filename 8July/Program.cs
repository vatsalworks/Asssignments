// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World! and today is 8 July");


String james = "";
String para0 = "The James Bond series focuses on a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is Forever and a Day by Anthony Horowitz, published in May 2018. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny.";
String para1 = "The James Bond series focuses on a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is Forever and a Day by Anthony Horowitz, published in May 2018. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny";
String para2 = "The character—also known by the code number 007 has also been adapted for television, radio, comic strip, video games and film. The films are one of the longest continually running film series and have grossed over US$7.04 billion in total, making it the fifth-highest-grossing film series to date, which started in 1962 with Dr. No, starring Sean Connery as Bond. As of 2021, there have been twenty-five films in the Eon Productions series. The most recent Bond film, No Time to Die (2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor to play Bond in the Eon series. There have also been two independent productions of Bond films: Casino Royale (a 1967 spoof starring David Niven) and Never Say Never Again (a 1983 remake of an earlier Eon-produced film, 1965's Thunderball, both starring Connery). In 2015, the series was estimated to be worth $19.9 billion,[1] making James Bond one of the highest-grossing media franchises of all time.";
james = para1 + System.Environment.NewLine + para2;

String cont = "y";

do
{
    Console.WriteLine("Here are your choices: ");
    Console.WriteLine("1. count of blanck spaces in the string");
    Console.WriteLine("2. count of words in the string");
    Console.WriteLine("3. count of statements in the string");
    Console.WriteLine("4. Accept an input string from the user e.g. the and find out count of the in string and its positions");
    Console.WriteLine("5. Find out count of vovels (a,e,i,o,u) in the string");
    Console.WriteLine("6. Convert first character of each word in string into the uppercase");
    Console.WriteLine("7. Print all special characters from the string.");
    int val = Convert.ToInt32(Console.ReadLine());

    switch (val)
    {
        case 1:
            countOfBlankSpace(james);
            break;
        case 2:
            countWords(james);
            break;
        case 3:
            countStatements(james);
            break;
        case 4:
            Console.WriteLine("Enter a word which you want to search in the string");
            String pat = Console.ReadLine();
            countInputString(james, pat);
            break;
        case 5:
            countVowels(james);
            break;
        case 6:
            convert(james);
            break;
        case 7:
            specialCharacters(james);
            break;
        default:
            break;
    }

    Console.WriteLine("Press y/Y if you want to continue");
    cont = Console.ReadLine();
    Console.Clear();
} while (cont == "y" || cont == "Y");


void countOfBlankSpace(String s)
{
    int count = 0;
    int countCheck = 0;

    foreach (char c in s)
    {
        
        if(c == ' ')
        {
            count++;
        }
        
    }
    
    for(int i=0; i < s.Length; i++)
    {
        if (s[i] == ' ')
        {
            countCheck++;
        }
    }
    Console.WriteLine("Count of Blank Space = " + count);
   // Console.WriteLine(countCheck);

}

void countWords(String s)
{
    int words = 0;
    int i = 0;
    while (i < s.Length)
    {
        
        while (i < s.Length && !char.IsWhiteSpace(s[i]))
            i++;

        words++;

       
        while (i < s.Length && char.IsWhiteSpace(s[i]))
            i++;
    }
    Console.WriteLine("Count of words in sentence = " + words);

}

void countStatements(String s)
{
    int i = 0;
    int count = 0;
    while(i < s.Length)
    {
        while (i < s.Length && s[i] != '.')
        {
            i++;
        }
        
        count++;
        i++;
    }
    Console.WriteLine("Count of Statements = " + count);

}

void countInputString(String s, String pat)
{
    int count = 0;
    foreach (Match m in Regex.Matches(s, pat))
    {
        count++;
    }
    Console.WriteLine("Count of occurences = " + count);
}

void countVowels(String s)
{
    int a = 0, e = 0, i = 0, o = 0, u = 0;
    for (int iter = 0; iter < s.Length; iter++)
    {
        if (s[iter] == 'a' || s[iter] == 'A')
        {
            a++;
        }
        else if (s[iter] == 'e' || s[iter] == 'E')
        {
            e++;
        }
        else if (s[iter] == 'i' || s[iter] == 'I')
        {
            i++;
        }
        else if (s[iter] == 'o' || s[iter] == 'O')
        {
            o++;
        }
        else if (s[iter] == 'u' || s[iter] == 'U')
        {
            u++;
        }
    }
    Console.WriteLine("The count of a = " + a);
    Console.WriteLine("The count of e = " + e);
    Console.WriteLine("The count of i = " + i);
    Console.WriteLine("The count of o = " + o);
    Console.WriteLine("The count of u = " + u);
}

void convert(String f)
{
    String s = f;

    s=char.ToUpper(s[0]) + s.Substring(1);

    for (int i=1; i < s.Length-1; i++)
    {
        if (!char.IsLetter(s[i - 1]))
        {
            s = s.Substring(0,i) + char.ToUpper(s[i]) + s.Substring(i+1);
        }
    }

   
    Console.WriteLine(s);
}

void specialCharacters(String input)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if ( (input[i] >= 32 && input[i] <= 47) || (input[i] >= 58 && input[i] <= 64) || (input[i] >= 123 && input[i] <= 126) || (input[i] >= 91 && input[i] <= 96))
        {
            count++;
            Console.WriteLine(input[i]);
        }

    }

    Console.WriteLine("Total number of special character = " + count);
}