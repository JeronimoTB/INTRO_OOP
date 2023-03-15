class OperacionesAritmeticas
{
    //PROPIEDADES (Atributos)
    //mod acc  tipo dato  nombrePropieda (Atributo)
    //Metodo recibir (set) Metodo entregar (get)
    //Valor de la Propiedad
    public int numero_uno { get;set; }
    public int numero_dos { get;set; }

    //METODOS (Funciones o Acciones)
    //Metodo sin parametros
    //mod acc tipo retorno nombreMetodo
    public void sumar_num(){
        //Operaciones
        float resul = numero_uno + numero_dos;

        //Salida
        Console.WriteLine("El resultado de la suma es " + resul);
    }

    public void restar_num(){
        //Operaciones
        float resul = numero_uno - numero_dos;

        //Salida
        Console.WriteLine("El resultado de la resta es " + resul);
    }

    public void multiplicar_num(){
    float resul = numero_uno * numero_dos;

    Console.WriteLine("El resultado de la multiplicacion es " + resul);
    }

    public void dividir_num(){
    float resul = numero_uno / numero_dos;

    Console.WriteLine("El resultado de la division es " + resul);
    }

    //Metodo Constructor 
    /*OperacionesAritmeticas(){
        gsgsgs
        gsgsgsg
        fasfdafsad
    }
    */
}