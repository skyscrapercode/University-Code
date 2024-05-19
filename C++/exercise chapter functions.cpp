#include <iostream>

void display();
double calcArea(double, double);
int tilesNeeded(double, double);
void displayData(double, int);

using namespace std;

int main()
{
	double length, width, area, sizeOfTile;
	int numOfTile;
	
	display();
	cout<<"What is the length and width: "<<endl;
	cin>>length>>width;
	area = calcArea(length, width);
	cout<<"Enter size of tile in centimeter square: ";
	cin>>sizeOfTile;
	numOfTile = tilesNeeded(area, sizeOfTile);
	displayData(area, numOfTile);
	
	
	
}

void display()
{
	cout<<"*****WELCOME TO A PROGRAM THAT HELPS YOU ESTIMATE*****"<<endl;
	cout<<"**********THE COST OF YOUR DREAM HOUSE.**********"<<endl;	
}

double calcArea(double length, double width)
{
	double area;
	area = length * width;
	return area;
}

int tilesNeeded(double area, double sizeOfTile)
{
	int numOfTile;
	numOfTile = area / sizeOfTile;
	return numOfTile;
}

void displayData(double area, int numOfTile)
{
	cout<<"The area of the room is "<<area<<endl;
	cout<<"The total tiles required is "<<numOfTile<<endl;	
}

