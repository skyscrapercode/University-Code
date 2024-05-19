/*
Name			: SHEIKH ADAM BAJUNID BIN MOHD FAISAL
Sid				: 2023135385
Course			: CSC126 
Group			: 1A
Due Date		: 14 June 2023 5:00 pm
Question No		: 1
Program Description	: This program is used to calculate the price and number of wallpaper rolls required for Mr Rayyan
*/

#include <iostream>

using namespace std;

int main()
{
	double numOfRolls, area, height, width, height2, width2, doorArea, rollPrice = 100, labour = 10, roll = 5, wallpaperArea, roomArea, totalCost;
	
	cout<<"What is the height and width of the wall(in meters): ";
	cin>>height>>width;
	
	cout<<"What is the height and width of the door(in meters): ";
	cin>>height2>>width2;
	
	area = width * height;
	doorArea = width2 * height2;
	roomArea = area * 4;
	wallpaperArea = roomArea - doorArea;
	numOfRolls = wallpaperArea / roll;
	totalCost = (rollPrice * numOfRolls ) + (numOfRolls * labour);
	
	cout<<"The number of rolls required is "<<numOfRolls<<endl;
	cout<<"The total cost of everything is RM"<<totalCost;
	
	return 0;
	
}

