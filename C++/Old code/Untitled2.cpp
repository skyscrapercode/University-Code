#include <iostream>
#include <math.h>

using namespace std;

int main()
{
	int marks;
	char grade;
	cout<<"What is your marks: ";
	cin>>marks;
	
	if (marks >= 75 && marks <= 100)
		grade = 'A';
	else if (marks >= 65 && marks < 75)
		grade = 'B';
	else if (marks >= 55 && marks < 65)
		grade = 'C';
	else if (marks >= 40 && marks < 55)
		grade = 'D';
	else if (marks >= 0  && marks < 40)
		grade = 'E';
	else if (marks > 100 || marks < 0)
	{
		cout<<"You input wrong marks!!";
		return 0;
	}
	cout<<"You got an "<<grade;
	
	return 0;
}
