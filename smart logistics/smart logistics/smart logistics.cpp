// smart logistics.cpp : �������̨Ӧ�ó������ڵ㡣
//

#include "stdafx.h"
#include"application\include\geoInfo.h"



int main()
{
	geoInfo geo;
	point from, to;
	from = geo.getAddressByName(L"������ͨ��ѧ");
	to = geo.getAddressByName(L"����ʦ����ѧ");
	route r= geo.getRoute(from, to);
	system("pause");
    return 0;
}

