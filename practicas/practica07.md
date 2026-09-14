
### **Práctica de Git: Fundamentos en una Sola Rama y Gestión de Errores**

- [**Práctica de Git: Fundamentos en una Sola Rama y Gestión de Errores**](#práctica-de-git-fundamentos-en-una-sola-rama-y-gestión-de-errores)
  - [Objetivo](#objetivo)
  - [Conceptos Clave a Recordar](#conceptos-clave-a-recordar)
  - [Fase 1: Preparación del Entorno y Primera Confirmación](#fase-1-preparación-del-entorno-y-primera-confirmación)
  - [Fase 2: Modificaciones y Análisis de Diferencias entre Áreas](#fase-2-modificaciones-y-análisis-de-diferencias-entre-áreas)
  - [Fase 3: Gestión de Errores y Recuperación ("Eliminar Cagadas")](#fase-3-gestión-de-errores-y-recuperación-eliminar-cagadas)
    - [Escenario A: Descartar cambios en el directorio de trabajo](#escenario-a-descartar-cambios-en-el-directorio-de-trabajo)
    - [Escenario B: Despreparar cambios (quitar del staging area)](#escenario-b-despreparar-cambios-quitar-del-staging-area)
    - [Escenario C: Deshacer la última confirmación (commit)](#escenario-c-deshacer-la-última-confirmación-commit)
    - [Escenario D: Recuperar un archivo eliminado por error](#escenario-d-recuperar-un-archivo-eliminado-por-error)
    - [Escenario E: Ignorar archivos (evitar "cagadas" futuras)](#escenario-e-ignorar-archivos-evitar-cagadas-futuras)

**Objetivo:** Familiarizarse con el flujo de trabajo básico de Git, entender y utilizar las áreas de almacenamiento (directorio de trabajo, área de preparación y repositorio), visualizar diferencias entre estados y practicar la corrección de errores, todo ello manteniendo un historial lineal en una única rama.

**Conceptos Clave a Recordar:**
*   **Directorio de trabajo:** Es donde se encuentran los archivos que puedes usar o modificar.
*   **Área de preparación (o índice):** Un archivo que almacena información sobre lo que se incluirá en tu próxima confirmación (commit).
*   **Repositorio Git (o directorio Git):** Es donde se guardan los metadatos y la base de datos de objetos de tu proyecto, incluyendo el historial de confirmaciones.

---

**Fase 1: Preparación del Entorno y Primera Confirmación**

1.  **Crea un nuevo proyecto:** Inicia un nuevo repositorio Git en una carpeta vacía.
2.  **Identifícate:** Establece tu nombre de usuario y tu dirección de correo electrónico a nivel global en Git para que se asocien a tus futuras confirmaciones.
3.  **Primer archivo:** Crea un archivo de texto simple, por ejemplo, `README.txt`, y añade una línea de contenido como "Mi primer proyecto Git".
4.  **Verifica el estado inicial:** Observa el estado actual del repositorio. Deberías ver el nuevo archivo como "no rastreado" en tu directorio de trabajo. **Reflexiona:** ¿Qué significa que un archivo esté "no rastreado"?
5.  **Prepara el archivo:** Añade el archivo `README.txt` al área de preparación.
6.  **Verifica el estado preparado:** Revisa el estado del repositorio de nuevo. Observa cómo el archivo `README.txt` ha cambiado de estado, indicando que está listo para ser confirmado. **Reflexiona:** ¿Qué diferencia hay entre un archivo "no rastreado" y uno "preparado"?
7.  **Realiza la primera confirmación:** Guarda los cambios que están en el área de preparación en el repositorio local. Incluye un mensaje descriptivo como "Primera versión del README".
8.  **Verifica el estado limpio:** Comprueba el estado del repositorio para asegurarte de que el directorio de trabajo y el área de preparación están limpios. **Reflexiona:** ¿Dónde se encuentran ahora los cambios de tu archivo `README.txt`?
9.  **Revisa el historial:** Visualiza el historial de confirmaciones realizadas en el repositorio.

---

**Fase 2: Modificaciones y Análisis de Diferencias entre Áreas**

1.  **Modifica el archivo existente:** Edita `README.txt` añadiendo una segunda línea, por ejemplo, "Esta es una nueva línea de contenido.".
2.  **Crea un nuevo archivo:** Crea un segundo archivo, por ejemplo, `documento.txt`, y añade algo de texto.
3.  **Observa los cambios no preparados:** Revisa el estado del repositorio. Deberías ver `README.txt` como "modificado" (y rastreado) y `documento.txt` como "no rastreado".
4.  **Compara directorio de trabajo y repositorio (archivo `README.txt`):** Visualiza las diferencias entre la versión actual de `README.txt` en tu directorio de trabajo y la última versión de este archivo que está guardada en el repositorio. **Reflexiona:** ¿Qué te muestran estas diferencias?
5.  **Prepara un cambio:** Añade solo el archivo `README.txt` al área de preparación.
6.  **Compara área de preparación y repositorio (`README.txt`):** Visualiza las diferencias entre la versión de `README.txt` que está en el área de preparación y la última versión confirmada en el repositorio. **Reflexiona:** ¿Qué ha cambiado en la visualización de diferencias?
7.  **Compara directorio de trabajo y área de preparación (`README.txt`):** Visualiza las diferencias que existen entre el `README.txt` que tienes modificado en tu directorio de trabajo y el `README.txt` que está listo en el área de preparación. **Reflexiona:** ¿Por qué existen estas diferencias si ambos son el mismo archivo `README.txt`?
8.  **Prepara el segundo archivo:** Añade `documento.txt` al área de preparación.
9.  **Realiza una nueva confirmación:** Guarda todos los cambios preparados con un mensaje como "Añadida nueva línea al README y creado documento.txt".
10. **Revisa el historial actualizado:** Visualiza el historial de confirmaciones para ver la nueva entrada.

---

**Fase 3: Gestión de Errores y Recuperación ("Eliminar Cagadas")**

**Escenario A: Descartar cambios en el directorio de trabajo**

1.  **Introduce un cambio erróneo:** Modifica `README.txt` añadiendo una línea de texto que consideres un error (ej: "Línea de prueba que no quiero guardar").
2.  **Verifica el estado:** Revisa el estado del repositorio para ver `README.txt` como modificado.
3.  **Deshaz los cambios en el directorio de trabajo:** Sin añadir el archivo al área de preparación, descarta las modificaciones realizadas en `README.txt`, volviéndolo al estado de la última confirmación. **Reflexiona:** ¿Qué área de almacenamiento te permitió deshacer esta "cagada" sin afectar el historial?
4.  **Confirma la eliminación del error:** Comprueba el estado del repositorio para verificar que los cambios erróneos han desaparecido y el directorio de trabajo está limpio.

**Escenario B: Despreparar cambios (quitar del staging area)**

1.  **Modifica un archivo:** Edita `documento.txt` con nuevo contenido.
2.  **Prepara el cambio accidentalmente:** Añade `documento.txt` al área de preparación.
3.  **Verifica el estado:** Comprueba el estado del repositorio. Observa que el archivo está preparado.
4.  **Desprepara el archivo:** Quita `documento.txt` del área de preparación, pero **manteniendo las modificaciones** en tu directorio de trabajo. **Reflexiona:** ¿Qué ha sucedido con los cambios? ¿Dónde se encuentran ahora?
5.  **Confirma la despreparación:** Vuelve a revisar el estado del repositorio para ver que `documento.txt` ya no está en el área de preparación, pero sigue modificado en tu directorio de trabajo.

**Escenario C: Deshacer la última confirmación (commit)**

1.  **Introduce un nuevo cambio y confírmalo:** Modifica `README.txt` (ej: "Modificación que acabo de confirmar, pero no era la final"). Añade el archivo al área de preparación y realiza una confirmación con un mensaje como "Commit con error accidental".
2.  **Verifica el historial:** Revisa el historial de confirmaciones.
3.  **Deshaz la última confirmación (manteniendo los cambios):** Mueve el puntero de la última confirmación para que apunte a la confirmación anterior, pero asegurándote de que los cambios de la confirmación deshecha permanezcan en el área de preparación y el directorio de trabajo. **Reflexiona:** ¿Por qué es útil poder deshacer un commit sin perder los cambios?
4.  **Verifica el estado:** Comprueba el estado del repositorio. Deberías ver los cambios del commit anterior ahora en el área de preparación, listos para ser confirmados de nuevo.
5.  **Añade más cambios y vuelve a confirmar correctamente:** Modifica `documento.txt` (ej: "Contenido final del documento"). Añade `documento.txt` al área de preparación. Ahora, realiza una nueva confirmación que incluya tanto los cambios de `README.txt` como los de `documento.txt` con un mensaje corregido y más completo (ej: "Commit final y corregido de README y documento").
6.  **Verifica el historial final:** Revisa el historial para ver que solo aparece un commit en lugar de los dos originales, lo que representa el estado final deseado.

**Escenario D: Recuperar un archivo eliminado por error**

1.  **Elimina un archivo del directorio de trabajo:** Borra `documento.txt` directamente desde el explorador de archivos o la consola del sistema operativo.
2.  **Verifica el estado:** Comprueba el estado del repositorio. Git debería informarte que el archivo ha sido eliminado.
3.  **Restaura el archivo eliminado:** Recupera el archivo `documento.txt` a su última versión confirmada desde el repositorio. **Reflexiona:** ¿Cómo es posible que Git recupere un archivo que ya no está en tu disco local?
4.  **Confirma la restauración:** Verifica el estado del repositorio para asegurarte de que `documento.txt` ha vuelto y el directorio de trabajo está limpio.

**Escenario E: Ignorar archivos (evitar "cagadas" futuras)**

1.  **Crea un archivo temporal:** Crea un archivo nuevo en tu directorio de trabajo, por ejemplo, `log.txt`, y añadele algún contenido.
2.  **Verifica su estado:** Revisa el estado del repositorio. Deberías ver `log.txt` como un archivo "no rastreado".
3.  **Crea una regla de ignorado:** Crea un archivo llamado `.gitignore` en la raíz de tu repositorio y añade una regla para ignorar `log.txt` (o patrones de archivos similares, como `*.log`).
4.  **Confirma que el archivo está ignorado:** Vuelve a revisar el estado del repositorio. `log.txt` no debería aparecer en la lista de archivos "no rastreados". **Reflexiona:** ¿Por qué es importante ignorar ciertos archivos?
5.  **Confirma el archivo de ignorados:** Añade el archivo `.gitignore` al área de preparación y realiza una confirmación con un mensaje como "Añadido .gitignore para ignorar archivos temporales".
