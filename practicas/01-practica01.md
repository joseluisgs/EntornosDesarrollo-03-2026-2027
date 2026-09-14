## Práctica 1: Fundamentos de Git en Entorno Local (Sin Ramas)

- [Práctica 1: Fundamentos de Git en Entorno Local (Sin Ramas)](#práctica-1-fundamentos-de-git-en-entorno-local-sin-ramas)
  - [Conceptos Clave a Introducir y Reforzar:](#conceptos-clave-a-introducir-y-reforzar)
  - [Fase 1: Inicialización y Primer Commit](#fase-1-inicialización-y-primer-commit)
  - [Fase 2: Diferencias entre Áreas y Creación de Tags](#fase-2-diferencias-entre-áreas-y-creación-de-tags)
  - [Fase 3: Identificación de Autores y Descarte de Cambios (Errores Menores)](#fase-3-identificación-de-autores-y-descarte-de-cambios-errores-menores)
  - [Fase 4: Deshacer Commits (Borrando y Preservando Cambios)](#fase-4-deshacer-commits-borrando-y-preservando-cambios)
  - [Fase 5: Recuperación y Revertir](#fase-5-recuperación-y-revertir)
  - [Reflexión Final (Importancia de Git Local)](#reflexión-final-importancia-de-git-local)


### Conceptos Clave a Introducir y Reforzar:
1.  **Directorio de Trabajo (*Working Directory*):** Donde se modifican los archivos directamente.
2.  **Área de Preparación (*Staging Area* o Índice):** Zona intermedia donde se seleccionan los cambios exactos que se incluirán en la próxima "instantánea" (commit).
3.  **Repositorio Git (*Git Directory*):** Donde se almacenan los metadatos y el historial completo de las instantáneas confirmadas (commits).

### Fase 1: Inicialización y Primer Commit

| **Paso** | **Descripción y Comandos**                                                                                                                                                                | **Concepto de Git**                                                                        |
| :------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :----------------------------------------------------------------------------------------- |
| **1.1**  | **Crea el directorio** `practica01` y **navega** dentro.                                                                                                                                  | Directorio de trabajo.                                                                     |
| **1.2**  | **Inicializa el repositorio local** con `git init`.                                                                                                                                       | Crea el directorio oculto `.git` (el Repositorio).                                         |
| **1.3**  | **Configura tu identidad** (si no lo has hecho) para que tus cambios se asocien a ti: `git config --global user.name "Tu Nombre"` y `git config --global user.email tu.email@ejemplo.com` | Configuración necesaria para la autoría de commits.                                        |
| **1.4**  | **Crea los archivos iniciales** (solo HTML sin estilos y TXT):<br>1. Crea `index.html` con una estructura básica.<br>2. Crea `info.txt` y añade "Proyecto iniciado."                      | Los archivos están en estado "no rastreado" (*untracked*).                                 |
| **1.5**  | **Verifica el estado** con `git status`.                                                                                                                                                  | Muestra qué archivos están "no rastreados" en el Directorio de trabajo.                    |
| **1.6**  | **Añade ambos archivos** al Área de preparación: `git add .`                                                                                                                              | Mueve los archivos del Directorio de trabajo al Área de preparación (*staged*).            |
| **1.7**  | **Verifica el estado** de nuevo. Deberían aparecer como "preparados para confirmar".                                                                                                      |                                                                                            |
| **1.8**  | **Realiza la primera confirmación** (commit): `git commit -m "feat: Estructura base del proyecto"`                                                                                        | Toma la instantánea del Área de preparación y la guarda permanentemente en el Repositorio. |
| **1.9**  | **Revisa el historial** con `git log --oneline`.                                                                                                                                          | Muestra la instantánea confirmada.                                                         |

### Fase 2: Diferencias entre Áreas y Creación de Tags

| **Paso** | **Descripción y Comandos**                                                                              | **Concepto de Git**                                                         |
| :------- | :------------------------------------------------------------------------------------------------------ | :-------------------------------------------------------------------------- |
| **2.1**  | **Modifica** `index.html` añadiendo una nueva línea de texto.                                           | Archivo modificado en el Directorio de trabajo (estado *modified*).         |
| **2.2**  | **Muestra las diferencias** entre el Directorio de trabajo y el último commit: `git diff HEAD`          | Visualiza los cambios que **aún no han sido preparados**.                   |
| **2.3**  | **Prepara** el cambio: `git add index.html`                                                             | El cambio está ahora en el Área de preparación.                             |
| **2.4**  | **Muestra las diferencias** entre el Área de preparación y el último commit: `git diff --cached`        | Visualiza los cambios **listos para ser confirmados**.                      |
| **2.5**  | **Realiza el commit:** `git commit -m "docs: Actualización de la portada"`                              | Se crea una nueva instantánea en el Repositorio.                            |
| **2.6**  | **Etiqueta esta versión** como importante: `git tag v1.0-estable`                                       | **Tags:** Permite marcar puntos específicos del historial como importantes. |
| **2.7**  | **Muestra el detalle** de la etiqueta: `git show v1.0-estable`                                          | Visualiza los metadatos y cambios asociados a esa versión.                  |
| **2.8**  | **Visualiza el historial** con formato gráfico (simulando un árbol lineal): `git log --oneline --graph` | Observa la historia de confirmaciones.                                      |

### Fase 3: Identificación de Autores y Descarte de Cambios (Errores Menores)

**Importancia de Git a nivel local:** Incluso trabajando individualmente, Git permite rastrear *quién* (tú, en este caso) y *cuándo* se introdujo cada línea de código, lo cual es invaluable para la depuración.

| **Paso** | **Descripción y Comandos**                                                                                                    | **Concepto de Git**                                                                                               |
| :------- | :---------------------------------------------------------------------------------------------------------------------------- | :---------------------------------------------------------------------------------------------------------------- |
| **3.1**  | **Modifica** `info.txt` añadiendo una línea con una *fecha* (ej: 2024-05-20 - Revisión).                                      |                                                                                                                   |
| **3.2**  | **Prepara y confirma** el cambio: `git commit -am "chore: Añadida revisión de fecha"`                                         | Se utiliza `-am` para añadir archivos rastreados modificados y confirmar en un solo paso.                         |
| **3.3**  | **Visualiza el historial línea a línea** para `index.html`: `git blame index.html`                                            | **Blame/Annotate:** Muestra el commit, el autor y la fecha de la última modificación para cada línea del archivo. |
| **3.4**  | **Equivocación en el Directorio de Trabajo:** Modifica `index.html` añadiendo una línea de prueba que **no quieres guardar**. |                                                                                                                   |
| **3.5**  | **Descarta los cambios locales** (solución a la "cagada" sin preparar): `git restore index.html`                              | Deshace los cambios en el Directorio de trabajo, volviendo al estado del último commit.                           |
| **3.6**  | **Equivocación en el Área de Preparación:** Modifica `info.txt` y **prepáralo**: `git add info.txt`                           | El archivo está listo para el commit.                                                                             |
| **3.7**  | **Desprepara los cambios** (saca del staging): `git restore --staged info.txt`                                                | Mueve el archivo del Área de preparación de vuelta al Directorio de trabajo, **manteniendo los cambios**.         |
| **3.8**  | **Confirma la despreparación:** `git status`. El archivo `info.txt` debería estar modificado, pero sin preparar.              |                                                                                                                   |

### Fase 4: Deshacer Commits (Borrando y Preservando Cambios)

| **Paso** | **Descripción y Comandos**                                                                                                                                                              | **Concepto de Git**                                                                                                                                                                                                         |
| :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **4.1**  | **Crea un commit que se quiere editar:** Añade una línea a `index.html` (ej: "Línea que olvidé incluir"). Prepara y confirma: `git commit -m "fix: Arreglo rápido"`                     |                                                                                                                                                                                                                             |
| **4.2**  | **Modifica el commit anterior (sin reescribir la historia):** Te das cuenta de que el mensaje es malo. `git commit --amend -m "fix: Corregido pequeño error tipográfico en la portada"` | Permite corregir el mensaje del último commit y/o añadir cambios olvidados.                                                                                                                                                 |
| **4.3**  | **Crea un commit para deshacer (preservando cambios):** Añade varias líneas de contenido nuevo a `info.txt`. Prepara y confirma: `git commit -m "feat: Gran funcionalidad v2.0"`        |                                                                                                                                                                                                                             |
| **4.4**  | **Deshace el último commit** (pero quieres los cambios para reempaquetarlos): `git reset --soft HEAD~1`                                                                                 | **Deshacer commit (Soft):** Mueve el puntero `HEAD` hacia atrás, eliminando el commit, pero **mantiene los cambios** en el Área de preparación y Directorio de trabajo.                                                     |
| **4.5**  | **Verifica el estado:** `git status`. Los cambios de "Gran funcionalidad v2.0" deberían estar listos para confirmar (staged).                                                           |                                                                                                                                                                                                                             |
| **4.6**  | **Crea un commit para deshacer (borrando la línea y la historia):** Confirma de nuevo los cambios de `info.txt` con un mensaje (ej: "feat: Funcionalidad destructiva").                 |                                                                                                                                                                                                                             |
| **4.7**  | **Deshace el último commit y borra los cambios de forma permanente:** `git reset --hard HEAD~1`                                                                                         | **Deshacer commit (Hard):** Mueve el puntero `HEAD` hacia atrás, *eliminando* el commit y *limpiando* el Área de preparación y el Directorio de trabajo. **¡Esto borra las líneas de código introducidas por ese commit!**. |
| **4.8**  | **Verifica el historial** y el contenido de `info.txt`. Las líneas de código introducidas en 4.6 deben haber desaparecido.                                                              |                                                                                                                                                                                                                             |

### Fase 5: Recuperación y Revertir

| **Paso** | **Descripción y Comandos**                                                                                                                                                         | **Concepto de Git**                                                                                                                                                                          |
| :------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **5.1**  | **Simula un borrado accidental:** Borra el archivo `index.html` del Directorio de trabajo (usando el explorador de archivos o `rm index.html`).                                    | Git notificará que el archivo ha sido eliminado.                                                                                                                                             |
| **5.2**  | **Verifica el estado:** `git status`.                                                                                                                                              | Muestra el archivo como eliminado.                                                                                                                                                           |
| **5.3**  | **Recupera el archivo** a su última versión confirmada: `git restore index.html`                                                                                                   | El archivo vuelve al Directorio de trabajo.                                                                                                                                                  |
| **5.4**  | **Crea un commit para deshacer (simulación de trabajo compartido):** Añade nuevo contenido a `info.txt` y confírmalo: `git commit -m "fix: Bug introducido que debe ser deshecho"` |                                                                                                                                                                                              |
| **5.5**  | **Deshace este commit de forma segura:** `git revert HEAD`                                                                                                                         | **Revertir:** Crea una *nueva* confirmación que anula los efectos del commit especificado, **manteniendo ambos commits en la historia**. Ideal para cambios que ya se consideran "públicos". |
| **5.6**  | **Verifica el historial:** `git log --oneline`. Verás el commit original y el nuevo commit de reversión, ambos coexisten.                                                          |                                                                                                                                                                                              |

### Reflexión Final (Importancia de Git Local)

El uso de un **Sistema de Control de Versiones (VCS)**, como Git, es una herramienta valiosa. Incluso en un trabajo mantenido por una sola persona (trabajo individual) sin ramas, los beneficios son enormes:

*   **Historial Completo de Revisiones:** Git almacena un registro de todas las modificaciones realizadas a lo largo del tiempo, lo que permite recuperar versiones específicas posteriormente.
*   **Capacidad de Deshacer Cambios:** Permite revertir y deshacer rápidamente a una versión estable conocida.
*   **Seguridad:** Asegura que los cambios, incluso antes de ser compartidos en un repositorio remoto, están almacenados de forma segura en la base de datos local de Git.
*   **Aislamiento de Errores:** Las áreas de trabajo (Directorio, Staging, Repositorio) permiten aislar los cambios que no funcionan (como se demostró con `git restore` o `git reset --soft`) antes de confirmarlos permanentemente, previniendo la pérdida de trabajo no deseado.
*   **Auditoría y Traza:** Comandos como `git blame` permiten identificar con precisión cuándo y por quién se introdujo cada línea de código, facilitando la depuración y la corrección de fallas.