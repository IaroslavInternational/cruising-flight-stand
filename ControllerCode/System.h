#pragma once

#include "Headers/commands.h"

#include <HX711.h>
#include <Adafruit_INA219.h>

#define T_DELAY	   30
#define C_DELAY	   50
#define DELAY_TIME 1

#define S_BAUD_RATE	9600 
#define S_TIMEOUT	10	 

#define HX711_1_CLK	 3
#define HX711_1_DOUT 2
#define HX711_2_CLK	 5
#define HX711_2_DOUT 4
#define HX711_3_CLK	 7
#define HX711_3_DOUT 6
#define HX711_4_CLK	 9
#define HX711_4_DOUT 8
#define HX711_5_CLK	 11
#define HX711_5_DOUT 10

#define HX711_1_CAL_FACTOR 1.0f	
#define HX711_2_CAL_FACTOR 1.0f	
#define HX711_3_CAL_FACTOR 1.0f	
#define HX711_4_CAL_FACTOR 1.0f	
#define HX711_5_CAL_FACTOR 1.0f	
#define HX711_SCALE		   0.035274f

#define ASPD_IN A0
#define V_PIN	A1

#define MAX_V			   50			
#define SHUNT_1_RESISTANCE 0.0005	

class hx711_adc
{
public:
	hx711_adc(float cal_factor);
public:
	void  Setup(size_t data_pin, size_t clock_pin);	
	void  Process(String header, float* arr);			
	float GetUnits();
	float GetKoef();
	void  SetKoef(float koef);
private:
	HX711 hx711;									
	float calibration_factor;						
	float units = 0.0f;								
};

class voltmeter
{
public:
	voltmeter(uint8_t pin);
public:
	void Process(String header);
private:
	uint8_t pin;
};

class ampermeter
{
public:
	void Setup();
public:
	void Process(String header);
	float GetVoltage();
private:
	Adafruit_INA219 ina219;
};

class System
{
public:
	System();
public:	
	void InitiliazeModules();												
public:	
	void PreProcess(size_t b_rate = S_BAUD_RATE, size_t t_out = S_TIMEOUT); 
	void ProcessCommands();													
public:
	void  Tick();							
private:	
	hx711_adc tenzo1;
	hx711_adc tenzo2;
	hx711_adc tenzo3;
	hx711_adc tenzo4;
	hx711_adc tenzo5;
	voltmeter vm;
	ampermeter amp;
private:
	int   sum = 0;
	int   offset = 0;
	float Vout = 0.0f;
	float P = 0.0f;
	float sensorValue = 0.0f;
private:
	bool   set_koefs      = false;
	unsigned short int current_t_time = 0;
	unsigned short int current_time = 0;
	String sub_command    = "";	
};
