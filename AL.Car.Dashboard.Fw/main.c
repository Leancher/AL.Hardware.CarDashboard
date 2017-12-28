#include "board/board.h"

float inj_width_h_lev = 0;
float inj_width_l_lev = 0;
float spd_width_h_lev = 0;
float spd_width_l_lev = 0;
//Измерение длительности импульса скорости, высокий и низкий уровни одинаковой ширины, меняется частота
//Меряем ширину только выского уровня
//Ширина 40мс (5000) с которой можно начинать считать
void measure_speed_impulse()
{
	TCNT1 = 0;
	//Ищем начало высокого уровня, ждем пока пройдет 1
	while (get_pb3_in() == 1)
	{
		//Если долго считает, то нет импульса
		if (TCNT1 > 5000) break;
	}
	TCNT1 = 0;
	//Ждем пока пройдет 0
	while (get_pb3_in() == 0)
	{
		if (TCNT1 > 5000) break;
	}
	spd_width_l_lev = TCNT1 * 0.008;
	TCNT1 = 0;
	//ждем пока пройдет 1
	while (get_pb3_in() == 1)
	{
		if (TCNT1 > 5000) break;
	}
	spd_width_h_lev = TCNT1 * 0.008;	
}

//Измерение длительности открытия форсунки
void measure_injector_impulse()
{
	TCNT1 = 0;
	//Ищем начало периода, ждем пока пройдет 1
	while (get_pb5_in() == 1)
	{
		//Если долго считает, то нет импульса, макс 20 мс, 2500
		if (TCNT1 > 4000) break;
	}
	TCNT1 = 0;
	//Ищем начало периода, ждем пока пройдет 0
	while (get_pb5_in() == 0)
	{
		if (TCNT1 > 15000) break;
	}
	TCNT1 = 0;
	//Считаем высокий уровень, ждем пока пройдет 1
	while (get_pb5_in() == 1)
	{
		if (TCNT1 > 4000) break;
	}
	inj_width_h_lev = TCNT1 * 0.008;
	TCNT1 = 0;
	//Считаем низкий уровень, ждем пока пройдет 0, макс 120мс, 15000
	while (get_pb5_in() == 0)
	{
		if (TCNT1 > 15000) break;
	}
	inj_width_l_lev = TCNT1 * 0.008;	
}

void sserial_process_request(unsigned char portindex)
{
	if (sserial_request.command == 1)
	{
		wdt_reset();
		if (sserial_request.data[0] < 255) measure_injector_impulse();
		sserial_response.result = 128 + sserial_request.command;
		//Умножаем на десять для получения одного знака после запятой
		sserial_response.data[0] = inj_width_h_lev * 10;						
		sserial_response.data[1] = inj_width_l_lev;
		sserial_response.datalength = 2;
		sserial_send_response();
	}
	
	if (sserial_request.command == 2)
	{
		wdt_reset();
		if (sserial_request.data[0] < 255) measure_speed_impulse();
		sserial_response.result = 128 + sserial_request.command;
		sserial_response.data[0] = spd_width_h_lev;
		sserial_response.data[1] = spd_width_l_lev;
		sserial_response.datalength = 2;
		sserial_send_response();
	}
	
	//Тест
	if (sserial_request.command == 4)
	{
		wdt_reset();
		if (sserial_request.data[0] < 255)	set_board_green_led(1);
		sserial_response.result = 128 + sserial_request.command;
		sserial_response.data[0] = 1;
		sserial_response.datalength = 1;
		sserial_send_response();
	}
	//Тест
	if (sserial_request.command == 5)
	{
		wdt_reset();
		if (sserial_request.data[0] < 255)	set_board_green_led(0);
		sserial_response.result = 128 + sserial_request.command;
		sserial_response.data[0] = 1;
		sserial_response.datalength = 1;
		sserial_send_response();
	}	
}

ISR(USART0_RX_vect)
{
	cli();
	sserial_poll_uart(UART_USB);
	sei();
}

int main(void)
{
	wdt_enable(WDTO_4S);
	sserial_set_devname(DEV_NAME);
	uart_init_withdivider(UART_USB,UBRR_VALUE);
	_delay_ms(500);
	set_board_green_led(1);
	pb3_in_enable();
	pb5_in_enable();

	//предделитель на 64, 125кГц, 0.008млс
	TCCR1B &= ~(1 << CS12);
	TCCR1B |=  (1 << CS11);
	TCCR1B |=  (1 << CS10);

	UCSR0B |= (1<<RXCIE0);
	sei();
    while (1) 
    {
		wdt_reset();
    }
}