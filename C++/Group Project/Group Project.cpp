/*
Name			: SHEIKH ADAM BAJUNID BIN MOHD FAISAL, MUHAMAD AZIM HAFIZI BIN CHE MAT, MOHAMAD IMAN MUZAKKIR BIN ISMAIL 
Student id		: 2023135385, 2023172751, 2023159911
Course			: CSC126 
Group			: 1A
Due Date		: 21 July 2023 
Program title	: Food Ordering System 
*/

#include <iostream>
#include <iomanip>
#include <string.h>

int displayMenu(); //Function Prototype to display the menu 
double burger(); // Function Prototype to calculate price of burger
double pizza(); //Function Prototype to calculate price of pizza
double iceCream(); //Function Prototype to calculate price of Ice Cream
double sandwich(); //Function Prototype to calculate price of sandwich
double addon(); //Function Prototype to calculate price of addon
int paymentMethod(double, double&, double&); //Function Prototype to ask and receive payment
void orderReceipt(double*, double, double, int*, double, double, int); //Function Prototype to display the receipt at the end

using namespace std;

int main() //Function Main to call other functions and do calculations
{
	int foodQuantity[4] = {0,0,0,0} , people, choice;
    double foodTotal[5], paymentAmount = 0, change = 0, govTax = 0, totalPriceWithTax = 0, food[5];
    
	cout<<"How many people would like to order: ";
    cin>>people;

    for (int i = 0; i < people; i++) //loop for how many people would like to order
	{
        int itemCode = displayMenu(); //Display's the menu
        
        switch (itemCode) 
		{
            case 1: food[0] = pizza() ; foodTotal[0] += food[0]; foodQuantity[0] += 1; break; // Calculation for burger
            case 2: food[1] = burger() ; foodTotal[1] += food[1]; foodQuantity[1] += 1; break;  // Calculation for pizza
            case 3: food[2] = iceCream() ; foodTotal[2] += food[2]; foodQuantity[2] += 1; break; // Calculation for icecream
            case 4: food[3] = sandwich() ; foodTotal[3] += food[3]; foodQuantity[3] += 1; break; // Calculation for sandwich
        }
        
        cout<<"Would you like addon's that go with your food?(1 for Yes 2 for No): ";
        cin>>itemCode;
        
        switch (itemCode)
        {
        	case 1: food[4] = addon() ; foodTotal[4] += food[4]; break; // Calculation for addon
		}
        
    }
    
    
    foodTotal[5] = foodTotal[0] + foodTotal[1] + foodTotal[2] + foodTotal[3] + foodTotal[4]; // Calculation to total cost all 4 food items and 1 addon
    govTax = foodTotal[5] * 6/100; // Calculate for goverment tax
    totalPriceWithTax = foodTotal[5] + govTax; // Calculate for price with tax 
    
    choice = paymentMethod(totalPriceWithTax, paymentAmount, change); // Function Calling paymentMethod
    orderReceipt(foodTotal ,govTax, totalPriceWithTax, foodQuantity, paymentAmount, change, choice); // Function Calling for the Order Receipt
    
	
}

int displayMenu() // This contains the entire menu of our food ordering system
{
	int itemCode;
	
    cout<<"--------------------------------------------------------"<<endl;
    cout<<setw(32)<<"RESTAURANT MENU"<<endl;
    cout<<"--------------------------------------------------------"<<endl;
    cout<<"--------------------------------------------------------"<<endl;
    cout<<"| Item Code |        Item Name       | Base Price (RM)|"<<endl;
    cout<<"--------------------------------------------------------"<<endl;
    cout<<"|    [1]    | Pizza                  |     21.87      |"<<endl;
    cout<<"|    [2]    | Burger                 |     2.99       |"<<endl;
    cout<<"|    [3]    | Ice Cream              |     4.50       |"<<endl;
    cout<<"|    [4]    | Sandwich               |     9.49       |"<<endl;
    cout<<"--------------------------------------------------------"<<endl;
    
    do
    {
    	cout<<"Please enter item code to order: ";
    	cin>>itemCode;
    
    	if (itemCode < 0 || itemCode > 4)
    	{
    		cout<<"Incorrect item code. Please try again."<<endl;
    		cin.ignore();
		}
		
    }while (itemCode < 0 || itemCode > 4);
	
	return itemCode;
}
double pizza() // This contains the code to build a pizza
{
	int choice [4];
	char addon[4][20];
	double price = 0;
	cout<<"-----------------------------------------------------"<<endl;
	cout<<setw(32)<<"PIZZA SIZES"<<endl;
	cout<<"-----------------------------------------------------"<<endl;
	cout<<"|  Item Code |      Item Name      |   Price (RM)   |"<<endl;
	cout<<"|---------------------------------------------------|"<<endl;
	cout<<"|     [1]    | Small               |     13.99      |"<<endl;
	cout<<"|     [2]    | Medium              |     16.99      |"<<endl;
	cout<<"|     [3]    | Large               |     19.99      |"<<endl;
	cout<<"|     [4]    | Extra-Large         |     22.99      |"<<endl;
	cout<<"|---------------------------------------------------|"<<endl;
	
	do 
	{
		cout<<"Enter Item Code: ";
		cin>>choice[0];
		
		if( choice[0] < 1 || choice[0] > 4)
		{
			cout<<"Incorrect Item Code. Please try again\n";
			cin.ignore();
		}
		
	}while(choice[0] < 1 || choice[0] > 4 );
	
	switch(choice[0])
	{
		case 1 : strcpy(addon[0], "Small");price += 13.99; break;
		case 2 : strcpy(addon[0], "Medium");price += 16.99; break;
		case 3 : strcpy(addon[0], "Large");price += 19.99; break;
		case 4 : strcpy(addon[0], "Extra-Large");price += 22.99; break;
	}
	cout<<"-----------------------------------------------------"<<endl;
	cout<<setw(32)<<"PIZZA CRUST"<<endl;
	cout<<"-----------------------------------------------------"<<endl;
	cout<<"|  Item Code |      Item Name      |   Price (RM)   |"<<endl;
	cout<<"|---------------------------------------------------|"<<endl;
	cout<<"|     [1]    | Thin Crust          |     1.99       |"<<endl;
	cout<<"|     [2]    | Thick Crust         |     3.99       |"<<endl;
	cout<<"|     [3]    | Flat Crust          |     2.99       |"<<endl;
	cout<<"|---------------------------------------------------|"<<endl;
	
	do 
	{
		cout<<"Enter Item Code: ";
		cin>>choice[1];
		
		if( choice[1] < 1 || choice[1] > 3)
		{
			cout<<"Incorrect Item Code. Please try again\n";
			cin.ignore();
		}
		
	}while(choice[1] < 1 || choice[1] > 3 );
	
	switch(choice[1])
	{
		case 1 : strcpy(addon[1], "Thin Crust"); price += 1.99; break;
		case 2 : strcpy(addon[1],"Thick Crust"); price += 3.99; break;
		case 3 : strcpy(addon[1], "Flat Crust"); price += 2.99; break;
	}
	cout<<"-----------------------------------------------------"<<endl;
	cout<<setw(32)<<"PIZZA TOPPINGS"<<endl;
	cout<<"-----------------------------------------------------"<<endl;
	cout<<"|  Item Code |      Item Name      |   Price (RM)   |"<<endl;
	cout<<"|---------------------------------------------------|"<<endl;
	cout<<"|     [1]    | Pepperoni           |     4.90       |"<<endl;
	cout<<"|     [2]    | Extra Cheese        |     4.90       |"<<endl;
	cout<<"|     [3]    | Mushrooms           |     4.90       |"<<endl;
	cout<<"|     [4]    | Sausage             |     4.90       |"<<endl;
	cout<<"|---------------------------------------------------|"<<endl;
	
	do 
	{
		cout<<"Enter Item Code: ";
		cin>>choice[2];
		
		if( choice[2] < 1 || choice[2] > 4)
		{
			cout<<"Incorrect Item Code. Please try again\n";
			cin.ignore();
		}
		
	}while(choice[2] < 1 || choice[2] > 4 );
	
	switch(choice[2])
	{
		case 1 : strcpy(addon[2], "Pepperoni"); price += 4.90; break;
		case 2 : strcpy(addon[2], "Extra Cheese"); price += 4.90; break;
		case 3 : strcpy(addon[2], "Mushrooms"); price += 4.90; break;
		case 4 : strcpy(addon[2], "Sausage"); price += 4.90; break;
	}
	cout<<"-----------------------------------------------------"<<endl;
	cout<<setw(32)<<"PIZZA SAUCES"<<endl;
	cout<<"-----------------------------------------------------"<<endl;
	cout<<"|  Item Code |      Item Name      |   Price (RM)   |"<<endl;
	cout<<"|---------------------------------------------------|"<<endl;
	cout<<"|     [1]    | Marinara Sauce      |     0.99       |"<<endl;
	cout<<"|     [2]    | BBQ Sauce           |     0.99       |"<<endl;
	cout<<"|     [3]    | Buffalo Sauce       |     1.50       |"<<endl;
	cout<<"|     [4]    | Alfredo Sauce       |     1.99       |"<<endl;
	cout<<"|---------------------------------------------------|"<<endl;

	do 
	{
		cout<<"Enter Item Code: ";
		cin>>choice[3];
		
		if( choice[3] < 1 || choice[3] > 4)
		{
			cout<<"Incorrect Item Code. Please try again\n";
			cin.ignore();
		}
		
	}while(choice[3] < 1 || choice[3] > 4 );

	switch(choice[3])
	{
		case 1 : strcpy(addon[3], "Marinara Sauce"); price += 0.99; break;
		case 2 : strcpy(addon[3], "BBQ Sauce"); price += 0.99; break;
		case 3 : strcpy(addon[3], "Buffalo Sauce"); price += 1.50; break;
		case 4 : strcpy(addon[3], "Alfredo Sauce"); price += 1.99; break;
	}
	cout<<"\nYour pizza\n";
	cout<<"Size: "<<addon[0]<<endl;
	cout<<"Crust: "<<addon[1]<<endl;
	cout<<"Topping: "<<addon[2]<<endl;
	cout<<"Sauce: "<<addon[3]<<endl;
	cout<<"Price: RM"<<price<<endl;
	return price;
}

double burger() // This contains the code to build a burger
{
	int num, order[6] = {0,0,0,0,0,0};
	double price = 0;
	cout<<"-----------------------------------------------------"<<endl;
	cout<<setw(29)<<"BURGER TOPPINGS"<<endl;
	cout<<"-----------------------------------------------------"<<endl;
	cout<<"|  Item Code |      Item Name      |   Price (RM)   |"<<endl;
	cout<<"|---------------------------------------------------|"<<endl;
	cout<<"|     [1]    | Bison               |     13.99      |"<<endl;
	cout<<"|     [2]    | Beef                |     7.99       |"<<endl;
	cout<<"|     [3]    | Turkey              |     6.99       |"<<endl;
	cout<<"|     [4]    | Chicken             |     5.99       |"<<endl;
	cout<<"|     [5]    | Vegetable           |     2.99       |"<<endl;
	cout<<"|     [6]    | Egg                 |     2.99       |"<<endl;
	cout<<"|---------------------------------------------------|"<<endl;
	
	cout<<"How many toppings would you like: ";
	cin>>num;
	
	int choice[num];
	for (int i = 0; i < num ; ++i)
	{
		do
		{
		
			cout<<"Enter Item Code: \n";
			cin>>choice[i];
		
			if( choice[i] < 1 || choice[i] > 6)
				{
					cout<<"Incorrect Item Code. Please try again\n";
					cin.ignore();
				}
				
		}while(choice[i] < 1 || choice[i] > 6 );
		
		switch(choice[i])
		{
			case 1 : order[0] += 1; price += 13.99; break;
			case 2 : order[1] += 1; price += 7.99; break;
			case 3 : order[2] += 1; price += 6.99; break;
			case 4 : order[3] += 1; price += 5.99; break;
			case 5 : order[4] += 1; price += 2.99; break;
			case 6 : order[5] += 1; price += 2.99; break;
		}
	}
	cout<<setw(10)<<"Toppings"<<setw(10)<<"Quantity"<<endl;
	cout<<setw(10)<<"Bison"<<setw(5)<<order[0]<<endl;
	cout<<setw(10)<<"Beef"<<setw(5)<<order[1]<<endl;
	cout<<setw(10)<<"Turkey"<<setw(5)<<order[2]<<endl;
	cout<<setw(10)<<"Chicken"<<setw(5)<<order[3]<<endl;
	cout<<setw(10)<<"Vegetable"<<setw(5)<<order[4]<<endl;
	cout<<setw(10)<<"Egg"<<setw(5)<<order[5]<<endl;
	cout<<"Burger Price: RM"<<price<<fixed<<setprecision(2)<<endl;
	return price;
}

double iceCream() // This contains the code to build a ice cream
{
	int type[3];
	double price = 0;
	char addon[3][20];
	
	cout<<" ______________________________________________"<<endl;
	cout<<"|               Base                           |"<<endl;
	cout<<"|           [1] Cone - RM1                     |"<<endl;
	cout<<"|           [2] Waffle- RM5                    |"<<endl;
	cout<<"|           [3] Cup- RM3.50                    |"<<endl;
	cout<<"|______________________________________________|"<<endl;
	
	do 
	{
		cout<<"Enter Item Code: ";
		cin>>type[0];
		
		if( type[0] < 1 || type[0] > 3 )
		{
			cout<<"Incorrect Item Code. Please try again\n";
			cin.ignore();
		}
		
	}while(type[0] < 1 || type[0] > 3 );
	
	switch(type[0])
	{
		case 1 : strcpy(addon[0],"Cone"); price += 1 ; break;
		case 2 : strcpy(addon[0],"Waffle"); price += 5 ; break;
		case 3 : strcpy(addon[0],"Cup"); price += 3.50 ; break;
	}
	
	cout<<" ______________________________________________"<<endl;
	cout<<"|                Flavours                      |"<<endl;
	cout<<"|           [1] Chocolate - RM3                |"<<endl;
	cout<<"|           [2] Vanilla - RM2                  |"<<endl;
	cout<<"|           [3] Strawberry - RM 2.50           |"<<endl;
	cout<<"|______________________________________________|"<<endl;
	
	do 
	{
		cout<<"Enter Item Code: ";
		cin>>type[1];
		
		if( type[1] < 1 || type[1] > 3 )
		{
			cout<<"Incorrect Item Code. Please try again\n";
			cin.ignore();
		}
		
	}while(type[1] < 1 || type[1] > 3 );
	
	switch(type[1])
	{
		case 1 : strcpy(addon[1],"Chocolate"); price += 3; break;
		case 2 : strcpy(addon[1],"Vanilla"); price += 2; break;
		case 3 : strcpy(addon[1],"Strawberry"); price += 2.50; break;	
	}
	
	cout<<" ______________________________________________"<<endl;
	cout<<"|                Toppings                      |"<<endl;
	cout<<"|           [1] Choco Mint - RM6.90            |"<<endl;
	cout<<"|           [2] Pistachio - RM8                |"<<endl;
	cout<<"|           [3] Oreo - RM4.50                  |"<<endl;
	cout<<"|______________________________________________|"<<endl;
	
	do 
	{
		cout<<"Enter Item Code: ";
		cin>>type[2];
		
		if( type[2] < 1 || type[2] > 3 )
		{
			cout<<"Incorrect Item Code. Please try again\n";
			cin.ignore();
		}
		
	}while(type[2] < 1 || type[2] > 3 );
	
	switch(type[2])
	{
		case 1 : strcpy(addon[2],"Choco Mint"); price += 6.90; break;
		case 2 : strcpy(addon[2],"Pistachio"); price += 8; break;
		case 3 : strcpy(addon[2],"Oreo"); price += 4.50; break;
	}
	
	cout<<"\nBase     : "<<addon[0];
	cout<<"\nFlavour  : "<<addon[1];
	cout<<"\nToppings : "<<addon[2];
	cout<<"\nPrice    : RM"<<price<<endl;
	
	return price;

}

double sandwich() // This contains the code to build a sandwich
{
	int type[4];
	double price = 0;
	char addon[4][20];
	
	cout<<" ______________________________________________"<<endl;
	cout<<"|               BREAD                          |"<<endl;
	cout<<"|           [1] White Bread - RM2              |"<<endl;
	cout<<"|           [2] Garlic Bread- RM3.80           |"<<endl;
	cout<<"|           [3] Baguette- RM7                  |"<<endl;
	cout<<"|           [4] Whole Wheat bread - RM2.50     |"<<endl;
	cout<<"|______________________________________________|"<<endl;
	
	do 
	{
		cout<<"Enter Item Code: ";
		cin>>type[0];
		
		if( type[0] < 1 || type[0] > 4 )
		{
			cout<<"Incorrect Item Code. Please try again\n";
			cin.ignore();
		}
		
	}while(type[0] < 1 || type[0] > 4 );
	
	switch(type[0])
	{
		case 1 : strcpy(addon[0],"White Bread"); price += 2; break;
		case 2 : strcpy(addon[0],"Garlic Bread"); price += 3.80; break;
		case 3 : strcpy(addon[0],"Baguette"); price += 7; break;
		case 4 : strcpy(addon[0],"Whole Wheat Bread"); price += 2.50; break;	
	} 
	
	cout<<" ______________________________________________"<<endl;
	cout<<"|               Meat                           |"<<endl;
	cout<<"|           [1] Chicken - RM3.50               |"<<endl;
	cout<<"|           [2] Beef- RM6                      |"<<endl;
	cout<<"|           [3] Turkey - RM8                   |"<<endl;	
	cout<<"|______________________________________________|"<<endl;
	
	do 
	{
		cout<<"Enter Item Code: ";
		cin>>type[1];
		
		if( type[1] < 1 || type[1] > 3 )
		{
			cout<<"Incorrect Item Code. Please try again\n";
			cin.ignore();
		}
		
	}while(type[1] < 1 || type[1] > 3 );
	
	switch(type[1])
	{
		case 1 : strcpy(addon[1],"Chicken"); price += 3.50; break;
		case 2 : strcpy(addon[1],"Beef"); price += 6; break;
		case 3 : strcpy(addon[1],"Turkey"); price += 8; break;
	}
	
		
    cout<<" ______________________________________________"<<endl;
	cout<<"|              Cheese                         |"<<endl;
	cout<<"|           [1] Cheddar - RM2.99              |"<<endl;
	cout<<"|           [2] Mozzarella - RM3.80           |"<<endl;
	cout<<"|           [3] Gorgonzola- RM4               |"<<endl;
	cout<<"|_____________________________________________|"<<endl;
	
	do 
	{
		cout<<"Enter Item Code: ";
		cin>>type[2];
		
		if( type[2] < 1 || type[2] > 3 )
		{
			cout<<"Incorrect Item Code. Please try again\n";
			cin.ignore();
		}
		
	}while(type[2] < 1 || type[2] > 3 );
	
	switch(type[2])
	{
		case 1 : strcpy(addon[2],"Cheeddar"); price += 2.99; break;
		case 2 : strcpy(addon[2],"Mozzarella"); price += 3.80; break;
		case 3 : strcpy(addon[2],"Gorgonzola"); price += 4; break;	
	}
	
	
	cout<<" ______________________________________________"<<endl;
	cout<<"|              SAUCE                           |"<<endl;
	cout<<"|           [1] Thousand Island - RM3          |"<<endl;
	cout<<"|           [2] BBQ- RM1.99                    |"<<endl;
	cout<<"|           [3] Tomato sauce - RM1             |"<<endl;
	cout<<"|           [4] Mayonnaise - RM2.50            |"<<endl;
	cout<<"|           [5] Mustard - RM3                  |"<<endl;
	cout<<"|______________________________________________|"<<endl;
	
	do 
	{
		cout<<"Enter Item Code: ";
		cin>>type[3];
		
		if( type[3] < 1 || type[3] > 5 )
		{
			cout<<"Incorrect Item Code. Please try again\n";
			cin.ignore();
		}
	
	}while(type[3] < 1 || type[3] > 5 );
	
	switch(type[3])
	{
		case 1 : strcpy(addon[3],"Thousand Island"); price += 3; break;
		case 2 : strcpy(addon[3],"BBQ"); price += 1.99; break;
		case 3 : strcpy(addon[3],"Tomato"); price += 1; break;
		case 4 : strcpy(addon[3],"Mayonnaise"); price += 2.50; break;
		case 5 : strcpy(addon[3],"Mustard"); price += 3; break;
	}
	
    
	
	cout<<"\nBread  : "<<addon[0];
	cout<<"\nPatty  : "<<addon[1];
	cout<<"\ncheese : "<<addon[2];
	cout<<"\nsauce  : "<<addon[3];
	cout<<"\nPrice  : RM"<<price;
	
	return price;
}

double addon() // This contains the code to build addons for food
{
	int choice[2]; // Declare an array to store the user's choice
	char order[2][20]; // Declare an array to store the order details
	double price = 0; // Declare a variable to store the price
	
	
	// Print the side dishes menu
	cout<<"-----------------------------------------------------"<<endl;
	cout<<setw(29)<<"SIDES"<<endl;
	cout<<"-----------------------------------------------------"<<endl;
	cout<<"|  Item Code |      Item Name      |   Price (RM)   |"<<endl;
	cout<<"|---------------------------------------------------|"<<endl;
	cout<<"|     [1]    | French Fries        |     4.99       |"<<endl;
	cout<<"|     [2]    | Onion rings         |     5.99       |"<<endl;
	cout<<"|     [3]    | Cheesy Wedges       |     5.99       |"<<endl;
	cout<<"|     [4]    | Coleslaw            |     4.99       |"<<endl;
	cout<<"|---------------------------------------------------|"<<endl;
	
	
	// Get the user's choice for sides
	do 
	{
		cout<<"Enter Item Code: ";
		cin>>choice[0];
		
		
		// Validate the user's choice
		if( choice[0] < 1 || choice[0] > 4)
		{
			cout<<"Incorrect Item Code. Please try again\n";
			cin.ignore();
		}
	}while(choice[0] < 1 || choice[0] > 4 );
	
	
	// Set the order details based on the user's choice
	switch(choice[0])
	{
		case 1 : strcpy(order[0], "French Fries"); price += 4.99; break;
		case 2 : strcpy(order[0], "Onion rings"); price += 5.99; break;
		case 3 : strcpy(order[0], "Cheesy Wedges"); price += 5.99; break;
		case 4 : strcpy(order[0], "Coleslaw"); price += 4.99; break;
	}
	
	// Print the beverage menu
	cout<<"-----------------------------------------------------"<<endl;
	cout<<setw(31)<<"BEVERAGES"<<endl;
	cout<<"-----------------------------------------------------"<<endl;
	cout<<"|  Item Code |      Item Name      |   Price (RM)   |"<<endl;
	cout<<"|---------------------------------------------------|"<<endl;
	cout<<"|     [1]    | Coke                |     2.99       |"<<endl;
	cout<<"|     [2]    | Sprite              |     2.99       |"<<endl;
	cout<<"|     [3]    | Ice Lemon Tea       |     2.99       |"<<endl;
	cout<<"|---------------------------------------------------|"<<endl;
	
	
	// Get the user's choice for beverages
	do 
	{
		cout<<"Enter Item Code: ";
		cin>>choice[1];
		
		// Validate the user's choice
		if( choice[1] < 1 || choice[1] > 3)
		{
			cout<<"Incorrect Item Code. Please try again\n";
			cin.ignore();
		}
	}while(choice[1] < 1 || choice[1] > 3 );
	
	// Set the order details based on the user's choice
	switch(choice[1])
	{
		case 1 : strcpy(order[1], "Coke"); price += 2.99; break;
		case 2 : strcpy(order[1], "Sprite"); price += 2.99; break;
		case 3 : strcpy(order[1], "Ice Lemon Tea"); price += 2.99; break;
	}
	
	// Print the order details
	cout<<"\nAdd-On\n";
	cout<<"Sides: "<<order[0]<<endl;
	cout<<"Beverages: "<<order[1]<<endl;
	cout<<"Price: RM"<<price<<endl;
	return price;
}

int paymentMethod(double totalPriceWithTax, double &paymentAmount, double &change) // This contains the code to ask and receive payment
{
	int choice;
	cout<<endl<<"Total Cost: RM"<<fixed<<setprecision(2)<<totalPriceWithTax<<endl;
	cout<<"Select a payment method: "<<endl;
	cout<<"1. Cash"<<endl;
	cout<<"2. Credit/Debit Card"<<endl;
	cout<<"3. E-Wallet"<<endl;
	cout<<"4. FPX"<<endl;
	cout<<"Enter your choice (1-4): ";
	cin>>choice;
	
	while (choice < 1 || choice > 4)
	{
		cout<<"Invalid choice. Please enter a valid choice (1-4): ";
        cin>>choice;
	}
	
			
	cout<<"Enter the payment amount: RM";
	cin>>paymentAmount;	
		
	while (paymentAmount <= totalPriceWithTax) 
	{
       	cout<<"Insufficient payment. Please enter a sufficient amount: RM";
    	cin>>paymentAmount;
    }
		
	change = paymentAmount - totalPriceWithTax;
	
	return choice;
}

void orderReceipt(double* foodTotal, double govTax, double totalPriceWithTax, int* foodQuantity, double paymentAmount, double change, int choice) // This contains the code to display the full receipt of order
{
	char method[20];
	
	switch (choice)
	{
		case 1: strcpy(method, "Cash"); break;
		case 2: strcpy(method, "Credit/Debit Card"); break;
		case 3: strcpy(method, "E-Wallet"); break;
		case 4: strcpy(method, "FPX"); break;
	}
	
	cout<<"*****ORDER RECEIPT*****"<<endl;
	cout<<setw(10)<<"Item"<<setw(10)<<"Quantity"<<endl;
    cout<<setw(10)<<"Pizza"<<setw(5)<<foodQuantity[0]<<endl;
    cout<<setw(10)<<"Burger"<<setw(5)<<foodQuantity[1]<<endl;
    cout<<setw(10)<<"Ice Cream"<<setw(5)<<foodQuantity[2]<<endl;
    cout<<setw(10)<<"Sandwich"<<setw(5)<<foodQuantity[3]<<endl;
    cout<<setw(10)<<"Subtotal: RM"<<foodTotal[5]<<endl;
    cout<<setw(15)<<"6% Service Tax: RM"<<govTax<<fixed<<setprecision(2)<<endl;
    cout<<setw(15)<<"Total Price: RM"<<totalPriceWithTax<<fixed<<setprecision(2)<<endl;
    cout<<setw(15)<<"Payment Method: "<<method<<fixed<<setprecision(2)<<endl;
    cout<<setw(15)<<"Payment Amount: RM"<<paymentAmount<<fixed<<setprecision(2)<<endl;;
    cout<<setw(10)<<"Change: RM"<<change<<fixed<<setprecision(2)<<endl;
    
}
