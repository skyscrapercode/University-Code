#include <iostream>

using namespace std;

int main()
{
	double salary, sales, commission;
	
	while (salary != -1)
	{
		cout<<"Enter sales in Ringgit Malaysia (-1 to end): ";
		cin>>salary;
	
		commission = salary - (salary * 10/100);
		if(commission > 0)
		{
			cout<<"Salary is: RM"<<commission<<endl;
		}
		
		sales = sales + commission;
	}
	cout<<"Have a Good Day!!!"<<endl;
	cout<<"Your total salary is RM"<<sales;
}
