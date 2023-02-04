#include "System.h"
#include "Headers\SpecialFuntions.hpp"

float t1Data[T_DELAY];
float t2Data[T_DELAY];
float t3Data[T_DELAY];
float t4Data[T_DELAY];
float t5Data[T_DELAY];
float cData[C_DELAY];

/*   System stuff   */

System::System()
	:
	tenzo1(HX711_1_CAL_FACTOR),
	tenzo2(HX711_2_CAL_FACTOR),
	tenzo3(HX711_3_CAL_FACTOR),
	tenzo4(HX711_4_CAL_FACTOR),
	tenzo5(HX711_5_CAL_FACTOR),
	vm(V_PIN),
	pt(ASPD_IN)
{}

void System::InitiliazeModules()
{
	tenzo1.Setup(HX711_1_DOUT, HX711_1_CLK);
	tenzo2.Setup(HX711_2_DOUT, HX711_2_CLK);
	tenzo3.Setup(HX711_3_DOUT, HX711_3_CLK);
	tenzo4.Setup(HX711_4_DOUT, HX711_4_CLK);
	tenzo5.Setup(HX711_5_DOUT, HX711_5_CLK);

	amp.Setup();
}

void System::PreProcess(size_t b_rate, size_t t_out)
{
	Serial.begin(b_rate);
	Serial.setTimeout(t_out);

	pt.Init();

	/*while (true)
	{
		if (Serial.available() > 0)
		{
			String data = Serial.readString();
			Serial.println(data);

			if (data == WORK_MODE_ACTIVE)
			{
				Serial.println(WORK_MODE_ACTIVATING);
				break;
			}
		}
	}*/
}

void System::ProcessCommands()
{
	// Если порт доступен
/*	if (Serial.available() > 0)
	{
		String command = Serial.readString();
	}*/
}

void System::Tick()
{
	t1Data[current_t_time] = tenzo1.GetUnits();
	t2Data[current_t_time] = tenzo2.GetUnits();
	t3Data[current_t_time] = tenzo3.GetUnits();
	t4Data[current_t_time] = tenzo4.GetUnits();
	t5Data[current_t_time] = tenzo5.GetUnits();
	cData[current_time]    = amp.GetVoltage();

	current_t_time = current_t_time + DELAY_TIME;
    current_time = current_time + DELAY_TIME;

	if (current_time == C_DELAY)
	{
		amp.Process(A_DATA);

		current_time = 0;
	}

	if (current_t_time == T_DELAY)
	{
		tenzo1.Process(Tenzo1, t1Data);
		tenzo2.Process(Tenzo2, t2Data);
		tenzo3.Process(Tenzo3, t3Data);
		tenzo4.Process(Tenzo4, t4Data);
		tenzo5.Process(Tenzo5, t5Data);

		current_t_time = 0;
	}

	vm.Process(V_DATA);

	pt.Process(Pito);
	pt.Process(Pito_Raw);
}

/* end System stuff */

/*   HX 711 stuff   */

hx711_adc::hx711_adc(float cal_factor)
	:
	calibration_factor(cal_factor)
{}

void hx711_adc::Setup(size_t data_pin, size_t clock_pin)
{
	hx711.begin(data_pin, clock_pin);
	hx711.set_scale(calibration_factor);
	hx711.tare();
}

void hx711_adc::Process(String header, float* arr)
{
	Serial.print(header);
	Serial.print("|");
	Serial.print(String(SpecialFunctions::mean<float>(arr, T_DELAY)));
	Serial.print("\n");
}

float hx711_adc::GetUnits()
{
	units = hx711.get_units(), 10;

	//if (units < 0)
	//{
	//	units = 0.00;
	//}

	return units * HX711_SCALE;
}

float hx711_adc::GetKoef()
{
	return calibration_factor;
}

void hx711_adc::SetKoef(float koef)
{
	calibration_factor = koef;
	hx711.set_scale(koef);
}

/* end HX 711 stuff */

/*   pito stuff   */

pito::pito(uint8_t pin)
{
	pinMode(pin, INPUT);
}

void pito::Process(String header)
{
	sensorValue = analogRead(pin) - offset;
	Vout = (5 * sensorValue) / 1024.0;
	P = Vout - 2.5;

	if (header == Pito)
	{
		SpecialFunctions::SendData(header, (String)P);
	}
	else if (header == Pito_Raw)
	{
		SpecialFunctions::SendData(header, (String)(analogRead(pin)));
	}
}

void pito::Init()
{
	for (int i = 0; i < 10; i++)
	{
		sensorValue = analogRead(pin) - 512;
		sum += sensorValue;
	}

	offset = sum / 10.0;
}

/* end pito stuff */

/*   voltmeter stuff   */

voltmeter::voltmeter(uint8_t pin)
{
	pinMode(pin, INPUT);
}

void voltmeter::Process(String header)
{
	SpecialFunctions::SendData(header, (String)map(analogRead(this->pin), 0, 1023, 0, MAX_V));
}

/* end voltmeter stuff */

/*   ampermeter stuff   */

void ampermeter::Setup()
{
	if (!ina219.begin()) {
		Serial.println("Failed to find INA219 chip");
	}
}

void ampermeter::Process(String header)
{
	SpecialFunctions::SendData(header, (String)SpecialFunctions::mean(cData, C_DELAY));
}

float ampermeter::GetVoltage()
{
	return ina219.getShuntVoltage_mV();
}

/* end ampermeter stuff */