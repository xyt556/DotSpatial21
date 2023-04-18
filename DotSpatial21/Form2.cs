using DotSpatial.Projections;
using DotSpatial.Projections.Forms;
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
    public partial class FormInputParams : Form
    {
        public double StartX { get; private set; }
        public double StartY { get; private set; }
        public double EndX { get; private set; }
        public double EndY { get; private set; }
        public double IntervalX { get; private set; }
        public double IntervalY { get; private set; }
        public ProjectionInfo selectedProjection { get; private set; }
        public FormInputParams()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // 获取用户输入的参数
            StartX = Convert.ToDouble(txtStartX.Text);
            StartY = Convert.ToDouble(txtStartY.Text);
            EndX = Convert.ToDouble(txtEndX.Text);
            EndY = Convert.ToDouble(txtEndY.Text);
            IntervalX = Convert.ToDouble(txtIntervalX.Text);
            IntervalY = Convert.ToDouble(txtIntervalY.Text);
            // 创建ProjectionSelectControl控件
            ProjectionSelectControl projectionSelectControl = new ProjectionSelectControl();
            DialogResult = DialogResult.OK;
            
            
            Close();
            
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您取消了绘制", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnProj_Click(object sender, EventArgs e)
        {
            //// 定制投影

            //// 创建 ProjectionDialog 对象
            //ProjectionCustomDialog projectionDialog = new ProjectionCustomDialog();
            //// 显示坐标系选择对话框
            //DialogResult result = projectionDialog.ShowDialog();

            //// 显示新窗体以选择坐标系
            //if (result == DialogResult.OK)
            //{
            //    // 获取选定的坐标系
            //    selectedProjection = projectionDialog.SelectedProjectionInfo;

            //    // 在控件上显示选定的坐标系的信息
            //    MessageBox.Show($"您设置的投影是：{selectedProjection}");
            //}


            ProjectionSelectDialog projectionSelectDialog = new ProjectionSelectDialog();
            DialogResult result = projectionSelectDialog.ShowDialog();
            // 显示新窗体以选择坐标系
            if (result == DialogResult.OK)
            {
                // 获取选定的坐标系
                selectedProjection = projectionSelectDialog.SelectedCoordinateSystem;

                // 在控件上显示选定的坐标系的信息
                MessageBox.Show($"您设置的投影是：{selectedProjection}");
            }
        }
    }
}
