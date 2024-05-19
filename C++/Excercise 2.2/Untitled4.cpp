#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double salary, newsalary, increase = 3, newsalary1 ; 
	char name [20];
	cout<<"What is your name: ";
	cin>>name;
	cout<<"What is your current salary: ";
	cin>>salary;
	newsalary = ( salary * (increase/100)) ;
	newsalary1 = (newsalary + salary);
	cout<<"Your name is "<<name<< " You currently make "<<salary<< ", You got a salary increase and will be making "<<newsalary1;
	
}
