# Glimpse.LightInject
Glimpse extension for LightInject



## Implemented functionality

* Loads all service registrations into a new Glimpse Tab



## Referencing

Glimpse.LightInject is available as a nuget package from the package manager console:

```csharp
Install-Package Glimpse.LightInject
```



## Usage

```csharp
using LightInject;
using Glimpse.LightInject;

IServiceContainer container = new ServiceContainer();
container.EnableGlimpse();
```
