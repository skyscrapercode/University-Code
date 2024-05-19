#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double salary, newsalary, increase ; 
	char name [20];
	cout<<"What is your name: ";
	cin.getline(name, 20);
	cout<<"What is your current salary: RM";
	cin>>salary;
	increase = salary + ( salary * (3.0/100)) ;
	cout<<"****Your new Monthly Salary****" <<endl;
	cout<<"Name: "<<name <<endl;
	cout<<"You currently make RM"<<salary <<endl;
	cout<<"You got a salary increase and will be making RM"<<increase <<endl;
	
}
