#include <iostream>
#include "clsLoginScreen.h"
#include "clsCurrency.h"

static void _PrintCurrency(clsCurrency Currency)
{
    cout << "\nCurrency Card:\n";
    cout << "_____________________________\n";
    cout << "\nCountry    : " << Currency.Country();
    cout << "\nCode       : " << Currency.CurrencyCode();
    cout << "\nName       : " << Currency.CurrencyName();
    cout << "\nRate(1$) = : " << Currency.Rate();

    cout << "\n_____________________________\n";

}

int main()

{
    while (true)
    {
        clsLoginScreen::ShowLoginScreen();
    }

    return 0;
}
