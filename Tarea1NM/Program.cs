using System;

public interface Medieval1
{
    void Torre();
}

public interface Medieval2
{
    void Muralla();
}

public interface Medieval3
{
    void Castillo();
}

public class ConstruirTorre : Medieval1
{
    public void Torre()
    {
        Console.WriteLine("Construccion de cuatro torres");
    }
}
public class ConstruirMuralla : Medieval2
{
    public void Muralla()
    {
        Console.WriteLine("Construccion de cuatro muralla");
    }
}
public class ConstruirCastillo : Medieval3
{
    public void Castillo()
    {
        Console.WriteLine("Construye un castillo al centro");
    }
}


public interface CreacionMedieval
{
    Medieval1 CreaTorre();
    Medieval2 CreaMuralla();
    Medieval3 CreaCastillo();
}
public class ConstruccionImperioOtomano : CreacionMedieval
{
    public Medieval1 CreaTorre() { return new ConstruirTorre(); }

    public Medieval2 CreaMuralla() { return new ConstruirMuralla(); }
    public Medieval3 CreaCastillo() { return new ConstruirCastillo(); }
}

public class ConstruccionImperioRomano : CreacionMedieval
{
    public Medieval1 CreaTorre() { return new ConstruirTorre(); }

    public Medieval2 CreaMuralla() { return new ConstruirMuralla(); }
    public Medieval3 CreaCastillo() { return new ConstruirCastillo(); }
}

public class Crear
{
    private readonly Medieval1 Torre_;
    private readonly Medieval2 Muralla_;
    private readonly Medieval3 Castillo_;
    public Crear(CreacionMedieval fabrica)
    {
        Torre_ = fabrica.CreaTorre();
        Muralla_ = fabrica.CreaMuralla();
        Castillo_ = fabrica.CreaCastillo();
    }
    public void Creacion()
    {
        Torre_.Torre();
        Muralla_.Muralla();
        Castillo_.Castillo();
    }
}
public class Programa
{
    public static void Main(string[] args)
    {
        CreacionMedieval CreacionOtomana = new ConstruccionImperioOtomano();
        Crear ImperioOtomano = new Crear(CreacionOtomana);
        ImperioOtomano.Creacion();
        CreacionMedieval CreacionRomana = new ConstruccionImperioRomano();
        Crear ImperioRomano = new Crear(CreacionRomana);
        ImperioRomano.Creacion();
    }
}