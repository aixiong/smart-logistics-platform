// smart logistics.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include"application\include\geoInfo.h"

int main()
{
	geoInfo geo;
	
	point p2 = geo.getAddressByName(L"北京师范大学");

	point p1 = geo.getAddressByName(L"北京师范大学");
	route r = geo.getRoute(p1, p2);
	system("pause");
    return 0;
}

