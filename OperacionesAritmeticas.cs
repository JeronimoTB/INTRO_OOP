class OperacionesAritmeticas
{
    //PROPIEDADES (Atributos)
    //mod acc  tipo dato  nombrePropieda (Atributo)
    //Metodo recibir (set) Metodo entregar (get)
    //Valor de la Propiedad
    public int numero_uno { get;set; }
    public int numero_dos { get;set; }
    public int operation { get; set; }

    //METODOS (Funciones o Acciones)
    //Metodo sin parametros
    //mod acc tipo retorno nombreMetodo
   
    //METODO QUE REALIZA SUMA
    public int sumar_num(int n1, int n2){
        //Operaciones
        int resultadoSuma = 0;
        resultadoSuma = n1 + n2;

        //Retornar Resultado (Se realiza mas no muestra nada)
        return resultadoSuma;
    }
    
    //METODO QUE IMPRIME LA SUMA
    public void ImprimirSuma(){
        //Operaciones
        int resulS = sumar_num(numero_uno, numero_dos);

        //Salida
        Console.WriteLine($"El resultado de la suma es: {resulS}");
    }

    //METODO QUE REALIZA RESTA
    public int restar_num(int n1, int n2){
        //Operaciones
        int resultadoResta = 0;
        resultadoResta = n1 - n2;

        //Retornar Resultado (Se realiza mas no muestra nada)
        return resultadoResta;
    }

    //METODO QUE IMPRIME LA RESTA
    public void ImprimirResta(){
        //Operaciones
        int resulR = restar_num(numero_uno, numero_dos);

        //Salida
        Console.WriteLine($"El resultado de la Resta es: {resulR}");
    }


    //METODO QUE REALIZA MULTIPLICACION
    public int multiplicar_num(int n1, int n2){
        //Operaciones
        int resultadoMulti = 0;
        resultadoMulti = n1 * n2;

        //Retornar Resultado (Se realiza mas no muestra nada)
        return resultadoMulti;
    }

    //METODO QUE IMPRIME LA MULTIPLICACION
    public void ImprimirMultiplicacion(){
        //Operaciones
        int resulM = multiplicar_num(numero_uno, numero_dos);

        //Salida
        Console.WriteLine($"El resultado de la Multiplicacion es: {resulM}");
    }

    //METODO QUE REALIZA DIVISION
    public int dividir_num(int n1, int n2){
        //Operaciones
        int resultadoDivi = 0;
        resultadoDivi = n1 / n2;

        //Retornar Resultado (Se realiza mas no muestra nada)
        return resultadoDivi;
    }

    public void ImprimirDivision(){
        //Operaciones
        int resulD = dividir_num(numero_uno, numero_dos);

        //Salida
        Console.WriteLine($"El resultado de la Multiplicacion es: {resulD}");
    }

      public void operacionRealizar(){
        switch (operation)
        {
            case 1:
                ImprimirSuma();
                break;
            case 2:
                ImprimirResta();
                break;
            case 3:
                ImprimirMultiplicacion();
                break;
            case 4:
                ImprimirDivision();
                break;
            default:
                Console.WriteLine("Opción Inválida");
                break;
        }
    }
    
     /*
    public void operacionRealizar (){
        if (operation == 1){
            sumar_num();
        }
        else if (operation == 2){
            restar_num();
        }
        else if (operation == 3){
            multiplicar_num();
        }
        else if (operation == 4){
            dividir_num();
        }
        else{
            Console.WriteLine("Operacion Invalida");
        }
    }
    */
    
    //Metodo Constructor 
    /*OperacionesAritmeticas(){
        gsgsgs
        gsgsgsg
        fasfdafsad
    }
    */
}