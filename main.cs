using System;

class Program {
  public static void Main (string[] args) {
    string [] list = System.IO.File.ReadAllLines(@"input.txt");
    int highest =  0;
    int highest2 = 0;
    int highest3 = 0;
    int temp = 0;
    
    foreach (string i in list){
      if(i != ""){
        temp+=Convert.ToInt32(i);
      }
      else{
        temp = 0;
      }
      if(temp > highest){
        highest2 = highest;
        highest3 = highest2;
        highest = temp;
      }
      else if(temp > highest2){
        highest3 = highest2;
        highest2 = temp;
      }
      else if(temp > highest3){
        highest3 = temp;
      }
    }
    Console.WriteLine(highest+highest2+highest3);
  }
}