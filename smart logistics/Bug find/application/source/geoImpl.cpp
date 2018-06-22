
#include<vector>
#include<wchar.h>
#include"..\include\charTrans.h"
#include "..\include\geoImpl.h"

//http://restapi.amap.com/v3/direction/driving?key=ed870059aaf92e6f3272cdb9a74a819f&origin=116.365772,39.961557&destination=116.365772,39.961557&originid=&destinationid=&extensions=base&strategy=1&waypoints=&avoidpolygons=&avoidroad=

const std::wstring addressToPoint = L"GET /v3/geocode/geo?address=北京交通大学&output=JSON&key=ed870059aaf92e6f3272cdb9a74a819f HTTP/1.1\r\nHost: restapi.amap.com\r\nConnection: Alive\r\n\r\n";
const std::string pointToRoute = "GET /v3/direction/driving?key=ed870059aaf92e6f3272cdb9a74a819f&origin=111,222&destination=333,444&originid=&destinationid=&extensions=base&strategy=1&waypoints=&avoidpolygons=&avoidroad= HTTP/1.1\r\nHost: restapi.amap.com\r\nConnection: Close\r\n\r\n";
geoImpl::geoImpl()
{
	//com.connectServer();
}

point geoImpl::getAddressByName(const std::wstring& name)
{
	try
	{
		std::wstring message = addressToPoint;
		std::wstring::size_type pos = message.find(L"北京交通大学");
		std::wstring::size_type len = sizeof(L"北京交通大学") / sizeof(wchar_t);
		message.replace(pos, len, name);
		std::wstring str = sendAndRecv(message);
		//提取所需的地理信息，经纬度
		if (str.empty())return point{};
		std::wstring::size_type pos1 = str.find(L"location") + 11;
		std::wstring::size_type pos2 = str.find(L",", pos1);
		std::wstring::size_type pos3 = str.find(L"\"", pos2);
		std::wstring lon = str.substr(pos1, pos2 - pos1);
		std::string lon1 = charTrans::wStringToString(lon);
		point p;
		p.longitude = atof(lon1.data());
		std::wstring lat = str.substr(pos2 + 1, pos3 - pos2 - 1);
		std::string lat1 = charTrans::wStringToString(lat);
		p.latitude = atof(lat1.data());
		return p;
	}
	catch (std::exception&)
	{
		return point(0, 0);
	}
}

route geoImpl::getRoute(const point & from, const point & to)
{
	std::string message = pointToRoute;
	char fromChar[32] = { 0 };
	sprintf_s(fromChar, "%.6lf,%.6lf", from.longitude, from.latitude);
	char toChar[32] = { 0 };
	sprintf_s(toChar, "%.6lf,%.6lf", to.longitude, to.latitude);
	message.replace(message.find("111,222"), 7, fromChar);
	message.replace(message.find("333,444"), 7, toChar);
	std::wstring str = sendAndRecv(message);
	route r;
	std::wstring::size_type pos1 = str.find(L"distance") + 11;
	std::wstring::size_type pos2 = str.find(L",", pos1);
	std::wstring dis = str.substr(pos1, pos2 - pos1 - 1);
	std::string dis1 = charTrans::wStringToString(dis);
	r.distance = atof(dis1.data());
	pos1 = str.find(L"duration") + 11;
	pos2 = str.find(L",", pos1);
	std::wstring dur = str.substr(pos1, pos2 - pos1 - 1);
	std::string dur1 = charTrans::wStringToString(dur);
	r.duration = atof(dur1.data());
	return r;
}

//请求和响应
std::wstring geoImpl::sendAndRecv(const std::wstring& message)
{
	communication com;
	std::vector<char> vec = charTrans::unicodeToUtf8(message.data());
	com.connectServer();
	com.sendString(vec);
	std::vector<char> res;
	com.recvString(res);
	if (res.empty())return L"";
	std::wstring str = charTrans::utf8ToUnicode(res);
	std::wstring::size_type pos = str.find(L"\r\n\r\n");
	str = str.substr(pos + 4);
	return str;
}
std::wstring geoImpl::sendAndRecv(const std::string& message)
{
	communication com;
	std::vector<char> vec(message.begin(), message.end());
	com.connectServer();
	com.sendString(vec);
	std::vector<char> res;
	com.recvString(res);
	if (res.empty())return L"";
	std::wstring str = charTrans::utf8ToUnicode(res);
	std::wstring::size_type pos = str.find(L"\r\n\r\n");
	str = str.substr(pos + 4);
	return str;
}
