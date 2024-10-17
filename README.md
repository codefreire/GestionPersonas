# GestionPersonas
___
## • Estructura del proyecto
  El proyecto cuenta con la siguiente estructura de carpetas:
  - Models => Modelado y contexto de la base de datos.
  - Views => Vistas utilizando Razor, bootstrap y HTML.
  - Controllers => Manejo de rutas y métodos HTTP para implementar un CRUD.
  - Services => Lógica de negocio que define los pasos a seguir al realizar acciones del CRUD.
  - Repositories => Responsable del acceso e interacción con los datos de la base de datos.
___
## • Creación base de datos
  1. Descargarse el archivo **'database-personas.sql'** ubicado en la raíz de este proyecto
  2. Abrir el archivo en SSMS (entorno gráfico para administrar bases de datos MS SQL Server)
  3. Clic en ejecutar o F5. Creará la base de datos con la tabla Personas.
___
## • Cómo ejecutar la aplicación
  1. Descargarse o clonar este repositorio.
  2. Abrirlo con Visual Studio (doble clic en el archivo de la solucion: **'GestionPersonas.sln'**)
  3. Abrir el archivo **'appsettings.json'** aquí se encuentra la cadena de conexión a la base de datos **"cnPersonasDB"**
  4. Dentro de la cadena de conexión cambiar el valor de **server=LAPTOP-2MO9QJ8P\\MSSQLSERVER01;** Por el nombre de su servidor (motor) de su base de datos MS SQL Server.
     - Puede consultar el nombre de su motor:
         En SSMS clic en New Query, pegar y ejecutar la siguiente consulta:
           **SELECT @@SERVERNAME AS 'SERVERNAME'**
         Le devolverá su SERVERNAME y eso lo coloca dentro de la cadena de conexión: server=**SERVERNAME**;
         Los demás datos de la cadena de conexión quedan iguales.
  6. Guardar
  7. Ejecutar (triángulo verde) o abrir terminal dentro del proyecto y ejecutar el comando **'dotnet run'**
  8. Listo se despliega la aplicación. Si no es así pruebe en una ventana en incógnito.
        Puede ver en la terminal la url donde está corriendo la aplicación.
        También puede verla dentro de la carpeta **'Properties'** en el archivo **launchSettings.json** en **"applicationUrl"**
