#include "board/board.h"

int speed=0;
int dir=0;
#define MAX_SPEED 180

void board_init()
{
	//sserial_send_end(UART_485);
	UCSR0B |= (1<<RXCIE0);
	sei();
}

ISR(USART0_RX_vect)
{
	cli();
	sserial_poll_uart(UART_USB);
	sei();
}

void sserial_process_request(unsigned char portindex)
{
	//Получить скорость
	if (sserial_request.command==1)
	{
		wdt_reset();
		if (sserial_request.data[0]<255)
		{
			if (dir==0)
			{
				speed++;
				if (speed>MAX_SPEED) dir=1;
			}
			else
			{
				speed--;
				if (speed<0) dir=0;
			}
		}
		sserial_response.result=128+sserial_request.command;
		sserial_response.data[0]=speed;
		sserial_response.datalength=1;
		sserial_send_response();		
	}
	if (sserial_request.command==4)
	{
		wdt_reset();
		if (sserial_request.data[0]<255)	set_board_green_led(1);
		sserial_response.result=128+sserial_request.command;
		sserial_response.data[0]=1;
		sserial_response.datalength=1;
		sserial_send_response();
	}
	if (sserial_request.command==5)
	{
		wdt_reset();
		if (sserial_request.data[0]<255)	set_board_green_led(0);
		sserial_response.result=128+sserial_request.command;
		sserial_response.data[0]=1;
		sserial_response.datalength=1;
		sserial_send_response();
	}	
}

int main(void)
{
	wdt_enable(WDTO_4S);
	sserial_set_devname(DEV_NAME);
	uart_init_withdivider(UART_USB,UBRR_VALUE);
	_delay_ms(500);
	board_init();
	set_board_red_led(1);
    while (1) 
    {
		wdt_reset();
		//sserial_poll_uart(UART_485);
    }
}

