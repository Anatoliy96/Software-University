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
    }
}
