// smart logistics.cpp : �������̨Ӧ�ó������ڵ㡣
//

#include "stdafx.h"
#include"application\include\geoInfo.h"

int main()
{
	geoInfo geo;
	
	point p2 = geo.getAddressByName(L"����ʦ����ѧ");

	point p1 = geo.getAddressByName(L"����ʦ����ѧ");
	route r = geo.getRoute(p1, p2);
	system("pause");
    return 0;
}

