using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DerekBanasCSharpTut
{
    [Serializable()]
    public class Animal22: ISerializable
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double AnimalID { get; set; } = 1;
        public Animal22(string name, double height, double weight)
        {
            Name = name;
            Height = height;
            Weight = weight;
        }
        public Animal22()
        {

        }
        public override string ToString()
        {
            return String.Format("{0} weighs {1}lbs and  {2}inches tall",
                Name, Weight, Height);
        }
        //serialize
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Height", Height);
            info.AddValue("Weight", Weight);
        }
        //deserialize
        public Animal22(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Weight = (double)info.GetValue("Weight", typeof(double));
            Height = (double)info.GetValue("Height", typeof(double));
        }
    }
    
}
