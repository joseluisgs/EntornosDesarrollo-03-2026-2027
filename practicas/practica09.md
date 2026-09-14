# Práctica de Git: Práctica con Git y GitHub

- [Práctica de Git: Práctica con Git y GitHub](#práctica-de-git-práctica-con-git-y-github)
    - [**Práctica Individual: Desarrollo Colaborativo de un Blog Personal (`my-personal-blog`)**](#práctica-individual-desarrollo-colaborativo-de-un-blog-personal-my-personal-blog)


### **Práctica Individual: Desarrollo Colaborativo de un Blog Personal (`my-personal-blog`)**

**Objetivo:** Desarrollar de forma individual un blog personal utilizando Git para el control de versiones local y GitHub para gestionar el repositorio remoto y simular la colaboración. Durante esta práctica, aplicarás los principios del control de versiones, gestionarás distintas líneas de desarrollo (ramas), entenderás las diferencias y usos de la integración de cambios (fusión y reorganización), seleccionarás cambios específicos (`cherry-pick`), resolverás conflictos y simularás un flujo de trabajo de colaboración con Pull Requests.

**Instrucciones Generales:**

*   Realiza todos los pasos en un entorno de línea de comandos (terminal). Algunas acciones relacionadas con GitHub se realizarán en la interfaz web, lo cual se indicará explícitamente.
*   Guarda cada paso y cualquier mensaje de error o salida relevante, ya que podría ser útil para la entrega o la revisión.
*   **Lee cuidadosamente cada instrucción antes de ejecutarla y piensa qué acción o comando de Git es la más adecuada.**
*   Para visualizar el historial y comprender el impacto de tus acciones, recuerda que existe una herramienta para **mostrar el historial de confirmaciones de forma concisa, con ramas y en formato gráfico, incluyendo todas las referencias**. Utilízala frecuentemente.

---

**Fase 1: Preparación Inicial y Control Básico de Versiones (Local)**

1.  **Preparación del Entorno Git y GitHub:**
    *   Si aún no la tienes, crea una **cuenta en GitHub**.
    *   Si aún no lo has hecho, informa a Git sobre **quién eres** (tu nombre de usuario) y **cómo contactarte** (tu dirección de correo electrónico) a nivel global en tu sistema.
    *   Define cuál es tu **editor de texto preferido** (por ejemplo, VS Code) para que Git lo utilice automáticamente cuando necesite que escribas un mensaje.
    *   Activa la visualización de **colores en la salida de Git** para facilitar la lectura.
    *   Verifica la configuración de Git para confirmar que tus preferencias se han aplicado correctamente.

2.  **Inicio del Proyecto Local del Blog:**
    *   Crea un nuevo directorio en tu sistema con el nombre `my-personal-blog`.
    *   Dentro de este directorio, **inicializa un nuevo repositorio Git vacío** para comenzar el control de versiones.
    *   Verifica el estado actual de tu repositorio. Debería indicar que no hay confirmaciones y que el directorio de trabajo está limpio.

3.  **Creación de la Estructura Base del Blog y Primera Instantánea:**
    *   Crea un archivo llamado `index.html` con el siguiente contenido: `<!DOCTYPE html><html lang="es"><head><meta charset="UTF-8"><title>Mi Blog Personal</title><link rel="stylesheet" href="style.css"></head><body><h1>Bienvenido a mi Blog</h1><p>Aquí compartiré mis ideas y proyectos.</p></body></html>`.
    *   Crea un archivo `style.css` con el contenido: `body { font-family: sans-serif; background-color: #f4f4f4; }`.
    *   Crea un directorio `posts/` y dentro de él, un archivo `welcome.md` con el contenido: `# Mi Primera Publicación\n¡Hola mundo! Este es el inicio de mi blog.`.
    *   Verifica el estado del repositorio para ver los nuevos archivos sin seguimiento.
    *   **Añade todos los archivos** a la zona de intercambio (staging area), preparándolos para la siguiente instantánea.
    *   Verifica el estado de nuevo. Los archivos deberían aparecer como "preparados para confirmar".
    *   **Guarda la instantánea actual** de tu proyecto con un mensaje descriptivo: `"feat: Configuración inicial del blog y publicación de bienvenida"`.

4.  **Modificaciones y Ajustes Locales:**
    *   Consulta el **historial de confirmaciones** de tu repositorio.
    *   Modifica `index.html` para cambiar el título principal de `<h1>Bienvenido a mi Blog</h1>` a `<h1>Blog de [Tu Nombre]</h1>`.
    *   Modifica `style.css` para cambiar el `background-color` a `#e0f7fa` y añadir `color: #333;`.
    *   Verifica el estado del repositorio. Deberías ver los archivos como "modificados", pero aún no preparados.
    *   Muestra las diferencias de los cambios que has realizado pero que **aún no están en la zona de intercambio**.
    *   **Añade solo `index.html`** a la zona de intercambio.
    *   Muestra las diferencias de los cambios que **ya están en la zona de intercambio** y listos para ser guardados.
    *   **Guarda la instantánea** de los cambios de `index.html` con el mensaje: `"docs: Actualizar título del blog"`.
    *   Ahora, modifica `style.css` para cambiar el color de texto a `#222`.
    *   Añade `style.css` a la zona de intercambio.
    *   Te das cuenta de que la última instantánea guardada (`"docs: Actualizar título del blog"`) debería haber incluido también esta actualización de estilo. **Modifica la última instantánea para incluir los cambios de `style.css` y ajusta el mensaje** a: `"feat: Actualizar título y estilos base del blog"`.
    *   Visualiza el historial de confirmaciones de forma concisa para ver que solo hay 2 instantáneas y la última tiene el mensaje ajustado.

---

**Fase 2: Conexión con GitHub y Sincronización Remota**

1.  **Creación del Repositorio Remoto en GitHub (Interfaz Web):**
    *   Accede a GitHub y **crea un nuevo repositorio** con el nombre `my-personal-blog`. **Importante: No marques la opción "Inicializar este repositorio con un README"**.
    *   Obtén la URL HTTPS de este nuevo repositorio vacío.

2.  **Vinculación del Repositorio Local con el Remoto:**
    *   Ahora, conecta tu repositorio local `my-personal-blog` con el repositorio remoto que acabas de crear en GitHub. Dale el nombre predeterminado para el repositorio remoto (`origin`).
    *   **Envía tu rama principal** (master) a este repositorio remoto por primera vez. Esto hará que tus commits locales aparezcan en GitHub.
    *   Verifica en la interfaz web de GitHub que tus archivos y commits han sido subidos correctamente.

3.  **Simulación de Clonación y Colaboración (Otro Desarrollador):**
    *   Imagina que eres un nuevo colaborador o que trabajas desde otra máquina. **Crea una copia local** de tu repositorio `my-personal-blog` desde GitHub a una *nueva* ubicación en tu computadora (por ejemplo, `my-personal-blog-cloned`).
    *   En tu copia clonada (`my-personal-blog-cloned`), crea un nuevo archivo `config.js` con el siguiente contenido: `export const blogName = "[Tu Nombre] Blog";`.
    *   Modifica el `README.md` añadiendo al final una nueva línea con la frase: `Configuración básica de estilos y estructura.`.
    *   **Guarda la instantánea** de estos cambios con un mensaje descriptivo: `"chore: Añadir archivo de configuración y actualizar README"`.
    *   **Sube estos nuevos cambios** a tu repositorio remoto en GitHub.

4.  **Actualización del Repositorio Local Original:**
    *   Vuelve a tu repositorio *original* (`my-personal-blog`). **Descarga los cambios de tu repositorio remoto** e **intégralos** en tu rama principal local. Deberías ver el nuevo archivo (`config.js`) y la sección en `README.md` que se crearon en la copia clonada.

---

**Fase 3: Líneas de Desarrollo Paralelas, Fusión, Reorganización y Selección de Commits (con Remotos)**

1.  **Crear y Publicar una Rama de Desarrollo (`develop`):**
    *   Asegúrate de estar en tu rama principal (`master`).
    *   **Crea una nueva línea de desarrollo paralela** llamada `develop` y **cambia a ella inmediatamente**.
    *   En la rama `develop`, crea un archivo `archive.html` con el siguiente contenido: `<!DOCTYPE html><html lang="es"><head><meta charset="UTF-8"><title>Archivo de Publicaciones</title></head><body><h1>Archivo de Publicaciones</h1><p>Lista de todas las entradas del blog.</p></body></html>`.
    *   Modifica `index.html` para añadir un enlace al archivo después del párrafo: `<p><a href="archive.html">Ver todas las publicaciones</a></p>`.
    *   Añade los archivos modificados a la zona de intercambio y **guarda la instantánea** de estos cambios con el mensaje: `"feat: Crear página de archivo y enlazar desde la portada"`.
    *   **Sube la nueva rama `develop` a GitHub**. Verifica que aparece en la interfaz web de GitHub.

2.  **Hotfix Urgente en `master` y Publicación:**
    *   **Cambia a la línea `master`**.
    *   **Crea una nueva línea de desarrollo temporal** llamada `hotfix/typo-welcome` y **cambia a ella**.
    *   En esta nueva línea, modifica `posts/welcome.md` para corregir un pequeño error tipográfico (cambia `¡Hola mundo!` por `¡Hola a todos!`).
    *   Añade `posts/welcome.md` a la zona de intercambio y **guarda la instantánea** del cambio con el mensaje: `"fix: Corregir error tipográfico en publicación de bienvenida"`.
    *   **Sube esta rama `hotfix/typo-welcome` a GitHub**.
    *   **Cambia de nuevo a la línea `master`**.
    *   **Integra la línea `hotfix/typo-welcome` en `master`**.
    *   **Sube los cambios de `master` a GitHub**.
    *   **Elimina la rama `hotfix/typo-welcome` de tu repositorio local y de GitHub**.

3.  **Divergencia, Fusión (`merge`) y Resolución de Conflictos (Locales y Remotos):**
    *   **Cambia a la línea `develop`**.
    *   **Descarga e integra los últimos cambios** de la rama `master` remota en tu `develop` local. Esto asegura que `develop` tiene el hotfix.
    *   En la rama `develop`, modifica `style.css` añadiendo una nueva regla CSS para `h1`: `h1 { color: #00796b; text-align: center; }`. Añade `style.css` a la zona de intercambio y **guarda la instantánea** con el mensaje: `"style: Centrar título principal y cambiar color"`.
    *   **Sube este cambio a la rama `develop` en GitHub**.
    *   **Cambia a la línea `master`**.
    *   Modifica intencionadamente **la misma regla `h1` en `style.css`** (cambia `text-align: center;` por `text-align: left;` y `color: #00796b;` por `color: #004d40;`). Añade `style.css` a la zona de intercambio y **guarda la instantánea** con el mensaje: `"style: Alineación de título a la izquierda y color oscuro"`.
    *   **Sube este cambio a la rama `master` en GitHub**.
    *   **Cambia a la línea `develop`**.
    *   Ahora, **intenta integrar los cambios de la rama `master` en `develop`**. **¡Debería producirse un conflicto en `style.css`!**.
    *   Verifica el estado del repositorio para ver los archivos en conflicto. Deberían aparecer marcados.
    *   Abre `style.css` en tu editor. Verás los **marcadores de conflicto** (`<<<<<<<`, `=======`, `>>>>>>>`).
    *   **Resuelve el conflicto manualmente** en `style.css`. Decide que quieres la alineación centrada y el color original de `develop`, pero también quieres el color oscuro de `master`. Por ejemplo, mantén `text-align: center;` y `color: #004d40;`. Elimina los marcadores de conflicto.
    *   Añade el archivo `style.css` a la zona de intercambio para marcar el conflicto como resuelto.
    *   **Guarda la instantánea de la fusión** con un mensaje que explique la resolución del conflicto.
    *   **Sube la rama `develop` a GitHub** después de la fusión y resolución.
    *   Visualiza el historial completo (incluyendo todas las ramas y el gráfico) para observar el commit de fusión y cómo la historia de las ramas se entrelaza. **Compara este historial con el que verás en el escenario de `rebase` más adelante**, notando el commit extra de fusión.

4.  **Demostración de Reorganización (`rebase`) y Selección de Commit (`cherry-pick`) (con Remotos):**
    *   **Cambia a la línea `develop`**.
    *   **Crea una nueva línea de desarrollo `feature/metadata-posts`** a partir de `develop` y cambia a ella.
    *   En `feature/metadata-posts`, crea un nuevo archivo `post-data.js` con el contenido: `export const postMetadata = [{ id: 'welcome', title: 'Mi Primera Publicación', date: '2023-01-01' }];`.
    *   Añade `post-data.js` a la zona de intercambio y **guarda la instantánea** con el mensaje: `"feat: Añadir archivo de metadatos para publicaciones"`.
    *   Modifica `main.js` (si existe, o `script.js` si aún no tienes `main.js`) para importar `postMetadata` y mostrar un log de ello.
    *   Añade `main.js` (o `script.js`) a la zona de intercambio y **guarda la instantánea** con el mensaje: `"feat: Integrar metadatos en script principal"`.
    *   **Cambia a la línea `develop`**.
    *   Modifica `index.html` para añadir una sección de `<footer>` al final del `<body>`: `<footer><p>&copy; 2023 Mi Blog. Todos los derechos reservados.</p></footer>`.
    *   Añade `index.html` a la zona de intercambio y **guarda la instantánea** con el mensaje: `"feat: Añadir pie de página global"`.
    *   **Ahora, vuelve a tu rama `feature/metadata-posts`**.
    *   **Reaplica los cambios de tu línea `feature/metadata-posts` sobre la `develop` actual**. (Si hay conflictos, resuélvelos manualmente y continúa la reorganización).
    *   Una vez reorganizada, cambia a `develop`. **Integra `feature/metadata-posts` en `develop`**. (Debido a la reorganización previa, esto debería ser un "avance rápido" - fast-forward merge).
    *   **Sube la rama `develop` a GitHub**.
    *   **Elimina la rama `feature/metadata-posts` de tu repositorio local y de GitHub**.
    *   Visualiza el historial completo para observar el historial lineal resultante del `rebase` en comparación con el `merge` anterior. **Compara la estructura del historial**.

5.  **Uso de `cherry-pick` para un Commit Específico (con Remotos):**
    *   Asegúrate de estar en la rama `develop`.
    *   Crea una nueva línea de desarrollo, `feature/social-links`, para añadir enlaces a redes sociales y cambia a ella.
    *   Modifica `index.html` para añadir una sección de enlaces a redes sociales dentro del `<footer>`: `<p>Sígueme en: <a href="#">Twitter</a> | <a href="#">LinkedIn</a></p>`.
    *   Añade `index.html` a la zona de intercambio y **guarda la instantánea** con el mensaje: `"feat: Añadir enlaces a redes sociales en el pie de página"`.
    *   **Cambia a la línea `develop`**.
    *   **Identifica el ID de la instantánea** que añadió *solo* los enlaces a redes sociales en `index.html` (la que acabas de hacer en `feature/social-links`) consultando el historial de `feature/social-links`.
    *   **Aplica esa instantánea específica** a la rama `develop`. Esto es útil cuando necesitas una funcionalidad concreta de una rama de características que aún no está lista para fusionar por completo.
    *   **Sube la rama `develop`** con el nuevo commit `cherry-picked` a GitHub.
    *   **Elimina la rama `feature/social-links` de tu repositorio local y de GitHub**.
    *   Visualiza el historial completo para ver que el commit de los enlaces de redes sociales ahora existe en `develop`, duplicado en esencia, pero manteniendo el historial original de la rama `feature/social-links` intacta para el resto de su desarrollo.

---

**Fase 4: Flujo de Trabajo de Colaboración con Forks y Pull Requests**

1.  **Simulación de Fork de Proyecto Oficial (Interfaz Web):**
    *   Accede a la página de tu repositorio *original* (`my-personal-blog`) en GitHub. **Simula que otro usuario hace un 'fork'** de este repositorio a su propia cuenta de GitHub. (Esta es una acción en la interfaz web de GitHub. No necesitas hacerlo realmente, solo entender el concepto).

2.  **Clonar el Fork y Crear Rama de Característica (Simulado):**
    *   Imagina que eres ese "otro usuario". **Crea una copia local** de tu repositorio *bifurcado* (`fork`) en una *nueva* carpeta en tu computadora (por ejemplo, `my-personal-blog-fork`).
    *   Dentro de este clon del fork, crea una nueva rama llamada `feature/contact-page` y cámbiate a ella.
    *   Crea un archivo `contact.html` con el contenido: `<!DOCTYPE html><html lang="es"><head><meta charset="UTF-8"><title>Contacto</title></head><body><h1>Página de Contacto</h1><p>Envíame un mensaje.</p></body></html>`.
    *   Modifica `index.html` en esta rama para añadir un enlace a `contact.html` en el pie de página.
    *   Añade los archivos modificados a la zona de intercambio y **guarda la instantánea** de estos cambios.
    *   **Sube esta rama `feature/contact-page` a tu repositorio bifurcado** en GitHub (el que está en tu cuenta, no el original).

3.  **Creación de un Pull Request (Interfaz Web):**
    *   Ve a la interfaz web de GitHub de *tu repositorio bifurcado*.
    *   **Crea una solicitud de integración (Pull Request)** desde tu rama `feature/contact-page` hacia la rama `develop` del *repositorio original* (`my-personal-blog`). Proporciona un título y una descripción clara para tu característica. (Esta es una acción en la interfaz web de GitHub).

4.  **Sincronizar el Fork desde el Repositorio Original (Upstream):**
    *   Imagina que el repositorio original (`my-personal-blog`) ha recibido actualizaciones en su rama `develop` mientras trabajabas. Quieres **sincronizar tu repositorio bifurcado local (`my-personal-blog-fork`)** con esos cambios del repositorio original *antes* de que tu Pull Request sea revisado.
    *   Primero, añade una referencia remota al repositorio original (llámala `upstream`).
    *   Ahora, **descarga (fetch) los cambios** de la referencia `upstream`.
    *   Cambia a tu rama principal (`master`) en tu repositorio local bifurcado (`my-personal-blog-fork`).
    *   **Integra los cambios de `upstream/master`** en tu `master` local.
    *   **Sube tu rama `master` local actualizada** a **tu repositorio bifurcado en GitHub**.

5.  **Simulación de Aceptación/Conflicto del Pull Request (en el Repositorio Original):**
    *   Vuelve a tu repositorio *original* (`my-personal-blog`), en la rama `develop`.
    *   Modifica `index.html` para añadir un nuevo enlace en el `<footer>` justo donde se añadió el enlace a `contact.html` en la rama del Pull Request. Por ejemplo, añade: `<p><a href="#">Mapa del Sitio</a></p>` después de los enlaces a redes sociales.
    *   Añade `index.html` a la zona de intercambio y **guarda la instantánea** con un mensaje.
    *   **Sube este cambio a la rama `develop` del repositorio original en GitHub**.
    *   Ahora, desde la interfaz web de GitHub del repositorio original, observa el Pull Request que creaste. Debería indicar que **hay conflictos y que no puede ser fusionado automáticamente**.
    *   En tu repositorio local original (`my-personal-blog`), en la rama `develop`, **descarga (fetch) los cambios de la rama `feature/contact-page` del repositorio bifurcado**. (Tendrás que añadir el fork como remoto temporal si no lo has hecho antes).
    *   **Intenta integrar la rama remota de `feature/contact-page` en tu `develop` local**. **Debería producirse un conflicto en `index.html`**.
    *   **Resuelve el conflicto manualmente** en `index.html`. Decide mantener tanto el enlace a "Mapa del Sitio" como el enlace a "Contacto". Elimina los marcadores de conflicto.
    *   Añade `index.html` a la zona de intercambio y **guarda la instantánea de la fusión**.
    *   **Sube la rama `develop` del repositorio original a GitHub**.
    *   (Si vuelves a la interfaz de GitHub, el Pull Request ahora debería aparecer como fusionable o, si ya se había cerrado, los cambios se habrían incorporado).
    *   **Elimina la rama `feature/contact-page` de tu repositorio local *original* y de GitHub (del fork)**.

---

**Fase 5: Deshacer Cambios "Publicados" de Forma Segura**

1.  **Deshacer un Commit Publicado de Forma Segura (`git revert` y `push`):**
    *   Vuelve a tu repositorio *original* (`my-personal-blog`), en la rama `develop`.
    *   Modifica `config.js` añadiendo una nueva constante: `export const temporaryMessage = "Este es un mensaje temporal de prueba.";`.
    *   Añade `config.js` a la zona de intercambio y **guarda la instantánea** con el mensaje: `"chore: Añadir mensaje temporal de prueba"`.
    *   **Sube esta instantánea a la rama `develop` en GitHub**.
    *   Visualiza el historial completo para obtener el ID de esa instantánea.
    *   Te das cuenta de que esta instantánea, ya "publicada", no debería estar allí. **Deshaz los cambios de esa instantánea específica** creando una *nueva instantánea* que anule sus efectos. **Mantén la historia del proyecto intacta y lineal**.
    *   Se abrirá tu editor para el mensaje del nuevo commit de reversión. Acepta el mensaje predeterminado o edítalo si lo deseas, y guarda.
    *   **Sube este nuevo commit de reversión** a la rama `develop` en GitHub.
    *   Visualiza el historial completo para ver que el commit original y el de reversión coexisten en el historial.

---

**Fase 6: Finalización y Reflexión**

1.  **Limpieza Final de Líneas de Desarrollo:**
    *   Asegúrate de estar en una de tus líneas de desarrollo principales (como `master` o `develop`) en tu repositorio *original* (`my-personal-blog`).
    *   **Elimina todas las líneas de característica (`feature/*`) y hotfix (`hotfix/*`)** que hayas creado y que ya hayas integrado o que no necesites más, tanto de tu repositorio local como de GitHub (si las subiste).
    *   Repite el proceso de limpieza de ramas en tu repositorio bifurcado (`my-personal-blog-fork`), si es necesario.
    *   Visualiza el estado de las ramas locales y remotas para confirmar que solo quedan las que deseas.

2.  **Reflexión Final:**
    *   Consulta el historial completo del proyecto en tu repositorio *original* y en tu *fork* (localmente y en GitHub). Compara cómo se ve el historial tras las operaciones de fusión (`merge`) y reorganización (`rebase`).
    *   Analiza el flujo de trabajo de colaboración que seguiste para el Pull Request. Identifica las ventajas de usar un repositorio remoto como GitHub para este proceso, incluyendo la gestión de documentación y la retroalimentación.
    *   Discute los posibles "peligros de reorganizar" commits que ya se han "publicado" (enviado a un repositorio remoto) y por qué `git revert` es la opción preferida en esos casos.

---