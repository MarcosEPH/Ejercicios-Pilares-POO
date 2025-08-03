using System;
using System.Collections.Generic;
using System.Linq;

class Libro
{
    public string Titulo { get; private set; }
    public string Autor { get; private set; }
    public bool Disponible { get; set; }
    public int Id { get; private set; }

    public Libro(string titulo, string autor, int id)
    {
        Titulo = titulo;
        Autor = autor;
        Id = id;
        Disponible = true;
    }
}

class Biblioteca
{
    private List<Libro> libros = new List<Libro>();
    private Dictionary<int, string> prestamos = new Dictionary<int, string>();
    private int siguienteId = 1;

    // Registrar un libro sin duplicar títulos
    public bool RegistrarLibro(string titulo, string autor)
    {
        if (libros.Any(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Ya existe un libro con ese título.");
            return false;
        }

        libros.Add(new Libro(titulo, autor, siguienteId++));
        Console.WriteLine("Libro registrado exitosamente.");
        return true;
    }

    // Prestar un libro si está disponible y registrar el usuario internamente
    public bool PrestarLibro(string titulo, string nombreUsuario)
    {
        Libro libro = libros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));

        if (libro == null)
        {
            Console.WriteLine("El libro no existe.");
            return false;
        }

        if (!libro.Disponible)
        {
            Console.WriteLine("El libro no está disponible.");
            return false;
        }

        libro.Disponible = false;
        prestamos[libro.Id] = nombreUsuario;
        Console.WriteLine($"Libro '{libro.Titulo}' prestado a {nombreUsuario}.");
        return true;
    }

    // Mostrar libros disponibles
    public void MostrarLibrosDisponibles()
    {
        var disponibles = libros.Where(l => l.Disponible).ToList();

        if (disponibles.Count == 0)
        {
            Console.WriteLine("No hay libros disponibles.");
            return;
        }

        Console.WriteLine("\nLibros disponibles:");
        foreach (var libro in disponibles)
        {
            Console.WriteLine($"- {libro.Titulo} por {libro.Autor} (ID: {libro.Id})");
        }
    }

    // Mostrar préstamos actuales (no se expone estructura interna)
    public void MostrarPrestamos()
    {
        if (prestamos.Count == 0)
        {
            Console.WriteLine("No hay préstamos registrados.");
            return;
        }

        Console.WriteLine("\nPréstamos registrados:");
        foreach (var entry in prestamos)
        {
            Libro libro = libros.FirstOrDefault(l => l.Id == entry.Key);
            if (libro != null)
            {
                Console.WriteLine($"- '{libro.Titulo}' prestado a {entry.Value}");
            }
        }
    }
}