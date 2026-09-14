using System;
using System.Collections.Generic;

class Tasks
{
    static List<string> lista = new List<string>();

    public static void AddTask(string description)
    {
        lista.Add(description);
        Console.WriteLine($"Tarea \"{description}\" añadida.");
    }

    public static List<string> GetTasks()
    {
        return lista;
    }

    public static void DisplayTasks()
    {
        Console.WriteLine("--- Lista de Tareas ---");
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {lista[i]}");
        }
        Console.WriteLine("-----------------------");
    }

    public static void DeleteTask(int index)
    {
        if (index >= 0 && index < lista.Count)
        {
            Console.WriteLine($"Tarea \"{lista[index]}\" eliminada.");
            lista.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Índice no válido.");
        }
    }
}
