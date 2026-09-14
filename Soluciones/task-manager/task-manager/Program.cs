using System;
using System.Collections.Generic;

Console.WriteLine("Aplicación de Gestión de Tareas v1.0.0 iniciada.");

Tasks.AddTask("Aprender Git a fondo");
Tasks.AddTask("Completar la práctica de Git");

Tasks.DisplayTasks();

Console.WriteLine("Fecha actual: " + Utils.FormatDate(DateTime.Now));
