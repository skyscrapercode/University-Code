#include <iostream>
#include <math.h>
#include <string.h>

using namespace std;

int main()
{
	char holiday;
	double speed, fine, demerit, pay;
	cout<<"How fast were you going: ";
	cin>>speed;
	cout<<"Is it a holiday (Y for yes or N for no): ";
	cin>>holiday;
	
	if (speed <= 9 )
	{
		fine = 0;
		demerit = 0;
	}
	else if (speed > 9 && speed <= 19)
	{
		fine = 50;
		demerit = 1;
	}
	else if (speed > 19 && speed <= 29)
	{
		fine = 100;
		demerit = 2;
	}
	else if (speed > 29 && speed <= 40)
	{
		fine = 200;
		demerit = 4;
	}
	else
	{
		fine = 300;
		demerit = 7;
	}
	
	if (holiday == 'Y')
	{
		demerit = demerit * 2;
	}
	
	if (speed <= 9)
	{
		fine = fine + 10;
	}
	
	cout<<"You got "<<demerit<<" demerit points and have to pay RM"<<fine;
	return 0;
}
