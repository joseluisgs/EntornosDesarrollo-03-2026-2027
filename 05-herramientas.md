- [5. Herramientas y Recursos](#5-herramientas-y-recursos)
  - [5.1. Clientes Gráficos (GUI)](#51-clientes-gráficos-gui)
    - [5.1.1. GitKraken](#511-gitkraken)
    - [5.1.2. GitHub Desktop](#512-github-desktop)
    - [5.1.3. Sourcetree](#513-sourcetree)
    - [5.1.4. VS Code + Git](#514-vs-code--git)
    - [5.1.5. Comparativa de GUIs](#515-comparativa-de-guis)
  - [5.2. Extensiones VS Code para Git](#52-extensiones-vs-code-para-git)
    - [5.2.1. GitLens](#521-gitlens)
    - [5.2.2. Git Graph](#522-git-graph)
    - [5.2.3. Otras Extensiones Útiles](#523-otras-extensiones-útiles)
  - [5.3. GitHub CLI](#53-github-cli)
    - [5.3.1. Instalación](#531-instalación)
    - [5.3.2. Comandos Principales](#532-comandos-principales)
    - [5.3.3. Ejemplo Flujo Completo](#533-ejemplo-flujo-completo)
  - [5.4. Recursos de Aprendizaje](#54-recursos-de-aprendizaje)
    - [5.4.1. Tutoriales Interactivos](#541-tutoriales-interactivos)
    - [5.4.2. Documentación Oficial](#542-documentación-oficial)
    - [5.4.3. Cheat Sheets](#543-cheat-sheets)
    - [5.4.4. Juegos y Gamificación](#544-juegos-y-gamificación)
  - [5.5. Configuración Avanzada](#55-configuración-avanzada)
    - [5.5.1. Alias Útiles](#551-alias-útiles)
    - [5.5.2. Usar Alias](#552-usar-alias)
    - [5.5.3. Colores y Formato](#553-colores-y-formato)
    - [5.5.4. .gitconfig Completo](#554-gitconfig-completo)
  - [5.6. Errores Comunes y Soluciones](#56-errores-comunes-y-soluciones)
    - [5.6.1. ❌ Errores Típicos](#561--errores-típicos)
    - [5.6.2. ⚠️ Recuperación de Errores](#562--recuperación-de-errores)
    - [5.6.3. 🆘 Comandos de Emergencia](#563--comandos-de-emergencia)


# 5. Herramientas y Recursos

> 💡 **Punto de partida:** ¿Te imaginas construir un edificio sin herramientas? Podrías, pero tardarías una eternidad. Las herramientas de Git son como tener una grúa, un soldador y un robot: cada una hace un trabajo específico mucho más rápido.

> 💡 **¿Por qué me importa?**
> Dominar las herramientas correctas multiplica tu productividad. Un cliente gráfico te ayuda a visualizar el historial, una extensión de VS Code te ahorra comandos, y GitHub CLI te permite automatizar tareas repetitivas.
> 
> 🔗 **Conexión con otros puntos:** El Punto 04 viste Pull Requests, Forks y colaboración. Este punto verás las herramientas que facilitan todo ese trabajo: clientes gráficos, extensiones, CLI y recursos de aprendizaje.

En el Punto 04 vimos Pull Requests, Forks, Code Review y GitHub Actions. Ahora veremos las herramientas y recursos para Git: clientes gráficos, extensiones de VS Code, terminal Git y trucos para potenciar tu productividad.

**Objetivos de aprendizaje:**

- Conocer los clientes gráficos más populares (GitKraken, GitHub Desktop, Sourcetree)
- Instalar y usar extensiones de VS Code para Git
- Dominar GitHub CLI para automatizar tareas
- Configurar alias y personalizar Git
- Resolver errores comunes de forma rápida

Los clientes gráficos facilitan el uso de Git para quienes prefieren interfaces visuales.

### 5.1.1. GitKraken

| Característica | Descripción |
|----------------|-------------|
| **Plataforma** | Windows, Mac, Linux |
| **Licencia** | Freemium (gratis para uso personal) |
| **Puntos fuertes** | Mejor GUI, integra GitFlow, aprendizaje visual |
| **Integración** | GitHub, GitLab, Bitbucket, Enterprise |

> 💡 **Ideal para:** Principiantes que quieren entender visualmente cómo funciona Git.

### 5.1.2. GitHub Desktop

| Característica | Descripción |
|----------------|-------------|
| **Plataforma** | Windows, Mac |
| **Licencia** | Gratis |
| **Puntos fuertes** | Integración nativa GitHub, simple |
| **Limitaciones** | Solo GitHub, menos features |

### 5.1.3. Sourcetree

| Característica | Descripción |
|----------------|-------------|
| **Plataforma** | Windows, Mac |
| **Licencia** | Gratis |
| **Puntos fuertes** | Completo, gratuito |
| **Puntos débiles** | Interfaz anticuada |

### 5.1.4. VS Code + Git

| Característica | Descripción |
|----------------|-------------|
| **Plataforma** | Multiplataforma |
| **Licencia** | Gratis |
| **Puntos fuertes** | Ligero, integración nativa, extensible |

```bash
# Comandos Git desde terminal integrado en VS Code
# Ctrl+` para abrir terminal
# Clic en icono Git en barra lateral
```

### 5.1.5. Comparativa de GUIs

| Herramienta | Facilidad | Features | Integración | Precio |
|-------------|-----------|----------|-------------|--------|
| GitKraken | ⭐⭐⭐⭐⭐ | ⭐⭐⭐⭐⭐ | ⭐⭐⭐⭐⭐ | Freemium |
| GitHub Desktop | ⭐⭐⭐⭐⭐ | ⭐⭐⭐ | ⭐⭐⭐⭐⭐ | Gratis |
| Sourcetree | ⭐⭐⭐ | ⭐⭐⭐⭐ | ⭐⭐⭐ | Gratis |
| VS Code + Git | ⭐⭐⭐⭐ | ⭐⭐⭐⭐ | ⭐⭐⭐⭐ | Gratis |

## 5.2. Extensiones VS Code para Git

### 5.2.1. GitLens

| Característica | Descripción |
|----------------|-------------|
| **Función** | Ver blame, historial, comparar commits |
| **Atajo** | `Alt+` para blame rápido |

**Features principales:**
- Blame en línea
- Historial de archivos
- Comparar commits
- Buscar en historial
- Visualizar ramas

### 5.2.2. Git Graph

| Característica | Descripción |
|----------------|-------------|
| **Función** | Visualizar historial como grafo |

```mermaid
graph TB
    A[Git Graph en VS Code] --> B[Ver todas las ramas]
    A --> C[Ver commits detalle]
    A --> D[Ver archivos modificados]
    A --> E[Filtrar por fecha/autor]
    
    style A fill:#2196F3,color:#fff
```

### 5.2.3. Otras Extensiones Útiles

| Extensión | Función |
|-----------|---------|
| **Gitmoji** | Usar emojis en commits |
| **Git History** | Ver historial detallado de archivos |
| **GitLab Workflow** | Integración GitLab |
| **GitHub Pull Requests** | Gestionar PRs desde VS Code |
| **Remote Repositories** | Editar repositorios remotos directamente |

## 5.3. GitHub CLI

**GitHub CLI** (`gh`) permite gestionar GitHub desde la terminal.

### 5.3.1. Instalación

```bash
# Windows (scoop)
scoop install gh

# Windows (chocolatey)
choco install gh

# macOS
brew install gh

# Linux
# https://github.com/cli/cli/blob/trunk/docs/install_linux.md
```

### 5.3.2. Comandos Principales

```bash
# Autenticarse
gh auth login

# Ver estado de autenticación
gh auth status

# Pull Requests
gh pr list                    # Listar PRs
gh pr view [PR]               # Ver PR
gh pr create                  # Crear PR
gh pr checkout [PR]           # Cambiar a rama de PR
gh pr merge [PR]              # Fusionar PR
gh pr review [PR]             # Revisar PR

# Issues
gh issue list                 # Listar issues
gh issue view [issue]         # Ver issue
gh issue create               # Crear issue
gh issue close [issue]        # Cerrar issue

# Releases
gh release list               # Listar releases
gh release create             # Crear release

# Gist
gh gist list                  # Listar gists
gh gist create                # Crear gist

# Repository
gh repo view                  # Ver repo
gh repo clone [repo]          # Clonar repo
gh repo fork [repo]           # Fork repo
```

### 5.3.3. Ejemplo Flujo Completo

```bash
# Clonar repo
gh repo clone usuario/repo

# Crear rama
git checkout -b feature/nueva

# Trabajar y commit
git add .
git commit -m "feat: nueva funcionalidad"

# Subir y crear PR
git push -u origin feature/nueva
gh pr create --title "feat: nueva funcionalidad" --body "Descripción..."

# Ver estado de PR
gh pr view

# Aprobar PR (como revisor)
gh pr review --approve

# Fusionar PR
gh pr merge --merge
```

## 5.4. Recursos de Aprendizaje

### 5.4.1. Tutoriales Interactivos

| Recurso | Descripción | Nivel |
|---------|-------------|-------|
| [Learn Git Branching](https://learngitbranching.js.org) | Tutorial interactivo visual | Principiante |
| [Git Immersion](https://gitimmersion.com) | Tutorial paso a paso | Principiante |
| [GitKatas](https://github.com/praqma-training/git-katas) | Ejercicios prácticos | Todos |
| [GitHub Learning Lab](https://lab.github.com) | Cursos de GitHub | Principiante |

### 5.4.2. Documentación Oficial

| Recurso | Descripción |
|---------|-------------|
| [Git Documentation](https://git-scm.com/doc) | Documentación oficial |
| [Git Pro Book](https://git-scm.com/book/es/v2) | Libro completo de Git |
| [GitHub Docs](https://docs.github.com) | Documentación GitHub |
| [GitLab Docs](https://docs.gitlab.com) | Documentación GitLab |

### 5.4.3. Cheat Sheets

| Recurso | Descripción |
|---------|-------------|
| [Git Cheat Sheet](https://education.github.com/git-cheat-sheet-education.pdf) | Sheet oficial de GitHub |
| [Git Cheatsheet](https://ndpsoftware.com/git-cheatsheet.html) | Visual interactivo |
| [Git Command Explorer](https://git-cheatsheet.com) | Búsqueda por comando |

### 5.4.4. Juegos y Gamificación

| Recurso | Descripción |
|---------|-------------|
| [Oh My Git!](https://ohmygit.org) | Juego para aprender Git |
| [Git Tower Game](https://www.git-tower.com/learn/git/commands/game) | Juego de comandos |
| [Learning Git with Jupyter](https://github.com/jupyterlab/jupyterlab-git) | Git en Jupyter |

## 5.5. Configuración Avanzada

### 5.5.1. Alias Útiles

```bash
# Alias de configuración
git config --global alias.st status
git config --global alias.co checkout
git config --global alias.br branch
git config --global alias.ci commit
git config --global alias.df diff
git config --global alias.lg "log --oneline --graph --all"

# Alias avanzados
git config --global alias.last "log -1 HEAD"
git config --global alias.unstage "reset HEAD --"
git config --global alias.visual "!gitk"
```

### 5.5.2. Usar Alias

```bash
# En lugar de:
git status
git checkout main
git log --oneline --graph --all

# Se puede usar:
git st
git co main
git lg
```

### 5.5.3. Colores y Formato

```bash
# Activar colores
git config --global color.ui auto

# Colores específicos
git config --global color.branch.current "green reverse"
git config --global color.branch.local "green"
git config --global color.branch.remote "red"

# Formato de log
git config --global format.pretty "%h %s %cn"
```

### 5.5.4. .gitconfig Completo

```ini
[user]
    name = Tu Nombre
    email = tu.email@ejemplo.com

[core]
    editor = code --wait
    autocrlf = input
    safecrlf = warn

[alias]
    st = status
    co = checkout
    br = branch
    ci = commit
    df = diff
    lg = log --oneline --graph --all
    last = log -1 HEAD
    unstage = reset HEAD --

[color]
    ui = auto
    branch = auto
    diff = auto
    status = auto

[merge]
    tool = vscode
    conflictstyle = diff3

[difftool "vscode"]
    cmd = code --wait --diff $LOCAL $REMOTE

[pull]
    rebase = false

[push]
    default = simple
```

## 5.6. Errores Comunes y Soluciones

### 5.6.1. ❌ Errores Típicos

| Error | Causa | Solución |
|-------|-------|----------|
| "fatal: not a git repository" | No estás en un repo Git | `git init` o `git clone` |
| "nothing to commit, working tree clean" | No hay cambios | Modifica archivos |
| "changes not staged for commit" | Cambios sin preparar | `git add` |
| "commit nothing to commit" | Todo ya commiteado | Crea nueva rama |
| "failed to push some refs" | El remoto tiene cambios nuevos | `git pull` primero |
| "merge conflict" | Dos personas modificaron lo mismo | Resolver conflictos |
| "detached HEAD" | Checkout a commit, no rama | `git checkout rama` |

### 5.6.2. ⚠️ Recuperación de Errores

```bash
# Recuperar cambios después de reset --hard
git reflog                    # Ver historial
git reset --hard HEAD@{n}     # Restaurar

# Recuperar archivo eliminado
git checkout -- archivo.txt

# Recuperar commit eliminado
git reflog
git cherry-pick [commit-hash]

# Deshacer último commit (soft)
git reset --soft HEAD~1

# Ver qué commit eliminó algo
git log --all --full-history -- archivo.txt
```

### 5.6.3. 🆘 Comandos de Emergencia

```bash
# Ver todo el historial (incluido resets)
git reflog

# Buscar commit por mensaje
git log --all --grep="mensaje"

# Buscar commit que modificó una línea
git log -S "texto buscado"

# Recuperar archivo de cualquier commit
git checkout [commit-hash] -- archivo.txt

# Ver todos los commits de todas las ramas
git log --all --oneline --graph

# Encontrar "perdido" commit
git fsck --lost-found
```

**Resumen del punto:**

| Herramienta | Descripción |
|-------------|-------------|
| **GitKraken** | Cliente gráfico multiplataforma, visual intuitivo |
| **GitHub Desktop** | Cliente oficial de GitHub, simple y limpio |
| **Sourcetree** | Cliente gratuito de Atlassian, potente |
| **GitLens** | Extensión VS Code con blame, historial y annotations |
| **Git Graph** | Extensión VS Code para visualizar ramas como gráfico |
| **GitHub CLI** | Terminal para gestionar GitHub directamente |
| **gitref.com** | Referencia rápida de comandos |
| **Oh My Zsh** | Framework de terminal con plugins de Git |

En el Resumen consolidaremos todo lo aprendido en la unidad: conceptos, comandos, flujos de trabajo y herramientas.
