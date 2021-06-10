using System;

class CDAccount : Savingsaccount
{

    private int month;
    public int Month
    {
      get
      {
        return month;
      }
      set
      {
        if((value>=1)&&(value<=12)) month = value;
        else Console.WriteLine("Invalid input");
      }
    }
    
    private int day;
    public int Day
    {
      get
      {
        return day;
      }
      set
      {
        if((value>=1)&&(value<=31)) day = value;
        else Console.WriteLine("Invalid input");
      }
    }

    private int year;
    public int Year
    {
      get
      {
        return year;
      }
      set
      {
        if(value>=2019) year = value;
        else Console.WriteLine("Invalid input");

      }
    }
  
  public CDAccount()
  {

  }
  
  public CDAccount(int accountnumber, double interestrate, double balance, int month, int day, int year)
  {
    if(accountnumber>=0)this.Accountnumber = accountnumber;
    else Console.WriteLine("\nInvalid input");

    if(interestrate>=0.0) this.Interestrate = interestrate;
    else Console.WriteLine("Invalid input");

    if(balance>=0.0) this.Balance = balance;
    else Console.WriteLine("Invalid input");

    if((month>=1)&&(month<=12)) this.Month = month;
    else Console.WriteLine("Invalid input");

    if((day>=1)&&(day<=31)) this.Day = day;
    else Console.WriteLine("Invalid input");

    if(year>=2019) this.Year = year;
    else Console.WriteLine("Invalid input");

  }

  //Overriding toString method
  public override string ToString()
  {
    return "\nThe account:\nAccount Number:" + Accountnumber + "\n"+ "Interest rate:" + Interestrate + "\n"+ "Balance:"+ Balance+ "\n"+ "Maturity date => "+ "Month"+ " " + Month + " " + "Day" + " " + Day + " " + "Year" + " " + Year; 
  }

 
  
}




