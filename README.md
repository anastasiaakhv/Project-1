# Project-1

The assignment required developing a class representing a savings account. The data held
by the object of this class is: the account number, interest rate and account balance. Another class
must have been developed as well. The name of this class is CDAccount. The data held by the object of
this class is: account number, interestrate, account balance and account maturity date.
SavingsAccount is a parent class and CDAccount is child class. Deposit() and Withdraw()
methods were developed in order to give the users the ability add/take money to/from their
accounts.
Firstly the parent class was created. CDAccount (a child class) derives from the
SavingsAccount and inherits all data. The data of SavingsAccount is protected. What is more the
properties were used in order to get and set data easily and not violate the encapsulation rule.
ToString() method was overridden to display objects easily.
In order to demonstrate the process, the user was given 100$ account. First he had to add
something to his account and then withdraw something from the account. Both results were
displayed. Next the user is asked to provide all the accounts he has. This means, that the user has
to input the number of accounts that he has and provide all the data. The program processes data
and displays all the accounts in descending order with respect to the balance.
