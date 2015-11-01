# Glimpse.LightInject
Glimpse extension for LightInject

[![Build status](https://ci.appveyor.com/api/projects/status/vmmjwi5y0pvh3jg4?svg=true)](https://ci.appveyor.com/project/PhillipSharpe/glimpse-lightinject)

[![cakebuild.net](https://img.shields.io/badge/WWW-getglimpse.com-blue.svg)](http://getglimpse.com/)

[![cakebuild.net](https://img.shields.io/badge/WWW-lightinject.net-blue.svg)](http://lightinject.net/)



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
