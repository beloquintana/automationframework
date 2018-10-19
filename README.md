# Proyecto de automatización de pruebas con Selenium en C#

Framework de pruebas automatizado con las funcionalidades bases para comenzar con la automatización de pruebas en un proyecto.

## Funcionalidades:
* Automatización de pruebas
* Reportes html
* Visual Testing
* Ejecución en paralelo
* Data Driven Testing

## Tecnologías:
* Selenium WebDriver
* C#
* ExtentReports
* NUnit
* Applitools

## Instalación:
Requiere de la Key de Applitools. Ir a https://applitools.com/ y crearse una cuenta. La Key que genera Applitools por usuario es necesaria colocarla en el archivo de configuración: app.config (automationframework/AutomationFramework/app.config)
Colocarla en el tag:
```xml
<myxml>
   <add key="API_Key" value="" />
</myxml>
```

