#include <iostream>
#include <math.h>
#include <iomanip>
using namespace std;

int main()
{
	double TCC = 25, numofhours, fees ;
	char name[20] , program[20];
	cout<<"How many hours are you enrolled: ";
	cin>>numofhours;
	cin.ignore();
	cout<<"What program are you studying for: ";
	cin.getline(program, 20);
	cout<<"What is your name: ";
	cin.getline(name, 20);
	fees = TCC * numofhours;
	cout<<"Your name is "<<name <<endl;
	cout<<"You are currently studying "<<program<< " and enrolled for "<<numofhours<< " credit hours" <<endl;
	cout<<"Your fees at Tapah Community College is RM"<<fees;
	
}
