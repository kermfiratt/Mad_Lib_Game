using System;

namespace Mad_Lib_Game
{
class Program
  {
    static void Main(string[] args)
      
      {
        string famous_men_actor_name, movie_from_hollywood, person_from_hollywood;
       
        
        Console.Write("Write a famous men anctor name from hollywood: ");
        famous_men_actor_name = Console.ReadLine();
        
        Console.Write("Write a movie name from hollywood: ");
        movie_from_hollywood = Console.ReadLine();
        
        Console.Write("Write a name from hollywood: ");
        person_from_hollywood = Console.ReadLine();

        
         Console.WriteLine("THE MOST HANDSOME ACTOR NAME IS " + famous_men_actor_name);
         
         Console.WriteLine("THE BEST MOVIE I HAVE EVER WATCH IS " + movie_from_hollywood); 
         
         Console.WriteLine("THE MOST UGLY PERSON IN HOLLYWOOD IS " + person_from_hollywood);   
       
      }
  }
}