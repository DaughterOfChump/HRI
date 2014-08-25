using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

//////////////////////////////////////////////////
/////    AUTOGENERATED MESSAGE DEFINITION    /////
//////////////////////////////////////////////////
/////         DO NOT MODIFY BY HAND!         /////
//////////////////////////////////////////////////

namespace ROS_CS
{
    namespace geometry_msgs
    {
        public class Point32 : ROS_CS.Core.BaseMessage
        {
            public readonly string typeID = "Point32";
            public readonly string md5sum = "cc153912f1453b708d221682bc23d9ac";
            public float x;
            public float y;
            public float z;

            public Point32 ()
            {
                x = 0.0f;
                y = 0.0f;
                z = 0.0f;
            }

            public override string ToString ()
            {
                return ROS_CS.Core.PrettyPrinter.PrettyPrint(ToStringRaw());
            }

            public override string ToStringRaw ()
            {
                string string_rep = typeID + ":\n";
                string_rep += "x: " + Convert.ToString(x) + "\n";
                string_rep += "y: " + Convert.ToString(y) + "\n";
                string_rep += "z: " + Convert.ToString(z) + "\n";
                return string_rep;
            }

            public override void Serialize(MemoryStream stream)
            {
                System.Byte[] x_bytes = BitConverter.GetBytes(x);
                stream.Write(x_bytes, 0, x_bytes.Length);
                System.Byte[] y_bytes = BitConverter.GetBytes(y);
                stream.Write(y_bytes, 0, y_bytes.Length);
                System.Byte[] z_bytes = BitConverter.GetBytes(z);
                stream.Write(z_bytes, 0, z_bytes.Length);
            }

            public override int Deserialize(System.Byte[] serialized)
            {
                return Deserialize(serialized, 0);
            }

            public override int Deserialize(System.Byte[] serialized, int startIndex)
            {
                int curIndex = startIndex;
                x = BitConverter.ToSingle(serialized, curIndex);
                curIndex += BitConverter.GetBytes(x).Length;
                y = BitConverter.ToSingle(serialized, curIndex);
                curIndex += BitConverter.GetBytes(y).Length;
                z = BitConverter.ToSingle(serialized, curIndex);
                curIndex += BitConverter.GetBytes(z).Length;
                return (curIndex - startIndex);
            }

        }
    }
}
