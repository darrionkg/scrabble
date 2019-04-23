using System;

namespace PingPong
{
  public class Game
  {
    public void replaceNumbersWithPingPong(int enteredInt) {
      for(int i =1; i<= enteredInt; i++ ){
        if(i % 15 == 0){
          Console.WriteLine("ping-pong");
        }else if (i % 5 == 0){
          Console.WriteLine("pong");
        }else if(i % 3 == 0){
          Console.WriteLine("ping");
        }else{
          Console.WriteLine(i);
        }
      }
    }
  }
 }
