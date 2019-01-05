const int inputSensor = A0;           // On nomme la broche A0 connectée au capteur

// =======================================

void setup() { 
  
  pinMode(inputSensor, INPUT);  // Déclaration du capteur en entrée

  Serial.begin(9600);            // Initialisation de la communication série
  
}


// ======================================
// Boucle principale

void loop() {

  
  int degres = analogRead(inputSensor);  //degres récupère la valeur analogique du capteur
  
  float floatDegres = degres*0.48; //la valeur est ici convertie en degrés
  
  //Transfère de données sans virgule 
  int floatInt = floatDegres * 100;

  Serial.println(floatInt);   //On affiche la valeur en degrés dans le moniteur série
  delay(2000);
}
