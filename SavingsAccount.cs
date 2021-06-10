using System;


class Savingsaccount
{
  protected int accountnumber;

  public int Accountnumber
  {
    get
    {
      return accountnumber;
    }
    set
    {
      if(value>0.0) accountnumber = value;
      else Console.WriteLine("The input is invalid");
    }
  }

  protected double interestrate;
  public double Interestrate
  {
    get
    {
      return interestrate;
    }
    set
    {
      if(value>0.0)  interestrate = value;
      else Console.WriteLine("The input is incvalid");
    }
  }

  protected double balance;
  public double Balance
  {
    get
    {
      return balance;
    }
    set
    {
      if(value>0.0)  balance = value;
      else Console.WriteLine("The input is incvalid");
    }

  }
  
  public double Deposit(double a)
  {
    Balance = Balance + a;
    if(balance>=0.0) return Balance; 
    else 
    {
      balance = 0;
      Console.WriteLine("Balance can not be below 0$\n");
      return balance;
    }
  }
  
  public double Withdraw(double a)
  {
    Balance = Balance - a;
    if(balance>=0.0) return Balance; 
    else 
    {
      balance = 0;
      Console.WriteLine("Balance can not be below 0$\n");
      return balance;
    }
  }
  

};
