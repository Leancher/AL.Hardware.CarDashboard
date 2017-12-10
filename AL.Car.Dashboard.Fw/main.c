#include "board/board.h"

#define INJ_AMOUNT 3
//130 ������������������ � ��/���, ����� �� 60, �������� � ��/���
//�������� �� ���-�� ��������
#define INJ_CAPACITY 130 / 60 * INJ_AMOUNT
#define SPEED_CORRECTION 12
#define LENGTH_WHEEL 0.025*13*2*3.14//2 m
//0.025� � �����
//13 ������ ������ � ������
//2*3.14 - ��*2*������ - ����� ���������� (������)

int dir=0;
#define MAX_SPEED 180

float inj_width_high=0;
float inj_width_low=0;
float inj_sum_high=0;
float inj_sum_1s=0;
float fuel_rate_ml_s=0;
float fuel_rate_l_h=0;
float fuel_rate_l_100km=0;

float spd_width_high=0;
float spd_width_low=0;
float spd_sum_high=0;
float spd_sum_1s=0;
float speed=0;
int spd_count_imp_1s=0;

//��������� ������������ �������� ��������
void measure_injector_impulse()
{
	TCNT1=0;
	//���� ���� ������� 1
	while (get_pb5_in()==1)
	{
		//���� ����� �������, �� ��� ��������
		//if (TCNT1>50000) return;
	}
	inj_width_high=TCNT1*0.008;
	TCNT1=0;
	//���� ���� ������� 0
	while (get_pb5_in()==0)
	{
		if (TCNT1>20000) return;
	}
	inj_width_low=TCNT1*0.008;
}

void measured_inj_imp_1s()
{
	int no_impulse_counter=0;
	inj_width_high = 0;
	inj_width_low = 0;
	inj_sum_high=0;
	inj_sum_1s=0;
	while (inj_sum_1s < 1000)
	{
		measure_injector_impulse();
		//���� ����� ��� ��������, �� �������
		if (inj_width_high==0) no_impulse_counter++;
		if (no_impulse_counter>20) return;
		inj_sum_1s = inj_sum_1s + inj_width_high + inj_width_low;
		inj_sum_high = inj_sum_high + inj_width_high;
	}
	//������ � ��/�, ����� �������� � ��, ����� �� 1000, �������� � ���
	fuel_rate_ml_s=inj_sum_high/1000*INJ_CAPACITY;
	//���� �������� ������ 1 (�������� ���), ������� �/�
	fuel_rate_l_h=fuel_rate_ml_s*3.6;
	//������ � �/100��
	//����� ���� �� ��������, �������� ����� � �����, �������� �� 3600, �������� � ��������
	//�������� �� ������ � ��/�, ����� �� 1000 ��� ���������� � ������
	//3600 ����� ����� �� 1000 �������� 3.6
	fuel_rate_l_100km = 100/speed*fuel_rate_ml_s*3.6;
}

//��������� ������������ �������� ��������
void measure_speed_impulse()
{
	TCNT1=0;
	//���� ���� ������� 1
	while (get_pb4_in()==1)
	{
		//���� ����� �������, �� ��� ��������
		//if (TCNT1>50000) return;
	}
	spd_width_high=TCNT1*0.008;
	TCNT1=0;
	//���� ���� ������� 0
	while (get_pb4_in()==0)
	{
		if (TCNT1>20000) return;
	}
	spd_width_low=TCNT1*0.008;
}

void measured_spd_imp_1s()
{
	int no_impulse_counter=0;
	spd_width_high = 0;
	spd_width_low = 0;
	spd_sum_high=0;
	spd_sum_1s=0;
	spd_count_imp_1s=0;
	while (spd_sum_1s < 1000)
	{
		measure_speed_impulse();
		spd_sum_1s = spd_sum_1s + spd_width_high + spd_width_low;
		spd_count_imp_1s++;
		//���� ����� ��� ��������, �� �������
		if (spd_width_high==0) no_impulse_counter++;
		if (no_impulse_counter>10)
		{
			spd_count_imp_1s=0;
			return;
		}
	}
	spd_count_imp_1s=spd_count_imp_1s/SPEED_CORRECTION;
	if (spd_count_imp_1s<1)
	{
		speed=1;
		return;
	}
	speed= spd_count_imp_1s * LENGTH_WHEEL *3.6;//3.6 ��/� � 1 �/�
}

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
	//����, �������� ��������
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
	
	if (sserial_request.command==1)
	{
		wdt_reset();
		if (sserial_request.data[0]<255)
		{
			measured_spd_imp_1s();
			measured_inj_imp_1s();
		}
		sserial_response.result=128+sserial_request.command;
		sserial_response.data[0]=speed;
		sserial_response.datalength=1;
		sserial_send_response();
	}	

	//����
	if (sserial_request.command==4)
	{
		wdt_reset();
		if (sserial_request.data[0]<255)	set_board_green_led(1);
		sserial_response.result=128+sserial_request.command;
		sserial_response.data[0]=1;
		sserial_response.datalength=1;
		sserial_send_response();
	}
	//����
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

