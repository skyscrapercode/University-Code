#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	int marks;
	char grade;
	cout<<"What is your marks: ";
	cin>>marks;
	
	if (marks > 100)
	{
		cout<<"You entered incorrect marks!";
		return 0;
	}
	else if (marks >= 75 )
	{
		grade = 'A';
	}
	else if (marks >= 65 )
	{
		grade = 'B';
	}
	else if (marks >= 55 )
	{
		grade = 'C';
	}
	else if (marks >= 40 )
	{
		grade = 'D';
	}
	else if (marks >= 0 )
	{
		grade = 'E';
	}
	else
	{
		cout<<"Wrong input!!!"
		return 0;
	}
	cout<<"You got an "<<grade;
	
	return 0;
}
