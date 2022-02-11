// Day11.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <vector>
using namespace std;//not good professional coding

enum class WeaponRarity
{
    Common, Uncommon, Rare, Legendary
};

int Factor(int num, int factor)
{
    return num * factor;
}
void Print(WeaponRarity rarity)
{
    switch (rarity)
    {
    case WeaponRarity::Common:
        cout << "Common\n";
        break;
    case WeaponRarity::Uncommon:
        cout << "Uncommon\n";
        break;
    case WeaponRarity::Rare:
        cout << "Rare\n";
        break;
    case WeaponRarity::Legendary:
        cout << "Legendary\n";
        break;
    }
}

int main()
{
    WeaponRarity rarity = WeaponRarity::Rare;
    Print(rarity);
    cout << (char)rarity << "\n";

    //std - standard namespace
    //:: - scope resolution operator
    //cout - console output stream
    //<< - insertion operator
    std::cout << "Hello World!\n";
    cout << "Holy ancient code!\n";

    int num = 5;

    //strings
    char best[] = "Batman";//  \0 - null terminator
    char weak[] = { 'A','q','u','a','m','a','n', '\0'};
    cout << best << "\n";
    cout << weak << "\n";

    {
        int nums[5] = { 1,2,3,4,5 }; //stack
        for (size_t i = 0; i < 5; i++)
        {
            cout << nums[i] << "\n";
        }
        while (true)
        {
            break;
        }
        int j = 0;
        do
        {
            j++;
            if (j < 10)
                continue;
            else
            {
                break;
            }
        } while (true);
    }//nums is automatically removed from the stack

    {
        int* numbers = new int[5]{ 1,2,3,4,5 };//heap
        delete[] numbers;
        numbers = nullptr;
    }

    srand((unsigned)time(NULL));
    cout << RAND_MAX << "\n";
    int random = rand();//0-RAND_MAX (32767)
    random = rand() % 1000;//0-999
    random = rand() % 1001;//0-1000
    random = rand() % 1000 + 1;//1-1000

    switch (random)
    {
    case 5:
        cout << "My fave!\n";
    case 7:
        cout << "Another fave!\n";
        break;
    default:
        break;
    }

    vector<int> scores;
    scores.push_back(1);
    scores.push_back(5);
    scores.push_back(7);
    scores.push_back(13);
    scores.push_back(1);
    cout << "-----------SCORES---------\n";
    for (size_t i = 0; i < scores.size(); i++)
    {
        cout << scores[i] << "\n";
    }
}
