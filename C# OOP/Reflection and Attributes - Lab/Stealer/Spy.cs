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
        public string StealFieldInfo(string investigatedClass, params string[] requstedFields)
        {
            Type classType = Type.GetType(investigatedClass);
            FieldInfo[] fields = classType.GetFields(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

            StringBuilder sb = new StringBuilder();

            object classInstance = Activator.CreateInstance(classType, new object[] { });
            sb.AppendLine($"Class under investigation: {investigatedClass}");

            foreach (FieldInfo field in fields.Where(f => requstedFields.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString().TrimEnd();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);
            FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            MethodInfo[] publicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] privateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            foreach (FieldInfo field in fields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach (MethodInfo publicMethod in publicMethods.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{publicMethod} have to be public!");
            }
            foreach (MethodInfo NonPublicMethod in privateMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{NonPublicMethod} have to be private!");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
