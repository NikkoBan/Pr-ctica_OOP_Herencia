using System;
using System.Collections.Generic;

// Clase base: Persona
public class Persona
{
    protected string nombre;

    public Persona(string nombre)
    {
        this.nombre = nombre;
    }

    public void mostrarNombre()
    {
        Console.WriteLine("Nombre: " + nombre);
    }
}

// Clase derivada: Profesor
public class Profesor : Persona
{
    private List<string> cursos;

    public Profesor(string nombre) : base(nombre)
    {
        cursos = new List<string>();
    }

    public void impartirCurso(string curso)
    {
        cursos.Add(curso);
        Console.WriteLine(nombre + " está impartiendo el curso: " + curso);
    }
}

// Clase derivada: Estudiante
public class Estudiante : Persona
{
    private int numeroEstudiante;

    public Estudiante(string nombre, int numeroEstudiante) : base(nombre)
    {
        this.numeroEstudiante = numeroEstudiante;
    }

    public void asistirClase()
    {
        Console.WriteLine(nombre + " está asistiendo a clase.");
    }
}

// Clase: Curso
public class Curso
{
    private string nombre;
    private int recuentoClases;
    private int recuentoEjercicios;

    public Curso(string nombre, int recuentoClases, int recuentoEjercicios)
    {
        this.nombre = nombre;
        this.recuentoClases = recuentoClases;
        this.recuentoEjercicios = recuentoEjercicios;
    }

    public void mostrarDetalles()
    {
        Console.WriteLine("Curso: " + nombre);
        Console.WriteLine("Número de clases: " + recuentoClases);
        Console.WriteLine("Número de ejercicios: " + recuentoEjercicios);
    }
}

// Clase: Clase
public class Clase
{
    private string identificador;
    private List<Estudiante> estudiantes;
    private List<Profesor> profesores;

    public Clase(string identificador)
    {
        this.identificador = identificador;
        estudiantes = new List<Estudiante>();
        profesores = new List<Profesor>();
    }

    public void agregarEstudiante(Estudiante estudiante)
    {
        estudiantes.Add(estudiante);
        Console.WriteLine("Estudiante " + estudiante.mostrarNombre() + " ha sido agregado a la clase " + identificador);
    }

    public void agregarProfesor(Profesor profesor)
    {
        profesores.Add(profesor);
        Console.WriteLine("Profesor " + profesor.mostrarNombre() + " ha sido agregado a la clase " + identificador);
    }

    public void impartirClase()
    {
        Console.WriteLine("La clase " + identificador + " está siendo impartida.");
    }
}

// Clase: Escuela
public class Escuela
{
    private List<Clase> clases;

    public Escuela()
    {
        clases = new List<Clase>();
    }

    public void agregarClase(Clase clase)
    {
        clases.Add(clase);
        Console.WriteLine("La clase " + clase.ToString() + " ha sido agregada a la escuela.");
    }

    public void mostrarClases()
    {
        Console.WriteLine("Las clases de la escuela son:");
        foreach (var clase in clases)
        {
            Console.WriteLine(clase.ToString());
        }
    }
}