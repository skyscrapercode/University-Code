#include <iostream>

void salaryBonus(double &, double &);

using namespace std;

int main()
{
	double salary, bonus, newSalary;
	
	cout<<"What is your salary: ";
	cin>>salary; 
	
	salaryBonus(salary, bonus);
	
	cout<<"Your bonus is "<<bonus<<endl;
	cout<<"Your new salary is "<<newSalary<<endl;
}

void salaryBonus(double newSalary, double &bonus, double salary)
{
	bonus = salary * 75/100;
	newSalary = salary + (salary * 10/100);
}
