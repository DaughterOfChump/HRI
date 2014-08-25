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
    namespace trajectory_msgs
    {
        public class MultiDOFJointTrajectoryPoint : ROS_CS.Core.BaseMessage
        {
            public readonly string typeID = "MultiDOFJointTrajectoryPoint";
            public readonly string md5sum = "3ebe08d1abd5b65862d50e09430db776";
            public List<geometry_msgs.Transform> transforms;
            public List<geometry_msgs.Twist> velocities;
            public List<geometry_msgs.Twist> accelerations;
            public ROS_CS.Core.Duration time_from_start;

            public MultiDOFJointTrajectoryPoint ()
            {
                transforms = new List<geometry_msgs.Transform>();
                velocities = new List<geometry_msgs.Twist>();
                accelerations = new List<geometry_msgs.Twist>();
                time_from_start = new ROS_CS.Core.Duration();
            }

            public override string ToString ()
            {
                return ROS_CS.Core.PrettyPrinter.PrettyPrint(ToStringRaw());
            }

            public override string ToStringRaw ()
            {
                string string_rep = typeID + ":\n";
                string_rep += "transforms:\n[";
                foreach (geometry_msgs.Transform element in transforms)
                {
                    string_rep += " " + element.ToStringRaw();
                }
                string_rep += "]\n\n";
                string_rep += "velocities:\n[";
                foreach (geometry_msgs.Twist element in velocities)
                {
                    string_rep += " " + element.ToStringRaw();
                }
                string_rep += "]\n\n";
                string_rep += "accelerations:\n[";
                foreach (geometry_msgs.Twist element in accelerations)
                {
                    string_rep += " " + element.ToStringRaw();
                }
                string_rep += "]\n\n";
                string_rep += time_from_start.ToStringRaw() + "\n";
                return string_rep;
            }

            public override void Serialize(MemoryStream stream)
            {
                System.Byte[] transforms_len_bytes = BitConverter.GetBytes((System.UInt32)transforms.Count);
                stream.Write(transforms_len_bytes, 0, transforms_len_bytes.Length);
                foreach(geometry_msgs.Transform element in transforms)
                {
                    element.Serialize(stream);
                }
                System.Byte[] velocities_len_bytes = BitConverter.GetBytes((System.UInt32)velocities.Count);
                stream.Write(velocities_len_bytes, 0, velocities_len_bytes.Length);
                foreach(geometry_msgs.Twist element in velocities)
                {
                    element.Serialize(stream);
                }
                System.Byte[] accelerations_len_bytes = BitConverter.GetBytes((System.UInt32)accelerations.Count);
                stream.Write(accelerations_len_bytes, 0, accelerations_len_bytes.Length);
                foreach(geometry_msgs.Twist element in accelerations)
                {
                    element.Serialize(stream);
                }
                time_from_start.Serialize(stream);
            }

            public override int Deserialize(System.Byte[] serialized)
            {
                return Deserialize(serialized, 0);
            }

            public override int Deserialize(System.Byte[] serialized, int startIndex)
            {
                int curIndex = startIndex;
                System.UInt32 transforms_len = BitConverter.ToUInt32(serialized, curIndex);
                curIndex += BitConverter.GetBytes(transforms_len).Length;
                for (int i = 0; i < (int)transforms_len; i++)
                {
                    geometry_msgs.Transform element = new geometry_msgs.Transform();
                    curIndex += element.Deserialize(serialized, curIndex);
                    transforms.Add(element);
                }
                System.UInt32 velocities_len = BitConverter.ToUInt32(serialized, curIndex);
                curIndex += BitConverter.GetBytes(velocities_len).Length;
                for (int i = 0; i < (int)velocities_len; i++)
                {
                    geometry_msgs.Twist element = new geometry_msgs.Twist();
                    curIndex += element.Deserialize(serialized, curIndex);
                    velocities.Add(element);
                }
                System.UInt32 accelerations_len = BitConverter.ToUInt32(serialized, curIndex);
                curIndex += BitConverter.GetBytes(accelerations_len).Length;
                for (int i = 0; i < (int)accelerations_len; i++)
                {
                    geometry_msgs.Twist element = new geometry_msgs.Twist();
                    curIndex += element.Deserialize(serialized, curIndex);
                    accelerations.Add(element);
                }
                curIndex += time_from_start.Deserialize(serialized, curIndex);
                return (curIndex - startIndex);
            }

        }
    }
}
