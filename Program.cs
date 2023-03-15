Console.WriteLine("Hola Mundo");
Console.WriteLine("Numero Uno");
int num_uno = int.Parse(Console.ReadLine());

Console.WriteLine("Numero Dos");
int num_dos = int.Parse(Console.ReadLine());

//Instanciar, crear un objeto o hacer una copia de la clase
//Forma orientada a objetos
//Instanciar la  class OperacionesAritmeticas (objeto de la class)
//Class  objeto(instancia) (= new)sonPalabrasReservadas metodoConstructorDeLaClass

var operacion_uno = new OperacionesAritmeticas(){
    //oper = operacion,
    numero_uno = num_uno,
    numero_dos = num_dos
};

var operacion_dos = new OperacionesAritmeticas(){
    //oper = operacion,
    numero_uno = num_uno,
    numero_dos = num_dos
};


//Ver los resultados de la suma
operacion_uno.sumar_num();
operacion_uno.restar_num();
operacion_uno.multiplicar_num();
operacion_uno.dividir_num();
