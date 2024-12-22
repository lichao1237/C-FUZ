# 第一章C#概述

## CLR的概念和功能

.NET提供了一个称为公共语言运行时的运行时环境，它运行代码并提供使开发过程更加轻松的服务。

1. **基础功能**——那些对其他的特性有广泛影响的功能。包括：

2. 垃圾回收

3. 内存安全和类型安全

4. 对编程语言的高级支持

5. **次要功能**——那些由基础功能发展而来的、但不是必须的功能：

6. AppDomains 程序隔离

7. 程序安全与沙盒

8. **其他功能**——那些运行时环境需要的、但并不依赖基础功能的特性。这些功能帮助我们建立了一个完整的编程环境。比如：

9. 版本管理

10. 调试、性能分析

11. 互操作

[什么是 CLR ？ - 知乎](https://zhuanlan.zhihu.com/p/68158037)

## C#的优势和特点

特点：跨平台、跨语言

跨平台：.net可跨操作系统和硬件环境、.net framework中的语言首先由编译器编译成与平台无关的MSIL，然后有JIT编译器编译成具体平台上的可执行代码。

跨语言：.net将开发语言和运行平台分离，设计了一个通用语言系统CLS，定义了标准的数据类型。CLS是一个内置在公共语言运行库中的类型系统，支持大多数语言中存在的类型和操作。

优势：C#是一种类型安全的、现代的、简单的。综合了Visual Basic的高生产率和C++的行动力。适用于Windows平台。

## C#开发.NET应用程序的步骤

编写应用程序代码==》把代码编译成MSIL，存储在装配件中==》CLR==》机器代码==》代码被执行。

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-11-21-11-54-58-image.png)

## C#源程序文件、vs解决方案文件、Web项目文件、C#项目文件的后缀名

在C#开发中，不同类型的文件有各自的文件后缀名，以下是一些常见文件类型及其后缀名的说明：

### 1. **C# 源程序文件**

- **后缀名**：`.cs`
- **描述**：C# 的源代码文件，包含类、方法和程序逻辑。

### 2. **Visual Studio 解决方案文件**

- **后缀名**：`.sln`
- **描述**：Visual Studio 的解决方案文件，用于保存整个解决方案的信息，包括多个项目的引用和配置。

### 3. **Web 项目文件**

- **后缀名**：`.aspx`
- **描述**：ASP.NET Web 项目或普通 C# 项目的项目文件，用于记录项目的配置信息，如文件列表、编译设置等。
- **其他相关文件**：
  - `.config`：通常是 `web.config` 或 `app.config` 文件，用于保存应用程序配置。

### 4. **C# 项目文件**

- **后缀名**：`.csproj`
- **描述**：C# 项目的项目文件，定义了项目属性、依赖项、目标框架等。

### 其他常见文件后缀：

| **文件类型** | **后缀名**              | **描述**                                  |
| -------- | -------------------- | --------------------------------------- |
| 程序集      | `.dll`               | 生成的类库文件，可以被其他程序引用。                      |
| 可执行文件    | `.exe`               | C# 项目生成的可执行程序文件。                        |
| 配置文件     | `.config`            | 应用程序配置文件，如 `app.config` 或 `web.config`。 |
| 静态资源文件   | `.html`/`.css`/`.js` | Web 项目中的网页、样式和脚本文件。                     |
| 项目元数据文件  | `.user`              | 用户特定的项目设置（如调试配置）。                       |

这些文件类型共同组成了一个完整的 C# 项目或解决方案，开发时需要根据实际需求合理管理它们。

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-11-26-11-11-02-image.png)

## 第一个简单的C应用程序

# 第二章 C#编程基础

## System.Array的属性与方法

System.Array是所有数组类型的抽象基类型，所有的数组类型均由它派生，任何数组都可以是哟经System.Array具有的属性及方法。

1、Length属性可以获取数组的长度

2、GetLength(n)方法可以得到第n维的数组长度

3、Sort方法可以对数组按升序排序

4、Reverse方法可以把数组中的元素反序

[Array 类 (System) | Microsoft Learn](https://learn.microsoft.com/zh-cn/dotnet/api/system.array?view=net-8.0)

## 动态数组ArrayList

需引入System.Collections命名空间

Array与ArrayList的区别

1、Array的容量固定，而ArrayList可以动态扩充

2、ArrayList提供添加、插入或移除某一范围元素的方法。在Array中，只能一次获取或设置一个元素的值

3、Array可以是多维的，而ArrayList是一维的

[ArrayList 类 (System.Collections) | Microsoft Learn](https://learn.microsoft.com/zh-cn/dotnet/api/system.collections.arraylist?view=net-8.0)

## 一维数组的声明、创建、初始化

```csharp
//声明数组：数组元素类型[ ] 数组名
float[] fs;
//创建数组 数组名=new 数组元素类型[数组元素个数]
fs = new float[4];
//数组名中存放数组首地址
//声明数组和创建数组可以同时存在
float[] fs =new float[4];
//允许使用int类型常量指定数组元素的个数
const int size=4;float[] fs = new float[size];


//Length的使用 数组名.length是数组元素的个数
//初始化数组
//方法1：使用for循环初始化
for(int i=0;i<fs.Length;i++){
    fs[i]=(float)2007.0/(i+1);
}
//方法2：声明数组同时初始化
type[] arrayName = new type[size] { 1,2,3,4,5,...};
float[] fs=new float[4]{21.34f,37.58f,555.5f,834.23f};
//省略掉size大小，编译系统会根据初始化表中的数据个数，自动计算数组大小。
float[] fs=new float[]{21.34f,37.58f,555.5f,834.23f};
//声明数组的同时初始化，省略掉new
float[] fs={21.34f,37.58f,555.5f,834.23f};
```

## 规则与锯齿状二维数组的声明、创建、初始化

```csharp
//声明数组：数组元素类型[ , ] 数组名
Point[,] ps;
//声明数组：数组元素类型[][] 数组名;
Point[][] ps;
//创建数组：数组名=new 数组元素类型[一维元素个数][二维元素个数]
ps = new Point[4][]; //锯齿状二维数组 二维元素个数不指定
ps = new Point[4,5]; //规则二维数组 二维元素个数必须指定




//Lenth的使用
//数组名.Length 是规则二维数组含有的总元素的个数
int [,] c = new int [3,4]; //c.Length 为12
//数组名.Length 是锯齿状二维数组含有的一维数组的个数
int [][] c =new int[3][]; //c.Length为3
//初始化数组1
Point [][] ps=new Point[3][];
for(int i=0;i<ps.GetLength(0);i++){
    ps[i]=new Point[5];
    for(int j=0;j<ps[i].Length;j++){
       ps[i][j]=new Point(i+1,j+1); 
    }
}
//初始化数组2 
type [ , ]   arrayName=new  type[size1,size2] {{val11, val12, ……, val1n}, {val21, val22, ……, val2n},…, { valm1, valm2,
……, valmn} };
int [ , ]  a=new  int[2,3]{{0,1,2}, {3,4,5}};
//初始化数组3
int [ , ]  a=new  int[ , ]{{0,1,2}, {3,4,5}};
//初始化数组4
int [ , ]  a= {{0,1,2}, {3,4,5}};
//初始化数组5
int [ , ]  a;   a=new  int[ 2, 3]{{0,1,2}, {3,4,5}};
//初始化数组6：不规则数组的初始化
char[][]  st1=new  char[3][];
st1[0]=new  char[] {‘S’,’e’,’p’,’t’,’e’,’m’,’b’,’e’,’r’};
st1[1]=new  char[] {‘O’,’c’,’t’,’o’,’b’,’e’,’r’};
st1[2]=new  char[] { ‘N’,’o’,’v’,’e’,’m’,’b’,’e’,’r’};
```

[C# 锯齿数组 - C#教程 - 菜鸟教程](https://www.cainiaojc.com/csharp/csharp-jagged-array.html)

## foreach语句

C#的foreach循环用于遍历集合中的每一个元素

```csharp
//foreach   ( 类型  标识符  in   集合表达式 )
//语句；
int[] ints{1,2,3};
foreach(int temp in ints){
    Console.WriteLine(temp);
}
```

[迭代语句 - for、foreach、do 和 while - C# reference | Microsoft Learn](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement)

# 第三章 面向对象编程基础

## 属性及其属性的修饰符

### 属性的种类

可读写属性

只读属性

只写属性

static属性：只能访问静态数据

### 类的修饰符

public,
protected, private, internal,  protected  internal

## 方法的修饰符

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-11-28-09-42-39-image.png)

abstract：抽象类，含有抽象成员，不能被实例化，只能用作基类

sealed：密封类，不能从该类派生出其他类

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-11-28-09-46-42-image.png)

## 修饰符的无效组合

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-11-28-10-17-03-image.png)

## 属性和字段的区别及其联系

1、均可以访问对象中包含的数据

```csharp
//字段是对象的内部数据存储单元，是直接与对象的状态相关联的。
//定义字段后，可以通过对象实力直接访问该字段的值（如果字段是公开的）。
class Person
{
    public string Name; // 字段
}

Person person = new Person();
person.Name = "张三"; // 直接赋值
Console.WriteLine(person.Name); // 直接访问字段的值
/*-------------------------------------------------------*/

//属性通常通过封装字段来间接访问和操作对象的数据。
//属性本质上是方法的语法糖，可以包含逻辑来控制对字段的访问行为，例如验证、计算或限制。
class Person
{
    private string name; // 私有字段

    public string Name // 属性
    {
        get => name; // 通过字段间接访问数据
        set => name = value; // 通过字段间接修改数据
    }
}

Person person = new Person();
person.Name = "张三"; // 通过属性赋值
Console.WriteLine(person.Name); // 通过属性读取值
```

2、属性不能直接访问数据：属性要通过封装字段间接访问数据。

3、属性可以限制数值的取值范围：在set方法里面限制数值的范围

4、属性可以设置为只读、只写、可读写

5、属性可以像方法一样使用virtual、abstract、override、new、static等修饰符，而这些修饰符不能用于字段

```csharp
using System;

class Student
{
    // 字段：直接存储数据
    private string name; // 普通字段
    private int age; // 直接字段存储年龄

    // 属性：对字段的封装
    public string Name
    {
        get => name; // 只读方式获取字段值
        set => name = value; // 通过赋值语句修改字段值
    }

    public int Age
    {
        get => age; // 获取字段值
        set
        {
            // 限制数值范围
            if (value < 0 || value > 150)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "年龄必须在0到150之间");
            }
            age = value;
        }
    }

    // 只读属性
    public int BirthYear => DateTime.Now.Year - age; // 根据当前年计算出生年份

    // 虚属性（可被子类重写）
    public virtual string Description => $"姓名: {Name}, 年龄: {Age}, 出生年份: {BirthYear}";

    // 构造函数
    public Student(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}

class HighSchoolStudent : Student
{
    public HighSchoolStudent(string name, int age) : base(name, age) { }

    // 重写虚属性
    public override string Description => $"高中生 - {base.Description}";
}

class Program
{
    static void Main(string[] args)
    {
        // 使用字段和属性
        Student student = new Student("张三", 20);

        // 直接使用字段（错误示例，因为字段是私有的）
        // student.name = "李四"; // 无法访问

        // 使用属性
        student.Name = "李四";
        student.Age = 25;
        Console.WriteLine(student.Description);

        // 高中生示例
        HighSchoolStudent highSchoolStudent = new HighSchoolStudent("王五", 17);
        Console.WriteLine(highSchoolStudent.Description);

        // 测试属性的取值范围限制
        try
        {
            student.Age = 200; // 会抛出异常
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"错误: {ex.Message}");
        }
    }
}
```

## 抽象属性

[如何定义抽象属性 - C# | Microsoft Learn](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/how-to-define-abstract-properties)

## 集合与foreach循环

### **C# 集合与 `foreach` 循环**

在 C# 中，**集合**（例如数组、列表、字典等）是存储和操作一组数据的容器。`foreach` 循环用于**遍历集合中的每个元素**，提供了一种简洁、安全的迭代方式。

---

### **常见集合类型**

1. **数组（Array）**  
   用于存储固定大小的同类型元素。
   
   ```csharp
   int[] numbers = { 1, 2, 3, 4, 5 };
   ```

2. **列表（List）**  
   动态大小的集合，可以添加或移除元素。
   
   ```csharp
   List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
   ```

3. **字典（Dictionary<TKey, TValue>）**  
   键值对集合，用于快速查找。
   
   ```csharp
   Dictionary<int, string> students = new Dictionary<int, string>
   {
      { 1, "Alice" },
      { 2, "Bob" },
   };
   ```

4. **队列（Queue）** 和 **栈（Stack）**  
   特殊规则的集合类型，分别遵循先进先出（FIFO）和后进先出（LIFO）。

---

### **`foreach` 的工作原理**

`foreach` 循环会自动调用集合对象的 `GetEnumerator` 方法，并迭代集合中的每个元素。它隐式使用了集合实现的 `IEnumerable` 或 `IEnumerable<T>` 接口。

**语法：**

```csharp
foreach (var item in collection)
{
    // 对每个 item 进行操作
}
```

---

### **示例代码**

#### **1. 遍历数组**

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };

foreach (int number in numbers)
{
    Console.WriteLine(number);
}
```

#### **2. 遍历列表**

```csharp
List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

foreach (string name in names)
{
    Console.WriteLine($"Hello, {name}!");
}
```

#### **3. 遍历字典**

```csharp
Dictionary<int, string> students = new Dictionary<int, string>
{
    { 1, "Alice" },
    { 2, "Bob" },
    { 3, "Charlie" },
};

foreach (KeyValuePair<int, string> student in students)
{
    Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
}
```

#### **4. 使用 `Queue`**

```csharp
Queue<string> tasks = new Queue<string>();
tasks.Enqueue("Task 1");
tasks.Enqueue("Task 2");
tasks.Enqueue("Task 3");

foreach (string task in tasks)
{
    Console.WriteLine(task);
}
```

#### **5. 使用 `Stack`**

```csharp
Stack<string> plates = new Stack<string>();
plates.Push("Plate 1");
plates.Push("Plate 2");
plates.Push("Plate 3");

foreach (string plate in plates)
{
    Console.WriteLine(plate);
}
```

---

### **优点和注意事项**

#### **优点：**

1. **简单易用：**
   
   - 不需要关心索引或迭代器细节。
   - 适用于任何实现了 `IEnumerable` 或 `IEnumerable<T>` 接口的集合。

2. **安全性：**
   
   - `foreach` 循环自动处理边界条件，避免了传统 `for` 循环中可能出现的索引越界问题。

3. **只读访问：**
   
   - 在循环中对集合的元素是**只读**的，无法修改元素本身（除非集合存储的是引用类型对象）。

#### **注意事项：**

1. **无法直接修改集合：**
   
   ```csharp
   List<int> numbers = new List<int> { 1, 2, 3, 4 };
   
   foreach (int number in numbers)
   {
      // number = 10; // 编译错误，无法修改
   }
   ```

2. **集合在迭代时不能被修改：** 如果在 `foreach` 循环中对集合本身进行添加或移除操作，会抛出 `InvalidOperationException`。
   
   ```csharp
   List<int> numbers = new List<int> { 1, 2, 3, 4 };
   
   foreach (int number in numbers)
   {
      numbers.Add(5); // 会抛出异常
   }
   ```

3. **适用于实现了 `IEnumerable` 接口的类型：** 只有集合支持 `IEnumerable` 或 `IEnumerable<T>` 接口时，才能使用 `foreach`。

---

### **总结**

- **集合**是存储数据的容器，`foreach` 是专门用来迭代集合元素的语法。
- `foreach` 更简洁安全，但无法直接修改集合内容。
- 适用于数组、列表、字典等各种集合类型，是处理集合元素的强大工具。

## 索引器

索引器允许类或者结构的实例就像数组一样进行索引。不用显示指定类型或者实例成员，即可设置或者检索索引值。索引器类似于属性，不同之处在于他们的访问器需要使用参数。

```csharp
using System;

class SampleCollection<T>
{
   // Declare an array to store the data elements.
   private T[] arr = new T[100];

   // Define the indexer to allow client code to use [] notation.
   public T this[int i]
   {
      get { return arr[i]; }
      set { arr[i] = value; }
   }
}

class Program
{
   static void Main()
   {
      var stringCollection = new SampleCollection<string>();
      stringCollection[0] = "Hello, World";
      Console.WriteLine(stringCollection[0]);
   }
}
// The example displays the following output:
//       Hello, World.
```

- 使用索引器可以用类似于数组的方式为对象建立索引。

- `get` 取值函数返回值。 `set` 取值函数分配值。

- [this](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/this) 关键字用于定义索引器。

- [value](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/value) 关键字用于定义由 `set` 访问器分配的值。

- 索引器不必根据整数值进行索引；由你决定如何定义特定的查找机制。

- 索引器可被重载。

- 索引器可以有多个形参，例如当访问二维数组时。

[使用索引器 - C# | Microsoft Learn](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/indexers/using-indexers)

索引器使你可以从语法上方便地创建类、结构或接口，以便客户端应用程序可以像访问数组一样访问它们。编译器会生成一个Item属性（或者如果存在IndexerNameAttribute，也可以生成一个命名属性）和适当的访问器方法。在主要目标是封装内部集合或数组的类型中，常常要实现索引器。例如，假设有一个类TempRecod，他表示24小时的周期内在10个不同时间点所记录的温度。此类包含一个float[ ]类型的数组temps，用于存储温度值。通过在此类中实现索引器，客户端可采用float temp = tempRecord[4] 的形式而不是float temp = tempRecord.temps[4] 访问TempRecord实例中的温度。试用期表示法不但简化了客户端应用程序语法；还使类及其目标更容易直观地为其他开发者所理解。

```csharp
// Indexer declaration
public int this[int index]
{
    // get and set accessors
}
```

```csharp
 public class TempRecord
{
    // Array of temperature values
    float[] temps =
    [
        56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
        61.3F, 65.9F, 62.1F, 59.2F, 57.5F
    ];

    // To enable client code to validate input
    // when accessing your indexer.
    public int Length => temps.Length;

    // Indexer declaration.
    // If index is out of range, the temps array will throw the exception.
    public float this[int index]
    {
        get => temps[index];
        set => temps[index] = value;
    }
}
```

```csharp
var tempRecord = new TempRecord();

// Use the indexer's set accessor
tempRecord[3] = 58.3F;
tempRecord[5] = 60.1F;

// Use the indexer's get accessor
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Element #{i} = {tempRecord[i]}");
}
```

##### **索引器和数组的不同点**

#### **相同点：**

1. **通过索引访问：**
   - 数组和索引器都可以通过类似 `obj[index]` 的方式访问数据。

#### **不同点：**

| 特性       | 数组                            | 索引器                     |
| -------- | ----------------------------- | ----------------------- |
| **定义形式** | 使用 `[]` 定义一个固定类型的集合。          | 是类或对象的成员，用于提供自定义的索引访问。  |
| **存储数据** | 数据存储在内存中，表示一组数据集合。            | 没有自己的存储，通常封装了某种集合或计算逻辑。 |
| **类型限制** | 类型固定，例如 `int[]` 或 `string[]`。 | 可以根据需求返回任意类型的数据。        |
| **范围限制** | 索引范围固定，如 `0` 到 `Length-1`。    | 索引规则由开发者定义，范围可自定义。      |
| **多维支持** | 支持多维数组，例如 `array[x, y]`。      | 仅支持一维索引，但可以通过参数模拟多维索引。  |

#### **示例：**

##### **数组**

```csharp
int[] numbers = { 1, 2, 3 };
Console.WriteLine(numbers[0]); // 输出 1
```

##### **索引器**

```csharp
class MyCollection
{
    private string[] data = { "A", "B", "C" };

    public string this[int index]
    {
        get => data[index];
        set => data[index] = value;
    }
}

MyCollection collection = new MyCollection();
Console.WriteLine(collection[0]); // 输出 A
collection[1] = "Z";
Console.WriteLine(collection[1]); // 输出 Z
```

---

### **索引器和属性的不同点**

#### **相同点：**

1. **封装数据：**
   - 两者都可以封装类的数据成员。
   - 都可以定义 `get` 和 `set` 访问器。

#### **不同点：**

| 特性       | 索引器                         | 属性                        |
| -------- | --------------------------- | ------------------------- |
| **访问形式** | 通过 `[]` 访问，例如 `obj[index]`。 | 通过名称访问，例如 `obj.Property`。 |
| **返回类型** | 通常返回单个值，可以有多个索引参数。          | 仅返回或设置单个值。                |
| **定义目的** | 提供类似数组的操作方式。                | 用于封装单个字段或逻辑。              |
| **参数支持** | 支持一个或多个参数。                  | 不支持参数。                    |
| **适用场景** | 用于封装集合或提供索引访问功能。            | 用于封装对象的属性值。               |

#### **示例：**

##### **索引器**

```csharp
class MyCollection
{
    private string[] data = { "A", "B", "C" };

    public string this[int index]
    {
        get => data[index];
        set => data[index] = value;
    }
}

MyCollection collection = new MyCollection();
Console.WriteLine(collection[0]); // 输出 A
collection[1] = "Z";
Console.WriteLine(collection[1]); // 输出 Z
```

##### **属性**

```csharp
class Person
{
    private string name;

    public string Name
    {
        get => name;
        set => name = value;
    }
}

Person person = new Person();
person.Name = "Alice"; // 使用属性赋值
Console.WriteLine(person.Name); // 输出 Alice
```

---

### **总结**

1. **索引器与数组的不同点：**
   
   - 数组存储实际数据，索引器只是封装了一种访问逻辑。
   - 数组的类型和大小是固定的，而索引器的逻辑可以更灵活。

2. **索引器与属性的不同点：**
   
   - 索引器通过索引（`[]`）访问数据，可以有多个参数。
   - 属性通过名字访问数据，不能接受参数。

两者可以结合使用，以实现更复杂的封装逻辑。

## 委托

委托是一种特殊的对象类型，只包含方法的地址。委托用于将方法作为参数传递给其他方法。

### 什么是委托？

委托是函数的封装，它代表一类函数，它们都符合一定的签名：拥有相同的参数列表和返回值类型。同时，委托也可以看成是对函数的抽象，是函数的类。此时委托的实例将代表一个具体的函数。

一个委托实例可以用来封装**一个静态**或**实例**方法。

## 委托应用—异步回调

由于实例化委托是一个对象，所以可以将其作为参数进行传递，也可以将其赋值给属性。这样，方法便可以将一个委托作为参数来接受，并且以后可以调用该委托。这称为异步回调，是在较长的进程完成后用来通知调用方的常用方法。以这种方式使用委托时，使用委托的代码不用了解有关所用方法的实现方面的任何信息。

就是将**委托**作为参数来传递给方法！！！[使用委托 - C# | Microsoft Learn](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/delegates/using-delegates)

```csharp
public static void MethodWithCallback(int param1, int param2, Callback callback)
{
    callback("The number is: " + (param1 + param2).ToString());
}
```

```csharp
MethodWithCallback(1, 2, handler);
```

```csharp
The number is: 3
```

## 如何委托？

委托是面向对象的，是引用类型，对委托的使用要先定义再实例化，才能调用。

```csharp
delegate int SomeDelegate(int nID,string sName);//定义
SomeDelegate d1 = new SomeDelegate(wr.InstanceMethod);//实例化
d1(5,"aaa");//调用这个委托
```

委托实例化的参数方法中的参数和返回类型必须和委托的定义一致。

委托实例化中的参数可以是非静态方法，也可以使静态方法。

可以在类的任何地方定义委托。

可以给委托定义添加修饰符public，private、protected

委托派生于System.Delegate,在语法上总是带有一个参数构造函数，这个参数就是委托引用的方法，这个方法必须匹配最初定义委托时的签名。

————————————————————

委托对象通常可以采用两种方式进行构造，一直是提供委托将封装的方法的名称，另一种是利用lambda表达式。调用委托会调用附加到委托实例的方法。调用方传递到委托的参数将传递到该方法，并且委托会将方法的返回值返回调用方。例如：

```csharp
// Create a method for a delegate.
public static void DelegateMethod(string message)
{
    Console.WriteLine(message)；
}
// Instantiate the delegate.
Callback handler = DelegateMethod;

// Call the delegate.
handler("Hello World");
```

## 委托与C++函数指针的区别

委托可以指向多个方法。

C#委托对象是真正的对象，C/C++函数指针只是函数入口地址。

委托类似于C++函数指针，但委托完全面向对象，不像C++指针会记住函数，委托会同时封装对象实例和方法。

## 多播

一次委托可以调用多个方法。

通过+和-运算符可以实现多播的增加或减少。

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-12-04-11-26-37-image.png)

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-12-04-11-26-09-image.png)

将多个方法组合到一个委托中，如果方法的返回值非void，则通过委托调用方法仅得到最后一个方法的返回值，其他的返回值都将丢失。

将多个方法组合到一个委托中，会顺序调用委托中的每个方法。

## 事件

定义事件的委托

```csharp
public delegate void EventHandler(object from,MyEventArgs e);
//System.EventArgs是包含事件数据的类的基类
//MyEventArgs类派生于EventArgs，实现自定义事件数据的功能


//定义事件 event 事件的委托名 事件名;
public event EventHandler TextOut;
//激活事件
if (TextOut!=null){
    TextOut(this,new EventArgs());
}
//订阅和取消订阅事件
evsrc.TextOut+=new EventSource.EventHandler(CatchEvent);
evsrc.TextOut-=new EventSource.EventHandler(CatchEvent);
//CatchEvent的签名要与定义的委托EventHandler的签名相同
```

## 实例构造函数

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-12-08-21-31-08-image.png)

构造函数修饰符有public、protected、internal、private

构造函数可以重载

base表示调用直接基类中的实例构造函数

this调用该类本身所声明的其他构造函数

[实例构造函数 - C# | Microsoft Learn](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/instance-constructors)

## 静态构造函数

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-12-08-21-31-29-image.png)

静态构造函数的修饰符：static

静态构造函数仅对静态数据成员进行初始化，不能对非静态数据成员进行初始化

静态构造函数都是私有的

静态构造函数是不可继承的，而且不能被直接调用

## 析构函数

[终结器 - C# | Microsoft Learn](https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/finalizers)

析构函数不能被重载，不能被继承。

一个类如果没有显示声明析构函数，则编译器将自动产生一个默认的析构函数。

析构函数不能由程序显示调用，由系统在释放对象时调用。

析构函数是在“垃圾回收器“回收对象的存储空间之前调用的，最终会调用System.ObjectDe的Finalize()

可使用System.GC.Collect()请求运行垃圾回收期，例如代码中有大量的对象刚刚停止使用

Dispose方法和Close方法：有点事资源在不需要时候立即被释放，对于像独占文件所那样的对象来说是非常好的。

———————————————————————————————————————

无法在结构中定义。它们仅用于类。

一个类只能有一个终结器

不能继承或重载终结器

不能手动调用终结器，可以自动调用它们

终结器不适用修饰符或参数

```csharp
class Car
{
    ~Car()  // finalizer
    {
        // cleanup statements...
    }
}
```

## 运算符重载

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-12-08-21-56-02-image.png)

[C# 运算符重载 | 菜鸟教程](https://www.runoob.com/csharp/csharp-operator-overloading.html)

## 用户定义的数据类型转换

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-12-08-21-58-50-image.png)

## 方法的参数

[方法参数 - C# reference | Microsoft Learn](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/method-parameters#params-modifier)

**params** 修饰符：在方法声明中的这个修饰符之后不允许有任何其他参数，并且在方法声明中只允许有一个这样的关键词

声明类型必须是集合类型

# 第四章 WinForm程序设计

1、掌握控件Button、TextBox、RadioButton、CheckBox、RichTextBox、ListBox、ComboBox、TreeView、ListView、PictureBox、菜单栏、工具栏、状态栏、OpenFileDialog、SaveFileDialog、FontDialog、ColorDialog

2、掌握事件处理过程

## Button

## TextBox

1、用于获取用户输入或者显示文本

2、只能对显示或输入的文本提供单个格式化样式

## RadioButton

# 第五章 流

File类常用静态方法

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-12-09-22-39-56-image.png)

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-12-10-09-03-46-image.png)

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-12-10-09-09-45-image.png)

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-12-10-09-13-11-image.png)

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-12-10-09-18-32-image.png)

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-12-10-09-18-51-image.png)

## FileStream

表示在磁盘或网络路径上指向文件的流，提供了在文件中读写字节的方法

Read用于只读

Write用于只写

ReadWrite用于读写

### 文件位置

FileStream类维护内部文件指针，该指针指向文件中进行下一次读写操作的位置

```csharp
public override long Seek(long offset,SeekOrigin origin)//将文件流的当前位置设置为起始位置
//就是设置起始位置
```

offset为文件指针以字节为单位的移动距离

origin为开始计算的起始位置

SeekOrigin.Beigin Current End

### 读取数据

不仅可以读取文本文件，还可以读取图像和声音文件

```csharp
public override int Read(byte[] array, int offset, int count)
//array为字节数组 offset为字节数组中开始写入数据的位置
//count指定从文件中读取多少字节
int ReadByte()
//从文件中读取一个字节，并将读取位置提升一个字节
```

![](C:\Users\86130\AppData\Roaming\marktext\images\2024-12-10-09-33-23-image.png)

## 用File创建文件

```csharp
using System.IO;
string strTempPath=Path.GetTempPath();
string strFileName=Path.Combine(strTempPath,"test.txt");
FileStream aFile=File.Create(strFileName);
if   ( File.Exists(strFileName) )
   Console.WriteLine(“File  {0}  have created”, strFileName);
else
   Console.WriteLine(“File {0} created failed”, strFileName);
aFile.Close( );
File.Delete(strFileName);
```

## StreamWrite

### 构造方法

```csharp
public StreamWrite(string path)
public StreamWirte(string path,bool append)
append为false，则创建一个新文件，或截取现有文件并打开它
append为true，则打开文件，保留原有数据。如果找不到文件，则创建一个新文件
```

### Write和WriteLine方法

```csharp
public override void Write(string value)
//将字符串写入流，参数除字符串可以是任何基本数据类型


public virtual void WriteLine(string value)
//将字符串写入流并换行，参数除字符串外可以是任何基本数据类型
```

## StreamReader

### 构造方法

```csharp
public StreamReader(Stream stream)
public StreamReader(string path)
```

### Read和ReadLine和ReadToEnd方法

```csharp
public override int Read()
//读取输入流中的下一个字符。到达末流尾则返回-1
public override int ReadLine()
//从当前流中读取一行字符，并将数据作为字符串返回
int Read(char[] buffer,int index , int count)
//从index开始，将当前流中最多count个字符读入buffer中
string ReadToEnd()
//从流的当前位置到末流读取流
```

## BinaryReader和BinaryWriter

```csharp
以二进制读取数据！！！
常用函数
public virtual XXX readXXX();
对各种基本数据类型的读取
public virtual int Read()
public virtual int Read(byte[] buffer,int index,int count)
public virtual int Read(char[] buffer,int index,int count)
构造函数
public BinaryReader(Stream input)
public BinaryReader(Stream input,Encoding encoding)
___________________

常用函数
public virtual void Write(XXX xxx);
public virtual void Write(byte[] buffer,int index,int count)
public virtual void Write(char[] buffer,int index,int count)
构造函数
protected BinaryWriter()
public BinaryWrite(Stream input)
public BinaryWrite(Stream input,Encoding encoding)
```

## 对象的串行化

.NET Framework在System.Runtime.Serialization和System.Runtime.Serialization.Formatters命名空间中提供了串行化对象的基础架构

System.Runtime.Serialization.Formatters.Binary在该命名空间中包含的BinaryFormatter类能把对象串行化为二进制数据，把二进制数据串行化为对象。

System.Runtime.Serialization.Formatters.Soap在该命名空间中包含的SoupFormatter类能把对象串行化为SOAP格式的XML数据，把SOAP格式的XLM数据串行化为对象。

```csharp
IFormatter接口
void Serialize(Stream serializationStream, Object graph)
将对象或具有给定根的对象图形序列化为所提供的流。
Object Deserialize(Stream serializationStream)
反序列化所提供流中的数据并重新组成对象图形


IFormatter serializer=new BinaryFormatter();
serializer.Serialize(myStream,myObject);


IFormatter serializer=new BinaryFormatter()
MyObjectType myNewObject=serializer.Deserialize(myStream) as MyObectType;
```

## 监控文件结构FileSystemWatcher

```csharp
使用FileSystemWatcher
首先设置一些属性，指定监控的位置、内容以及引发应用程序要处理的事件的时间

然后给FileSystemWatcher提供定制事件处理程序的地址，当发生重要事件时候，
FileSystemWatcher就调用这些属性。

打开FileSystemWatcher，等待事件。

启动这个对象之前必须设置的属性有

Path 设置要监控的文件位置和目录

NotifyFilter 枚举值贵姓在被监控的文件内要监控哪些内容，可能是
Attributes LastWrite
CreateTime Security DirectoryName FileName Size LastAccess

这些表示要监控的文件或文件夹的属性，如果规定的属性发生变化，就引发事件
Filter监控文件的过滤器
必须为Changed、Created、Deleted和Renamed编写事件处理程序。
当修改与Path、NotifyFilter和Filter属性匹配的文件或目录时，就引发每一个事件
将EnableRaisingEvents属性设置为true，就可以开始监控工作
```

```csharp
 FileSystemEventArgs类的属性
 public WatcherChangeTypes ChangeType { get; } 
 WatcherChangeTypes.All
     文件或文件夹的创建、删除、更改或重命名。 
 Changed
     文件或文件夹的更改。更改的类型包括大小、属性、安全设置、最近写入时间和最近访问时间方面的更改。  
 Created
      文件或文件夹的创建。 
 Deleted
     文件或文件夹的删除
 Renamed
     文件或文件夹的重命名
 FullPath
获取受影响的文件或目录的完全限定的路径。 
 Name
获取受影响的文件或目录的名称
```

```csharp
RenamedEventArgs的属性
OldFullPath
获取受影响的文件或目录的前一个完全限定的路径。 
OldName
获取受影响的文件或目录的旧名称。  
```

## 读写压缩文件

```csharp
//System.IO.Compression命名空间中有两个压缩流类，DeflateStream和GZIpStream。
对于这两个类，必须用已经有的流初始化它们
//构造方法
public GZipStream(Stream stream,CompressionMode mode)
CompressionMode.Compress压缩基础流
CompressionMode.Decompress解压缩基础流
```

# 多线程技术

程序中的多任务，在使用文件处理软件时，用户在输入文字的同时，软件能够同步进行拼写检查而不需要用户的等待。

多线程工作方式：单处理器计算机上的并发性。抢先实多任务处理：时间片轮转。

例如：Microsoft Word的拼写检查器，一个线程等待用户输入，另一个线程进行后台搜索，第三个线程将写入的数据存储在临时文件中，第四个线程重Internet上下载其他数据。

例如：运行在服务器上的应用程序中，一个线程等待客户的请求，称为监听器线程；只要接收到请求，就将它传送给另一个工作线程，之后继续与客户通信。监听器线程会立即返回，接受下一个客户发送的下一个请求。

## 进程的概念

进程是应用程序中的一个动态执行，包含程序代码在内存中的映像以及进程所需的系统资源

System.Diagnostics下的Process类可以访问和管理当下系统中的进程

## 线程的概率

线程包括堆栈、CPU寄存器状态以及系统任务计划列表中的项

进程中的所有线程共享进程的虚拟地址空间和系统资源，如程序代码的内存和堆。

## 线程的建立与启动

```csharp
//假定需要编写一个文件压缩软件，用户点击压缩按钮后开始压缩指定的文件。因为整个压缩过程
//需要一定的时间才能完成，而用户此时还可以需要移动或缩放程序的窗口，甚至暂停或终止当前
//文件的压缩。
//因此需要一个单独线程来处理压缩过程。
Thread compressThread=new Thread(entryPoint);

//在C#应用程序中，Main()方法所在线程是.NET运行库开始执行的第一个线程，称为主线程。
//在一个应用程序中创建的用于执行一些工作任务的线程称为工作线程。
//Thread的构造方法需要一个参数，用于指定线程的入口——即线程开始执行的方法
public delegate void ParameterizedThreadStart(Object obj)
public delegate void ThreadStart();
static void DoCompress(){
    //压缩代码
}

ThreadStart entryPoint=new ThreadStart(DoCompress);

//线程创建后，并未获得系统资源。启动线程，即给线程分配除处理器之外的系统资源并执行各种
//安全性检查
compressThread.Start();

public void start()
//在调用该方法后，新线程并不是出于running状态，而是处于unstarted状态。
```

```csharp
//线程的挂起、恢复与终止

public void Suspend()
compressThread.Supend();//使线程处于阻塞状态


public vodi Resume()
compressThread.Rusume();//恢复被挂起的线程，使其进入就绪状态

//Suspend方法不一定会立即起作用。.NET允许要挂起的线程再执行几个指令，达到可以安全挂起的状态
//确保垃圾收集器执行正确的操作。

public void Abort()
compressThread.Abort();//终止线程，Windows永久删除该线程的所有数据，该线程不能重新启动
//Abort方法会在所影响的线程中产生一个ThreadAbortException异常，在finally快中进行
//资源清理并确保线程正在处理的数据处于有效状态
//在调用Abort方法前一定要判断线程是否被激活
if(myThread.IsAlive){
    myThread.Abort();
}


public void Join()
thread1.join()//当前线程进入阻塞状态，等待调用该方法的线程执行完毕

public static void Sleep(int millisecondsTimeout)
//使当前线程睡眠指定的时间，休眠完后线程变为就绪状态
```

## Thread类的常用属性

```csharp
CurrentThread
//获取当前正在运行的线程
Thread myOwnThread=Thread.CurrentThread;

IsAlive
//指示当前线程的执行状态，如果此线程已启动并且尚未正常终止，则为true；否则为false。

IsBackground
//指示该线程是否为后台线程。
//后台运行的线程在所哟前台线程都结束后会被自动终止，以防止出现程序无法退出的情况。

Name
//线程的名称

Priority
//指示线程的调度优先级
ThreadPriority.Highest//将线程安排在具有任何其他优先级的线程之前
AboveNormal//将线程安排在具有Highest优先级的线程之后，在具有Normal优先级的线程之前
Normal//将线程安排在具有AboveNormal优先级的线程之后，在具有BelowNormal优先级的线程之前。为线程的默认优先级
BelowNormal//将线程安排在具有Normal优先级的线程之后，在具有Lowest优先级的线程之前
Lowest//将线程安排在具有任何其他优先级的线程之后
```

## 给线程传递数据

```csharp
//使用带ParmaeterizedThreadStart委托参数的Thread构造函数
//创建一个定制类，把线程的方法定义为实例方法，这样就可以初始化实例的数据，然后启动线程
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Wrox.ProCSharp.Threading
{
    // 定义一个 MyThread 类，用于在多线程中处理数据
    public class MyThread
    {
        private string data; // 存储线程的数据

        // 构造函数，初始化数据
        public MyThread(string data)
        {
            this.data = data;
        }

        // 线程执行的主方法
        public void ThreadMain()
        {
            // 输出线程信息，展示线程运行时的数据
            Console.WriteLine("Running in a thread, data: {0}", data);
        }
    }

    // 定义一个结构体 Data，用于存储消息
    public struct Data
    {
        public string Message; // 存储消息的字段
    }

    // 主程序入口
    class Program
    {
        static void Main()
        {
            // 启动第一个线程，注释掉了部分代码
            // FirstThread();

            /* 
            // 创建并启动两个线程，分别设置线程优先级
            var t1 = new Thread(Prio);
            t1.Name = "First";

            var t2 = new Thread(Prio);
            t2.Name = "Second";
            t1.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start(); 
            */

            // 创建一个线程并指定线程执行的方法为 ThreadMain
            var t1 = new Thread(ThreadMain);
            /* 
            var 是 C# 中的隐式类型，编译器会根据初始化表达式推断出变量的类型
            var 只能用在局部变量，并且必须初始化。
            */

            t1.Name = "MyNewThread1"; // 设置线程名称
            t1.IsBackground = true;   // 设置为后台线程
            t1.Start(); // 启动线程
            Console.WriteLine("Main thread ending now...");

            // 给线程传递数据的第一种方式（注释掉的代码）
            /* 
            var d = new Data { Message = "Info" };
            var t2 = new Thread(ThreadMainWithParameters);
            t2.Start(d);
            */

            // 给线程传递数据的第二种方式（创建一个 MyThread 实例）
            /* 
            var obj = new MyThread("info");
            var t3 = new Thread(obj.ThreadMain);
            t3.Start();
            */

            // 主线程等待用户输入
            Console.ReadLine();
        }

        // 线程方法，打印当前线程的名称并循环输出数字
        static void Prio()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("{0}, {1}", Thread.CurrentThread.Name, i);
            }
        }

        // 线程方法，打印当前线程的名称和 ID，并休眠 3 秒
        static void ThreadMain()
        {
            Console.WriteLine("Thread {0} started", Thread.CurrentThread.Name);
            Thread.Sleep(3000); // 使当前线程休眠 3 秒
            Console.WriteLine("Running in the thread {0}, id: {1}.", Thread.CurrentThread.Name, Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Thread {0} completed", Thread.CurrentThread.Name);
        }

        // 线程方法，接收一个对象并打印其消息（通过参数传递）
        static void ThreadMainWithParameters(object o)
        {
            Data d = (Data)o; // 将传递的对象转换为 Data 类型
            Console.WriteLine("Running in a thread, received {0}", d.Message); // 输出传递的消息
        }

        // 第一个线程的示例：使用 Lambda 表达式创建并启动线程
        static void FirstThread()
        {
            // 使用 Lambda 表达式创建线程并启动
            new Thread(() => Console.WriteLine("Running in a thread, id: {0}", Thread.CurrentThread.ManagedThreadId)).Start();

            Console.WriteLine("This is the main thread, id: {0}", Thread.CurrentThread.ManagedThreadId); // 输出主线程 ID
        }
    }
}
```

## 后台线程

## 线程池

1、线程池是可以用来在后台执行多个任务的线程集合，使主线程可以自由地异步执行其它任务。

2、该类会在需要时候增减池中线程的个数，直到最大的线程数。

3、池中的最大线程数是可以配置的

4、如果有更多的工作要处理，而线程池中线程的使用也到了极限，最新的工作就要排队，必须等待线程完成其任务。

5、线程池中的每个线程都使用默认的堆栈大小，以默认的优先级运行，并处于多线程单元中。

6、如果线程池线程都始终保持繁忙，但队列中包含挂起的工作，则线程池将在一段时间之后创建另一个辅助线程。

7、线程池适合于执行一些需要多个线程的任务。使用线程池可以优化任务的执行过程，提高吞吐量；如果应用程序需要对线程进行特定的控制，则不适合使用线程池，需要创建并管理自己的线程。

8、每个进程都有且仅有一个线程池。当进程启动时，线程池不会自动创建。只有第一次将回调方法排入队列时才会创建线程池。

9、线程池通常用于服务器应用程序，每个传入请求都将分配给线程池中的一个线程，一次可以异步处理请求，不会占用主线程，也不会延迟后续请求的处理。

```csharp
ThreadPool//常用方法
void GetMaxThreads(out int workerThreads,out int completionPortThreads)
//检索可以同时处于活动状态的线程池请求的数目，
//所有大于此数目的请求将保持排队状态，知道线程池线程变为可用
bool QueueUserWorkItem(WaitCallback callback)
public delegate void WaitCallback(Object state)
//将方法排入队列以便执行，此方法在有线程池线程变得可用时执行。
//线程池收到请求后会从池中选择一个线程来调用该方法。
//如果线程池还没有运行，就会创建一个线程池，并启动第一个线程。
//如果线程池已经在运行，且有一个空闲线程来完成该任务就把该作业传递给这个线程。
```

### 使用线程池的限制

线程池中所有线程都是后台线程。如果进程中的所有前台线程都结束了，所有的后台线程就会停止。不能把线程池中的线程改为前台线程。

不能给线程池中的线程设置优先级或名称。

线程池中的线程只能用于时间较短的任务，如果线程要一直运行，就应使用Thread类创建一个线程。

```csharp
using System;
using System.Threading;

namespace Wrox.ProCSharp.Threading
{
    class Program
    {
        static void Main()
        {
            // 获取线程池中可用的最大工作线程数和 I/O 完成线程数
            int nWorkerThreads; // 用于存储工作线程数
            int nCompletionPortThreads; // 用于存储 I/O 完成线程数
            ThreadPool.GetMaxThreads(out nWorkerThreads, out nCompletionPortThreads);

            // 打印最大工作线程数和 I/O 完成线程数
            Console.WriteLine("Max worker threads: {0}, I/O completion threads: {1}",
                nWorkerThreads, nCompletionPortThreads);

            // 使用线程池执行 5 个任务
            for (int i = 0; i < 5; i++)
            {
                // 将任务队列到线程池中
                ThreadPool.QueueUserWorkItem(JobForAThread);
            }

            // 主线程等待 3 秒，让线程池中的线程完成任务
            Thread.Sleep(3000);

            // 保持控制台窗口打开，直到用户按下回车键
            Console.ReadLine();
        }

        // 用于线程池的工作方法
        static void JobForAThread(object state)
        {
            // 模拟线程执行的任务：循环打印当前线程的 ID 和计数
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("loop {0}, running inside pooled thread {1}",
                    i, Thread.CurrentThread.ManagedThreadId);
                // 模拟任务处理耗时
                Thread.Sleep(50);
            }
        }
    }
}
```

## 线程同步

```csharp
所谓同步，是指在某一时刻只有一个线程可以访问变量。
当一个线程写入一个变量，同时有其他线程读取或写入这个变量时，就应同步变量。

高级语言程序中的一条语句在最后编译好的汇编语言机器码中可能被翻译为多条语句，在操作系统调度时被划分到不同时间片中

message+="Hello world";

只要一条C#语句被翻译为多个本地代码命令，线程的时间片就有可能在执行该语句的进程中终止。

在C#中处理同步

通过对指定对象的加锁和解锁可以同步代码段的访问

System.Threading.Monitor类提供的静态方法

public static void Enter(Object obj)//在指定对象上获取排它锁

public static bool TryEnter(Object obj)//试图获取指定对象上的排它锁

public static bool TryEnter(Object obj,TimeSpan timeout)//可以指定一个等待被锁定的超时值

public static void TryEnter(Object obj,TimeSpand timeout,ref bool lockTaken)

public static void Exit(Object obj)//释放指定对象上的排它锁

public static bool Wait(Object obj)//释放对象上的锁并阻塞当前线程，知道它重新获取该锁。

public static void Pulse(Object obj)//通知等待队列中的线程锁定对象转态的更改。

public static void PulseAll(Object obj)//通知所有的等待线程对象状态的更改
```

## 线程同步的几个方法

```csharp
//1、使用Lock（锁定对象）{互斥代码块}实现互斥
lock(x){
    //使用x的语句
}

//2、用Mutex类实现互斥
WaitOne public virtual bool WaitOne()
//分配互斥体访问权，该方法只向一个线程授予对互斥体的独占访问权
ReleaseMutex
//如果一个线程获取了互斥体，则要获取该互斥体的第二个线程将被挂起，知道第一个线程用该方法释放该互斥体。


if(Mutex.WaitOne()){
    try{
        ...
    }finally{
        mutex.ReleaseMutex();
    }else{
        ...
    }
}

//3、在互斥代码块前使用Monitor.Enter(锁定对象)，
//在互斥代码块后使用Monitor.Exit(锁定对象)

public void some_method(){
    //获取锁
    Monitor.Enter(this);

    //处理需要同步的代码

    //释放锁
    Monitor.Exit(this);
}


public void some_method(){
    //获取锁
    Monitor.Enter(this);
    try{
    //处理需要同步的代码
    }catch{

    }
    //释放锁
    finally{
    Monitor.Exit(this);
    }
}

//4、Interlocked 见程序示例SynchronizationSamples
//常用方法
long Add(reg long locationl,long value)
//以原子操作的形式，相加两个64位整数并用两者的和替换第一个整数
long Increment(ref long location)
//递增指定的变量的值并存储结果
long Decrement(ref long location)
//递减指定的变脸的值并存储结果
long Exchange(ref long locationl,long value)
//将一个变量设置为指定的值并返回变量的初始值


public int State{
    get{
        return Interlocked.Increment(ref state);
    }
}

//5、Semphore类
//见程序SemphoreSample

//6、ReaderWriterLockSlim 见程序ReaderWriterSample
```

Sempore

```csharp
using System; // 引入基础命名空间，用于常见的系统操作。
using System.Diagnostics; // 引入调试命名空间，用于断言和调试相关功能。
using System.Threading; // 引入多线程命名空间，提供线程和同步工具支持。

namespace Wrox.ProCSharp.Threading // 定义程序所属的命名空间。
{
    class Program // 主程序类。
    {
        static void Main() // 程序入口点。
        {
            int threadCount = 6; // 定义线程数量为 6。
            int semaphoreCount = 4; // 定义信号量的初始计数器值为 4（允许最多 4 个线程同时访问资源）。
            var semaphore = new SemaphoreSlim(semaphoreCount, semaphoreCount); // 创建信号量，限制并发线程数为 4。
            var threads = new Thread[threadCount]; // 创建一个线程数组，用于存储线程。

            // 创建并启动 6 个线程。
            for (int i = 0; i < threadCount; i++)
            {
                threads[i] = new Thread(ThreadMain); // 将线程的执行方法设置为 ThreadMain。
                threads[i].Start(semaphore); // 启动线程，并将信号量作为参数传递。
            }

            // 等待所有线程执行完成。
            for (int i = 0; i < threadCount; i++)
            {
                threads[i].Join(); // 阻塞主线程，直到当前线程完成。
            }

            Console.WriteLine("All threads finished"); // 所有线程完成后打印消息。
            Console.ReadLine(); // 等待用户输入，防止程序结束。
        }

        static void ThreadMain(object o) // 线程执行的主方法。
        {
            SemaphoreSlim semaphore = o as SemaphoreSlim; // 将传递的参数转换为 SemaphoreSlim 类型。
            Trace.Assert(semaphore != null, "o must be a Semaphore type"); // 使用断言确保信号量参数不为空。

            bool isCompleted = false; // 定义一个标志变量，用于控制线程是否完成其任务。
            while (!isCompleted) // 循环直到任务完成。
            {
                // 尝试获取信号量，如果在 600 毫秒内未成功则超时。
                if (semaphore.Wait(600))
                {
                    try
                    {
                        // 成功获取信号量，输出当前线程锁定信号量的消息。
                        Console.WriteLine("Thread {0} locks the semaphore",
                              Thread.CurrentThread.ManagedThreadId);
                        Thread.Sleep(2000); // 模拟线程执行任务，睡眠 2 秒。
                    }
                    finally
                    {
                        // 确保任务完成后释放信号量，并打印释放信号量的消息。
                        semaphore.Release();
                        Console.WriteLine("Thread {0} releases the semaphore",
                           Thread.CurrentThread.ManagedThreadId);
                        isCompleted = true; // 设置标志变量为 true，表示任务完成。
                    }
                }
                else
                {
                    // 如果信号量获取超时，打印超时消息，并继续循环尝试。
                    Console.WriteLine("Timeout for thread {0}; wait again",
                       Thread.CurrentThread.ManagedThreadId);
                }
            }
        }
    }
}
```

ReaderWriterSample

```csharp
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Wrox.ProCSharp.Threading
{
    class Program
    {
        // 创建一个共享的整数列表，用于读写操作
        private static List<int> items = new List<int>() { 0, 1, 2, 3, 4, 5 };

        // 使用 ReaderWriterLockSlim 提供线程同步功能，允许多个读者同时访问数据，但只允许一个写者
        private static ReaderWriterLockSlim rwl = new
              ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);

        // 读线程方法
        static void ReaderMethod(object reader)
        {
            try
            {
                // 尝试获取读锁
                rwl.EnterReadLock();

                // 遍历共享列表并读取数据
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine("reader {0}, loop: {1}, item: {2}",
                          reader, i, items[i]);
                    Thread.Sleep(40); // 模拟耗时操作
                }
            }
            finally
            {
                // 确保在退出方法时释放读锁
                rwl.ExitReadLock();
            }
        }

        // 写线程方法
        static void WriterMethod(object writer)
        {
            try
            {
                // 循环尝试获取写锁，每次尝试的超时时间为50毫秒
                while (!rwl.TryEnterWriteLock(50))
                {
                    Console.WriteLine("Writer {0} waiting for the write lock",
                          writer);
                    // 显示当前的读者线程数
                    Console.WriteLine("current reader count: {0}",
                          rwl.CurrentReadCount);
                }

                // 获取写锁后，开始写操作
                Console.WriteLine("Writer {0} acquired the lock", writer);
                for (int i = 0; i < items.Count; i++)
                {
                    items[i]++; // 修改共享列表中的每个元素
                    Thread.Sleep(50); // 模拟耗时操作
                }
                Console.WriteLine("Writer {0} finished", writer);
            }
            finally
            {
                // 确保在退出方法时释放写锁
                rwl.ExitWriteLock();
            }
        }

        // 主方法
        static void Main()
        {
            // 创建 TaskFactory，用于创建任务
            var taskFactory = new TaskFactory(TaskCreationOptions.LongRunning, TaskContinuationOptions.None);

            // 定义一个包含6个任务的数组
            var tasks = new Task[6];

            // 启动写线程和读线程
            tasks[0] = taskFactory.StartNew(WriterMethod, 1); // 写线程1
            tasks[1] = taskFactory.StartNew(ReaderMethod, 1); // 读线程1
            tasks[2] = taskFactory.StartNew(ReaderMethod, 2); // 读线程2
            tasks[3] = taskFactory.StartNew(WriterMethod, 2); // 写线程2
            tasks[4] = taskFactory.StartNew(ReaderMethod, 3); // 读线程3
            tasks[5] = taskFactory.StartNew(ReaderMethod, 4); // 读线程4

            // 等待所有任务完成
            for (int i = 0; i < 6; i++)
            {
                tasks[i].Wait();
            }
        }
    }
}
```

## 任务Task

```csharp
//任务在后台使用ThreadPool
//可以定义连续的工作，在一个任务完成后需要执行什么工作
//可以在层次结构中安排任务，例如父任务可以创建新的子任务，这可以创建一种依赖关系


//启动任务
//可以使用TaskFactory类或Task类的构造函数和Start()方法

// 定义任务执行的方法
static void TaskMethod()
{
    // 输出任务运行信息
    Console.WriteLine("running in a task");
    Console.WriteLine("Task id: {0} {1}", 
        Task.CurrentId, // 当前任务的ID
        Thread.CurrentThread.ManagedThreadId); // 当前线程的托管线程ID
}

// 使用TaskFactory类创建并启动任务
TaskFactory tf = new TaskFactory();
// 使用TaskFactory的StartNew方法启动任务
Task t1 = tf.StartNew(TaskMethod);

// 通过任务(Task)的工厂方法(Task.Factory)启动任务
Task t2 = Task.Factory.StartNew(TaskMethod);
// 输出当前线程的托管线程ID
Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

// 使用Task类的构造函数创建任务
Task t3 = new Task(TaskMethod);
// 使用RunSynchronously方法启动任务
// 任务会在调用者的当前线程中运行，
// 调用者需要等待任务完成后才能继续执行
t3.RunSynchronously();

// 使用Task类构造函数创建任务并设置任务创建选项
// TaskCreationOptions.PreferFairness提示任务调度器尽量公平分配线程
Task t4 = new Task(TaskMethod, TaskCreationOptions.PreferFairness);
// 使用Start方法启动任务
t4.Start();


```

### TaskCreationOptions选项

### 连续的任务

通过任务，可以指定在任务完成后，应开始运行另一个特定任务。例如，一个使用前一个任务的结果的新任务，如果前一个任务失败了，这个任务就应执行一些清理工作。

连续处理程序有一个Task类型的参数。

```csharp
// 定义一个任务方法
static void DoOnFirst()
{
    // 输出当前任务ID，并模拟执行任务
    Console.WriteLine("doing some task {0}", Task.CurrentId);
    Thread.Sleep(3000); // 模拟任务耗时
}

// 定义在任务完成后执行的方法，接受一个Task对象作为参数
static void DoOnSecond(Task t)
{
    // 输出前置任务的ID
    Console.WriteLine("task {0} finished", t.Id);
    // 输出当前任务ID
    Console.WriteLine("this task id {0}", Task.CurrentId);
    // 模拟清理操作
    Console.WriteLine("do some cleanup");
    Thread.Sleep(3000); // 模拟任务耗时
}

// 创建一个任务 t1，执行 DoOnFirst 方法
Task t1 = new Task(DoOnFirst);

// 创建两个后续任务 t2 和 t3，当 t1 完成后分别执行 DoOnSecond 方法
Task t2 = t1.ContinueWith(DoOnSecond);
Task t3 = t1.ContinueWith(DoOnSecond);

// 在 t2 完成后创建后续任务 t4，执行 DoOnSecond 方法
Task t4 = t2.ContinueWith(DoOnSecond);


```

### 代码说明：

1. **`DoOnFirst` 方法**：这是主任务执行的内容，模拟一个耗时任务，打印任务ID。
2. **`DoOnSecond` 方法**：这是后续任务执行的内容，接受一个完成的任务作为参数，打印其ID并进行一些清理工作。
3. **任务关系**：
   - `t1` 是主任务，调用 `DoOnFirst`。
   - `t2` 和 `t3` 是 `t1` 的后续任务（continuations），当 `t1` 完成时，分别调用 `DoOnSecond`。
   - `t4` 是 `t2` 的后续任务，当 `t2` 完成时，调用 `DoOnSecond`。
4. **任务启动顺序**：
   - 创建任务时并未启动，需调用 `t1.Start()` 才能开始。
   - 任务完成后会自动触发后续任务，无需手动启动后续任务。

### 注意事项：

- 如果 `t1` 未启动（未调用 `t1.Start()`），后续任务 `t2` 和 `t3` 将不会执行。
- 任务间的依赖关系（`ContinueWith`）确保了任务的执行顺序。
- 为了提高效率，可使用异步机制或并行化任务。

### 父任务和子任务

一个任务在另一个任务内部创建，构成父子关系。

如果父任务在子任务之前结束，父任务的状态就显示为WaitingForChildrentoComplete。子任务也结束时，父任务的状态就显示为RanToCompletion

如果父任务使用TaskCreationOptions枚举中的DetachedFromParent创建子任务，以上就无效

取消父任务就会取消子任务

```csharp
// 定义一个方法，演示父任务和子任务的关系
static void ParentAndChild()
{
    // 创建一个父任务，执行 ParentTask 方法
    Task parent = new Task(ParentTask);

    // 启动父任务
    parent.Start();

    // 主线程休眠 2 秒，等待父任务开始执行
    Thread.Sleep(2000);

    // 输出父任务的当前状态
    Console.WriteLine(parent.Status); // 可能是 Running 或 WaitingForChildrenToComplete

    // 主线程再休眠 4 秒，等待父任务及其子任务的执行
    Thread.Sleep(4000);

    // 再次输出父任务的当前状态
    Console.WriteLine(parent.Status); // 最终状态可能是 RanToCompletion 或 Faulted
}

// 定义父任务的内容
static void ParentTask()
{
    // 输出当前任务的 ID
    Console.WriteLine("task id {0}", Task.CurrentId);

    // 创建一个子任务，执行 ChildTask 方法
    Task child = new Task(ChildTask);

    // 启动子任务
    child.Start();

    // 模拟父任务的其他工作
    Thread.Sleep(1000);

    // 输出父任务已启动子任务的信息
    Console.WriteLine("parent started child");

    // （可选）如果父任务执行时间更长，可以取消注释下行代码模拟
    // Thread.Sleep(3000);
}

// 定义子任务的内容
static void ChildTask()
{
    // 输出子任务的开始信息
    Console.WriteLine("child");

    // 模拟子任务的执行时间
    Thread.Sleep(5000);

    // 输出子任务完成信息
    Console.WriteLine("child finished");
}
d");
        }
      }

```

### **代码解释**：

1. **`ParentAndChild` 方法**:
   - 创建并启动父任务 `parent`。
   - 主线程使用 `Thread.Sleep` 模拟等待，期间两次输出父任务状态。
2. **`ParentTask` 方法**:
   - 定义父任务内容，包括创建并启动一个子任务 `child`。
   - 子任务 `ChildTask` 是独立的，与父任务运行在不同的线程中。
3. **`ChildTask` 方法**:
   - 子任务主要执行耗时操作（`Thread.Sleep` 模拟耗时），然后输出完成信息。

---

### **任务状态说明**：

- **`parent.Status`** 的可能值：
  1. **`Running`**：父任务正在执行。
  2. **`WaitingForChildrenToComplete`**：父任务已完成自身工作，但等待子任务完成。
  3. **`RanToCompletion`**：父任务及其所有子任务都已成功完成。
  4. **`Faulted`**：父任务或其子任务发生了未处理的异常。

---

### **改进建议**：

1. 使用 **`TaskCreationOptions.AttachedToParent`** 让子任务自动附加到父任务，从而形成完整的任务层级结构，避免显式管理子任务的生命周期：
   
   csharp
   
   复制代码
   
   `Task child = new Task(ChildTask, TaskCreationOptions.AttachedToParent);`

2. 结合 **异步方法** 和 **等待 (`await`)** 来替代 `Thread.Sleep`，提高代码的可读性和性能。

```csharp
// 导入必要的命名空间
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

// 定义命名空间
namespace TaskSamples
{
    // 定义主程序类
    class Program
    {
        // 主方法，程序入口
        static void Main()
        {
            // 调用并行任务示例方法
            //ParallelDemo();

            // 调用简单任务示例方法
             SimpleTask();

            // 输出主任务的 ID 和线程 ID
            Console.WriteLine("Main Task id: {0}, Main Thread id: {1}", Task.CurrentId, Thread.CurrentThread.ManagedThreadId);

            // 调用任务的延续（Continuation）示例方法
            // ContinuationTask();

            // 调用父子任务示例方法
            // ParentAndChild();

            // 调用带结果的任务示例方法
            // ResultsFromTasks();

            // 主线程等待以确保任务完成（示例用）
            // Thread.Sleep(5000);

            // 示例：循环创建并启动多个任务
            //for (int i = 0; i < 10; i++)
            //{
            //    Task t1 = new Task(o =>
            //    {
            //        Console.WriteLine("running in a task {0}, thread {1}", Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
            //        Thread.Sleep(500);
            //        Console.WriteLine("still running {0}", Thread.CurrentThread.ManagedThreadId);
            //    }, "data", TaskCreationOptions.None);

            //    // 启动任务
            //    t1.Start();
            //}

            // 防止主线程立即结束
            Console.ReadLine();
        }

        // 示例：带返回结果的任务
        static void ResultsFromTasks()
        {
            // 创建任务并指定输入参数类型
            var t1 = new Task<Tuple<int, int>>(TaskWithResult, Tuple.Create<int, int>(8, 3));

            // 启动任务
            t1.Start();

            // 阻塞等待任务完成，获取结果
            Console.WriteLine(t1.Result); // 输出任务的计算结果
            Console.WriteLine("result from task: {0} {1}", t1.Result.Item1, t1.Result.Item2);
        }

        // 执行带返回结果的任务方法
        static Tuple<int, int> TaskWithResult(object division)
        {
            // 将输入参数转换为元组
            Tuple<int, int> div = (Tuple<int, int>)division;

            // 计算商
            int result = div.Item1 / div.Item2;

            // 计算余数
            int reminder = div.Item1 % div.Item2;

            // 输出任务完成状态
            Console.WriteLine("task creates a result...");

            // 返回计算结果
            return Tuple.Create<int, int>(result, reminder);
        }

        // 示例：任务创建和启动方法
        static void SimpleTask()
        {
            TaskFactory tf = new TaskFactory(); // 创建任务工厂
            Task t1 = tf.StartNew(TaskMethod); // 使用任务工厂启动任务

            Task t2 = Task.Factory.StartNew(TaskMethod); // 使用任务的静态工厂方法启动任务

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

            Task t3 = new Task(TaskMethod); // 使用构造函数创建任务
            t3.RunSynchronously(); // 在调用线程同步运行任务

            Task t4 = new Task(TaskMethod, TaskCreationOptions.PreferFairness);
            t4.Start(); // 启动任务
        }

        // 示例：任务延续
        static void ContinuationTask()
        {
            Task t1 = new Task(DoOnFirst); // 创建初始任务
            Task t2 = t1.ContinueWith(DoOnSecond); // 正常完成后执行
            Task t3 = t1.ContinueWith(DoOnSecond); // 创建另一个延续任务
            Task t4 = t2.ContinueWith(DoOnSecond); // 在第二个任务之后延续
            Task t5 = t1.ContinueWith(DoOnError, TaskContinuationOptions.OnlyOnFaulted); // 仅在任务出错时执行

            t1.Start(); // 启动初始任务
            Thread.Sleep(5000); // 主线程等待延续任务完成
        }

        // 初始任务的执行方法
        static void DoOnFirst()
        {
            Console.WriteLine("doing some task {0}", Task.CurrentId);
            Thread.Sleep(3000); // 模拟任务执行
        }

        // 延续任务的执行方法
        static void DoOnSecond(Task t)
        {
            Console.WriteLine("task {0} finished", t.Id);
            Console.WriteLine("this task id {0}", Task.CurrentId);
            Console.WriteLine("do some cleanup");
            Thread.Sleep(3000); // 模拟清理
        }

        // 错误处理任务方法
        static void DoOnError(Task t)
        {
            Console.WriteLine("task {0} had an error!", t.Id);
            Console.WriteLine("my id {0}", Task.CurrentId);
            Console.WriteLine("do some cleanup");
        }

        // 示例：父子任务
        static void ParentAndChild()
        {
            TaskFactory factory = new TaskFactory(); // 创建任务工厂

            // 创建并启动父任务
            var t1 = factory.StartNew(() =>
            {
                Console.WriteLine("parent task {0}", Task.CurrentId);

                // 创建附属于父任务的子任务
                factory.StartNew(() =>
                {
                    Console.WriteLine("child task {0}", Task.CurrentId);
                    Thread.Sleep(2000); // 模拟子任务执行
                    Console.WriteLine("finished child");
                }, TaskCreationOptions.AttachedToParent);

                Console.WriteLine("finished parent");
            });

            t1.Wait(); // 阻塞主线程，等待任务完成
        }

        // 示例：并行任务
        static void ParallelDemo()
        {
            Parallel.For<string>(0, 20, () => "abcd",
                (x, ls, str) =>
                {
                    Console.WriteLine(x); // 输出当前索引
                    return "defg"; // 返回中间状态
                },
                (str) =>
                {
                    Console.WriteLine("action {0}", str); // 输出最终状态
                });
        }

        // 任务执行内容
        static void TaskMethod()
        {
            Console.WriteLine("running in a task");
            Console.WriteLine("Task id: {0}, Thread id: {1}", Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
        }
    }
}
ne("running in a task");
            Console.WriteLine("Task id: {0}, Thread id: {1}", Task.CurrentId, Thread.CurrentThread.ManagedThreadId);
        }
    }
}

```

### **主要功能**

1. **任务创建**：通过 `Task` 和 `TaskFactory` 创建任务。
2. **延续任务**：任务完成后可设置继续执行的任务，支持不同触发条件。
3. **父子任务**：通过 `TaskCreationOptions.AttachedToParent` 建立父子任务关系。
4. **任务返回结果**：使用泛型任务返回计算结果。
5. **并行任务**：通过 `Parallel` 执行并行操作。

---

### **改进建议**

1. **异步编程**：使用 `async` 和 `await` 替代阻塞式等待。
2. **任务异常处理**：捕获任务中未处理的异常，确保代码健壮性。
3. **日志记录**：添加日志以便更好地追踪任务的执行。



## 异步委托

委托是使用线程池完成异步任务

轮询

等待句柄

使用与IAsyncResult相关的等待句柄

使用AyncWaitHandle属性可以访问等待句柄，这个属性返回一个WaitHandle类型的对象，可以等待委托线程完成任务

异步回调

这段代码主要展示了如何使用 .NET 异步编程模型（APM，Asynchronous Programming Model）来执行异步操作。以下是该代码的详细分析：

---

### **核心功能概述**

1. **同步调用 (`TakesAWhile`)**：
   
   - `TakesAWhile` 是一个模拟耗时操作的函数，接收两个参数：
     - `data`：初始值。
     - `ms`：模拟的延迟时间（毫秒）。
   - 返回处理后的结果（`data + 1`）。

2. **异步调用 (`BeginInvoke` 和 `EndInvoke`)**：
   
   - `BeginInvoke`：开始异步操作。
   - `EndInvoke`：等待异步操作完成并获取结果。
   - 提供了多种异步调用方式：
     - **轮询**：定期检查异步任务是否完成。
     - **等待句柄**：通过 `WaitOne` 方法等待异步操作完成。
     - **回调函数**：当异步操作完成时调用指定的回调方法。
     - **Lambda 表达式**：通过匿名方法处理异步结果。

---

### **代码功能分析**

#### **同步调用**

```csharp
// TakesAWhile(1, 3000);
```

- 直接调用 `TakesAWhile` 方法。主线程会被阻塞，直到 `TakesAWhile` 完成。

---

#### **异步调用方式**

##### **1. 轮询 (Polling)**

```csharp
IAsyncResult ar = d1.BeginInvoke(1, 3000, null, null);
while (!ar.IsCompleted)
{
    Console.Write(".");
    Thread.Sleep(50); // 模拟主线程执行其他任务
}
int result = d1.EndInvoke(ar);
Console.WriteLine("result: {0}", result);
```

- **步骤**：
  1. 异步开始：`BeginInvoke` 开启任务。
  2. 主线程轮询：通过检查 `ar.IsCompleted` 来判断任务是否完成。
  3. 获取结果：任务完成后调用 `EndInvoke`。
- **特点**：
  - 主线程保持运行，但效率较低（频繁轮询）。

---

##### **2. 等待句柄 (Wait Handle)**

```csharp
IAsyncResult ar = d1.BeginInvoke(1, 3000, null, null);
while (true)
{
    Console.Write(".");
    if (ar.AsyncWaitHandle.WaitOne(50, false))
    {
        Console.WriteLine("Can get the result now");
        break;
    }
}
int result = d1.EndInvoke(ar);
Console.WriteLine("result: {0}", result);
```

- **步骤**：
  1. 异步开始：`BeginInvoke` 开启任务。
  2. 主线程通过 `ar.AsyncWaitHandle.WaitOne` 等待，避免频繁轮询。
  3. 获取结果：任务完成后调用 `EndInvoke`。
- **特点**：
  - 使用 `WaitHandle` 更加高效。

---

##### **3. 回调函数 (Async Callback)**

```csharp
d1.BeginInvoke(1, 3000, TakesAWhileCompleted, d1);
for (int i = 0; i < 100; i++)
{
    Console.Write(".");
    Thread.Sleep(50); // 模拟主线程其他任务
}
```

- **步骤**：
  1. 异步开始：`BeginInvoke` 并指定回调函数。
  2. 回调函数 `TakesAWhileCompleted` 在任务完成时被自动调用。
  3. 在回调函数中调用 `EndInvoke` 获取结果。

```csharp
static void TakesAWhileCompleted(IAsyncResult ar)
{
    if (ar == null) throw new ArgumentNullException("ar");

    TakesAWhileDelegate d1 = ar.AsyncState as TakesAWhileDelegate;
    Trace.Assert(d1 != null, "Invalid object type");

    int result = d1.EndInvoke(ar);
    Console.WriteLine("result: {0}", result);
}
```

- **特点**：
  - 回调函数运行在委托线程中，而非主线程。

---

##### **4. Lambda 表达式**

```csharp
d1.BeginInvoke(1, 3000, arr =>
{
    int r = d1.EndInvoke(arr);
    Console.WriteLine("result: {0}", r);
}, null);
for (int i = 0; i < 100; i++)
{
    Console.Write(".");
    Thread.Sleep(50);
}
```

- **特点**：
  - 使用 Lambda 表达式简化代码。
  - 回调逻辑更直观。

---

### **优缺点比较**

| 异步调用方式     | 优点            | 缺点                 |
| ---------- | ------------- | ------------------ |
| 轮询         | 简单易懂，适合小任务    | 性能较低，频繁轮询消耗 CPU 资源 |
| 等待句柄       | 避免频繁轮询，更高效    | 等待时间设置需平衡          |
| 回调函数       | 自动触发回调，主线程更灵活 | 代码复杂，可能引发线程安全问题    |
| Lambda 表达式 | 代码简洁，逻辑清晰     | 与回调函数一样的线程安全问题     |

---

### **适用场景**

1. **轮询和等待句柄**：
   
   - 适用于较简单的异步任务。
   - 避免主线程复杂的线程安全问题。

2. **回调函数和 Lambda**：
   
   - 适用于需要异步任务完成后执行特定操作的场景。
   - 回调逻辑更复杂，但可以实现更高效的并发处理。

---

### **总结**

该代码演示了 .NET 异步编程模型的多种使用方式，可根据任务复杂度和性能需求选择适合的实现方式。在现代 .NET 开发中，推荐使用 `async/await` 替代 APM，简化代码逻辑并提升可读性。





以下是逐行注释的代码，帮助理解每一部分的功能和作用：

```csharp
using System; // 引入基础命名空间，提供基础类型和控制台功能
using System.Collections.Generic; // 引入泛型集合的命名空间
using System.Text; // 提供字符串操作相关功能
using System.Threading; // 提供线程和多线程相关功能
using System.Diagnostics; // 提供调试和跟踪相关功能

namespace Wrox.ProCSharp.Threading // 定义一个命名空间，用于组织代码
{
    class Program // 定义主类
    {
        // 定义一个耗时方法 TakesAWhile，模拟长时间操作
        static int TakesAWhile(int data, int ms)
        {
            Console.WriteLine("TakesAWhile started"); // 打印开始信息
            Thread.Sleep(ms); // 模拟耗时操作，休眠指定毫秒
            Console.WriteLine("TakesAWhile completed"); // 打印完成信息
            return ++data; // 返回结果，数据加1
        }

        // 定义一个委托，匹配 TakesAWhile 的方法签名
        public delegate int TakesAWhileDelegate(int data, int ms);

        static void Main() // 程序入口
        {
            // 创建 TakesAWhile 的委托实例
            TakesAWhileDelegate d1 = TakesAWhile;

            // 同步调用方式，已注释掉
            // TakesAWhile(1, 3000);

            // 1. 轮询方式 (Polling)
            IAsyncResult ar = d1.BeginInvoke(1, 3000, null, null); // 异步调用 TakesAWhile，返回异步结果 IAsyncResult
            while (!ar.IsCompleted) // 检查是否完成
            { 
                Console.Write("."); // 模拟其他工作
                Thread.Sleep(50); // 模拟短暂延时
            }
            int result = d1.EndInvoke(ar); // 阻塞等待异步操作完成，并获取结果
            Console.WriteLine("result: {0}", result); // 打印结果

            // 2. 等待句柄方式 (Wait Handle)，已注释掉
            // IAsyncResult ar = d1.BeginInvoke(1, 3000, null, null);
            // while (true)
            // {
            //    Console.Write(".");
            //    if (ar.AsyncWaitHandle.WaitOne(50, false)) // 等待异步句柄信号
            //    {
            //        Console.WriteLine("Can get the result now"); // 当可以获取结果时打印提示
            //        break;
            //    }
            // }
            // int result = d1.EndInvoke(ar);
            // Console.WriteLine("result: {0}", result);

            // 3. 异步回调方式 (Async Callback)，已注释掉
            // d1.BeginInvoke(1, 3000, TakesAWhileCompleted, d1);
            // for (int i = 0; i < 100; i++)
            // {
            //    Console.Write(".");
            //    Thread.Sleep(50);
            // }

            // 使用 Lambda 表达式实现异步回调
            d1.BeginInvoke(1, 3000, arr => 
            {
                int r = d1.EndInvoke(arr); // 获取结果
                Console.WriteLine("result: {0}", r); // 打印结果
            },
            null); // 无状态对象

            // 模拟主线程的其他工作
            for (int i = 0; i < 100; i++)
            {
                Console.Write("."); // 打印进度符号
                Thread.Sleep(50); // 模拟短暂延时
            }
        }

        // 回调方法，处理异步结果
        static void TakesAWhileCompleted(IAsyncResult ar)
        {
            if (ar == null) throw new ArgumentNullException("ar"); // 检查参数有效性

            TakesAWhileDelegate d1 = ar.AsyncState as TakesAWhileDelegate; // 从异步状态中获取委托实例
            Trace.Assert(d1 != null, "Invalid object type"); // 确保对象类型正确

            int result = d1.EndInvoke(ar); // 获取异步操作结果
            Console.WriteLine("result: {0}", result); // 打印结果
        }
    }
}
```

### 代码解析重点：

1. **同步与异步：**
   
   - 同步调用会阻塞主线程直到任务完成。
   - 异步调用允许主线程继续运行，而任务在后台执行。

2. **异步调用模式：**
   
   - **轮询 (Polling)：** 主线程通过检查 `IAsyncResult.IsCompleted` 判断任务是否完成。
   - **等待句柄 (Wait Handle)：** 使用 `AsyncWaitHandle.WaitOne` 等待异步完成信号。
   - **异步回调 (Async Callback)：** 使用回调函数处理任务完成后的逻辑。

3. **线程安全：**
   
   - 回调方法在异步线程中执行，应避免操作非线程安全资源。

4. **Lambda 表达式：**
   
   - 简化代码，内嵌异步结果处理逻辑，代替传统回调方法。
