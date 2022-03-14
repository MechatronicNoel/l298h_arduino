/*
 * L298H GUI 
 * Recibo datos por medio de UART y se convierten a un valor entero
 * para controlar la velocidad y giro del motor
 * 
 * Creado el 13/03/2022
 * by Noel Dominguez
 */


#define GUI_BAUD_RATE 115200 /* Velocidad de UART para la comunicacion con la interfaz */

 /* Pin para controlar velociad del motor */
#define IN_1 22 /* Pines Digitales donde conectaremos nuestro driver de motor */
#define IN_2 23 /* Pines Digitales donde conectaremos nuestro driver de motor */
#define EN_A       5 /* GPIO donde conectaremos el ENANLE de nuestro driver */
#define PWM1_Ch    0 /* Canal para nuestro pwm*/
#define PWM1_Res   8 /* Resolucion de nuestro pwm 2^8 = 256*/
#define PWM1_Freq  1000 /* Frecuencia denuestro pwm  */


/* Prototipo de funciones */
static void update_motor_parameters(void);
static void motor_control(uint16_t pwm, uint8_t dir);

void setup() {
  ledcAttachPin(EN_A, PWM1_Ch);
  ledcSetup(PWM1_Ch, PWM1_Freq, PWM1_Res);
 
  pinMode(IN_1,OUTPUT);
  pinMode(IN_2,OUTPUT);
  Serial.begin(GUI_BAUD_RATE);
  motor_control(0,3);

}

void loop() {
  
  update_motor_parameters();
 
}

/*Esta funcion separa los valores recibidos por serial para este caso estoy enviando en este formato(pwm,dir)
  notese que separo los valores por una "," para lograr identificar los valores, posteriormente convierto la cadena a 
  un valor entero */
static void update_motor_parameters(void){
    char Buffer[256];
    char *Split_Buffer[256];
    char *ptr = NULL;
    byte index = 0;
    uint8_t size = 0;
    uint8_t pwm = 0;
    uint8_t dir = 0;

    while ( Serial.available () ){
        size = Serial.readBytesUntil('\n',Buffer,sizeof(Buffer));
        Buffer[size] = 0;  

            
       ptr = strtok(Buffer,",");

            while ( ptr != NULL){
                Split_Buffer[index] = ptr;
                index++;
                ptr = strtok(NULL, ",");

            }
        
        /* Convertirmos los valores seriales a enteros y mapeamos para el rango permito por arduino
         si se requiere convertir a otro rango especificado lea mas sobre la funcion map*/
        pwm = atoi(Split_Buffer[0]); 
        dir = atoi(Split_Buffer[1]);
        motor_control(pwm,dir);
        

    }
      
}

/*Esta funcion controla el giro y la velocidad del motor*/
static void motor_control(uint16_t pwm, uint8_t dir){

  ledcWrite(PWM1_Ch,pwm); /* 0 - 256 */ 

  if ( dir == 0 ){
    digitalWrite(IN_1,HIGH);
    digitalWrite(IN_2,LOW);
  } else if (dir == 1){
    digitalWrite(IN_1,LOW);
    digitalWrite(IN_2,HIGH);
  } else {
    digitalWrite(IN_1,LOW);
    digitalWrite(IN_2,LOW);
  }

  
}
