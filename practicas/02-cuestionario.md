- [Práctica 2: Cuestionario de Razonamiento](#práctica-2-cuestionario-de-razonamiento)


# Práctica 2: Cuestionario de Razonamiento

**Instrucciones:** Responde a cada pregunta explicando tu razonamiento y basándote en la información proporcionada.

---

1.  **Diferencia entre Working Directory, Staging Area y Repositorio.**
    Un compañero dice que "git add y git commit hacen lo mismo: guardan cambios". Explica por qué está equivocado describiendo las tres zonas de Git (Working Directory, Staging Area, Repositorio) y qué hace cada comando en cada zona. Usa una analogía que un compañero de 17 años pueda entender.

2.  **¿Cuándo usar `git revert` y cuándo usar `git reset`?**
    Trabajas en un equipo de 5 personas. Has commiteado un error en la rama `main` y ya lo has subido con `push`. Explica por qué no puedes usar `git reset --hard` en esta situación, qué alternativa segura tienes y qué diferencia hay entre ambas. ¿Qué pasaría si un compañero ya hizo `pull` de tu commit erróneo?

3.  **Merge vs Rebase: implicaciones en el historial.**
    Tu compañero quiere hacer `git rebase` sobre `main` en una rama de feature que ya tiene 10 commits. Explica qué le pasaría al historial de commits después del rebase, por qué esto puede causar problemas si otros compañeros trabajan en la misma rama, y en qué situación el rebase es mejor que el merge.

4.  **El rol de `git stash` en el día a día.**
    Estás desarrollando una funcionalidad nueva y tu jefe te pide un hotfix urgente. No has terminado tu trabajo y no quieres commitear código a medias. Explica cómo resolverías esta situación usando `git stash`, paso a paso, y qué diferencia hay entre `git stash pop` y `git stash apply`.

5.  **Fork vs Trabajar en el mismo repositorio.**
    En un proyecto de clase, ¿cuándo es mejor hacer fork de un repositorio y cuándo es mejor crear una rama directamente en el repositorio original? Explica las diferencias entre ambos flujos de trabajo y qué problema resuelve el concepto de "upstream" cuando trabajas con forks.

6.  **¿Por qué `git push --force` es peligroso?**
    Un compañero ejecuta `git push --force` en la rama `main` porque quiere "limpiar" el historial. Explica qué hace exactamente este comando, por qué puede destruir el trabajo de otros desarrolladores, y cuál es la alternativa segura (`--force-with-lease`) y qué la diferencia.

7.  **Semantic Versioning: por qué importa.**
    Un equipo de desarrollo publica versiones de su software como `v1.0.0`, `v1.1.0`, `v1.1.1`. Explica qué significan los tres números (MAJOR, MINOR, PATCH) y por qué usar esta convención en lugar de simplemente ir incrementando un número (`v1`, `v2`, `v3`). Pon un ejemplo de cuándo cambiaría cada número.

8.  **Branch Protection y su relación con las Pull Requests.**
    Sin branch protection, cualquier desarrollador puede hacer push directamente a `main`. Explica por qué esto hace que las Pull Requests sean "opcionales" y cómo branch protection convierte las PRs en un paso obligatorio. Menciona al menos 3 reglas que se pueden configurar.

9.  **GitHub Actions: ¿qué automatiza y por qué?**
    Un compañero pregunta "¿para qué sirve GitHub Actions si ya puedo compilar y testear en local?". Explica qué ventajas tiene ejecutar los tests automáticamente en cada push, qué pasa si un test falla en local pero pasa en el CI, y cómo esto afecta a la confianza del equipo en el código.

10. **`git reflog`: el salvavidas de Git.**
    Has ejecutado `git reset --hard HEAD~3` por error y pareces haber perdido 3 commits importantes. Explica qué es `git reflog`, por qué puede recuperar esos commits "perdidos" aunque hayas usado `reset --hard`, y cuál es el proceso paso a paso para recuperarlos.
