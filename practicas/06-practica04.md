
## Práctica 4: Flujo de Trabajo Colaborativo con Pull Requests

- [Práctica 4: Flujo de Trabajo Colaborativo con Pull Requests](#práctica-4-flujo-de-trabajo-colaborativo-con-pull-requests)
  - [Roles Iniciales y Preparación](#roles-iniciales-y-preparación)
  - [Fase 1: Configuración Inicial del Proyecto (Alumno A)](#fase-1-configuración-inicial-del-proyecto-alumno-a)
  - [Fase 2: Primera Contribución y Pull Request (Alumno B)](#fase-2-primera-contribución-y-pull-request-alumno-b)
  - [Fase 3: Solicitud de Cambios y Actualización del PR (MP: Alumno A; Colaborador: Alumno B)](#fase-3-solicitud-de-cambios-y-actualización-del-pr-mp-alumno-a-colaborador-alumno-b)
  - [Fase 4: Segunda Contribución y Cambio de Roles (Alumno A)](#fase-4-segunda-contribución-y-cambio-de-roles-alumno-a)
  - [Reflexión Final sobre la Colaboración Remota](#reflexión-final-sobre-la-colaboración-remota)
  - [Qué entregar](#qué-entregar)


### Roles Iniciales y Preparación

| Rol                           | Alumno   | Tarea Inicial                                                           |
| :---------------------------- | :------- | :---------------------------------------------------------------------- |
| **Mantenedor Principal (MP)** | Alumno A | Crea el repositorio principal (Original/Upstream) en GitHub.            |
| **Colaborador**               | Alumno B | Crea una copia (Fork) del repositorio del Alumno A en su propia cuenta. |

**Importancia del Remoto y PRs:** GitHub, al ser una plataforma de alojamiento de repositorios Git, facilita enormemente la **colaboración** y la **revisión de código**. Un Pull Request (PR) es una herramienta de comunicación esencial que permite a un desarrollador proponer sus cambios y solicitar una revisión antes de que el código se fusione con una rama principal.

### Fase 1: Configuración Inicial del Proyecto (Alumno A)

1.  **Inicio del Proyecto Local (Alumno A):** Inicializa un repositorio Git local (`git init`).
2.  **Estructura Base (Alumno A):** Crea `index.html` (estructura básica, ej: `"<h1>Proyecto Colaborativo</h1>"`) y `data.txt` (ej: "Datos iniciales").
3.  **Primer Commit y Push:** Añade y confirma los archivos. Luego, crea un nuevo repositorio en GitHub (sin inicializar con README) y **sube la rama principal** a este remoto (`git push origin master/main`).

### Fase 2: Primera Contribución y Pull Request (Alumno B)

| Acción                     | Rol      | Comandos de Git/Acción Web                                                                                                           | Concepto Reforzado                                                 |
| :------------------------- | :------- | :----------------------------------------------------------------------------------------------------------------------------------- | :----------------------------------------------------------------- |
| **2.1 Bifurcación (Fork)** | Alumno B | Accede al repositorio de A en GitHub y hace **Fork**. Alternativa CLI: `gh repo fork <usuario-A>/practica04 --clone` (clona el fork automáticamente). | Crear una copia en su cuenta para trabajar de forma independiente. |
| **2.2 Clonación**          | Alumno B | `git clone <URL_del_fork_de_B>`                                                                                                      | Obtiene una copia local del repositorio bifurcado.                 |
| **2.3 Creación de Rama**   | Alumno B | `git checkout -b feature/cita-inicial`                                                                                               | Aísla el trabajo de la rama principal.                             |
| **2.4 Desarrollo**         | Alumno B | Modifica `data.txt` (ej: Añade una cita inspiradora).                                                                                | Archivo modificado en el Directorio de trabajo.                    |
| **2.5 Commit y Push**      | Alumno B | `git add .` y `git commit -m "feat: Añadida la primera cita."`. Luego, `git push -u origin feature/cita-inicial` (la `-u` vincula la rama local con la remota para futuros `push` sin especificar origen). | Sube la **rama nueva** a su repositorio remoto (el Fork).          |
| **2.6 Crear PR**           | Alumno B | En la interfaz web de GitHub (en su Fork), crea un **Pull Request** proponiendo fusionar `feature/cita-inicial` a `master` de **A**. Alternativa CLI: `gh pr create --base master --head feature/cita-inicial --title "feat: añadir cita inicial" --body "Añade una cita inspiradora"`. | Propone la integración de sus cambios al proyecto principal.       |

### Fase 3: Solicitud de Cambios y Actualización del PR (MP: Alumno A; Colaborador: Alumno B)

**ESCENARIO CLAVE (Actualización de un PR no aceptado):** El Alumno A (Mantenedor) revisa el PR y lo encuentra aceptable, pero solicita que se añada una segunda línea al archivo `data.txt` con el autor de la cita, o **el PR no será fusionado**.

| Acción                       | Rol      | Comandos de Git/Acción Web                                                                                        | Proceso de Actualización                                                                                                                                                               |
| :--------------------------- | :------- | :---------------------------------------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **3.1 Solicitud de Cambio**  | Alumno A | En la interfaz de GitHub, rechaza la fusión y deja un comentario solicitando la adición del autor. Alternativa CLI: `gh pr review <PR> --request-changes --body "Falta la fuente de la cita"`. | El PR sigue **abierto** y pendiente de revisión.                                                                                                                                       |
| **3.2 Modificación**         | Alumno B | En su rama local `feature/cita-inicial`, modifica `data.txt` para añadir la línea del autor.                      | Realiza los cambios solicitados por el Mantenedor.                                                                                                                                     |
| **3.3 Nuevo Commit**         | Alumno B | `git add data.txt` y `git commit -m "fix: Añadido el autor de la cita (solicitud de revisión)"`.                  | Se genera una **nueva instantánea** con la corrección.                                                                                                                                 |
| **3.4 Push Sucesivo**        | Alumno B | `git push origin feature/cita-inicial`.                                                                           | El *push* de nuevos *commits* a la **misma rama de origen** (`feature/cita-inicial`) hace que **GitHub actualice automáticamente el Pull Request existente** con estos nuevos cambios. |
| **3.5 Verificación**         | Alumno A | Revisa el PR en GitHub. El nuevo commit ("fix: Añadido el autor...") **aparece integrado** en la revisión del PR. | El Mantenedor no necesita un nuevo PR; la revisión se actualiza con los sucesivos cambios.                                                                                             |
| **3.6 Fusión**               | Alumno A | Fusiona el PR desde la interfaz web de GitHub. Alternativa CLI: `gh pr merge <PR>`.                                                                    | El código de B se integra en la rama principal de A.                                                                                                                                   |
| **3.7 Sincronización Local** | Alumno A | En su repositorio local: `git pull origin master`.                                                                | Actualiza su copia local con los cambios que acaba de fusionar.                                                                                                                        |

**¡CAMBIO DE ROLES!** El Alumno B ahora asume el rol de **Mantenedor Principal** (dueño del repositorio original `origin` en GitHub) y el Alumno A se convierte en **Colaborador**.

### Fase 4: Segunda Contribución y Cambio de Roles (Alumno A)

| Acción                            | Rol      | Comandos de Git/Acción Web                                                                                                                                                                                                | Concepto Reforzado                                                   |
| :-------------------------------- | :------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | :------------------------------------------------------------------- |
| **4.1 Sincronización (Upstream)** | Alumno A | Para evitar conflictos, debe sincronizar su *fork* local (`master` o `main`) con los cambios que se han fusionado en el repositorio de B (que es el nuevo principal). Ejecuta: `git remote add upstream <URL_del_repositorio_de_B>` (sustituye por la URL real del repo de B). Luego: `git fetch upstream` y `git merge upstream/master`. | Mantiene la copia bifurcada actualizada con el repositorio original. |
| **4.2 Desarrollo de Rama**        | Alumno A | Crea una nueva rama `feature/nueva-funcionalidad` y añade un nuevo archivo `config.js`. Confirma los cambios.                                                                                                             | Aislamiento del desarrollo.                                          |
| **4.3 Push al Fork**              | Alumno A | `git push -u origin feature/nueva-funcionalidad` (la `-u` vincula la rama local con la remota).                                                                                                            | Publica la rama en su propio Fork.                                   |
| **4.4 Crear PR**                  | Alumno A | Desde la interfaz web de su Fork, crea un Pull Request proponiendo la fusión en la rama `master` del **Alumno B**. Alternativa CLI: `gh pr create`.                                                                                                        | Inicia el proceso de revisión.                                       |
| **4.5 Fusión y Sincronización**   | Alumno B | Revisa el PR y lo fusiona desde la interfaz web. Luego, sincroniza su copia local del repositorio principal.                                                                                                              | El Mantenedor acepta los cambios.                                    |
| **4.6 Limpieza**                  | Ambos    | Eliminan las ramas de característica que han sido fusionadas, tanto local (`git branch -d <rama>`) como remotamente (`git push origin --delete <rama>`).                                                                  | Práctica de higiene de repositorio.                                  |

### Reflexión Final sobre la Colaboración Remota

La adición de un repositorio remoto y el flujo de Pull Requests aportan un valor inmenso a la colaboración:

1.  **Copia de Seguridad y Distribución:** El repositorio remoto actúa como la **copia de seguridad externa del código fuente**, y al ser Git distribuido, permite que todos los colaboradores trabajen y sincronicen el historial.
2.  **Revisión Estructurada:** El PR es el mecanismo formal para que el código sea revisado y comentado por el Mantenedor antes de ser integrado en la línea principal.
3.  **Iteración de Cambios:** Como se demostró en la Fase 3, el flujo de trabajo permite al Colaborador realizar **sucesivos *commits* y *pushes*** a la rama de origen (el *feature branch*) mientras el Pull Request está abierto. Estos nuevos *commits* se adjuntan automáticamente al PR, facilitando el proceso de corrección y aprobación sin tener que crear múltiples solicitudes de integración.

### Qué entregar

Cada pareja debe entregar lo siguiente en el repositorio de la práctica (o en el aula virtual, según indique el profesor):

| Entrega                                    | Descripción                                                                                                   |
| :----------------------------------------- | :------------------------------------------------------------------------------------------------------------ |
| **URL repositorio del Alumno A**           | Enlace al repositorio original creado en la Fase 1.                                                           |
| **URL repositorio del Alumno B (fork)**    | Enlace al repositorio bifurcado del Alumno B.                                                                 |
| **Captura de `gh pr list --state all`**    | Muestra todos los Pull Requests creados durante la práctica (los dos PRs: Fase 2 y Fase 4).                   |
| **Captura de `git log --oneline --graph --all`** | Muestra el historial completo de ambos repositorios con la estructura de ramas y fusiones.                    |
| **Captura del PR fusionado**               | Captura de pantalla del PR final fusionado en GitHub (el de la Fase 4, tras el cambio de roles).              |

> 💡 **Consejo:** Ejecuta `gh pr list --state all` y `git log --oneline --graph --all` desde la carpeta de tu repositorio local para generar las capturas requeridas.