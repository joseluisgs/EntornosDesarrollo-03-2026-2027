**Cuestionario sobre Git, GitHub y Documentación**

**Instrucciones:** Lee cuidadosamente cada pregunta y selecciona la opción que consideres correcta. No hay respuestas marcadas.

**Git: Conceptos Básicos y Fundamentos**

1.  **¿Qué es Git?**
    a) Un sistema de gestión de bases de datos relacionales.
    b) Un sistema distribuido de control de versiones.
    c) Un editor de código fuente para desarrollo web.
    d) Una plataforma de alojamiento de proyectos en la nube.

2.  **¿Quién es el autor principal de Git?**
    a) Cem Eygi
    b) Nora Gonzalo Ciordia
    c) Linus Torvalds
    d) Scott Chacon

3.  **¿Cuál de los siguientes es uno de los tres estados principales en los que se pueden encontrar los archivos en Git?**
    a) Abierto
    b) Guardado
    c) Compilado
    d) Modificado

4.  **Según las fuentes, ¿cómo almacena Git sus datos?**
    a) Como una lista de los cambios realizados en cada archivo.
    b) Como un conjunto de copias instantáneas de un sistema de archivos miniatura.
    c) En un archivo comprimido único para todo el proyecto.
    d) De forma incremental, guardando solo las diferencias entre versiones.

5.  **¿Qué representa un "repositorio" en el contexto de Git?**
    a) Un archivo de configuración del sistema operativo.
    b) El lugar donde se almacenan los datos actualizados e históricos de cambios de un proyecto.
    c) Una base de datos de usuarios y permisos.
    d) Una carpeta temporal para archivos descartados.

6.  **Un "commit" en Git se describe como:**
    a) Una solicitud para que otros desarrolladores revisen el código.
    b) Un mensaje breve para explicar los cambios realizados en el código fuente.
    c) Una instantánea del área de preparación almacenada de forma segura en la base de datos local.
    d) La acción de descargar la última versión de un proyecto desde un servidor remoto.

7.  **¿Qué es una rama (branch) en Git?**
    a) Un directorio del sistema de archivos que contiene copias de todos los archivos del proyecto.
    b) Un archivo que define los permisos de acceso al repositorio.
    c) Un apuntador móvil que apunta a una de las confirmaciones (commits) en el historial del proyecto.
    d) Una versión de un archivo que ha sido marcada como estable.

8.  **¿Cuál es el propósito del hash SHA-1 en Git?**
    a) Identificar de forma única a cada usuario del repositorio.
    b) Cifrar el contenido de los archivos para garantizar la seguridad.
    c) Calcularse con base en los contenidos de un archivo o estructura de directorio para identificar objetos.
    d) Comprimir los archivos para ahorrar espacio de almacenamiento.

9.  **Git es un ejemplo de qué tipo de sistema de control de versiones?**
    a) Centralizado.
    b) Distribuido.
    c) Jerárquico.
    d) En cascada.

**Comandos de Git**

10. **¿Cuál es la función principal del comando `git add`?**
    a) Deshacer los últimos cambios realizados en el directorio de trabajo.
    b) Mover los cambios del directorio de trabajo al área de entorno de ensayo (staging area).
    c) Guardar los cambios directamente en el repositorio local.
    d) Crear un nuevo repositorio de Git.

11. **Para rehacer la última confirmación (commit) y modificar su mensaje o los archivos incluidos, ¿qué opción se usa con `git commit`?**
    a) `--force`
    b) `--amend`
    c) `--reset`
    d) `--update`

12. **¿Qué realiza el comando `git checkout <nombre-de-la-rama>`?**
    a) Borra la rama especificada del repositorio local.
    b) Crea una nueva rama con el nombre indicado sin cambiar a ella.
    c) Cambia el HEAD para que apunte a la rama o confirmación especificada.
    d) Fusiona la rama especificada en la rama actual.

13. **¿Qué comando se utiliza para integrar los cambios de una rama específica en la rama actual a la que apunta HEAD?**
    a) `git rebase`
    b) `git push`
    c) `git merge`
    d) `git fetch`

14. **¿Cuál es el efecto del comando `git log --pretty=oneline`?**
    a) Muestra solo las dos últimas confirmaciones con detalles completos.
    b) Muestra un gráfico ASCII del historial de ramificaciones y uniones.
    c) Muestra las confirmaciones utilizando un formato alternativo de una sola línea.
    d) Muestra el parche introducido por cada confirmación.

15. **¿Qué comando se utiliza para guardar temporalmente el trabajo no confirmado en el directorio de trabajo y el área de preparación, permitiendo limpiar el espacio de trabajo sin crear un commit?**
    a) `git commit`
    b) `git clean`
    c) `git stash`
    d) `git revert`

16. **Si necesitas tomar uno o varios commits de una rama y aplicarlos directamente a otra sin realizar una fusión completa, ¿qué comando de Git usarías?**
    a) `git merge`
    b) `git rebase`
    c) `git cherry-pick`
    d) `git pull`

17. **¿Cuál es el propósito principal del archivo `.gitignore`?**
    a) Almacenar credenciales de usuario para el repositorio remoto.
    b) Listar patrones de ficheros y directorios que Git debe ignorar y no rastrear.
    c) Registrar un historial de los comandos de Git ejecutados.
    d) Crear alias para comandos de Git de uso frecuente.

18. **¿Qué hace el comando `git diff`?**
    a) Muestra el historial completo de confirmaciones del repositorio.
    b) Muestra la diferencia entre el directorio de trabajo, el área de ensayo y/o el último commit.
    c) Aplica un parche de cambios a un archivo.
    d) Elimina archivos modificados del repositorio.

19. **Cuando se ejecuta `git rm --cached <archivo>`, ¿cuál es el resultado esperado?**
    a) El archivo se elimina tanto del disco duro como del historial de Git.
    b) El archivo se mantiene en el directorio de trabajo, pero se elimina del área de preparación y deja de ser rastreado por Git.
    c) El archivo se mueve automáticamente a una rama temporal para su revisión.
    d) El archivo se renombra para evitar conflictos con otras versiones.

20. **Según las fuentes, ¿qué comando de Git permite eliminar una rama local incluso si no ha sido fusionada, perdiendo sus cambios si no han sido incorporados en otro lugar?**
    a) `git branch -f <rama>`
    b) `git branch -D <rama>`
    c) `git branch --delete-force <rama>`
    d) `git branch --unmerged <rama>`

**Flujos de Trabajo y Pull Requests**

21. **¿Qué es una "Pull Request" (Solicitud de extracción)?**
    a) Un comando de Git para descargar cambios de un repositorio remoto.
    b) Una herramienta de comunicación en el desarrollo de software para explicar el trabajo y facilitar la colaboración y revisión.
    c) Un tipo especial de rama que solo se usa para liberar nuevas versiones del software.
    d) Un proceso para crear una copia exacta de un repositorio en la máquina local.

22. **En el flujo de trabajo GitHub Flow, ¿qué se considera que debe estar siempre en un estado listo para ser puesto en producción?**
    a) El código en cualquier rama de características recién creada.
    b) El código en la rama `develop`.
    c) El código en la rama `master`.
    d) El código en las ramas de correcciones rápidas.

23. **Según la metodología GitFlow, ¿cuál es el propósito de la rama `develop`?**
    a) Almacenar el historial de publicación oficial y las versiones estables del proyecto.
    b) Servir como la principal línea de desarrollo donde se integran todas las nuevas características y correcciones.
    c) Realizar pruebas finales y ajustes menores antes de liberar una nueva versión.
    d) Corregir errores críticos que se encuentran directamente en producción.

24. **En el flujo de trabajo GitFlow, ¿de qué rama se crean las ramas de características (`feature branches`)?**
    a) `master`
    b) `hotfix`
    c) `develop`
    d) `release`

25. **¿Cuándo se fusiona una rama de corrección rápida (`hotfix`) en el flujo de GitFlow, una vez solucionado el problema?**
    a) Solo en la rama `develop`.
    b) Solo en la rama `master`.
    c) Tanto en `master` como en `develop`.
    d) No se fusiona, se elimina directamente después de su uso.

26. **Una buena práctica recomendada para crear Pull Requests es que el desarrollador se tome el tiempo de:**
    a) Solicitar al equipo que revise el código sin revisarlo previamente.
    b) Revisar el código ellos mismos antes de crear la solicitud de extracción para detectar errores comunes.
    c) Fusionar el código directamente en la rama principal sin ninguna revisión.
    d) Crear la Pull Request en borrador y luego realizar los cambios.

27. **¿Qué ventaja principal se asocia con mantener las Pull Requests breves?**
    a) Permite una revisión más exhaustiva y detallada por parte de los revisores.
    b) Aumenta el tiempo necesario para proporcionar retroalimentación debido a la complejidad.
    c) Facilita que, durante la revisión, se pueda prestar atención y analizar los cambios más rápidamente.
    d) Fomenta la inclusión de múltiples funcionalidades no relacionadas en una sola solicitud.

28. **Para facilitar la comprensión y revisión del código en una Pull Request, ¿qué se debe incluir en la descripción?**
    a) Solo el título de la solicitud de extracción.
    b) Una explicación de los cambios realizados, el propósito de la solicitud y el plan de pruebas.
    c) Únicamente los resultados de las pruebas exitosas del código.
    d) La dirección de correo electrónico del desarrollador para contacto directo.

29. **En GitHub, ¿cómo se puede referenciar otra Pull Request o una incidencia dentro de un comentario o descripción?**
    a) Escribiendo el nombre completo del proyecto y el autor.
    b) Utilizando el símbolo `#` seguido del número de identificación único de la Pull Request o incidencia.
    c) Pegando la dirección URL completa del elemento.
    d) Mencionando el hash SHA-1 de la confirmación relevante.

30. **Según las fuentes, ¿es posible abrir una Pull Request entre dos ramas del mismo repositorio, sin necesidad de un fork?**
    a) No, las Pull Requests están diseñadas exclusivamente para repositorios bifurcados.
    b) Sí, para formalizar el proceso de revisión de código y discusión dentro del mismo proyecto.
    c) Solo si ambas ramas están en un estado completamente estable y sin conflictos.
    d) Únicamente si el repositorio es privado y tiene un número limitado de colaboradores.

**Documentación (Javadoc y Markdown)**

31. **¿Qué es Javadoc?**
    a) Un lenguaje de programación diseñado específicamente para la documentación.
    b) Una herramienta para generar documentación automática a partir de comentarios con una sintaxis específica en código Java.
    c) Un editor de texto integrado en los IDE de Java.
    d) Un sistema de gestión de errores para proyectos Java.

32. **En Javadoc, ¿cuál es la función de la etiqueta `@param`?**
    a) Indicar el nombre del desarrollador o autor de la clase.
    b) Informar sobre el valor que devuelve un método, sin ser aplicable a constructores o métodos `void`.
    c) Definir un parámetro de un método o constructor, siendo requerido para todos los parámetros.
    d) Asociar la documentación con otro método o clase relacionada.

33. **¿Qué etiqueta de Javadoc se utiliza para indicar que un método o clase es obsoleto y que no se recomienda su uso, ya que posiblemente desaparecerá en versiones posteriores?**
    a) `@version`
    b) `@return`
    c) `@see`
    d) `@deprecated`

34. **Uno de los objetivos principales de John Gruber al crear Markdown fue:**
    a) Desarrollar un nuevo lenguaje de programación más eficiente.
    b) Permitir a la gente escribir usando un formato de texto llano fácil de leer y escribir, con la posibilidad de convertirlo en HTML válido.
    c) Crear un sistema de gestión de bases de datos para proyectos web.
    d) Reemplazar completamente la sintaxis XML en la documentación.

35. **¿Cómo se crea un encabezado de nivel 1 (el más grande) en Markdown?**
    a) Utilizando dos asteriscos (**) al principio de la línea.
    b) Escribiendo `<h1>` al principio de la línea.
    c) Utilizando el símbolo de almohadilla (`#`) al principio de una línea.
    d) Encerrando el texto entre comillas invertidas (`` ` ``).

36. **¿Qué sintaxis se utiliza en Markdown para aplicar negrita al texto?**
    a) Rodear el texto con un solo asterisco (`*`).
    b) Rodear el texto con dos asteriscos (`**`).
    c) Utilizar guiones bajos (`_`) al principio y al final del texto.
    d) Escribir el texto en mayúsculas completas.

37. **¿Cómo se pueden crear listas con viñetas en Markdown?**
    a) Empezando cada elemento con un número seguido de un punto (`1.`).
    b) Empezando cada línea con un asterisco (`*`), un guion (`-`) o un signo más (`+`).
    c) Utilizando el símbolo de almohadilla (`#`) para cada elemento.
    d) Encerrando cada elemento entre corchetes `[]`.

38. **Para indicar la lista de tareas pendientes a realizar en la descripción de una Pull Request en GitHub, ¿qué característica de formato Markdown se puede utilizar?**
    a) Emojis específicos para indicar el progreso.
    b) Listas de tareas que pueden ser marcadas como completadas.
    c) Fragmentos de código para mostrar el trabajo realizado.
    d) Referencias cruzadas a otras incidencias.

**GitKraken**

39. **¿Qué es GitKraken?**
    a) Un comando avanzado de Git para la resolución de conflictos.
    b) Una herramienta gráfica (GUI) que permite gestionar repositorios basados en Git de forma visual.
    c) Un tipo de flujo de trabajo de Git utilizado para proyectos a gran escala.
    d) Un sistema de archivos distribuido para almacenamiento de código fuente.

40. **Según las fuentes, ¿cuál de las siguientes es una ventaja destacada de GitKraken, especialmente en un contexto educativo?**
    a) Es exclusivamente de línea de comandos, lo que obliga al aprendizaje profundo de Git.
    b) Su entorno visual que muestra el árbol del proyecto, las ramas y las confirmaciones de manera atractiva y fácil de seguir.
    c) Requiere la configuración manual de complejos scripts para manejar las Pull Requests.
    d) Su compatibilidad limitada con plataformas de alojamiento como GitHub y GitLab.