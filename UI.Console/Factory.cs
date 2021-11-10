using Core;

using System.Configuration;
using System.Reflection;

namespace UI.Console;
public class Factory
{
    private static object lockObject = new object();

    public static IKisi CreateKisi()
    {
        lock (lockObject)
        {
            string assemblyName = ConfigurationManager.AppSettings["Kisi.AssemblyName"];
            string className = ConfigurationManager.AppSettings["Kisi.ClassName"];

            if (String.IsNullOrEmpty(assemblyName) || String.IsNullOrEmpty(className))
                throw new ApplicationException("Null değer!");

            Assembly assembly = Assembly.LoadFrom(assemblyName);
            var asmKisi = assembly.CreateInstance($"{assemblyName}.{className}");
            var kisi = asmKisi as IKisi;

            if (kisi == null)
                throw new ApplicationException($"IKisi örneği oluşturamadım {assemblyName}/{className}");

            return kisi;
        }
    }
}