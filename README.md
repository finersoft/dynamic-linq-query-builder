# Dynamic Linq Query Builder
[![Build status](https://ci.appveyor.com/api/projects/status/xylgqn0smrd63lnl/branch/master?svg=true)](https://ci.appveyor.com/project/tghamm/dynamic-linq-query-builder/branch/master) [![Coverage Status](https://coveralls.io/repos/castle-it/dynamic-linq-query-builder/badge.svg?branch=master&service=github)](https://coveralls.io/github/castle-it/dynamic-linq-query-builder?branch=master)

`dynamic-linq-query-builder` is a small library that allows any `.Net` framework class collection to be filtered dynamically at runtime.  

Features (v1.0.5)
--
* Generates an `IQueryable` from any collection and filter combination
* Capable of complex, grouped queries against as many fields as you want
* Supports a number of operators for each type
  * in
  * not in
  * equal
  * not equal
  * between
  * not between
  * less
  * less or equal
  * greater
  * greater or equal
  * begins with
  * not begins with
  * contains
  * not contains
  * ends with
  * not ends with
  * is empty
  * is not empty
  * is null
  * is not null
* Compatible with jQuery-QueryBuilder (see samples for an example)

Installation
--
`dynamic-linq-query-builder` can be installed via the nuget UI (as Castle.DynamicLinqQueryBuilder), or via the nuget package manager console:
```
PM> Install-Package Castle.DynamicLinqQueryBuilder
```

Getting Started
--
The easiest way to get started is to install the NuGet package and take a look at the MVC sample application included in the source code.  It contains a working example of both `dynamic-linq-query-builder` and `jQuery-QueryBuilder`.

Contributions
--
Contributions and pull requests are welcome.

对示例的增强：汉化，实用。
--
汉化
-
汉化了界面元素（加入了官方汉化包和实体属性汉化）

打印sql(在示例运行后，进入开发者模式，可以看到生成的sql语句)
-
FirstName = 'Jane' OR ( Age < 40 )  OR LastName LIKE('%on%')
