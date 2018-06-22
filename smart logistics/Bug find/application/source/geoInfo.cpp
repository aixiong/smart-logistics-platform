#include "..\include\geoInfo.h"
#include"..\include\geoImpl.h"

geoInfo::geoInfo():impl(new geoImpl()){}

point geoInfo::getAddressByName(const std::wstring name)
{
	return impl->getAddressByName(name);
}

route geoInfo::getRoute(const point & from, const point & to)
{
	return impl->getRoute(from, to);
}

