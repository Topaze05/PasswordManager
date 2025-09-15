#pragma once

int test();


extern "C" __declspec(dllexport) int Test() {
	return test();
}