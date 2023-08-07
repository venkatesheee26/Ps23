using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_22
{
    public class Mapper
    {
        public static void MapProperties(Source source, Destination destination)
        {
            // Get the types of Source and Destination classes
            Type sourceType = typeof(Source);
            Type destType = typeof(Destination);

            // Get all properties of the Source class
            PropertyInfo[] sourceProperties = sourceType.GetProperties();

            // Loop through the properties and check if they exist in the Destination class
            foreach (PropertyInfo sourceProperty in sourceProperties)
            {
                PropertyInfo destProperty = destType.GetProperty(sourceProperty.Name);
                if (destProperty != null && destProperty.CanWrite)
                {
                    // Get the value of the property from Source and set it in Destination
                    object value = sourceProperty.GetValue(source);
                    destProperty.SetValue(destination, value);
                }
            }
        }
    }

}
