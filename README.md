# Glimpse.LightInject
Glimpse extension for LightInject

[![Build status](https://ci.appveyor.com/api/projects/status/vmmjwi5y0pvh3jg4?svg=true)](https://ci.appveyor.com/project/SharpeRAD/glimpse-lightinject)

[![cakebuild.net](https://img.shields.io/badge/WWW-getglimpse.com-blue.svg)](http://getglimpse.com/)

[![cakebuild.net](https://img.shields.io/badge/WWW-lightinject.net-blue.svg)](http://lightinject.net/)



## Table of contents

1. [Implemented functionality](https://github.com/SharpeRAD/Glimpse.LightInject#implemented-functionality)
2. [Referencing](https://github.com/SharpeRAD/Glimpse.LightInject#referencing)
3. [Usage](https://github.com/SharpeRAD/Glimpse.LightInject#usage)
4. [License](https://github.com/SharpeRAD/Glimpse.LightInject#license)
5. [Share the love](https://github.com/SharpeRAD/Glimpse.LightInject#share-the-love)



## Implemented functionality

* Loads all service registrations into a new Glimpse Tab



## Referencing

[![NuGet Version](http://img.shields.io/nuget/v/Glimpse.LightInject.svg?style=flat)](https://www.nuget.org/packages/Glimpse.LightInject/) [![NuGet Downloads](http://img.shields.io/nuget/dt/Glimpse.LightInject.svg?style=flat)](https://www.nuget.org/packages/Glimpse.LightInject/)

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



## License

Copyright (c) 2015 - 2016 Phillip Sharpe

Glimpse.LightInject is provided as-is under the MIT license. For more information see [LICENSE](https://github.com/SharpeRAD/Glimpse.LightInject/blob/master/LICENSE).



## Share the love

If this project helps you in anyway then please :star: the repository as its good to know your hardwork is appreciated.