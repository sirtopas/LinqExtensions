# LinqExtensions
A simple extension class for Linq Ordering

### Usage
Simply clone or copy the LinqExtensions file and use within your application: 

```c#
using Project.Extensions;

var objects = _myRepo.GetObjects();
var sortedObjects = objects.SortBy(objects.ObjectName);

return sortedObjects;
```