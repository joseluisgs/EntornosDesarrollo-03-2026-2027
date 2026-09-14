- [Práctica 1: Test de Conocimientos](#práctica-1-test-de-conocimientos)
  - [Bloque 1: Fundamentos de Git (Preguntas 1-8)](#bloque-1-fundamentos-de-git-preguntas-1-8)
  - [Bloque 2: Comandos Git Esenciales (Preguntas 9-18)](#bloque-2-comandos-git-esenciales-preguntas-9-18)
  - [Bloque 3: Ramas y Fusiones (Preguntas 19-26)](#bloque-3-ramas-y-fusiones-preguntas-19-26)
  - [Bloque 4: Repositorios Remotos y GitHub (Preguntas 27-34)](#bloque-4-repositorios-remotos-y-github-preguntas-27-34)
  - [Bloque 5: Colaboración (PR, Fork, Code Review) (Preguntas 35-42)](#bloque-5-colaboración-pr-fork-code-review-preguntas-35-42)
  - [Bloque 6: Herramientas y CLI (Preguntas 43-50)](#bloque-6-herramientas-y-cli-preguntas-43-50)


# Práctica 1: Test de Conocimientos

**Instrucciones:** Lee atentamente cada pregunta y selecciona la opción que consideres correcta.

---

### Bloque 1: Fundamentos de Git (Preguntas 1-8)

1.  **¿Qué es Git?**
    a) Una plataforma de alojamiento de proyectos en la nube.
    b) Un sistema distribuido de control de versiones.
    c) Un editor de código fuente para desarrollo web.
    d) Un sistema de gestión de bases de datos relacionales.

2.  **¿Quién creó Git?**
    a) Scott Chacon
    b) Linus Torvalds
    c) Guido van Rossum
    d) Brendan Eich

3.  **¿Cuál es la principal ventaja de un sistema distribuido como Git frente a uno centralizado como SVN?**
    a) Es más rápido en todas las operaciones.
    b) Cada desarrollador tiene una copia completa del historial, por lo que puede trabajar sin conexión.
    c) No necesita servidor central.
    d) Elimina la posibilidad de conflictos.

4.  **¿Qué es un "commit" en Git?**
    a) La acción de subir cambios a un servidor remoto.
    b) Una instantánea del área de preparación almacenada de forma segura en el repositorio local.
    c) Un mensaje que describe los cambios realizados.
    d) La acción de fusionar dos ramas.

5.  **¿Cuáles son los tres estados principales de un archivo en Git?**
    a) Creado, modificado, eliminado.
    b) Modificado (*modified*), preparado (*staged*), confirmado (*committed*).
    c) Local, remoto, sincronizado.
    d) Privado, público, archivado.

6.  **¿Qué es el "staging area" (área de preparación)?**
    a) El espacio en disco donde Git almacena los objetos.
    b) Una zona intermedia donde se seleccionan los cambios que se incluirán en el próximo commit.
    c) La rama principal del repositorio.
    d) Un directorio temporal que se borra automáticamente.

7.  **¿Qué representa HEAD en Git?**
    a) El último archivo modificado por el desarrollador.
    b) Un puntero al último commit de la rama actual.
    c) La dirección del repositorio remoto.
    d) El nombre del desarrollador que hizo el último commit.

8.  **¿Qué es un hash SHA-1 en el contexto de Git?**
    a) Un algoritmo de compresión de archivos.
    b) Una contraseña que protege el repositorio.
    c) Un identificador único de 40 caracteres que Git genera para cada commit.
    d) Un tipo de archivo que Git ignora automáticamente.

---

### Bloque 2: Comandos Git Esenciales (Preguntas 9-18)

9.  **¿Qué realiza el comando `git init`?**
    a) Clona un repositorio remoto en la máquina local.
    b) Crea un nuevo repositorio Git vacío en el directorio actual.
    c) Añade todos los archivos al área de preparación.
    d) Muestra el estado del repositorio.

10. **¿Cuál es la función principal del comando `git add`?**
    a) Deshacer los últimos cambios realizados en el directorio de trabajo.
    b) Mover los cambios del directorio de trabajo al área de preparación.
    c) Guardar los cambios directamente en el repositorio local.
    d) Crear un nuevo repositorio de Git.

11. **¿Qué comando se utiliza para guardar los cambios preparados en el repositorio local?**
    a) `git push`
    b) `git commit`
    c) `git add`
    d) `git save`

12. **¿Qué hace el comando `git status`?**
    a) Muestra el historial completo de commits.
    b) Muestra el estado del directorio de trabajo y del área de preparación.
    c) Muestra las diferencias entre dos commits.
    d) Muestra la configuración de Git.

13. **¿Qué comando se utiliza para ver el historial de commits?**
    a) `git history`
    b) `git log`
    c) `git status`
    d) `git show`

14. **¿Qué hace el comando `git diff`?**
    a) Muestra el historial completo de confirmaciones.
    b) Muestra la diferencia entre el directorio de trabajo, el área de preparación y/o el último commit.
    c) Aplica un parche de cambios a un archivo.
    d) Elimina archivos modificados del repositorio.

15. **¿Qué comando se utiliza para deshacer cambios en el directorio de trabajo (volver a la última versión confirmada)?**
    a) `git reset`
    b) `git revert`
    c) `git restore`
    d) `git undo`

16. **¿Qué comando se utiliza para quitar un archivo del área de preparación sin perder los cambios en el directorio de trabajo?**
    a) `git restore <archivo>`
    b) `git restore --staged <archivo>`
    c) `git rm --cached <archivo>`
    d) `git reset --hard <archivo>`

17. **¿Qué comando se utiliza para guardar temporalmente cambios sin hacer commit?**
    a) `git save`
    b) `git hold`
    c) `git stash`
    d) `git cache`

18. **¿Cuál es la diferencia entre `git revert` y `git reset`?**
    a) No hay diferencia, son sinónimos.
    b) `git revert` crea un commit que deshace los cambios; `git reset` mueve el puntero HEAD.
    c) `git reset` es para ramas; `git revert` es para commits.
    d) `git revert` borra archivos; `git reset` solo modifica el historial.

---

### Bloque 3: Ramas y Fusiones (Preguntas 19-26)

19. **¿Qué es una rama (branch) en Git?**
    a) Una copia completa del repositorio.
    b) Un apuntador móvil que apunta a un commit en el historial del proyecto.
    c) Un archivo de configuración del repositorio.
    d) Una versión archivada del proyecto.

20. **¿Qué comando crea una nueva rama y cambia a ella en un solo paso?**
    a) `git branch <nombre>`
    b) `git checkout <nombre>`
    c) `git checkout -b <nombre>`
    d) `git switch --create <nombre>`

21. **¿Cuál es la diferencia entre `git merge` y `git rebase`?**
    a) `merge` crea un commit de fusión que une dos ramas; `rebase` reescribe los commits de una rama sobre la base de otra.
    b) No hay diferencia, ambos hacen lo mismo.
    c) `merge` es para ramas locales; `rebase` es para ramas remotas.
    d) `rebase` es más seguro que `merge`.

22. **¿Qué es un "conflicto de fusión" en Git?**
    a) Un error que impide ejecutar comandos de Git.
    b) Una situación donde dos ramas modifican las mismas líneas de un archivo y Git no puede fusionar automáticamente.
    c) Un problema de conexión con el repositorio remoto.
    d) Un error de sintaxis en el código fuente.

23. **¿Qué comando se utiliza para cancelar una fusión en curso?**
    a) `git merge --cancel`
    b) `git merge --abort`
    c) `git merge --stop`
    d) `git merge --undo`

24. **En GitFlow, ¿qué rama se utiliza para desarrollar nuevas funcionalidades?**
    a) `main`
    b) `develop`
    c) `feature/*`
    d) `release/*`

25. **¿Qué es un "cherry-pick" en Git?**
    a) Copiar todos los commits de una rama a otra.
    b) Aplicar un commit específico de una rama a la rama actual sin fusionar toda la rama.
    c) Eliminar un commit del historial.
    d) Crear una copia de seguridad de un commit.

26. **¿Qué comando elimina una rama local que ya ha sido fusionada?**
    a) `git branch -D <nombre>`
    b) `git branch -d <nombre>`
    c) `git branch --delete <nombre>`
    d) `git branch --remove <nombre>`

---

### Bloque 4: Repositorios Remotos y GitHub (Preguntas 27-34)

27. **¿Qué es GitHub?**
    a) Un sistema de control de versiones distribuido.
    b) Una plataforma de alojamiento de repositorios Git en la nube.
    c) Un cliente gráfico para Git.
    d) Un lenguaje de programación.

28. **¿Qué comando sube los commits del repositorio local al repositorio remoto?**
    a) `git pull`
    b) `git fetch`
    c) `git push`
    d) `git upload`

29. **¿Qué comando descarga los cambios del repositorio remoto y los fusiona con la rama actual?**
    a) `git push`
    b) `git fetch`
    c) `git pull`
    d) `git sync`

30. **¿Cuál es la diferencia entre `git fetch` y `git pull`?**
    a) No hay diferencia.
    b) `fetch` solo descarga los cambios sin fusionarlos; `pull` descarga y fusiona automáticamente.
    c) `fetch` es para ramas locales; `pull` es para ramas remotas.
    d) `pull` es más rápido que `fetch`.

31. **¿Qué es un "fork" en GitHub?**
    a) Una copia personal de un repositorio de otro usuario en tu propia cuenta.
    b) Una rama temporal que se crea para un hotfix.
    c) Un tipo de commit especial.
    d) Una herramienta de depuración de código.

32. **¿Qué comando configura el "tracking" (seguimiento) de una rama remota?**
    a) `git push -u origin <rama>`
    b) `git remote track <rama>`
    c) `git branch --set-upstream <rama>`
    d) `git config --track <rama>`

33. **¿Qué es una "Pull Request" (PR)?**
    a) Un comando de Git para descargar cambios.
    b) Una propuesta de cambios para revisar y fusionar código en un repositorio.
    c) Un tipo de rama especial.
    d) Un archivo de configuración de Git.

34. **¿Qué comando permite ver los repositorios remotos configurados?**
    a) `git remote -v`
    b) `git remote list`
    c) `git remote show`
    d) `git remote status`

---

### Bloque 5: Colaboración (PR, Fork, Code Review) (Preguntas 35-42)

35. **¿Qué es el "Code Review" (revisión de código)?**
    a) Un proceso donde los desarrolladores examinan el código de otros antes de fusionarlo.
    b) Un comando de Git para comparar versiones.
    c) Una herramienta de depuración automática.
    d) Un tipo de test unitario.

36. **¿Qué palabra clave en la descripción de una PR cierra automáticamente una Issue al fusionarse?**
    a) `Resolves`
    b) `Fixes`
    c) `Closes`
    d) Todas las anteriores son válidas.

37. **¿Qué es "Branch Protection" en GitHub?**
    a) Un sistema de copias de seguridad automáticas.
    b) Un conjunto de reglas que impiden pushes directos a ramas protegidas y requieren PRs aprobados.
    c) Un software antivirus para repositorios.
    d) Una herramienta para clonar repositorios privados.

38. **¿Cuál es la diferencia entre "Merge commit", "Squash and merge" y "Rebase and merge"?**
    a) No hay diferencia, las tres hacen lo mismo.
    b) "Merge commit" preserva el historial completo; "Squash" comprime todos los commits en uno; "Rebase" reaplica commits linealmente.
    c) "Squash" es para ramas pequeñas; "Merge" para ramas grandes.
    d) "Rebase" solo funciona con ramas remotas.

39. **¿Qué es un archivo CODEOWNERS?**
    a) Un archivo que lista los permisos de acceso al repositorio.
    b) Un archivo que define qué persona o equipo es responsable de revisar cambios en archivos específicos.
    c) Un archivo de configuración de Git.
    d) Un archivo que almacena las contraseñas del equipo.

40. **¿Qué comando de GitHub CLI (`gh`) crea una Pull Request desde la terminal?**
    a) `gh pr new`
    b) `gh pr create`
    c) `gh pr add`
    d) `gh pr open`

41. **¿Qué comando de `gh` aprueba una Pull Request?**
    a) `gh pr approve <PR>`
    b) `gh pr review <PR> --approve`
    c) `gh pr accept <PR>`
    d) `gh pr merge <PR> --approve`

42. **¿Qué es un "Draft Pull Request"?**
    a) Una PR que ya está fusionada.
    b) Una PR marcada como borrador que no se puede fusionar hasta que se marque como lista.
    c) Una PR que solo el autor puede ver.
    d) Una PR automática creada por GitHub Actions.

---

### Bloque 6: Herramientas y CLI (Preguntas 43-50)

43. **¿Qué herramienta gráfica de Git es la más recomendada para principiantes?**
    a) Sourcetree
    b) GitKraken
    c) GitHub Desktop
    d) Git GUI

44. **¿Qué extensión de VS Code muestra el historial de blame (quién modificó cada línea)?**
    a) Git Graph
    b) GitLens
    c) Git History
    d) Git Indicators

45. **¿Qué comando de GitHub CLI (`gh`) autentica al usuario con GitHub?**
    a) `gh login`
    b) `gh auth login`
    c) `gh connect`
    d) `gh setup`

46. **¿Qué comando de `gh` crea un repositorio nuevo en GitHub?**
    a) `gh new repo`
    b) `gh repo create`
    c) `gh repo init`
    d) `gh repo add`

47. **¿Qué es `.editorconfig`?**
    a) Un archivo de configuración de Git.
    b) Un archivo que define reglas de estilo de código (indentación, charset, etc.) para el equipo.
    c) Un archivo de configuración del sistema operativo.
    d) Un archivo que almacena las preferencias del usuario de GitHub.

48. **¿Qué herramienta permite gestionar GitHub desde la línea de comandos?**
    a) `git-cli`
    b) `hub`
    c) `gh` (GitHub CLI)
    d) `github-terminal`

49. **¿Qué es Semantic Versioning (MAJOR.MINOR.PATCH)?**
    a) Un sistema de numeración de commits.
    b) Un estándar para versionar software: MAJOR = cambios incompatibles, MINOR = nuevas funcionalidades, PATCH = correcciones de bugs.
    c) Un tipo de rama en GitFlow.
    d) Un formato de mensaje de commit.

50. **¿Qué archivo `.gitignore` debe contener un proyecto .NET/C#?**
    a) Solo archivos `.env`.
    b) `bin/`, `obj/`, `.vs/`, `*.user`, `packages/` y otros archivos de compilación.
    c) Todos los archivos del proyecto.
    d) Solo archivos `.cs`.
