#include "thingProperties.h"

const int buttonPin = 26;   
const int ledPin = 13;      
const unsigned long resetInterval = 120000;  
unsigned long lastResetTime = 0;  

int buttonState = 0;           
int previousButtonState = 0;  

void setup() {
  // Inicializa a comunica��o serial
  Serial.begin(9600);
  while (!Serial) { ; } // Aguarda a serial

  // Configura o pino do bot�o como entrada com pull-up interno
  pinMode(buttonPin, INPUT_PULLUP);

  // Configura o pino do LED como sa�da
  pinMode(ledPin, OUTPUT);

  // Inicializa as propriedades da IoT Cloud
  initProperties();

  // Conecta � Arduino IoT Cloud
  ArduinoCloud.begin(ArduinoIoTPreferredConnection);

  // Espera pela sincroniza��o das propriedades
  setDebugMessageLevel(2);
  ArduinoCloud.printDebugInfo();
}

void loop() {
  ArduinoCloud.update(); // Atualiza a conex�o com a nuvem

  // L� o estado atual do bot�o
  buttonState = digitalRead(buttonPin);

  // Verifica se houve mudan�a no estado do bot�o
  if (buttonState != previousButtonState) {
    if (buttonState == LOW) {  // Bot�o foi pressionado
      buttonPressCount++; // Incrementa o contador de press�es
      buttonPressed = true; // Sinaliza que o bot�o foi pressionado

      // Pisca o LED indicando que o bot�o foi pressionado
      digitalWrite(ledPin, HIGH);
      delay(100); // Mant�m o LED ligado por 100ms
      digitalWrite(ledPin, LOW);

      // Aguarda um intervalo de debounce
      delay(100); 
    } else {
      buttonPressed = false; // Reseta o estado do bot�o pressionado
    }
  }

  // Atualiza o estado anterior do bot�o
  previousButtonState = buttonState;

  // Verifica se � hora de realizar o reset manual do contador
  if (millis() - lastResetTime >= resetInterval) {
    buttonPressCount = 0; // Zera o contador de press�es
    lastResetTime = millis(); // Atualiza o �ltimo tempo de reset
  }
}

// Fun��es de callback para mudan�as nas vari�veis da IoT Cloud
void onButtonPressCountChange() {
  // Implementa��o para manipular mudan�as na vari�vel buttonPressCount
}

void onButtonPressedChange() {
  // Implementa��o para manipular mudan�as na vari�vel buttonPressed
}
