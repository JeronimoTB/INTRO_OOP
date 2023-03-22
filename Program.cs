// Console.WriteLine("Hola, ingresa 2 números...");
// Console.WriteLine("Numero Uno");
// int num_uno = int.Parse(Console.ReadLine());

// Console.WriteLine("Numero Dos");
// int num_dos = int.Parse(Console.ReadLine());

// Console.WriteLine("Que operacion desea realizar?\n1. Suma\n2. Resta\n3. Multiplicacion\n4. Division");
// int opera = int.Parse(Console.ReadLine());

// //Instanciar, crear un objeto o hacer una copia de la clase
// //Forma orientada a objetos
// //Instanciar la  class OperacionesAritmeticas (objeto de la class)
// //Class  objeto(instancia) (= new)sonPalabrasReservadas metodoConstructorDeLaClass

// var operacion_uno = new OperacionesAritmeticas(){
//     //oper = operacion,
//     numero_uno = num_uno,
//     numero_dos = num_dos,
//     operation = opera
// };


// //Ejemplo de que se pueden sacar muchas instancias, más este no sirve/se utiliza en este ejemplo
// var operacion_dos = new OperacionesAritmeticas(){
//     //oper = operacion,
//     numero_uno = num_uno,
//     numero_dos = num_dos
// };

// //Para mostrar los resultados de la suma, se debe hacer la operacion a traves
// //Del Objeto ya que es la que ahora tiene los atributos

// operacion_uno.operacionRealizar();
Console.WriteLine("Buen día, Bienvenido a el Hotel WC");
Console.WriteLine("Cuantas Días desea Hospedarse?");
float num_dia = float.Parse(Console.ReadLine());

Console.WriteLine("A qué tarifa pertenecen para Hospedarse?\n1. Individual\n2. Doble\n3. Familiar");
float caso_per = float.Parse(Console.ReadLine());

var operacion_uno = new OperacionesHotel(){
    caso_personas = caso_per,
    numero_dias = num_dia
};

operacion_uno.OperacionTarifas();