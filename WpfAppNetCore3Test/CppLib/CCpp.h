// MathLibrary.h - Contains declarations of math functions
#pragma once

#ifdef CPPLIB_EXPORTS
#define CPPLIB_API __declspec(dllexport)
#else
#define CPPLIB_API __declspec(dllimport)
#endif

extern "C" CPPLIB_API void SleepTest();