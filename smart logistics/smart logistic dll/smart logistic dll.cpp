// smart logistic dll.cpp : ���� DLL Ӧ�ó���ĵ���������
//

#include "stdafx.h"
#include "smart logistic dll.h"
#include"midInterface.h"



SMARTLOGISTICDLL_API void __stdcall getPointByName(modifiedPoint & p)
{
	__getPointByName(p);
}

SMARTLOGISTICDLL_API void __stdcall getRoute(modifiedRoute & r)
{
	__getRoute(r);
}
