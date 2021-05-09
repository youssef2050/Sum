using System;

class MainClass {
  public static void Main (string[] args) {
    int sum = 0;
    for(int i = 60 ; i<= 90 ;i++){
      if(i%5 == 0){
sum += i;
      }
    }
    Console.WriteLine ("sum :"+sum);
  }
}