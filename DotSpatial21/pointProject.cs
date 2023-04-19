using DotSpatial.Projections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotSpatial21
{
    public partial class FrmpointProject : Form
    {
        public FrmpointProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 获取原始坐标值
            double x = double.Parse(textBox_X.Text);
            double y = double.Parse(textBox_Y.Text);

            // 获取投影信息
            string sourceProjectionString = $"EPSG:{txtSource.Text.Trim()}"; // 原始坐标的投影信息，这里使用了WGS84经纬度坐标系
            string targetProjectionString = $"EPSG:{txtTarget.Text.Trim()}"; // 目标坐标的投影信息，这里使用了Web墨卡托投影
                        
            ProjectionInfo sourceProjection;
            ProjectionInfo targetProjection;
            double[] sourceCoord = new double[] { x, y };


            try
            {
                // 定义原始坐标
                sourceProjection = ProjectionInfo.FromEpsgCode(int.Parse(txtSource.Text.Trim()));
                sourceProjection.ParseEsriString(sourceProjectionString);
                // 定义目标坐标
                targetProjection = ProjectionInfo.FromEpsgCode(int.Parse(txtTarget.Text.Trim()));
                targetProjection.ParseEsriString(targetProjectionString);

                // 进行投影转换
                double[] targetCoord = new double[2];
                Reproject.ReprojectPoints(sourceCoord, null, sourceProjection, targetProjection, 0, 1);
                targetCoord[0] = sourceCoord[0];
                targetCoord[1] = sourceCoord[1];

                // 输出投影后的坐标
                textBox_TargetX.Text = targetCoord[0].ToString();
                textBox_TargetY.Text = targetCoord[1].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("坐标系代码不正确");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
