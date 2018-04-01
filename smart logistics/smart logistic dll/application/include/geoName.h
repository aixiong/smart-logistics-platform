#pragma once

struct route
{
	double distance;
	double duration;
};

struct point
{
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