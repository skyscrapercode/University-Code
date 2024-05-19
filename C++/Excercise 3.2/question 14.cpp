#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	double salary, hours, payrate, SOCSO, incomeTax, KWSP, workUnion, netPay;
	cout<<"How many hours do you work: ";
	cin>>hours;
	cout<<"What is the pay rate per hour: ";
	cin>>payrate;
	
 	if (hours <= 40)
    {
        salary = hours * payrate;
    }
    else if (hours > 40 && hours <= 50)
    {
        salary = (40 * payrate) + ((hours - 40) * (payrate * 1.5));
    }
    else if (hours > 50)
    {
        salary = (40 * payrate) + (10 * (payrate * 1.5)) + ((hours - 50) * (payrate * 2.0));
    }
    else
    {
    	cout<<"Invalid Input";
    	return 0;
	}
    
    SOCSO = salary * 5/100;
    incomeTax = salary * 10/100;
    KWSP = salary * 11/100;
    workUnion = 5;
    netPay = salary - (SOCSO + incomeTax + KWSP + workUnion);

	cout<<"Your gross salary is RM"<<salary <<endl;
	cout<<"Your SOCSO deduction is RM"<<SOCSO <<endl;
	cout<<"Your income tax deduction is RM"<<incomeTax <<endl;
	cout<<"Your KWSP deduction is RM"<<KWSP <<endl;
	cout<<"Your workers union deduction is RM"<<workUnion <<endl;
	cout<<"The net pay you will receive is RM"<<netPay <<endl;
	
}
