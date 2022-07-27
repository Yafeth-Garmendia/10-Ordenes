public  class  Vendedor : Persona
{
    public  string  CodigoVendedor { get ; set; }

    public  Vendedor ( int  codigo , string  nombre , string  codigoVendedor )
    {
        codigo  =  codigo ;
        Nombre  =  nombre ;
        CodigoVendedor  =  codigoVendedor ;
    }
}