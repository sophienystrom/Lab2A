using System;

class MainClass {
  public static void Main (string[] args) {

    Console.WriteLine ("Enter the name of item");
    var name = Console.ReadLine ();
    Console.WriteLine ("Enter the quantity");
    var t = Console.ReadLine ();
    Console.WriteLine ("Enter the price");
    var y = Console.ReadLine ();
    var t1 = Convert.ToDouble(t);
    var y1 = Convert.ToDouble(y);
    var r = (t1 * y1); /* variable r will be the variable assigned to total price instead of (t1 * y1) for organizational reasons */
    Console.WriteLine ("The total price of " + name + " = " + "$" + r);
   
    
    
    

  }
}