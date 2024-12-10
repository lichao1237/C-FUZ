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



第四章 WinForm程序设计

<style>
</style>

1、掌握控件Button、TextBox、RadioButton、CheckBox、RichTextBox、ListBox、ComboBox、TreeView、ListView、PictureBox、菜单栏、工具栏、状态栏、OpenFileDialog、SaveFileDialog、FontDialog、ColorDialog

2、掌握事件处理过程
