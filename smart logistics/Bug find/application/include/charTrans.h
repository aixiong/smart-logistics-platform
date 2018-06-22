#pragma once

#include<vector>
#include<string>
#include<wchar.h>

class charTrans
{
public:
	static std::vector<char> unicodeToUtf8(const wchar_t* uniStr);
	static std::wstring utf8ToUnicode(const std::vector<char>& utfStr);
	static std::string wStringToString(const std::wstring& wStr);
	static std::wstring stringToWstring(const std::string& str);
};