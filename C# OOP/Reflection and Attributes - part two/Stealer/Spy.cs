using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string name, string[] fieldsToInvestigate)
        {
            Type type = typeof(Hacker);

            FieldInfo[] fields = type.GetFields((BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static));

            StringBuilder stringBuilder = new StringBuilder();
            object classInstace = Activator.CreateInstance(type, new object[] { });

            stringBuilder.AppendLine($"Class under investigation: {name}");
            foreach (FieldInfo field in fields.Where(f => fieldsToInvestigate.Contains(f.Name)))
            {
                stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstace)}");
            }

            return stringBuilder.ToString().TrimEnd();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);

            FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
            MethodInfo[] publicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] privateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (FieldInfo field in fields)
            {
                stringBuilder.AppendLine($"{field.Name} must be private!");
            }

            foreach (MethodInfo method in publicMethods.Where(m => m.Name.StartsWith("get")))
            {
                stringBuilder.AppendLine($"{method.Name} have to be public!");
            }

            foreach (MethodInfo method in privateMethods.Where(m => m.Name.StartsWith("set")))
            {
                stringBuilder.AppendLine($"{method.Name} have to be private!");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
