// Clase base
public class Persona
{
    public string Nombre { get; set; }
}

// Herencia para estudiantes
public class Estudiante : Persona
{
    public int NumeroUnico { get; set; }
}

// Herencia para profesores
public class Profesor : Persona
{
    public List<Curso> Cursos { get; set; } = new List<Curso>();
}

// Clase Curso
public class Curso
{
    public string Nombre { get; set; }
    public int RecuentoClases { get; set; }
    public int RecuentoEjercicios { get; set; }
}

// Clase Clase (entidad)
public class Clase
{
    public string IdentificadorUnico { get; set; }
    public List<Profesor> Profesores { get; set; } = new List<Profesor>();
    public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
}

// Clase Escuela
public class Escuela
{
    public List<Clase> Clases { get; set; } = new List<Clase>();
}
