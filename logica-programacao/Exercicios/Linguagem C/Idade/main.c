#include "thingProperties.h"

const int buttonPin = 26;   
const int ledPin = 13;      
const unsigned long resetInterval = 120000;  
unsigned long lastResetTime = 0;  

int buttonState = 0;           
int previousButtonState = 0;  

void setup() {
  // Inicializa a comunicação serial
  Serial.begin(9600);
  while (!Serial) { ; } // Aguarda a serial

  // Configura o pino do botão como entrada com pull-up interno
  pinMode(buttonPin, INPUT_PULLUP);

  // Configura o pino do LED como saída
  pinMode(ledPin, OUTPUT);

  // Inicializa as propriedades da IoT Cloud
  initProperties();

  // Conecta à Arduino IoT Cloud
  ArduinoCloud.begin(ArduinoIoTPreferredConnection);

  // Espera pela sincronização das propriedades
  setDebugMessageLevel(2);
  ArduinoCloud.printDebugInfo();
}

void loop() {
  ArduinoCloud.update(); // Atualiza a conexão com a nuvem

  // Lê o estado atual do botão
  buttonState = digitalRead(buttonPin);

  // Verifica se houve mudança no estado do botão
  if (buttonState != previousButtonState) {
    if (buttonState == LOW) {  // Botão foi pressionado
      buttonPressCount++; // Incrementa o contador de pressões
      buttonPressed = true; // Sinaliza que o botão foi pressionado

      // Pisca o LED indicando que o botão foi pressionado
      digitalWrite(ledPin, HIGH);
      delay(100); // Mantém o LED ligado por 100ms
      digitalWrite(ledPin, LOW);

      // Aguarda um intervalo de debounce
      delay(100); 
    } else {
      buttonPressed = false; // Reseta o estado do botão pressionado
    }
  }

  // Atualiza o estado anterior do botão
  previousButtonState = buttonState;

  // Verifica se é hora de realizar o reset manual do contador
  if (millis() - lastResetTime >= resetInterval) {
    buttonPressCount = 0; // Zera o contador de pressões
    lastResetTime = millis(); // Atualiza o último tempo de reset
  }
}

// Funções de callback para mudanças nas variáveis da IoT Cloud
void onButtonPressCountChange() {
  // Implementação para manipular mudanças na variável buttonPressCount
}

void onButtonPressedChange() {
  // Implementação para manipular mudanças na variável buttonPressed
}
