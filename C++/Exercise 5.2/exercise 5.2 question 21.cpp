#include <iostream>

void calcGender (char);
int getYoungest();
int calcPatient();

using namespace std;

int main()
{
	int i = 0;
	while (i < 100)
	{
	cout<<"Patient ID: ";
	cin>>patientID;
	cout<<"Name: ";
	cin>>name;
	cout<<"Gender (M for male, F for female): ";
	cin>>gender;
	
	calcGender(gender);
	
	cout<<"Age: ";
	cin>>age;
	cout<<"Treatment Level(1-3): ";
	cin>>treatmentLevel;
	cout<<"What is your ward number: ";
	cin>>wardNumber;
	}
	
	cout<<"Summary of Liver Cancer Patients"<<endl;
	
	cout<<"Total number of males: "<<male<<endl;
	cout<<"Total number of female: "<<female<<endl;
	
	cout<<"The youngest patients is at age "<<age<<" years old"<<endl;
	cout<<"Number of patients who are in Ward 2 and were given treatment level 3: "<<treatmentLevel
	
}

void calcGender(char gender; int &male, int &female)
{
	if (strcmp(gender, "M") == 0)
	{
		male++
	}
	else if (strcmp(gender, "F") == 0)
	{
		female++
	}
}
