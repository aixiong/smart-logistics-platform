#include "..\include\charTrans.h"
#include<Windows.h>

std::vector<char> charTrans::unicodeToUtf8(const wchar_t * uniStr)
{
	unsigned len = WideCharToMultiByte(CP_UTF8, 0, uniStr, -1, NULL, 0, NULL, NULL);
	std::vector<char> utf8Str(len + 1, 0);
	WideCharToMultiByte(CP_UTF8, 0, uniStr, -1, &utf8Str[0], len, NULL, NULL);
	return utf8Str;
}

std::wstring  charTrans::utf8ToUnicode(const std::vector<char>& utf8Str)
{
	unsigned len = MultiByteToWideChar(CP_UTF8, NULL, &utf8Str[0], utf8Str.size(), NULL, 0);
	std::wstring uniStr(len + 1, 0);
	::MultiByteToWideChar(CP_UTF8, NULL, &utf8Str[0], utf8Str.size(), &uniStr[0], len);
	return uniStr;
}

std::string charTrans::wStringToString(const std::wstring& wStr)
{
	unsigned len = wStr.size() * 4;
	setlocale(LC_CTYPE, "");
	char *p = new char[len];
	wcstombs(p, wStr.c_str(), len);
	std::string str(p);
	delete[] p;
	return str;
}

std::wstring charTrans::stringToWstring(const std::string& str)
{
	unsigned len = str.size() * 2;// Ԥ���ֽ���
	setlocale(LC_CTYPE, "");     //������ô˺���
	wchar_t *p=new wchar_t[len];// ����һ���ڴ���ת������ַ���
	mbstowcs(p, str.c_str(), len);// ת��
	std::wstring wStr(p);
	delete[] p;// �ͷ�������ڴ�
	return wStr;
}
