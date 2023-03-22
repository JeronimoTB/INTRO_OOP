class OperacionesHotel
{
    public float caso_personas { get;set; }
    public float numero_dias { get;set; }
    
    public int TarifaIndi = 2500;

    public int TarifaDob = 4600;

    public int TarifaFam = 5200;


    public double tar_indi(float numero_dias){
        //Operaciones
        double tarifa1 = (TarifaIndi * numero_dias);
        double tarifaIva = tarifa1 + (tarifa1*0.19);
        double tarifaTot = tarifaIva - (tarifaIva*0.05);

        //Retornar Resultado (Se realiza mas no muestra nada)
        return tarifaTot;
    }

    public void TarifaIndividual(){
        //Operaciones
        double costo_indi = tar_indi(numero_dias);

        //Salida
        Console.WriteLine($"El costo de su estadia con el descuento del 5% es de: {costo_indi}");
    }

    public double tar_doble(float numero_dias){
        //Operaciones
        double tarifa2 = (TarifaDob * numero_dias);
        double tarifaIva2 = tarifa2 + (tarifa2*0.19);
        double tarifaTot2 = tarifaIva2 - (tarifaIva2*0.09);

        //Retornar Resultado (Se realiza mas no muestra nada)
        return tarifaTot2;
    }

    public void TarifaDoble(){
        //Operaciones
        double costo_doble = tar_doble(numero_dias);

        //Salida
        Console.WriteLine($"El costo de su estadia con el descuento del 9% es de: {costo_doble}");
    }

    public double tar_fam(float numero_dias){
        //Operaciones
        double tarifa3 = (TarifaFam * numero_dias);
        double tarifaIva3 = tarifa3 + (tarifa3*0.19);
        double tarifaTot3 = tarifaIva3 - (tarifaIva3*0.15);

        //Retornar Resultado (Se realiza mas no muestra nada)
        return tarifaTot3;
    }

    public void TarifaFamiliar(){
        //Operaciones
        double costo_familiar = tar_fam(numero_dias);

        //Salida
        Console.WriteLine($"El costo de su estadia con el descuento del 15% es de: {costo_familiar}");
    }


    public void OperacionTarifas(){
        switch (caso_personas)
        {
            case 1:
                TarifaIndividual();
                break;
            case 2:
                TarifaDoble();
                break;
            case 3:
                TarifaFamiliar();
                break;
            default:
                Console.WriteLine("Opción Inválida");
                break;
        }
    }
}