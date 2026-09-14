# Práctica de Git: Proyecto Colaborativo con Git y GitHub

### **Práctica en Pareja: Desarrollo Colaborativo de un Generador de Citas Inspiradoras (`quote-generator`)**

**Objetivo:** Desarrollar en pareja una aplicación simple para generar citas inspiradoras. Esta práctica se centrará en la **colaboración mediante repositorios remotos en GitHub**, la gestión de **líneas de desarrollo (ramas)**, la **resolución de conflictos**, la integración de cambios mediante **fusión (`merge`) y reorganización (`rebase`)**, y la comunicación a través de **Pull Requests (solicitudes de integración)**.

**Roles y Rotación:**

*   Inicialmente, el **Alumno A** será el **Mantenedor Principal** (propietario del repositorio en GitHub) y el **Alumno B** será el **Colaborador** (hará `fork` del repositorio).
*   Tras cada fase principal de integración de una característica o corrección, **los roles se invertirán**. El Alumno B se convertirá en el Mantenedor y el Alumno A en el Colaborador para la siguiente fase, y así sucesivamente. Esta rotación es fundamental para que ambos experimenten ambos roles.

**Instrucciones Generales:**

*   Realicen todos los pasos en un entorno de línea de comandos (terminal). Algunas acciones relacionadas con GitHub se realizarán en la interfaz web, lo cual se indicará explícitamente.
*   Guarden cada paso, los comandos ejecutados y cualquier mensaje de error o salida relevante, ya que podría ser útil para la entrega o la revisión.
*   **Lean cuidadosamente cada instrucción antes de ejecutarla y piensen qué acción o comando de Git es la más adecuada.**
*   Para visualizar el historial y comprender el impacto de sus acciones, recuerden que existe una herramienta para **mostrar el historial de confirmaciones de forma concisa, con ramas y en formato gráfico, incluyendo todas las referencias**. Utilícenla frecuentemente.

---

**Fase 0: Preparación del Entorno (Individual para ambos alumnos)**

1.  **Configuración de Git:**
    *   Si aún no lo tienen, cada alumno debe informar a Git sobre **quién es** (su nombre de usuario) y **cómo contactarle** (su dirección de correo electrónico) a nivel global en su sistema.
    *   Cada alumno debe definir su **editor de texto preferido** (por ejemplo, VS Code) para que Git lo utilice automáticamente cuando necesite escribir un mensaje.
    *   Activen la visualización de **colores en la salida de Git** para facilitar la lectura.
    *   Verifiquen la configuración de Git para confirmar que sus preferencias se han aplicado correctamente.
2.  **Cuentas de GitHub:**
    *   Asegúrense de que ambos alumnos tengan una **cuenta activa en GitHub**.

---

**Fase 1: Configuración Inicial del Proyecto y Puesta en Marcha en GitHub**
**(Rol: Alumno A - Mantenedor Principal)**

1.  **Inicio del Proyecto Local (Alumno A):**
    *   El Alumno A crea un nuevo directorio en su sistema con el nombre `quote-generator`.
    *   Dentro de este directorio, **inicializa un nuevo repositorio Git vacío**.
    *   Verifica el estado actual de su repositorio.
2.  **Estructura Base de la Aplicación (Alumno A):**
    *   El Alumno A crea un archivo llamado `README.md` con el siguiente contenido: `# Generador de Citas Inspiradoras`.
    *   Crea un archivo llamado `quotes.js` con el siguiente contenido (o el equivalente en Python si lo prefieren):
        ```javascript
        const quotes = [
            "La vida es lo que pasa mientras estás ocupado haciendo otros planes. - John Lennon",
            "El único modo de hacer un gran trabajo es amar lo que haces. - Steve Jobs",
            "La innovación distingue a un líder de un seguidor. - Steve Jobs"
        ];
        function getRandomQuote() {
            const randomIndex = Math.floor(Math.random() * quotes.length);
            return quotes[randomIndex];
        }
        export { quotes, getRandomQuote };
        ```
    *   Crea un archivo `index.html` básico para mostrar la cita:
        ```html
        <!DOCTYPE html>
        <html lang="es">
        <head>
            <meta charset="UTF-8">
            <title>Generador de Citas</title>
        </head>
        <body>
            <h1>Cita del Día</h1>
            <p id="quote-display"></p>
            <button id="generate-button">Generar Nueva Cita</button>
            <script type="module" src="app.js"></script>
        </body>
        </html>
        ```
    *   Crea un archivo `app.js` para interactuar con `quotes.js` e `index.html`:
        ```javascript
        import { getRandomQuote } from './quotes.js';
        document.addEventListener('DOMContentLoaded', () => {
            const quoteDisplay = document.getElementById('quote-display');
            const generateButton = document.getElementById('generate-button');
            quoteDisplay.textContent = getRandomQuote();
            generateButton.addEventListener('click', () => {
                quoteDisplay.textContent = getRandomQuote();
            });
        });
        ```
    *   **Añade todos los archivos** a la zona de intercambio.
    *   **Guarda la instantánea actual** de su proyecto con un mensaje descriptivo: `"feat: Configuración inicial de la aplicación y primeras citas"`.
3.  **Creación del Repositorio Remoto en GitHub (Alumno A - Interfaz Web):**
    *   El Alumno A accede a GitHub y **crea un nuevo repositorio** con el nombre `quote-generator`. **Importante: No marques la opción "Inicializar este repositorio con un README"**.
    *   Obtiene la URL HTTPS de este nuevo repositorio vacío.
4.  **Vinculación y Primer Envío al Remoto (Alumno A):**
    *   El Alumno A conecta su repositorio local `quote-generator` con el repositorio remoto de GitHub. Dale el nombre predeterminado para el repositorio remoto (`origin`).
    *   **Envía su rama principal** (master) a este repositorio remoto por primera vez.
    *   Verifica en la interfaz web de GitHub que sus archivos y confirmaciones han sido subidos correctamente.

---

**Fase 2: Primera Contribución y Pull Request**
**(Rol: Alumno B - Colaborador; Alumno A - Mantenedor)**

1.  **Bifurcación (Fork) del Repositorio (Alumno B - Interfaz Web):**
    *   El Alumno B accede al repositorio `quote-generator` del Alumno A en GitHub.
    *   **Crea una copia del repositorio en su propia cuenta de GitHub mediante un 'fork'**.
2.  **Clonación del Fork y Desarrollo de Característica (Alumno B):**
    *   El Alumno B **crea una copia local** de *su propio repositorio bifurcado* (`fork`) en su computadora.
    *   Dentro de este repositorio clonado, **crea una nueva línea de desarrollo** (rama) llamada `feature/add-author-name` y **cambia a ella inmediatamente**.
    *   En esta rama, el Alumno B modifica `quotes.js` para añadir el autor de las citas de forma estructurada (por ejemplo, como objetos con `text` y `author`), y modifica `getRandomQuote` para que devuelva la cita con el autor:
        ```javascript
        const quotes = [
            { text: "La vida es lo que pasa mientras estás ocupado haciendo otros planes.", author: "John Lennon" },
            { text: "El único modo de hacer un gran trabajo es amar lo que haces.", author: "Steve Jobs" },
            { text: "La innovación distingue a un líder de un seguidor.", author: "Steve Jobs" }
        ];
        function getRandomQuote() {
            const randomIndex = Math.floor(Math.random() * quotes.length);
            return `${quotes[randomIndex].text} - ${quotes[randomIndex].author}`;
        }
        export { quotes, getRandomQuote };
        ```
    *   **Añade los archivos modificados** a la zona de intercambio.
    *   **Guarda la instantánea** de estos cambios con un mensaje: `"feat: Estructurar citas con texto y autor explícitos"`.
    *   **Envía esta nueva rama `feature/add-author-name` a su repositorio bifurcado** en GitHub.
3.  **Creación de un Pull Request (Alumno B - Interfaz Web):**
    *   El Alumno B navega a la interfaz web de GitHub de *su repositorio bifurcado*.
    *   **Crea una Solicitud de Integración (Pull Request)** desde su rama `feature/add-author-name` hacia la rama `master` del *repositorio original* (del Alumno A). Proporciona un título y una descripción clara.
4.  **Revisión y Fusión del Pull Request (Alumno A - Interfaz Web y Local):**
    *   El Alumno A revisa el Pull Request propuesto por el Alumno B en GitHub.
    *   Asumiendo que los cambios son aceptables, el Alumno A **fusiona el Pull Request** directamente desde la interfaz web de GitHub.
    *   El Alumno A **elimina la rama `feature/add-author-name`** del repositorio del Alumno B en GitHub (si la opción se presenta).
    *   El Alumno A **descarga los cambios** de su repositorio remoto y los **integra** en su rama `master` local.

**¡CAMBIO DE ROLES!**
*El Alumno B asumirá ahora el rol de Mantenedor Principal (dueño del repositorio original `quote-generator` en GitHub) y el Alumno A se convertirá en Colaborador.*

---

**Fase 3: Desarrollo Paralelo, Conflictos y Fusión**
**(Rol: Alumno A - Colaborador; Alumno B - Mantenedor)**

1.  **Preparación del Repositorio del Nuevo Mantenedor (Alumno B):**
    *   El Alumno B ahora es el Mantenedor. En su `master` local (que ya tiene los cambios de la Fase 2), añade un archivo `styles.css` con el contenido: `body { font-family: sans-serif; background-color: #f0f0f0; }`.
    *   Modifica `index.html` para enlazar este nuevo archivo CSS.
    *   **Guarda la instantánea** de estos cambios con un mensaje: `"style: Añadir estilos básicos al generador de citas"`.
    *   **Envía estos cambios** a la rama `master` de *su* repositorio en GitHub.
2.  **Sincronización y Desarrollo del Nuevo Colaborador (Alumno A):**
    *   El Alumno A (nuevo Colaborador) **sincroniza su repositorio bifurcado local** con los últimos cambios del repositorio original (del Alumno B). Esto implica añadir una referencia remota al repositorio del Alumno B (si no la tiene), **descargar los cambios** y **fusionarlos** en su `master` local, y luego **subir** su `master` actualizado a *su propio fork*.
    *   Dentro de su repositorio clonado, el Alumno A **crea una nueva línea de desarrollo** llamada `feature/random-background` y **cambia a ella**.
    *   En esta rama, el Alumno A modifica `styles.css` para añadir un fondo aleatorio. **¡Intencionadamente, modifica la misma línea donde el Alumno B ya cambió el `background-color`!** Por ejemplo: `body { font-family: sans-serif; background-color: lightblue; } /* Otro cambio */`.
    *   **Guarda la instantánea** de estos cambios con un mensaje: `"feat: Implementar fondo de color aleatorio en CSS"`.
    *   **Envía esta rama `feature/random-background` a su repositorio bifurcado** en GitHub.
3.  **Creación de Pull Request con Conflicto (Alumno A - Interfaz Web):**
    *   El Alumno A crea un Pull Request desde su rama `feature/random-background` hacia la rama `master` del *repositorio original* (del Alumno B).
    *   **GitHub debería indicar que hay un conflicto** y que no puede ser fusionado automáticamente.
4.  **Resolución Local de Conflictos y Fusión (Alumno B - Interfaz Web y Local):**
    *   El Alumno B (Mantenedor) accede al Pull Request y ve el conflicto.
    *   El Alumno B **descarga la rama `feature/random-background`** del Alumno A a su repositorio local.
    *   **Integra la rama `feature/random-background` en su `master` local**. **¡Se producirá un conflicto en `styles.css`!**.
    *   Abre `styles.css` en su editor. Verá los **marcadores de conflicto**.
    *   **Resuelve el conflicto manualmente** en `styles.css`. Decide que quiere el `background-color` que él mismo puso (`#f0f0f0`) pero también quiere la idea de fondo aleatorio (puede añadir una nueva regla o un comentario que lo indique para futura implementación). **Elimina los marcadores de conflicto.**
    *   **Añade el archivo `styles.css`** a la zona de intercambio para marcar el conflicto como resuelto.
    *   **Guarda la instantánea de la fusión** con un mensaje que explique la resolución del conflicto.
    *   **Envía la rama `master` actualizada a su repositorio en GitHub**.
    *   En GitHub, el Pull Request debería ahora aparecer como fusionable (o, si ya se había cerrado, los cambios se habrían incorporado).
    *   El Alumno B **elimina la rama `feature/random-background`** de su repositorio local y del repositorio del Alumno A en GitHub.

**¡CAMBIO DE ROLES!**
*El Alumno A asumirá ahora el rol de Mantenedor Principal (dueño del repositorio original `quote-generator` en GitHub) y el Alumno B se convertirá en Colaborador.*

---

**Fase 4: Integración con Reorganización (`rebase`)**
**(Rol: Alumno B - Colaborador; Alumno A - Mantenedor)**

1.  **Preparación del Repositorio del Nuevo Mantenedor (Alumno A):**
    *   El Alumno A ahora es el Mantenedor. En su `master` local (que ya tiene los cambios de la Fase 3), añade un archivo `footer.html` con el contenido: `<footer><p>&copy; 2023 Generador de Citas</p></footer>`.
    *   Modifica `index.html` para incluir este pie de página al final del `<body>`.
    *   **Guarda la instantánea** de estos cambios con un mensaje: `"feat: Añadir pie de página básico"`.
    *   **Envía estos cambios** a la rama `master` de *su* repositorio en GitHub.
2.  **Sincronización, Desarrollo y Reorganización del Nuevo Colaborador (Alumno B):**
    *   El Alumno B (nuevo Colaborador) **sincroniza su repositorio bifurcado local** con los últimos cambios del repositorio original (del Alumno A).
    *   Dentro de su repositorio clonado, el Alumno B **crea una nueva línea de desarrollo** llamada `feature/new-quotes` y **cambia a ella**.
    *   En esta rama, el Alumno B añade dos nuevas citas a `quotes.js`:
        ```javascript
        // ...
        { text: "El éxito no es la clave de la felicidad. La felicidad es la clave del éxito.", author: "Albert Schweitzer" },
        { text: "Tu tiempo es limitado, no lo desperdicies viviendo la vida de otra persona.", author: "Steve Jobs" }
        // ...
        ```
    *   Añade `quotes.js` a la zona de intercambio y **guarda la primera instantánea** con un mensaje: `"feat: Añadir nueva cita de Albert Schweitzer"`.
    *   Añade otra cita más: `{ text: "Solo hay una forma de evitar las críticas: no hagas nada, no digas nada, y no seas nada.", author: "Aristóteles" }`.
    *   Añade `quotes.js` a la zona de intercambio y **guarda la segunda instantánea** con un mensaje: `"feat: Añadir nueva cita de Aristóteles"`.
    *   **Reaplica los cambios de su línea `feature/new-quotes` sobre la rama `master` del repositorio original** (para crear un historial lineal). Si hay conflictos, resuélvelos y continúa el proceso.
    *   **Envía su rama `feature/new-quotes` a su repositorio bifurcado** en GitHub.
3.  **Creación y Fusión del Pull Request (Alumno B - Interfaz Web; Alumno A - Interfaz Web y Local):**
    *   El Alumno B crea un Pull Request desde su rama `feature/new-quotes` hacia la rama `master` del repositorio original del Alumno A.
    *   El Alumno A (Mantenedor) revisa el Pull Request. Dado que la rama del Alumno B fue reorganizada previamente, **la fusión debería ser un "avance rápido" (fast-forward merge)** o al menos una fusión trivial.
    *   El Alumno A **fusiona el Pull Request** desde la interfaz web de GitHub.
    *   El Alumno A **elimina la rama `feature/new-quotes`** de su repositorio local y del repositorio del Alumno B en GitHub.
    *   El Alumno A **descarga los cambios** a su rama `master` local.

**¡CAMBIO DE ROLES!**
*El Alumno B asumirá ahora el rol de Mantenedor Principal (dueño del repositorio original `quote-generator` en GitHub) y el Alumno A se convertirá en Colaborador.*

---

**Fase 5: Deshacer Cambios "Publicados" de Forma Segura**
**(Rol: Alumno A - Colaborador; Alumno B - Mantenedor)**

1.  **Introducción de un Error "Publicado" (Alumno B):**
    *   El Alumno B (Mantenedor, en su `master` local) modifica `index.html` para añadir una línea de comentario con información sensible (simulada), por ejemplo: `<!-- Contraseña de desarrollo: dev_pass123 -->`.
    *   Añade `index.html` a la zona de intercambio y **guarda la instantánea** con el mensaje: `"chore: Añadir comentario de depuración con datos sensibles"`.
    *   **Envía esta instantánea** a la rama `master` en GitHub.
    *   Visualiza el historial completo para obtener el ID de esa instantánea.
2.  **Deshacer el Error de Forma Segura (Alumno B):**
    *   El Alumno B se da cuenta de que ha "publicado" datos sensibles. **Deshace los cambios de esa instantánea específica** creando una *nueva instantánea* que anule sus efectos. Esto es crucial para no reescribir el historial ya compartido.
    *   Se abrirá su editor para el mensaje del nuevo commit de reversión. Acepta el mensaje predeterminado o edítalo si lo desea, y guarda.
    *   **Envía este nuevo commit de reversión** a la rama `master` en GitHub.
    *   Visualiza el historial completo para ver que el commit original con el error y el commit de reversión coexisten en el historial.
3.  **Actualización del Colaborador (Alumno A):**
    *   El Alumno A (Colaborador, en su `master` local) **sincroniza su `master` local** con el `master` remoto del Alumno B.
    *   Observa el historial completo para ver el commit original con el error y el commit de reversión que lo anula.

---

**Fase 6: Finalización y Reflexión (Ambos Alumnos - Discusión en pareja)**

1.  **Limpieza Final de Líneas de Desarrollo:**
    *   Asegúrense de estar en su rama `master` local en sus respectivos repositorios.
    *   **Eliminen todas las líneas de característica (`feature/*`) y hotfix (`hotfix/*`)** que hayan creado y que ya hayan integrado o que no necesiten más, tanto de sus repositorios locales como de GitHub (si las subieron).
    *   Visualicen el estado de las ramas locales y remotas para confirmar que solo quedan las que desean.
2.  **Reflexión Final:**
    *   Revisen el historial completo de sus proyectos (localmente y en GitHub). Discutan las diferencias en la **estructura del historial** obtenida con las operaciones de **fusión (`merge`)** frente a la **reorganización (`rebase`)**. ¿Qué tipo de historial es más fácil de leer en cada caso?.
    *   Analicen el flujo de trabajo de colaboración que siguieron para los Pull Requests. Identifiquen las ventajas de usar GitHub para este proceso, incluyendo la gestión de documentación y la retroalimentación.
    *   Discutan la importancia de **resolver los conflictos** a tiempo y de forma colaborativa. ¿Cómo les ayudó la herramienta de resolución de conflictos?.
    *   Reflexionen sobre los **"peligros de reorganizar" commits que ya se han "publicado"** (enviado a un repositorio remoto) y por qué **`git revert` es la opción preferida** en esos casos. Git generalmente solo añade información, lo que hace que sea difícil borrar datos de forma irreversible una vez confirmados.
    *   Comenten cómo la rotación de roles les ayudó a entender las diferentes perspectivas y responsabilidades en un proyecto colaborativo.