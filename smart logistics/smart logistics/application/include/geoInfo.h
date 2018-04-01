#pragma once
#include<memory>
#include<utility>
#include<string>
#include<wchar.h>
#include"geoName.h"

class geoImpl;

class geoInfo
{
public:
	geoInfo();
	point getAddressByName(const std::wstring& name);
	route getRoute(const point& from, const point& to);
private:
	std::shared_ptr<geoImpl> impl;
};