// smart logistic dll.cpp : 定义 DLL 应用程序的导出函数。
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
