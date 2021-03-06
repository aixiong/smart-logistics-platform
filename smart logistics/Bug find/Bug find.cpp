// Bug find.cpp : Defines the entry point for the console application.
//

#include<iostream>

#include"application\include\geoInfo.h"

using namespace std;

wstring extract(const wstring& name)
{
	wstring one = L"北京市";
	for (auto c : name)
	{
		if (c == ' ' || c == ',' || c == '(' || c == ')' || c == '）' || c == '（')
		{
			continue;
		}
		else one += c;
	}
	return one;
}
int main()
{
	geoInfo one;
	wstring name;
	int num = 0;
	while (wcin >> name)
	{
		name = extract(name);
		point p=one.getAddressByName(name);
		cout << p.latitude << " " << p.longitude << endl;
		if (p.latitude == 0)++num;
	}
	cout << num << endl;
	system("pause");
    return 0;
}

