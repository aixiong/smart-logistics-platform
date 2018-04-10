// smart logistics.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include<iostream>
#include"application\include\geoInfo.h"



int main()
{
	geoInfo geo;
	point from, to;
	from = geo.getAddressByName(L"北京交通大学");
	to = geo.getAddressByName(L"北京师范大学");
	std::cout << from.latitude << " " << to.longitude;
	route r= geo.getRoute(from, to);
	system("pause");
    return 0;
}

