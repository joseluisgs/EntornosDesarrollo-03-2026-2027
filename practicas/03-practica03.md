
## Práctica 3: Sincronización, Ramificación y Control de Errores con Repositorios Remotos

- [Práctica 3: Sincronización, Ramificación y Control de Errores con Repositorios Remotos](#práctica-3-sincronización-ramificación-y-control-de-errores-con-repositorios-remotos)
  - [Conceptos Clave a Introducir y Reforzar:](#conceptos-clave-a-introducir-y-reforzar)
  - [Fase 1: Creación del Repositorio Remoto y Primera Conexión](#fase-1-creación-del-repositorio-remoto-y-primera-conexión)
  - [Fase 2: Sincronización y Descarga de Cambios (Pull vs. Fetch)](#fase-2-sincronización-y-descarga-de-cambios-pull-vs-fetch)
  - [Fase 3: Trabajo con Ramas Remotas](#fase-3-trabajo-con-ramas-remotas)
  - [Fase 4: Deshacer Cambios Publicados y Control de Errores Remotos](#fase-4-deshacer-cambios-publicados-y-control-de-errores-remotos)
  - [Fase 5: Limpieza de Ramas Remotas](#fase-5-limpieza-de-ramas-remotas)
  - [Importancia de Añadir el Repositorio Remoto](#importancia-de-añadir-el-repositorio-remoto)


### Conceptos Clave a Introducir y Reforzar:

1.  **Repositorio Remoto:** Lugar donde se almacenan los datos actualizados e históricos de cambios, a menudo en un servidor externo (como GitHub, GitLab o Bitbucket).
2.  **Sincronización:** El proceso de intercambiar historial de versión entre el repositorio local y el remoto.
3.  **`git remote`:** Comando para gestionar los enlaces a los repositorios remotos.
4.  **`git push`:** Sube los cambios locales al repositorio remoto.
5.  **`git fetch` vs. `git pull`:** `fetch` descarga los cambios remotos sin integrarlos, mientras que `pull` descarga e integra automáticamente (fetch + merge/rebase).
6.  **`git revert`:** La manera segura de deshacer cambios que ya han sido **publicados** o compartidos en el repositorio remoto.

### Fase 1: Creación del Repositorio Remoto y Primera Conexión

| **Paso** | **Descripción y Comandos**                                                                                                                                                            | **Concepto de Git**                                                           |
| :------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | :---------------------------------------------------------------------------- |
| **1.1**  | **Crea y prepara tu proyecto local:** Inicializa un repositorio local (`practica03`). Crea `README.txt` y `index.html`. Confirma ambos con `git commit -m "feat: Estructura inicial"` | Confirma la primera instantánea local.                                        |
| **1.2**  | **Crea el Repositorio Remoto:** Ve a tu plataforma de alojamiento (ej: GitHub) y crea un nuevo repositorio llamado `practica03-remota`. **No lo inicialices con README**.             | El repositorio remoto será la "Copia de seguridad externa del código fuente". |
| **1.3**  | **Vincula el repositorio local con el remoto:** `git remote add origin <URL_del_repositorio_remoto>`                                                                                  | Crea un enlace llamado `origin` al repositorio externo.                       |
| **1.4**  | **Verifica el enlace remoto:** `git remote -v`                                                                                                                                        | Muestra el listado de repositorios remotos definidos.                         |
| **1.5**  | **Sube la rama principal (`master`/`main`) al remoto:** `git push origin master` (o `main`)                                                                                           | **`git push`** envía los *commits* locales al servidor.                       |
| **1.6**  | **Verifica en la web** que tus archivos y el historial han sido subidos correctamente.                                                                                                |                                                                               |

### Fase 2: Sincronización y Descarga de Cambios (Pull vs. Fetch)

**Potencia del Remoto:** La capacidad de sincronizar (Actualización o *sync*) permite integrar los cambios hechos en el remoto (por otros usuarios o desde otra máquina) en la copia de trabajo local.

| **Paso** | **Descripción y Comandos**                                                                                                                                                                       | **Concepto de Git**                                                                                                                                  |
| :------- | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :--------------------------------------------------------------------------------------------------------------------------------------------------- |
| **2.1**  | **Simula un cambio en el remoto (Interfaz Web):** Accede a GitHub y modifica `README.txt` directamente desde la interfaz web (añade una línea: "Cambio realizado directamente en el servidor."). | Crea un commit **que solo existe en el repositorio remoto**.                                                                                         |
| **2.2**  | **Descarga los metadatos sin integrar:** `git fetch origin master`                                                                                                                               | **`git fetch`** descarga el historial del servidor remoto. El cambio ahora está en tu repositorio local oculto, pero no en tu directorio de trabajo. |
| **2.3**  | **Compara la rama local con la remota:** `git log master..origin/master` (o similar)                                                                                                             | Muestra los commits que tiene el remoto pero no tu local.                                                                                            |
| **2.4**  | **Integra los cambios descargados (Merge):** `git merge origin/master`                                                                                                                           | Fusiona los cambios que `fetch` trajo, actualizando tu directorio de trabajo.                                                                        |
| **2.5**  | **Alternativa de un solo paso:** (Si hubieras usado `git pull origin master`)                                                                                                                    | **`git pull`** es una combinación de `git fetch` y `git merge`.                                                                                      |

### Fase 3: Trabajo con Ramas Remotas

| **Paso** | **Descripción y Comandos**                                                                                                                                            | **Concepto de Git**                                                                                    |
| :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :----------------------------------------------------------------------------------------------------- |
| **3.1**  | **Crea y cambia a una nueva rama local:** `git checkout -b feature/metadata`                                                                                          | Se crean líneas de desarrollo independientes.                                                          |
| **3.2**  | **En la rama `feature/metadata`:** Crea el archivo `config.txt` con contenido (ej: "Version: 1.0"). Confirma el cambio: `git commit -m "feat: Añadida configuración"` | El commit existe solo localmente en esta rama.                                                         |
| **3.3**  | **Sube la nueva rama al remoto:** `git push origin feature/metadata`                                                                                                  | El comando `push` sube la rama y sus commits al remoto, permitiendo que otros (o el servidor) la vean. |
| **3.4**  | **Vuelve a la rama principal:** `git checkout master`                                                                                                                 | Los archivos de tu directorio de trabajo cambian para reflejar el estado de `master`.                  |
| **3.5**  | **Integra la rama de característica localmente:** `git merge feature/metadata`                                                                                        | El contenido de `config.txt` se incorpora a `master` localmente.                                       |
| **3.6**  | **Sube la rama `master` actualizada al remoto:** `git push origin master`                                                                                             | Sincroniza el resultado de la fusión con el servidor.                                                  |
| **3.7**  | **Elimina la rama local:** `git branch -d feature/metadata`                                                                                                           | Se recomienda eliminar las ramas ya fusionadas.                                                        |

### Fase 4: Deshacer Cambios Publicados y Control de Errores Remotos

**Control de Errores Remotos:** Si ya has subido un *commit* (`push`), **no debes** usar `git reset --hard` seguido de un `push --force` en la mayoría de los casos de trabajo colaborativo, ya que reescribe la historia. La herramienta recomendada para deshacer cambios **ya publicados** es `git revert`.

| **Paso** | **Descripción y Comandos**                                                                                                                                                                              | **Concepto de Git**                                                                                                                                                                          |
| :------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **4.1**  | **Introduce un error y confírmalo:** Modifica `index.html` (ej: añade una línea sensible: "Contraseña de desarrollo: 1234"). Confirma: `git commit -m "chore: Commit con datos sensibles"`              | La instantánea existe localmente.                                                                                                                                                            |
| **4.2**  | **Sube el error (Publicación):** `git push origin master`                                                                                                                                               | El cambio está ahora en el repositorio remoto, compartido.                                                                                                                                   |
| **4.3**  | **Identifica el ID del commit con el error:** `git log --oneline` y copia el código hash (ej: `a1b2c3d`).                                                                                               | Necesario para referenciar el commit a deshacer.                                                                                                                                             |
| **4.4**  | **Deshace el commit de forma segura:** `git revert a1b2c3d`                                                                                                                                             | **`git revert`** crea un **nuevo commit** que anula los cambios del commit especificado, **preservando el historial existente**. Se abrirá tu editor para confirmar el mensaje de reversión. |
| **4.5**  | **Sube el commit de reversión al remoto:** `git push origin master`                                                                                                                                     | Esto publica la corrección sin reescribir la historia, lo cual es vital para el trabajo compartido.                                                                                          |
| **4.6**  | **Verifica:** `git log --oneline`. Deberías ver tanto el commit original con el error (ej: "Commit con datos sensibles") como el nuevo commit de anulación (ej: "Revert "Commit con datos sensibles""). | Esto muestra que Git añade historial (el *revert*) en lugar de modificarlo.                                                                                                                  |

### Fase 5: Limpieza de Ramas Remotas

| **Paso** | **Descripción y Comandos**                                                                                                                                        | **Concepto de Git**                                           |
| :------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------- | :------------------------------------------------------------ |
| **5.1**  | **Crea una rama temporal, súbela y bórrala:** (Si tienes una rama que no se fusionó, o simulas una rama de prueba). Crea y súbela: `git push origin test-branch`. |                                                               |
| **5.2**  | **Elimina la rama del repositorio remoto:** `git push origin --delete test-branch`                                                                                | Este comando elimina la referencia de la rama en el servidor. |
| **5.3**  | **Elimina la rama local:** `git branch -d test-branch`                                                                                                            | Eliminación de la referencia local, completando la limpieza.  |

### Importancia de Añadir el Repositorio Remoto

Añadir un repositorio remoto (como GitHub o GitLab) añade un nivel de potencia crucial:

*   **Copia de Seguridad Externa:** Si tu repositorio local sufre un daño, el VCS remoto conserva una copia del código fuente, lo que permite revertir y deshacer los cambios a una versión estable conocida.
*   **Gestión Distribuida:** Git es un sistema distribuido de control de versiones. El manejo remoto permite que los cambios se importen como ramas adicionales y puedan ser fusionados de la misma manera que en la rama local.
*   **Sincronización de Equipos:** Permite a múltiples desarrolladores trabajar en el mismo proyecto, descargando los cambios de otros (`git pull` o `git fetch`) y subiendo los propios (`git push`).