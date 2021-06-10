using System;
using System.Collections.Generic;



class MainClass {
  public static void Main (string[] args) {

  Console.WriteLine("Initially you were given a bank account with 100$ Balance");
  Console.WriteLine("Input the amount of money you want to add");

  double addsomething = 0;
  addsomething = Convert.ToDouble(Console.ReadLine()); 

  CDAccount first = new CDAccount(1, 2, 100, 11, 2, 2020);
  first.Deposit(addsomething);

  Console.WriteLine(first);
  Console.WriteLine("Now let's withdraw something from your account");
  double withdrawsomething = 0;
  withdrawsomething = Convert.ToDouble(Console.ReadLine()); 
  first.Withdraw(withdrawsomething);
  Console.WriteLine(first);


  Console.WriteLine("Please list all of your accounts");
    int a, b, c, d;
    double e, f;

    CDAccount [] myarray = new CDAccount[1000];
    Console.WriteLine("How many accounts do you want to specify?");
    int i = 0;
    int j =0;
    i = Convert.ToInt32(Console.ReadLine());
    while(j<i)
    {

    Console.WriteLine("Enter your account number here: ");
    a = Convert.ToInt32(Console.ReadLine()); 

    Console.WriteLine("Enter yourr rate here:");
    e = Convert.ToDouble(Console.ReadLine());  // Interestrate

    Console.WriteLine("Enter your balance here: ");
    f = Convert.ToDouble(Console.ReadLine());  // Balance

    Console.WriteLine("Enter your month here: ");
    b = Convert.ToInt32(Console.ReadLine());  // Month

    Console.WriteLine("Enter your day here: ");
    c = Convert.ToInt32(Console.ReadLine()); // Day

    Console.WriteLine("Enter your year here: ");
    d = Convert.ToInt32(Console.ReadLine()); // Year

    myarray[j] = new CDAccount(a, e, f, b, c, d);

    j++; 

    }

    int taso = 0;
    int tasoo = 0;

    for(taso = 0; taso < i; taso++)
    {
      for(tasoo=1;tasoo>taso; tasoo--)
      {
        if(myarray[tasoo].Balance > myarray[tasoo-1].Balance)
        {
          var temp = myarray[tasoo];
          myarray[tasoo] = myarray[tasoo-1];
          myarray[tasoo-1] = temp;
        }
      }
    }

    foreach(CDAccount item in myarray)
    {
    Console.WriteLine(item);
    }

}
}





















  
