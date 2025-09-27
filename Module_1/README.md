# Chapter 1.01 - Introduction to C#
C# is a general-purpose, type-safe, object-oriented programming language created under the leadership of Anders Hejlsberg. Its focus is on programmer productivity by balancing simplicity, expressiveness, and performance. C# is platform-neutral and works across multiple runtimes.  


# Chapter 1.02 - Object Orientation in C#
## 1. Encapsulation  
- Encapsulation is about defining a clear boundary around an object to separate its public behavior from its internal implementation details.  
- This separation helps developers manage complexity by ensuring that changes inside an object do not ripple through the entire program.  
- External code interacts with the object only through its public interface, maintaining consistency and predictability.  

## 2. Unified Type System  
- C# uses a unified type system, where all entities, including primitive types such as integers and characters, share a common base type (object).  
- This allows uniform operations across all types.  
- For example, every type can be converted to a string via the `ToString()` method.  
- The unified system makes C# more consistent and reduces the distinction between user-defined and built-in types.  

## 3. Classes and Interfaces  
- **Classes**: The traditional building blocks of object-oriented programming that encapsulate both state (fields) and behavior (methods).  
- **Interfaces**: Define behavior without state. They act as contracts specifying what a type should do, not how it should do it.  
- Interfaces enable multiple inheritance of behavior in C#.  
- They also enforce a separation between specification and implementation, promoting flexibility and clean design.  

## 4. Function Members in C#  
- C# goes beyond just methods by introducing multiple kinds of function members:  
  - **Methods**: Perform actions and contain the logic of an object.  
  - **Properties**: Encapsulate state by wrapping fields with controlled accessors (`get` and `set`). Example: a button’s `Color` or a label’s `Text`.  
  - **Events**: Provide a mechanism for signaling and responding to state changes. They are central in GUI programming and event-driven systems.  
- This expansion of function members makes C# more expressive than a strict object-oriented model where only methods exist.  

## 5. Functional Programming Influences  
- Although primarily object-oriented, C# incorporates features from functional programming, enhancing its flexibility:  
  - **Delegates**: Allow functions to be treated as values, enabling them to be passed around like variables.  
  - **Lambda Expressions**: Support inline, anonymous functions that can capture surrounding variables, encouraging a declarative style.  
  - **Immutability Support**: Through `record`s, C# makes it easy to define immutable, read-only data structures, aligning with the principles of functional programming.  
  - **Query Expressions (LINQ)**: Provide a declarative way to work with collections, similar to SQL, and enable list and reactive programming patterns.  


# Chapter 1.03 - Type Safety in C#
## 1. What Type Safety Means in C#  
- C# enforces the idea that instances of a type can only interact through defined protocols.  
- This ensures that the internal state of each type remains consistent.  
- Example: You cannot attempt to use a string as though it were an integer unless you explicitly convert it.  
- This strict enforcement avoids mistakes that are common in loosely typed languages where type mismatches often slip into runtime.  

## 2. Static Typing  
- C# primarily uses static typing, which means that type rules are checked at compile time, before the program even runs.  
- **Advantages of static typing**:  
  - Error prevention early in development.  
  - Improved tooling support (e.g., IntelliSense).  
  - Easier large-scale development.  

## 3. Runtime Type Safety  
- Even after compilation, C# enforces type safety at runtime.  
- The Common Language Runtime (CLR) ensures that objects are only accessed in ways that respect their type definitions.  
- This double layer of safety—compile-time and runtime—makes programs more predictable and resilient.  

## 4. Strong Typing  
- C# is also a strongly typed language.  
- Type rules are enforced strictly.  
- Example: A method that requires an `int` cannot accept a `float` without an explicit cast.  
- Strong typing prevents unintended conversions that might otherwise cause subtle bugs.  

## 5. Limited Dynamic Typing  
- C# provides the `dynamic` keyword for flexibility when compile-time type information is unavailable.  
- Code using `dynamic` is type-checked at runtime.  
- Useful for interop scenarios (e.g., COM, scripting engines).  
- Use cautiously due to bypassing compile-time checks.  

## 6. Benefits of Type Safety  
- **Reliability**: Avoids type mismatches.  
- **Maintainability**: Easier to refactor code safely.  
- **Refactoring support**: IDEs can track all references.  
- **Scalability**: Safer large-scale development.  


# Chapter 1.04 - Memory Management
## 1. Automatic Memory Management  
- C# delegates memory allocation and cleanup to the CLR, using a garbage collector (GC).  
- Objects are created with `new`, and the runtime manages their lifetimes.  
- When no longer referenced, the GC reclaims their memory.  

## 2. Garbage Collection in Detail  
- The GC runs periodically.  
- It examines the heap to identify memory that is no longer accessible.  
- Memory is reclaimed and reused.  
- GC is non-deterministic but optimized for performance.  

## 3. Elimination of Manual Deallocation  
- Unlike C++, C# does not require `delete`.  
- Reduces risks of memory leaks and invalid pointer errors.  

## 4. Pointers in C#  
- Allowed only in `unsafe` code blocks.  
- Useful for performance-critical or low-level tasks.  
- Most C# applications avoid direct pointer manipulation.  

## 5. Special Cases and Performance Considerations  
- Use `struct`s to reduce GC pressure.  
- Use object pooling in high-frequency object scenarios.  
- Use `IDisposable` + `using` for unmanaged resources.  

## 6. Advantages of Automatic Memory Management  
- **Safety**: Prevents manual memory handling errors.  
- **Productivity**: Focus on logic, not memory.  
- **Consistency**: Fewer crashes from invalid memory access.  


# Chapter 1.05 - Platform Support
## 1. Cross-Platform Capabilities  
- Supported platforms:  
  - Windows  
  - macOS  
  - Linux  
  - Android & iOS (.NET MAUI)  
  - Web Browsers (via Blazor)  
  - Windows 10+ devices (Xbox, HoloLens)  

## 2. Runtimes for Platform-Specific Needs  
- Examples of runtimes:  
  - ASP.NET (.NET 8)  
  - Windows Desktop (.NET 8)  
  - WinUI 3 (.NET 8)  
  - MAUI (.NET 8)  
  - .NET Framework (legacy)  

## 3. Self-Contained Deployment  
- Avoids dependency on a system-installed runtime.  
- Application includes its own runtime bundle.  

## 4. Specialized and Niche Runtimes  
- Unity (game dev)  
- UWP (legacy Windows 10+ runtime)  
- .NET Micro Framework (embedded devices)  
- SQL Server CLR Integration (in-database C# code)  

## 5. Why Platform Support Matters  
- **Code Reusability**  
- **Investment Protection**  
- **Future Readiness**  


# Chapter 1.06 - CLRs, BCLs, and Runtimes
## 1. Common Language Runtime (CLR)  
- Core execution engine for .NET languages.  
- Responsibilities:  
  - Garbage collection  
  - Exception handling  
  - Type safety  
  - JIT and AOT compilation  
- **Managed Code vs Native Code**:  
  - C# compiles to Intermediate Language (IL)  
  - CLR compiles IL to native machine code  
- **Metadata and Reflection**:  
  - Assemblies include metadata  
  - Reflection allows runtime type inspection  

## 2. Base Class Library (BCL)  
- Provides common features:  
  - Collections  
  - I/O  
  - String and text processing  
  - XML/JSON  
  - Networking  
  - Concurrency (Tasks, async/await)  

## 3. Runtimes  
- Structure:  
  - CLR → execution  
  - BCL → common libraries  
  - App Layer → specialized frameworks (ASP.NET, MAUI, etc.)  
- Examples:  
  - ASP.NET (.NET 8)  
  - WinUI 3  
  - .NET Framework  
  - Unity  
  - UWP  
  - .NET Micro Framework  

## 4. Deployment Considerations  
- Use **self-contained deployments** to include required runtime and avoid installation issues.  


# Chapter 1.07 - Major Runtime Options
## 1. .NET 8 (Flagship Runtime)  
- Cross-platform successor to .NET Core  
- Key features:  
  - Unified application model  
  - Self-contained deployment  
  - Not bundled with OS  
- Compatibility:  
  - Backward-compatible with .NET Core / 5 / 6 / 7  
  - Not compatible with legacy .NET Framework  

## 2. Windows Desktop and WinUI 3  
- **Windows Forms / WPF**: Mature, classic UI frameworks  
- **WinUI 3**: Modern UI for Windows desktop (via Windows App SDK)  

## 3. MAUI (Multi-platform App UI)  
- Cross-platform mobile + desktop framework  
- Targets: Android, iOS, Windows, macOS  
- Unified project structure  
- **Alternative**: Avalonia (open-source WPF-style cross-platform framework)  

## 4. .NET Framework (Legacy Runtime)  
- Windows-only, tightly integrated  
- Last version: 4.8  
- Still supported but frozen  
- Not forward-compatible with .NET 5/6/7/8 without migration  

## 5. Niche Runtimes  
- **Unity**: Game engine  
- **UWP**: Legacy Windows Store model  
- **.NET Micro Framework**: Embedded systems  
- **SQL Server CLR Integration**: In-database C# execution  

## 6. Deployment Models  
- **Framework-dependent**: Requires external runtime  
- **Self-contained**: Ships with included runtime  


# Chapter 1.08 - A Brief History of C# Versions
- **C# 12** (with .NET 8): Collection expressions, primary constructors, default lambda parameters, aliasing types, inline arrays  
- **C# 11**: Raw strings, UTF-8 literals, list patterns, required members, static abstract interface members  
- **C# 10**: File-scoped namespaces, global `using`, record structs, lambda improvements  
- **C# 9**: Top-level statements, `init`-only setters, records, enhanced pattern matching  
- **C# 8**: Indices/ranges, nullable references, async streams, default interface methods  
- **C# 7.x**: Tuples, pattern matching, `out` variables, local functions  
- **C# 6**: Null-conditional, string interpolation, `nameof`, expression-bodied members  
- **C# 5**: `async`/`await`  
- **C# 4**: `dynamic`, named/optional parameters  
- **C# 3**: LINQ, lambdas, anonymous types  
- **C# 2**: Generics, nullable types, iterators  

