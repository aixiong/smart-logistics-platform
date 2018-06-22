#pragma once
#include<string>
#include"communication.h"
#include"geoName.h"

class geoImpl
{
private:
	//communication com;
public:
	geoImpl();
	point getAddressByName(const std::wstring& name);
	route getRoute(const point& from, const point& to);
private:
	std::wstring sendAndRecv(const std::wstring& message);
	std::wstring sendAndRecv(const std::string& message);
};