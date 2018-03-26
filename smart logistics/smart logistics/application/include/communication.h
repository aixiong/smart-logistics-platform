#pragma once
#include<memory>
#include<string>
#include<vector>

class comImpl;

class communication
{
public:
	communication(std::string ipStr="106.11.208.26",unsigned portNum=80);
	bool connectServer();
	bool sendString(const std::vector<char>& content);
	bool recvString(std::vector<char>& content);
private:
	std::shared_ptr<comImpl> impl;
};

struct connectFailure
{
};