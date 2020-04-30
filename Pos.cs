using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARM
{
    class Pos
    {
        public struct Point_rec
        {
            public double x;//水平于臂
            public double y;//垂直于臂
            public double z;//垂直于平面
        } ;
        public Point_rec pr;
        public struct Point_polar
        {
            public double a;//大
            public double b;//小
            public double c;//底
        };
        public Point_polar pp;

        double Linkage_1 = 120;//大  单位mm
        double Linkage_2 = 120;//小  单位mm

        float[] SCARA_offset = new float[3];
        
        float CenterOffset = 0;
        float HeadOffset = 0;
        float ZOffset = 0;
        double RAD2DEG = 180/Math.PI;
        /// <summary>
        /// 正解；由极坐标到直角坐标
        /// </summary>
        public void calculate_forward_Transform()
        {
            double x_sin, x_cos, y_sin, y_cos;

            x_sin = Math.Sin(this.pp.a/ RAD2DEG) * Linkage_1;
            x_cos = Math.Cos(this.pp.a/ RAD2DEG) * Linkage_1;
            y_sin = Math.Sin(this.pp.b/ RAD2DEG) * Linkage_2;
            y_cos = Math.Cos(this.pp.b/ RAD2DEG) * Linkage_2;

            double arm_xy = x_cos + y_cos + CenterOffset + HeadOffset;

            pr.x = arm_xy * Math.Acos(this.pp.c) - SCARA_offset[0];
            pr.y = arm_xy * Math.Asin(this.pp.c) - SCARA_offset[1];
            pr.z = x_sin + y_sin - SCARA_offset[2];
          
        }
        public void calculate_delta()
        {
            float[] SCARA_offset = new float[3];
            float CenterOffset = 0;
            float HeadOffset = 0;
            float ZOffset = 0;

            //P.x = cartesian[0] * axis_scaling[0] + SCARA_offset[0];
            //P.y = cartesian[1] * axis_scaling[1] + SCARA_offset[1];
            //P.z = cartesian[2] * axis_scaling[2] + SCARA_offset[2];

            double ARM_XY = Math.Sqrt(Math.Pow(this.pr.x, 2) + Math.Pow(this.pr.y, 2)) - CenterOffset - HeadOffset;
            double ARM_XYZ = Math.Sqrt(Math.Pow(ARM_XY, 2) + Math.Pow(this.pr.z, 2));

            double SCARA_C2 = (Math.Pow(ARM_XYZ, 2) - Math.Pow(Linkage_1, 2) - Math.Pow(Linkage_2, 2)) / (2 * Linkage_1 * Linkage_2);
            double SCARA_S2 = Math.Sqrt(1 - Math.Pow(SCARA_C2, 2));

            double SCARA_K1 = Linkage_1 + Linkage_2 * SCARA_C2;
            double SCARA_K2 = Linkage_2 * SCARA_S2;

            double SCARA_theta = (Math.Atan2(this.pr.z, ARM_XY) + Math.Atan2(SCARA_K2, SCARA_K1));
            double SCARA_psi = Math.Atan2(SCARA_S2, SCARA_C2);
 
            pp.a = SCARA_theta;
            pp.b = (SCARA_theta - SCARA_psi);
            pp.c = Math.Atan2(pr.y, pr.x);
        }


    }
}
