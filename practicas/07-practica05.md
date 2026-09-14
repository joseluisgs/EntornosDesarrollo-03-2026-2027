# Práctica de Git: Control de Versiones Avanzado

- [Práctica de Git: Control de Versiones Avanzado](#práctica-de-git-control-de-versiones-avanzado)
    - [**Práctica Individual: Desarrollo del Gestor de Tareas (`task-manager`)**](#práctica-individual-desarrollo-del-gestor-de-tareas-task-manager)


### **Práctica Individual: Desarrollo del Gestor de Tareas (`task-manager`)**

**Objetivo:** Desarrollar de forma individual una aplicación básica de gestión de tareas (`task-manager`) utilizando Git para el control de versiones. Durante el proceso, deberás aplicar los principios del control de versiones, gestionar distintas líneas de desarrollo, entender las diferencias y usos de la integración de cambios (fusión y reorganización), seleccionar cambios específicos y corregir errores comunes, todo en tu repositorio local.

**Instrucciones Generales:**

*   Realiza todos los pasos en un entorno de línea de comandos (terminal).
*   Guarda cada paso y cualquier mensaje de error o salida relevante, ya que podría ser útil para la entrega o la revisión.
*   **Lee cuidadosamente cada instrucción antes de ejecutarla y piensa qué acción de Git es la más adecuada.**
*   Para visualizar el historial y comprender el impacto de tus acciones, usa frecuentemente: `git log --oneline --graph --all`

---

**Fase 1: Preparación Inicial y Control Básico de Versiones**

1.  **Preparación del Entorno Git:**
    *   Si aún no lo has hecho, configura tu identidad en Git:
        ```bash
        git config --global user.name "Tu Nombre"
        git config --global user.email "tu.email@ejemplo.com"
        ```
    *   Configura tu editor de texto preferido (VS Code recomendado):
        ```bash
        git config --global core.editor "code --wait"
        ```
    *   Activa los colores en la salida de Git:
        ```bash
        git config --global color.ui auto
        ```
    *   Verifica la configuración: `git config --list`

2.  **Inicio del Proyecto:**
    *   Crea el directorio del proyecto y navega hasta él:
        ```bash
        mkdir task-manager
        cd task-manager
        ```
    *   Inicializa el repositorio Git: `git init`
    *   Verifica el estado: `git status`

3.  **Creación de la Estructura Base:**
    *   Crea el proyecto .NET:
        ```bash
        dotnet new console --name task-manager
        dotnet new sln --name task-manager
        dotnet sln add task-manager/task-manager.csproj
        ```
    *   Crea un archivo `README.md` con el contenido: `# Gestor de Tareas`
    *   Verifica el estado del repositorio.
    *   Añade todos los archivos al staging: `git add .`
    *   Guarda la instantánea: `git commit -m "feat: Configuración inicial del proyecto"`

4.  **Modificaciones y Actualizaciones:**
    *   Consulta el historial: `git log --oneline`
    *   Modifica `README.md` añadiendo: `Una aplicación sencilla para organizar tus tareas.`
    *   Modifica `Program.cs` cambiando la línea de `Console.WriteLine` a: `Console.WriteLine("Aplicación de Gestión de Tareas v1.0.0 iniciada.");`
    *   Verifica los cambios pendientes: `git diff`
    *   Añade solo `README.md` al staging: `git add README.md`
    *   Muestra las diferencias preparadas: `git diff --cached`
    *   Guarda: `git commit -m "docs: Añadir descripción al README"`

5.  **Corrección de Errores Locales:**
    *   Añade una función temporal en `Program.cs`:
        ```csharp
        // Función de prueba temporal
        ```
    *   Añade `Program.cs` al staging.
    *   Te das cuenta de que no la quieres. Retírala del staging: `git restore --staged Program.cs`
    *   Verifica: `git status` (debería aparecer como "modificado")
    *   Descarta los cambios: `git restore Program.cs`
    *   Ahora modifica `Program.cs` para que el mensaje sea: `Console.WriteLine("Aplicación de Gestión de Tareas v1.0.0 iniciada.");`
    *   Añade `Program.cs` al staging.
    *   Enmienda el último commit: `git commit --amend -m "feat: Añadir descripción al README y versión inicial v1.0.0"`
    *   Visualiza el historial: `git log --oneline` (deberías ver 2 commits)

---

**Fase 2: Líneas de Desarrollo Paralelas, Fusión vs. Reorganización, y Resolución de Conflictos**

1.  **Establecer una Línea de Desarrollo (`develop`):**
    *   Asegúrate de estar en `main`.
    *   Crea y cambia a la rama `develop`: `git checkout -b develop`

2.  **Implementación de una Nueva Funcionalidad (en `develop`):**
    *   Crea el archivo `Tasks.cs`:
        ```csharp
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
        }
        ```
    *   Modifica `Program.cs`:
        ```csharp
        using System;
        using System.Collections.Generic;

        Console.WriteLine("Aplicación de Gestión de Tareas v1.0.0 iniciada.");

        Tasks.AddTask("Aprender Git a fondo");
        Tasks.AddTask("Completar la práctica de Git");

        Console.WriteLine("Tareas actuales: " + Tasks.GetTasks().Count);
        ```
    *   Añade y commitea: `git add . && git commit -m "feat: Implementar gestión de tareas básicas"`

3.  **Corrección Urgente en la Línea Principal (`main`):**
    *   Cambia a `main`: `git checkout main`
    *   Crea rama de hotfix: `git checkout -b hotfix/fix-log`
    *   Modifica `Program.cs` (cambia "iniciada" por "lista"):
        ```csharp
        Console.WriteLine("Aplicación de Gestión de Tareas v1.0.0 lista.");
        ```
    *   Añade y commitea: `git add Program.cs && git commit -m "fix: Corregir mensaje inicial"`
    *   Vuelve a `main` y fusiona: `git checkout main && git merge hotfix/fix-log`
    *   Elimina la rama: `git branch -d hotfix/fix-log`

4.  **Divergencia de Desarrollos:**
    *   En `develop`: añade `Tasks.AddTask("Revisar la práctica");` en `Program.cs` y commitea.
    *   En `main`: añade `## Próximas Características` al final de `README.md` y commitea.
    *   Visualiza la divergencia: `git log --oneline --graph --all`

5.  **Demostración de Fusión (`merge`) con Conflicto:**
    *   Desde `develop`, crea `feature/merge-path`.
    *   Añade a `Tasks.cs` la función `DisplayTasks`:
        ```csharp
        public static void DisplayTasks()
        {
            Console.WriteLine("--- Lista de Tareas ---");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {lista[i]}");
            }
            Console.WriteLine("-----------------------");
        }
        ```
    *   Añade y commitea: `git add . && git commit -m "feat: Añadir función DisplayTasks"`
    *   **¡Simula el conflicto!** Cambia a `develop`.
    *   Modifica `Program.cs` en `develop`: cambia `"iniciada"` por `"preparada"`.
    *   Añade y commitea: `git add . && git commit -m "chore: Cambio que causará conflicto"`
    *   Intenta fusionar: `git merge feature/merge-path` → **¡ConFLICTO!**
    *   Abre `Program.cs`, verás los marcadores (`<<<<<<<`, `=======`, `>>>>>>>`).
    *   Resuelve: mantén el mensaje actualizado Y la función `DisplayTasks`.
    *   Añade y commitea: `git add . && git commit -m "merge: Resolver conflicto en Program.cs"`
    *   Elimina: `git branch -d feature/merge-path`

6.  **Demostración de Reorganización (`rebase`):**
    *   Desde `develop`, crea `feature/rebase-path`.
    *   Añade a `Tasks.cs` la función `DeleteTask`:
        ```csharp
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
        ```
    *   Añade y commitea: `git add . && git commit -m "feat: Añadir función DeleteTask"`
    *   Cambia a `develop` y añade `## Módulo de Seguridad` al `README.md`. Commitea.
    *   Vuelve a `feature/rebase-path` y reorganiza: `git rebase develop`
    *   Fusiona en `develop`: `git checkout develop && git merge feature/rebase-path`
    *   Visualiza: `git log --oneline --graph --all` (historial lineal)
    *   Elimina: `git branch -d feature/rebase-path`

---

**Fase 3: Selección de Commits Específicos y Recuperación de Errores Avanzada**

1.  **Selección de Commit Específico (`cherry-pick`):**
    *   Desde `develop`, crea `feature/small-utility`.
    *   Crea `Utils.cs`:
        ```csharp
        class Utils
        {
            public static string FormatDate(DateTime date)
            {
                return date.ToShortDateString();
            }
        }
        ```
    *   Añade y commitea: `git add . && git commit -m "feat: Añadir función FormatDate en Utils.cs"`
    *   Modifica `Program.cs` para usar `FormatDate`:
        ```csharp
        Console.WriteLine("Fecha actual: " + Utils.FormatDate(DateTime.Now));
        ```
    *   Añade y commitea: `git add . && git commit -m "feat: Integrar FormatDate en Program.cs"`
    *   Cambia a `develop`.
    *   Identifica el hash del commit que añadió solo `Utils.cs`: `git log feature/small-utility --oneline`
    *   Aplica solo ese commit: `git cherry-pick <hash-del-commit>`
    *   Visualiza: `git log --oneline` (el commit aparece en `develop`)

2.  **Deshacer un Commit Reciente:**
    *   En `develop`, crea `bug.txt` con: `Este archivo introduce un bug crítico.`
    *   Añade y commitea: `git add bug.txt && git commit -m "bug: Introducir bug accidental"`
    *   **Opción A (soft):** `git reset --soft HEAD~1` (mantiene cambios en staging)
    *   **Opción B (hard):** `git reset --hard HEAD~1` (borra todo)

3.  **Deshacer un Commit "Publicado" (`git revert`):**
    *   En `develop`, modifica `Program.cs` añadiendo: `Console.WriteLine("Característica publicada con error.");`
    *   Añade y commitea: `git add . && git commit -m "feat: Característica con error"`
    *   Revierte: `git revert HEAD`
    *   Visualiza: `git log --oneline` (se ve el commit de revert)

---

**Fase 4: Finalización y Reflexión**

1.  **Limpieza de Ramas:**
    *   Elimina todas las ramas `feature/*` y `hotfix/*` ya fusionadas.
    *   Verifica: `git branch`

2.  **Visualización del Historial Final:**
    *   `git log --oneline --graph --all`
    *   Reflexiona: ¿Cuándo usarías merge vs rebase en un proyecto real?

---

## Qué entregar

- [ ] Captura de `git log --oneline --graph --all` mostrando ramas merge y rebase
- [ ] Captura del conflicto resuelto (marcadores antes, resolución después)
- [ ] Captura de `git log` tras `cherry-pick` (se ve el commit duplicado)
- [ ] Captura de `git revert` en el historial
- [ ] Reflexión escrita (3-5 líneas): ¿Cuándo usarías merge vs rebase en un proyecto real?
