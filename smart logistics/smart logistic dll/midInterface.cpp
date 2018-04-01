#include "midInterface.h"
#include"application\include\geoInfo.h"
#include"application\include\charTrans.h"

void __getPointByName(modifiedPoint& p)
{
	geoInfo geo;
	std::string address = p.address;
	std::wstring addressw = charTrans::stringToWstring(address);
	point obj = geo.getAddressByName(addressw);
	p.lat = obj.latitude;
	p.lon = obj.longitude;
}

void __getRoute(modifiedRoute& r)
{
	geoInfo geo;
	route obj = geo.getRoute(r.from, r.to);
	r.distance = obj.distance;
	r.duration = obj.duration;
}
