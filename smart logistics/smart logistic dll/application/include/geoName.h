#pragma once

struct route
{
	route(double _distance=0,double _duration=0):distance(_distance),duration(_duration){}
	double distance;
	double duration;
};

struct point
{
	point(double _latitude=0,double _longitude=0):latitude(_latitude),longitude(_longitude){}
	double latitude;
	double longitude;
};

struct modifiedPoint
{
	double lat, lon;
	char* address;
};
struct modifiedRoute
{
	point from, to;
	double distance;
	double duration;
};