// ���� ifdef ���Ǵ���ʹ�� DLL �������򵥵�
// ��ı�׼�������� DLL �е������ļ��������������϶���� SMARTLOGISTICDLL_EXPORTS
// ���ű���ġ���ʹ�ô� DLL ��
// �κ�������Ŀ�ϲ�Ӧ����˷��š�������Դ�ļ��а������ļ����κ�������Ŀ���Ὣ
// SMARTLOGISTICDLL_API ������Ϊ�Ǵ� DLL ����ģ����� DLL ���ô˺궨���
// ������Ϊ�Ǳ������ġ�
#pragma once

#ifdef SMARTLOGISTICDLL_EXPORTS
#define SMARTLOGISTICDLL_API __declspec(dllexport)
#else
#define SMARTLOGISTICDLL_API __declspec(dllimport)
#endif

struct modifiedPoint;
struct modifiedRoute;

EXTERN_C SMARTLOGISTICDLL_API void _stdcall getPointByName(modifiedPoint& p);

EXTERN_C SMARTLOGISTICDLL_API void _stdcall getRoute(modifiedRoute& r);