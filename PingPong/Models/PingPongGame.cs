using System;

namespace PingPong
{
  public class Game
  {
    public string replaceNumbersWithPingPong(int i) {
        if(i % 15 == 0){
          return "ping-pong";
        }else if (i % 5 == 0){
          return "pong";
        }else if(i % 3 == 0){
          return "ping";
        }else{
          // string stringI = i.ToString();
          // return stringI;
          return i.ToString();
        }
    }
  }
 }
