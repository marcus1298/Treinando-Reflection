using System;
using System.Reflection;

class Program
{
    // Método que lista as propriedades e métodos de um objeto genérico
    static void ListPropertiesAndMethods(object obj)
    {
        Type type = obj.GetType();

        // Lista as propriedades
        Console.WriteLine("Propriedades:");
        PropertyInfo[] properties = type.GetProperties();
        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine("  " + property.Name);
        }

        // Lista os métodos
        Console.WriteLine("Métodos:");
        MethodInfo[] methods = type.GetMethods();
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine("  " + method.Name);
        }
    }

    // Método que cria uma instância de um objeto genérico
    static object CreateInstance(Type type)
    {
        return Activator.CreateInstance(type);
    }

    static void Main(string[] args)
    {
        // Cria uma instância de um objeto
        MyClass myObject = new MyClass();

        // Lista as propriedades e métodos do objeto
        ListPropertiesAndMethods(myObject);


        MyOtherClass myOtherObject = (MyOtherClass)CreateInstance(typeof(MyOtherClass));
    }
}

class MyClass
{
    public int MyProperty { get; set; }
    public void MyMethod(string arg) { }
}

class MyOtherClass
{
    public string MyOtherProperty { get; set; }
    public void MyOtherMethod() { }
}