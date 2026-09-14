# Práctica de Git: Control de Versiones Avanzado

- [Práctica de Git: Control de Versiones Avanzado](#práctica-de-git-control-de-versiones-avanzado)
    - [**Práctica Individual: Desarrollo del Gestor de Tareas (`task-manager`)**](#práctica-individual-desarrollo-del-gestor-de-tareas-task-manager)


### **Práctica Individual: Desarrollo del Gestor de Tareas (`task-manager`)**

**Objetivo:** Desarrollar de forma individual una aplicación básica de gestión de tareas (`task-manager`) utilizando Git para el control de versiones. Durante el proceso, deberás aplicar los principios del control de versiones, gestionar distintas líneas de desarrollo, entender las diferencias y usos de la integración de cambios (fusión y reorganización), seleccionar cambios específicos y corregir errores comunes, todo en tu repositorio local.

**Instrucciones Generales:**

*   Realiza todos los pasos en un entorno de línea de comandos (terminal).
*   Guarda cada paso y cualquier mensaje de error o salida relevante, ya que podría ser útil para la entrega o la revisión.
*   **Lee cuidadosamente cada instrucción antes de ejecutarla y piensa qué acción de Git es la más adecuada.**
*   Para visualizar el historial y comprender el impacto de tus acciones, recuerda que existe una herramienta para **mostrar el historial de confirmaciones de forma concisa, con ramas y en formato gráfico, incluyendo todas las referencias**. Utilízala frecuentemente.

---

**Fase 1: Preparación Inicial y Control Básico de Versiones**

1.  **Preparación del Entorno Git:**
    *   Si aún no lo has hecho, informa a Git sobre **quién eres** (tu nombre de usuario) y **cómo contactarte** (tu dirección de correo electrónico) a nivel global en tu sistema.
    *   Define cuál es tu **editor de texto preferido** para que Git lo utilice automáticamente cuando necesite que escribas un mensaje.
    *   Activa la visualización de **colores en la salida de Git** para facilitar la lectura.
    *   Verifica la configuración de Git para confirmar que tus preferencias se han aplicado correctamente.

2.  **Inicio del Proyecto:**
    *   Crea un nuevo directorio en tu sistema con el nombre `task-manager`.
    *   Dentro de este directorio, **inicializa un nuevo repositorio Git vacío** para comenzar el control de versiones.
    *   Verifica el estado actual de tu repositorio. Debería indicar que no hay confirmaciones y que el directorio de trabajo está limpio.

3.  **Creación de la Estructura Base:**
    *   Crea un archivo llamado `README.md` con el siguiente contenido: `# Gestor de Tareas`.
    *   Crea un archivo llamado `main.js` con el siguiente contenido: `console.log("Aplicación de Gestión de Tareas iniciada.");`
    *   Verifica el estado del repositorio. Deberías ver los nuevos archivos, indicando que no están siendo rastreados.
    *   **Añade ambos archivos** a la zona de intercambio (staging area), preparándolos para la siguiente instantánea.
    *   Verifica el estado de nuevo. Los archivos deberían aparecer como "preparados para confirmar".
    *   **Guarda la instantánea actual** de tu proyecto con un mensaje descriptivo: `"feat: Configuración inicial del proyecto"`.

4.  **Modificaciones y Actualizaciones:**
    *   Consulta el **historial de confirmaciones** de tu repositorio para ver las instantáneas guardadas.
    *   Modifica el archivo `README.md` añadiendo una nueva línea debajo del título con la frase: `Una aplicación sencilla para organizar tus tareas.`.
    *   Modifica el archivo `main.js` añadiendo una nueva línea al final con: `// Versión 1.0.0`.
    *   Verifica el estado del repositorio. Deberías ver los archivos como "modificados", pero aún no preparados.
    *   Muestra las diferencias de los cambios que has realizado pero que **aún no están en la zona de intercambio**.
    *   **Añade solo `README.md`** a la zona de intercambio.
    *   Muestra las diferencias de los cambios que **ya están en la zona de intercambio** y listos para ser guardados.
    *   **Guarda la instantánea** de los cambios de `README.md` con el mensaje: `"docs: Añadir descripción al README"`.

5.  **Corrección de Errores Locales (Antes de Compartir):**
    *   Modifica `main.js` añadiendo una función de prueba temporal:
        ```javascript
        function testFeature() {
            console.log("Función de prueba temporal.");
        }
        ```
    *   Añade `main.js` a la zona de intercambio.
    *   Te das cuenta de que no quieres esa función de prueba en la próxima instantánea. **Retira los cambios de `main.js` de la zona de intercambio**, pero manteniendo la función de prueba en tu directorio de trabajo.
    *   Verifica el estado para confirmar que `main.js` ahora aparece como "modificado" (sin preparar).
    *   Ahora, decide que quieres descartar completamente esa función de prueba. **Deshaz los cambios en `main.js`** para que vuelva al estado de su última instantánea guardada. **¡Cuidado! Este tipo de acción es destructiva si no estás seguro de lo que haces**.
    *   Verifica el estado del repositorio. `main.js` ya no debería mostrar cambios.
    *   **Enmendar la Última Instantánea:** Modifica `main.js` para que contenga: `console.log("Aplicación de Gestión de Tareas v1.0.0 iniciada.");`.
    *   Añade `main.js` a la zona de intercambio.
    *   Te das cuenta de que la última instantánea guardada (`"docs: Añadir descripción al README"`) debería haber incluido también esta actualización de versión. **Modifica la última instantánea para incluir los cambios de `main.js` y ajusta el mensaje** a: `"feat: Añadir descripción al README y versión inicial v1.0.0"`.
    *   Visualiza el historial de confirmaciones de forma concisa para ver que solo hay 2 instantáneas y la última tiene el mensaje ajustado.

---

**Fase 2: Líneas de Desarrollo Paralelas, Fusión vs. Reorganización, y Resolución de Conflictos**

1.  **Establecer una Línea de Desarrollo (`develop`):**
    *   Asegúrate de estar en la línea de desarrollo principal (por defecto, `master`).
    *   **Crea una nueva línea de desarrollo paralela** llamada `develop` y **cambia a ella inmediatamente**.
    *   Verifica en qué línea de desarrollo te encuentras.

2.  **Implementación de una Nueva Funcionalidad (en `develop`):**
    *   En la línea `develop`, crea un nuevo archivo llamado `tasks.js` con el siguiente contenido:
        ```javascript
        const tasks = [];
        function addTask(description) {
            tasks.push({ id: tasks.length + 1, description, completed: false });
            console.log(`Tarea "${description}" añadida.`);
        }
        function getTasks() {
            return tasks;
        }
        export { addTask, getTasks };
        ```
    *   Modifica `main.js` para importar y usar `addTask`:
        ```javascript
        import { addTask, getTasks } from './tasks.js';
        console.log("Aplicación de Gestión de Tareas v1.0.0 iniciada.");
        // Versión 1.0.0
        addTask("Aprender Git a fondo");
        addTask("Completar la práctica de Git");
        console.log("Tareas actuales:", getTasks());
        ```
    *   Añade `tasks.js` y `main.js` a la zona de intercambio.
    *   **Guarda la instantánea** de los cambios con el mensaje: `"feat: Implementar gestión de tareas básicas y añadir ejemplos"`.

3.  **Corrección Urgente en la Línea Principal (`master`):**
    *   Imagina que se detecta un error crítico en la línea `master` y necesitas corregirlo urgentemente. **Cambia a la línea `master`**.
    *   **Crea una nueva línea de desarrollo temporal** llamada `hotfix/fix-log` y **cambia a ella**.
    *   En esta nueva línea, modifica `main.js` para corregir el mensaje inicial (cambia `iniciada` por `lista`):
        ```javascript
        console.log("Aplicación de Gestión de Tareas v1.0.0 lista.");
        // Versión 1.0.0
        ```
    *   Añade `main.js` a la zona de intercambio.
    *   **Guarda la instantánea** del cambio con el mensaje: `"fix: Corregir mensaje inicial en console.log"`.
    *   **Cambia de nuevo a la línea `master`**.
    *   **Integra la línea `hotfix/fix-log` en `master`**. Observa que esta integración debería ser un "avance rápido" (fast-forward merge) ya que la línea de corrección es un descendiente directo de `master`.
    *   Visualiza el historial completo para ver la fusión lineal.
    *   **Elimina la línea `hotfix/fix-log`**, ya que sus cambios ya están en `master` y no se necesita más.

4.  **Divergencia de Desarrollos para Comparación de Integraciones:**
    *   **En la línea `develop`:** Asegúrate de estar en ella. Añade una nueva tarea en `main.js`: `addTask("Revisar la práctica");`.
    *   Añade `main.js` a la zona de intercambio y **guarda la instantánea** con el mensaje: `"chore: Añadir tarea de revisión"`.
    *   **En la línea `master`:** Cambia a ella. Añade una nueva sección al `README.md` al final: `## Próximas Características`.
    *   Añade `README.md` a la zona de intercambio y **guarda la instantánea** con el mensaje: `"docs: Añadir sección de futuras características"`.
    *   Visualiza el historial completo. **Deberías ver cómo `master` y `develop` han divergido**, mostrando caminos de desarrollo separados desde un punto común.

5.  **Demostración de Fusión (`merge`) con Conflicto:**
    *   Crea una nueva línea `feature/merge-path` a partir de `develop` y cambia a ella.
    *   Modifica `main.js` en `feature/merge-path` para añadir una función `displayTasks` después de `getTasks`:
        ```javascript
        function displayTasks() {
            console.log("--- Lista de Tareas ---");
            getTasks().forEach(task => console.log(`ID: ${task.id}, Desc: ${task.description}, Comp: ${task.completed}`));
            console.log("-----------------------");
        }
        export { addTask, getTasks, displayTasks };
        ```
    *   Añade los archivos modificados a la zona de intercambio y **guarda la instantánea** con el mensaje: `"feat: Añadir función displayTasks"`.
    *   **¡Simula un conflicto intencionado!** Cambia a la línea `master`.
    *   Modifica intencionadamente **la misma línea o zona** en `main.js` que se modificó en `feature/merge-path` (por ejemplo, cambia `console.log("Aplicación de Gestión de Tareas v1.0.0 lista.");` por `console.log("Aplicación de Gestión de Tareas v1.0.0 preparada.");` o añade una línea justo donde `displayTasks` debería importarse).
    *   Añade `main.js` a la zona de intercambio y **guarda la instantánea** con el mensaje: `"chore: Actualización en main.js que causará conflicto"`.
    *   **Cambia de nuevo a la línea `develop`**.
    *   Ahora, **intenta integrar los cambios de `feature/merge-path` en `develop`**. **¡Debería producirse un conflicto!**
    *   Verifica el estado del repositorio para ver los archivos en conflicto. Deberían aparecer marcados.
    *   Abre `main.js` en tu editor. Verás los **marcadores de conflicto** (`<<<<<<<`, `=======`, `>>>>>>>`).
    *   **Resuelve el conflicto manualmente**. Decide qué partes de `main.js` quieres mantener de ambas líneas (por ejemplo, el mensaje actualizado de `master` *y* la función `displayTasks` de tu rama de característica). Elimina los marcadores de conflicto.
    *   Añade el archivo `main.js` a la zona de intercambio para marcar el conflicto como resuelto.
    *   **Confirma la fusión** con un mensaje por defecto o uno personalizado que explique la resolución.
    *   **Análisis:** Visualiza el historial completo. **Observa el commit de fusión (`Merge commit`) y cómo la historia de las ramas se entrelaza, mostrando una estructura no lineal.**
    *   **Elimina la línea `feature/merge-path`**.

6.  **Demostración de Reorganización (`rebase`):**
    *   **Cambia a la línea `develop`**.
    *   Crea una nueva línea `feature/rebase-path` a partir de `develop` y cambia a ella.
    *   Modifica `tasks.js` en `feature/rebase-path` para añadir una función `deleteTask`:
        ```javascript
        const tasks = [];
        // ... (addTask, getTasks existentes) ...
        function deleteTask(id) {
            const index = tasks.findIndex(task => task.id === id);
            if (index > -1) {
                tasks.splice(index, 1);
                console.log(`Tarea con ID ${id} eliminada.`);
            } else {
                console.log(`Tarea con ID ${id} no encontrada.`);
            }
        }
        export { addTask, getTasks, deleteTask, displayTasks };
        ```
    *   Añade `tasks.js` a la zona de intercambio y **guarda la instantánea** con el mensaje: `"feat: Añadir función deleteTask"`.
    *   **¡Simula la integración de cambios en `develop` *antes* de la fusión final de `feature/rebase-path`!**
        *   **Cambia a la línea `develop`**.
        *   Añade una nueva línea en `README.md` (por ejemplo, `## Módulo de Seguridad`).
        *   Añade `README.md` a la zona de intercambio y **guarda la instantánea** con el mensaje: `"docs: Añadir sección de módulo de seguridad"`.
        *   Ahora, vuelve a tu línea `feature/rebase-path`.
    *   **Reorganización (Rebase):** Ahora, **reaplica los cambios de tu línea `feature/rebase-path` *sobre* la línea `develop`**.
        *   Si hay conflictos, resuélvelos manualmente (similar al `merge`) y continúa el proceso de reorganización.
    *   Cambia a la línea `develop`.
    *   **Integra `feature/rebase-path` en `develop`**. Esto debería ser un "avance rápido" (fast-forward merge) debido a la reorganización previa.
    *   **Análisis:** Visualiza el historial completo. **Observa cómo las instantáneas de `feature/rebase-path` ahora aparecen *después* de las instantáneas de `develop` en una línea recta, reescribiendo el historial de tu línea local y resultando en un historial más lineal sin un commit de fusión explícito.** Compara esto con el historial obtenido con la fusión (`merge`).
    *   **Elimina la línea `feature/rebase-path`**.

---

**Fase 3: Selección de Commits Específicos y Recuperación de Errores Avanzada**

1.  **Selección de Commit Específico (`cherry-pick`):**
    *   Asegúrate de estar en la línea `develop`.
    *   Crea una nueva línea, `feature/small-utility`, para una pequeña utilidad que se necesita puntualmente, y cambia a ella.
    *   Crea un archivo `utils.js` con el siguiente contenido:
        ```javascript
        export function formatDate(date) {
            return date.toLocaleDateString();
        }
        ```
    *   Añade `utils.js` a la zona de intercambio y **guarda la instantánea** con el mensaje: `"feat: Añadir función formatDate en utils.js"`.
    *   Modifica `main.js` para usar `formatDate` (simula una integración más compleja que aún no se quiere):
        ```javascript
        import { addTask, getTasks, deleteTask, displayTasks } from './tasks.js';
        import { formatDate } from './utils.js'; // Nueva importación
        // ... (resto del código) ...
        console.log("Fecha actual:", formatDate(new Date())); // Uso de la función
        ```
    *   Añade `main.js` a la zona de intercambio y **guarda la instantánea** con el mensaje: `"feat: Integrar formatDate en main.js"`.
    *   **Situación:** Te das cuenta de que la función `formatDate` en `utils.js` es crucial y debe estar en `develop` lo antes posible, pero el resto de los cambios en `feature/small-utility` (incluida la integración en `main.js`) aún no están listos para ser fusionados.
    *   **Cambia a la línea `develop`**.
    *   **Identifica el ID de la instantánea** que añadió *solo* la función `formatDate` en `utils.js` (la que tiene el mensaje `"feat: Añadir función formatDate en utils.js"`) consultando el historial de `feature/small-utility`.
    *   **Aplica esa instantánea específica** a la línea `develop` sin fusionar toda la rama.
    *   Visualiza el historial completo para ver que la instantánea de `formatDate` ahora existe en `develop`. Nota que se crea una *nueva* instantánea con un identificador diferente.
    *   Puedes elegir mantener la línea `feature/small-utility` para seguir trabajando en ella o, si no la necesitas más, eliminarla.

2.  **Deshacer un Commit Reciente (Solo en tu copia de trabajo):**
    *   Asegúrate de estar en la línea `develop`.
    *   Crea un archivo `bug.txt` con el contenido: `Este archivo introduce un bug crítico.`
    *   Añade `bug.txt` a la zona de intercambio y **guarda la instantánea** con el mensaje: `"bug: Introducir un bug accidentalmente en bug.txt"`.
    *   Visualiza el historial de forma concisa para ver el identificador de esta última instantánea.
    *   **Opción A: Deshacer la última instantánea, manteniendo los cambios en la zona de intercambio (para editar y volver a guardar):**
        *   Rebobina el puntero de la rama un paso atrás, dejando los cambios de esa instantánea en la zona de intercambio.
        *   Verifica el estado. El archivo `bug.txt` debería estar en el área de preparación.
        *   Si quisieras, podrías modificar el archivo y volver a guardar una instantánea, o descartar los cambios.
    *   **Opción B: Deshacer la última instantánea, descartando completamente los cambios:**
        *   (Si no lo hiciste en la Opción A, o si quieres practicar esta opción específica, repite el commit de `bug.txt`).
        *   Rebobina el puntero de la rama un paso atrás, y también limpia completamente la zona de intercambio y el directorio de trabajo, eliminando `bug.txt` sin dejar rastro. **¡Esta acción es destructiva y no se puede deshacer fácilmente!**
        *   Verifica el estado. Tu directorio de trabajo debería estar limpio, y `bug.txt` debería haber desaparecido.

3.  **Deshacer un Commit "Publicado" (Simulado de forma segura):**
    *   Asegúrate de estar en la línea `develop`.
    *   Modifica `main.js` añadiendo una línea: `console.log("Esta es una característica 'publicada' con un error potencial.");`.
    *   Añade `main.js` a la zona de intercambio y **guarda la instantánea** con el mensaje: `"feat: Característica 'publicada' con un error potencial"`.
    *   Visualiza el historial de forma concisa para obtener el identificador de esta instantánea.
    *   **Deshaz esta instantánea de forma segura**. Esto significa que se creará una *nueva instantánea* que invierte los cambios del commit anterior, manteniendo ambos en el historial. Este método es el más seguro cuando los cambios ya han sido "publicados" (es decir, compartidos con otros).
    *   Se abrirá tu editor para el mensaje del nuevo commit de reversión. Acepta el mensaje predeterminado o edítalo si lo deseas, y guarda.
    *   Visualiza el historial completo. **Observa que se ha creado un nuevo commit que deshace los cambios del commit anterior, manteniendo ambos en el historial. Esto es crucial para trabajos ya compartidos.**

---

**Fase 4: Finalización y Reflexión**

1.  **Limpieza de Líneas de Desarrollo:**
    *   Asegúrate de estar en una de tus líneas de desarrollo principales (como `master` o `develop`).
    *   **Elimina todas las líneas de característica (`feature/*`) y hotfix (`hotfix/*`)** que hayas creado y que ya hayas integrado o que no necesites más. Recuerda que solo puedes eliminar ramas que ya han sido fusionadas, a menos que fuerces la eliminación.
    *   Verifica que solo quedan las líneas de desarrollo que deseas mantener.

2.  **Visualización del Historial Final:**
    *   **Visualiza el historial completo de tu proyecto**, incluyendo todas las líneas de desarrollo, para observar el resultado final de todas tus operaciones.
    *   Reflexiona sobre cómo la **integración (fusión `merge`)** y la **reorganización (`rebase`)** crearon historiales diferentes, y cómo la **selección de commits (`cherry-pick`)** insertó una instantánea específica sin integrar toda una línea de desarrollo.

