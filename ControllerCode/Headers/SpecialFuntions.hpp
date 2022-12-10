#pragma once

#include <Arduino.h>
#include "commands.h"

namespace SpecialFunctions
{
	static inline void SendData(String header, String value)
	{
		Serial.print(header);
		Serial.print(SPLITTER_SIGN);
		Serial.print(value);

		Serial.println();
	}

    template<typename T>
    static inline T mean(T* arr, size_t len)
    {
        T sum = (T)0.0;

        for (size_t i = 0; i < len; i++)
        {
            sum = sum + arr[i];
        }

        return T(sum / len);
    }
}