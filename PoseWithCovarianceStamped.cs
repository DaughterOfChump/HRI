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
        public class PoseWithCovarianceStamped : ROS_CS.Core.BaseMessage
        {
            public readonly string typeID = "PoseWithCovarianceStamped";
            public readonly string md5sum = "953b798c0f514ff060a53a3498ce6246";
            public std_msgs.Header header;
            public geometry_msgs.PoseWithCovariance pose;

            public PoseWithCovarianceStamped ()
            {
                header = new std_msgs.Header();
                pose = new geometry_msgs.PoseWithCovariance();
            }

            public override string ToString ()
            {
                return ROS_CS.Core.PrettyPrinter.PrettyPrint(ToStringRaw());
            }

            public override string ToStringRaw ()
            {
                string string_rep = typeID + ":\n";
                string_rep += header.ToStringRaw() + "\n";
                string_rep += pose.ToStringRaw() + "\n";
                return string_rep;
            }

            public override void Serialize(MemoryStream stream)
            {
                header.Serialize(stream);
                pose.Serialize(stream);
            }

            public override int Deserialize(System.Byte[] serialized)
            {
                return Deserialize(serialized, 0);
            }

            public override int Deserialize(System.Byte[] serialized, int startIndex)
            {
                int curIndex = startIndex;
                curIndex += header.Deserialize(serialized, curIndex);
                curIndex += pose.Deserialize(serialized, curIndex);
                return (curIndex - startIndex);
            }

        }
    }
}
