# 🛒 Ecommerce API - .NET 9.0

![Build Status](https://img.shields.io/badge/build-passing-brightgreen?style=for-the-badge)
![.NET Version](https://img.shields.io/badge/.NET-9.0-blue?style=for-the-badge&logo=dotnet)
![Language](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge)
![Contributions](https://img.shields.io/badge/contributions-welcome-orange?style=for-the-badge)

## 📋 Descripción General

**Ecommerce API** es una aplicación web robusta desarrollada en **.NET 9.0** que implementa una arquitectura por capas para la gestión completa de un sistema de comercio electrónico. El proyecto está diseñado siguiendo principios de **Clean Architecture** y **SOLID**, garantizando escalabilidad, mantenibilidad y testabilidad.

### ✨ Características Principales
- 🏗️ **Arquitectura por Capas**: Separación clara de responsabilidades
- 🔐 **Seguridad Integrada**: Autenticación y autorización
- 📊 **API RESTful**: Endpoints bien documentados
- 🎯 **Clean Code**: Código limpio y bien estructurado
- 🚀 **Alto Rendimiento**: Optimizado para .NET 9.0

## 📁 Estructura del Proyecto

```
ecommerce/
├── 📂 ecommerce/                    # Proyecto API Principal
│   ├── Controllers/                 # Controladores de la API
│   ├── Program.cs                   # Punto de entrada
│   └── appsettings.json            # Configuraciones
├── 📂 Application/                  # Capa de Aplicación
│   ├── DTOs/                       # Data Transfer Objects
│   ├── Interfaces/                 # Contratos de servicios
│   ├── Services/                   # Lógica de negocio
│   └── Validators/                 # Validaciones
├── 📂 Domain/                       # Capa de Dominio
│   ├── Entities/                   # Entidades del negocio
│   ├── Enums/                      # Enumeraciones
│   └── ValueObjects/               # Objetos de valor
├── 📂 Infrastructure/               # Capa de Infraestructura
│   ├── Data/                       # Contexto de base de datos
│   ├── Repositories/               # Implementación de repositorios
│   └── Configurations/             # Configuraciones de EF Core
├── 📄 README.md                     # Documentación del proyecto
└── 📄 LICENSE                       # Licencia MIT
```

## 🛠️ Tecnologías Utilizadas

| Tecnología | Descripción | Enlace Oficial |
|------------|-------------|----------------|
| ![.NET](https://img.shields.io/badge/.NET-9.0-blue?style=flat-square&logo=dotnet) | Framework principal | [.NET 9.0](https://dotnet.microsoft.com/) |
| ![C#](https://img.shields.io/badge/C%23-Latest-239120?style=flat-square&logo=c-sharp) | Lenguaje de programación | [C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/) |
| ![Entity Framework](https://img.shields.io/badge/Entity%20Framework-Core-512BD4?style=flat-square) | ORM para base de datos | [EF Core](https://docs.microsoft.com/en-us/ef/core/) |
| ![ASP.NET Core](https://img.shields.io/badge/ASP.NET-Core-512BD4?style=flat-square) | API Web Framework | [ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/) |

## 🚀 Instalación y Ejecución

### Prerrequisitos
- ✅ [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- ✅ [Git](https://git-scm.com/)
- ✅ [SQL Server](https://www.microsoft.com/en-us/sql-server) (opcional, puede usar LocalDB)

### Pasos de Instalación

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/LFDIAZDEV2209/ecommerce.git
   cd ecommerce
   ```

2. **Restaurar dependencias**
   ```bash
   dotnet restore
   ```

3. **Configurar base de datos**
   ```bash
   # Actualizar cadena de conexión en appsettings.json
   dotnet ef database update
   ```

4. **Ejecutar la aplicación**
   ```bash
   dotnet run --project ecommerce
   ```

5. **Acceder a la API**
   ```
   🌐 API: https://localhost:7000
   📚 Swagger: https://localhost:7000/swagger
   ```

## 🎯 Próximas Mejoras

- [ ] 🔍 **Implementar búsqueda avanzada** con filtros por categoría y precio
- [ ] 🛒 **Sistema de carrito de compras** con persistencia
- [ ] 💳 **Integración de pagos** con PayPal/Stripe
- [ ] 📧 **Notificaciones por email** para pedidos
- [ ] 📱 **API Mobile-First** con optimizaciones
- [ ] 🔄 **Cache Redis** para mejor rendimiento
- [ ] 📊 **Dashboard de administración** con métricas
- [ ] 🧪 **Tests unitarios y de integración** completos
- [ ] 🐳 **Dockerización** del proyecto
- [ ] ☁️ **Deploy en Azure/AWS** con CI/CD

## 🤝 Contribuciones

¡Las contribuciones son bienvenidas! Sigue estos pasos para colaborar:

1. **Fork el proyecto**
   ```bash
   # Haz click en el botón Fork en GitHub
   ```

2. **Crear una rama para tu feature**
   ```bash
   git checkout -b feature/nueva-funcionalidad
   ```

3. **Realizar tus cambios y commit**
   ```bash
   git add .
   git commit -m "feat: agregar nueva funcionalidad"
   ```

4. **Push a tu rama**
   ```bash
   git push origin feature/nueva-funcionalidad
   ```

5. **Crear un Pull Request**
   - Ve a GitHub y crea un PR describiendo tus cambios
   - Incluye screenshots si es necesario
   - Menciona issues relacionados con `#numero`

### 📝 Convenciones de Commit
Usamos [Conventional Commits](https://www.conventionalcommits.org/):
- `feat:` para nuevas características
- `fix:` para corrección de bugs
- `docs:` para cambios en documentación
- `refactor:` para refactorización de código

## 📄 Licencia

Este proyecto está bajo la licencia **MIT**. Ver el archivo [LICENSE](./LICENSE) para más detalles.

---

<div align="center">

### 🌟 ¡Si te gusta el proyecto, dale una estrella! ⭐

**Desarrollado con ❤️ por [LFDIAZDEV2209](https://github.com/LFDIAZDEV2209)**

📂 **Repositorio:** https://github.com/LFDIAZDEV2209/ecommerce

</div>