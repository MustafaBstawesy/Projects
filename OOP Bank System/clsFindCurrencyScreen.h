#pragma once
#include<iostream>
#include "clsScreen.h"
#include "clsInputValidate.h"
#include "clsCurrency.h"

class clsFindCurrencyScreen : protected clsScreen
{
private:

	enum enFindMethod { eCode = 1, eCountry = 2 };

	static void _PrintCurrencyCard(clsCurrency Currency)
	{
		cout << "\nCurrency Card\n";

		cout << "__________________________\n";
		cout << "Country   : " << Currency.Country() << endl;
		cout << "Code      : " << Currency.CurrencyCode() << endl;
		cout << "Name      : " << Currency.CurrencyName() << endl;
		cout << "Rate(1$) =: " << Currency.Rate() << endl;
		cout << "__________________________\n";
	}

	static void CurrnecyIsFound(clsCurrency Currency)
	{
		if (Currency.IsEmpty())
			cout << "\nCurrency Not Found :-(" << endl;
		else
		{
			cout << "\nCurrency Found :-)" << endl;
			_PrintCurrencyCard(Currency);
		}
		
	}

public:

	static void ShowFindCurrecnyScreen()
	{
		_DrawScreenHeader("\tFind Currency Screen");

		short Method;
		cout << "Find By: [1] Code or [2] Country ? ";
		Method = clsInputValidate::ReadIntNumber();

		string  CurrencyCode;

		switch ((enFindMethod)Method)
		{
		case enFindMethod::eCode:
		{
			cout << "\nPlease Enter Currency Code: ";
			CurrencyCode = clsInputValidate::ReadString();

			clsCurrency Currecny = clsCurrency::FindByCode(clsString::UpperAllString(CurrencyCode));

			CurrnecyIsFound(Currecny);
			break;
		}
		

		case enFindMethod::eCountry:
		{
			cout << "\nPlease Enter Country Name: ";
			CurrencyCode = clsInputValidate::ReadString();

			clsCurrency Currecny = clsCurrency::FindByCountry(clsString::UpperAllString(CurrencyCode));

			CurrnecyIsFound(Currecny);
			break;
		}
		}
	}
};

