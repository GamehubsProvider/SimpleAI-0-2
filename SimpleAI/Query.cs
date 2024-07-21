 using System;
using System.Drawing;
using System.IO; 
using System.Net; 
// core of ALL QUERIES'


public class Query {     
  
  public  static void PasswordFunction() {
        Console.WriteLine("Enter Your Name first"); 
        string Name = Console.ReadLine(); 
        if(string.IsNullOrEmpty(Name)) {
          Console.WriteLine("Try Again");  
        } else if(!string.IsNullOrEmpty(Name) && Name.Length > 20) {
          string NameDataBase = $"{Name}: "; 
          Console.WriteLine("Now enter your Password"); 
          int password = Convert.ToInt32(Console.ReadLine()); 
          File.AppendAllText("passwords.txt", NameDataBase + password + Environment.NewLine); 
               

        } 
        
         else if(Name.Contains("I wanna login",StringComparison.OrdinalIgnoreCase)) {
          Console.WriteLine("Your Name?"); 
          string GetName = Console.ReadLine();
          if(File.ReadAllText("passwords.txt").Contains(GetName)) {
            Console.WriteLine("You have logined in!"); 
          }
        }
  }
  public async static void ReShape() {
    Console.WriteLine("Enter Length"); 
    int Lengths = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("This func is still in beta so..."); 
    Console.WriteLine("Current WindowSize: {0}", Console.WindowHeight); 
    await Task.Delay(1000); 
    
  }
  
  public async static void GmailFormat() {
    string Gmail = Console.ReadLine();  
    if(Gmail.Contains("Just Analyze My Gmail",StringComparison.OrdinalIgnoreCase)) {
      GmailFormatters(); 
    }
    Console.WriteLine("Ok.. Just enter your gmail name no symbols or dots needed"); 
    await Task.Delay(1000); 
    Console.WriteLine("First Half"); 
    if(string.IsNullOrEmpty(Gmail)) {
      Console.WriteLine("Enter Gmail Please"); 
      Gmail = Console.ReadLine();
    } if(!string.IsNullOrEmpty(Gmail)) {
      string half1 = Gmail;  
      Console.WriteLine("Now end half or empty text just dont be empty "); 
      string End = Console.ReadLine();
      if(string.IsNullOrEmpty(End)) {
        Console.WriteLine("iNVALID");
      } if(!string.IsNullOrEmpty(End)) {
        string EndHalf = End;
        string Gmails = half1 + EndHalf;
        Console.WriteLine(half1 + "@" + ".com"); 
      }
    }
  } 
  public async static void GmailFormatters() {
    string Gmail = Console.ReadLine();
    if(!Gmail.Contains("@") && !Gmail.EndsWith(".com") && Gmail.Length > 13) {
      Console.WriteLine("Invalid Gmail"); 
    }  else if(Gmail.Contains("@") && Gmail.EndsWith(".com") && Gmail.Length < 13) {
      Console.WriteLine("Gmail" + "Is Valid"); 
    } while(string.IsNullOrEmpty(Gmail)) {
      Console.WriteLine("Write an valid Gmail!"); 
      Gmail = Console.ReadLine(); 
    }
  }
  public async static void Snippets() {
    string HtmlSnippet = @" <!DOCTYPE html> 
    <html> 
     <head> <title>Snippets</title>  
     </head>
     <body> <p1> Hello World </p1> 
    </html>";  
      Console.WriteLine(HtmlSnippet);
      string SnippetAsker = Console.ReadLine(); 
      if(SnippetAsker.Contains("C# Code")) {
        Console.WriteLine(@"Console.WriteLine(""Hello World"")"); 
      }
  }
  public async static void Adventure() {
    string you = "You: ";  // continuation of the game; 
    string XEpsilonX = "XEpsilonX *assistant of Mk.2* : "; 
    int XEpsilonXHP = 100; 
    int PlayerHP = 100;   
    bool Fight = true; 
    
    string Start = Console.ReadLine();

    if(Start.Contains("DeadHit")) {
      XEpsilonXHP = 0; 
      Console.WriteLine("Mk.2: You Won"); 
    }
  if(Start.Contains("Fight",StringComparison.OrdinalIgnoreCase)) {
      Console.WriteLine(XEpsilonX + "AH!"); 
      XEpsilonXHP = XEpsilonXHP - 30; // YOUR A MIGHTEST WARRIOR IMAGINE THAT;
    Fight = true; 
       if(Start.Contains("Defend",StringComparison.OrdinalIgnoreCase)) {
         Console.WriteLine(XEpsilonX + "ILL DEFEAT YOU!"); 
         PlayerHP = PlayerHP - 28; 
         Fight = true; 
         
       } if(PlayerHP == 0 && XEpsilonXHP == 0) {
         Console.WriteLine(XEpsilonX + "Its a Tie Mk.2 boss");
       } else if(PlayerHP == 0) {
         Fight = false; 
         Console.WriteLine(XEpsilonX + "I WON Mk.2 boss");
       } else if(XEpsilonXHP == 0) { 
         Fight = false; 
         Console.WriteLine("Mk.2: Wow you won!"); 
         
       }
    }
  } 
    
  public async static void GamePaper() {
    bool screen = true; 
    
    while (screen) { 
      string[] keywords = {"Rock","Paper","Scissors"};  // rock paper scissors but the computer output is hidden
      Random random = new Random(); 
      string Output = keywords[random.Next(keywords.Length)];
      string OutPut = keywords[random.Next(keywords.Length)]; 
      Console.WriteLine("3.."); 
      await Task.Delay(1000);
      Console.WriteLine("Enter Your Choice"); 
      string Choice = Console.ReadLine();  

      if(Choice.Contains("Paper",StringComparison.OrdinalIgnoreCase) && OutPut == "Scissors")
      if(Choice.Contains("Rock",StringComparison.OrdinalIgnoreCase) && OutPut ==  "Paper") {
        Console.WriteLine("You Lose");
        Console.WriteLine("Computer Choice: " + Output);
        Console.WriteLine("Play Again?"); 
        if(Choice.Contains("Y",StringComparison.OrdinalIgnoreCase)) {
        GamePaper(); 
        } else if(Choice.Contains("N", StringComparison.OrdinalIgnoreCase)) {
          screen = false; 
        }
      }
      if(Choice.Contains("Scissors",StringComparison.OrdinalIgnoreCase) && OutPut == "Paper") {
        Console.WriteLine("You Won");  
        Console.WriteLine("PlayAgain?"); 
        if(Choice.Contains("Y",StringComparison.OrdinalIgnoreCase)) {
        GamePaper(); 
        } else if(Choice.Contains("N", StringComparison.OrdinalIgnoreCase)) {
          screen = false; 
        }
      }
   if(Choice.Contains("Paper") && OutPut == "Rock") {
     Console.WriteLine("You Win");
    Console.WriteLine("Play Again?");  
     if(Choice.Contains("Y",StringComparison.OrdinalIgnoreCase)) {
     GamePaper(); 
     } else if(Choice.Contains("N", StringComparison.OrdinalIgnoreCase)) {
       screen = false; 
     }
     
   }   if(Choice.Contains("Rock",StringComparison.OrdinalIgnoreCase ) && OutPut == "Paper") {
        Console.WriteLine("You Lost"); 
        Console.WriteLine("Play Again? Y/N"); 
        if(Choice.Contains("Y",StringComparison.OrdinalIgnoreCase)) {
        GamePaper(); 
        } else if(Choice.Contains("N", StringComparison.OrdinalIgnoreCase)) { // comparisons
          screen = false; 
        }
      }
    }
  }
  public async static void CsCodeQuery() {
    Console.WriteLine("Error");  // incomplete
  }
  public async static void NumberGuess() { 
    bool screen = true; 
    while(screen) {
    Console.WriteLine("first number value"); 
      int Value = Convert.ToInt32(Console.ReadLine()); 
      int Values = Value;
      Console.WriteLine("second number value");
      int Value2 = Convert.ToInt32(Console.ReadLine());
      int Valuess = Value2;  // own value number guessing game
      
    bool HasWon = false; 
    Random random = new Random(); 
    int randomNumber = random.Next(Values, Valuess); 
    int guess = Convert.ToInt32(Console.ReadLine()); 
    if(guess > randomNumber) {
      Console.WriteLine("Too high");
    } else if(guess < randomNumber) {
      Console.WriteLine("Too low");
    } else if(guess == randomNumber) {
      HasWon = true; 
      Console.WriteLine("You won!");
      Console.WriteLine("The Number is " + randomNumber); 
      await Task.Delay(1000); 
      Console.WriteLine("Want to play again?"); 
      string input = Console.ReadLine();
      if(input.Contains("Yes", StringComparison.OrdinalIgnoreCase)) {
        NumberGuess();
      } else if(input.Contains("No", StringComparison.OrdinalIgnoreCase)) {
        Console.WriteLine("Okay");
        Console.WriteLine("Quitting...to..Main"); 
      }
    }
   }
}  
  } 

  

