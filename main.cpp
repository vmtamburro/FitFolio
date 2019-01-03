#include <iostream>
#include <cmath>
#include <iomanip>

using namespace std;

int main()
{
    int weightType;
    int heightType;
    float lbs;
    float kilograms;
    float feet;
    float meters;
    float BMI;

    //eventually this step will be a part of some sort of drop-down menu
    cout << "Enter 1 if you would like to enter weight in kilograms. Enter 2 if you would like to enter weight in pounds.";
    cin >> weightType;


    if(weightType==2)
    {
        cout << "Enter weight in pounds: ";
        cin >> lbs;
        kilograms = lbs / 2.205;
    }
    else
    {
        cout << "Enter weight in kilograms: ";
        cin >>kilograms;
        lbs = kilograms * 2.205;
    }

    //again in a drop-down menu. Also a drop-down for inches separately.
    cout << "Enter 1 if you would like to enter height in meters. Enter 2 if you would like to enter height in feet.";
    cin >> heightType;

    if (heightType == 2)
    {
        cout << "Enter height in feet: ";
        cin >>feet;
        meters = feet / 3.281;
    }
    else
    {
        cout << "Enter height in meters: ";
        cin >> meters;
        feet = meters * 3.281;
    }

    BMI = kilograms / pow(meters, 2);
    cout <<setprecision(1)<<fixed;
    cout <<BMI<<endl;

    if (BMI < 18.5)
        cout << "Underweight"<<endl;
    else if(BMI >=18.5 && BMI < 25)
        cout << "Normal"<<endl;
    else if (BMI >= 25 && BMI < 30)
        cout << "Overweight" <<endl;
    else if (BMI >=30)
        cout << "Obese" <<endl;



}
