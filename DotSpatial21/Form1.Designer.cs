namespace DotSpatial21
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.要素ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.创建要素ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文本转点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.创建经纬网ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.经纬网1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.经纬网2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空间分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.叠置分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缓冲区分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spatialToolStrip = new DotSpatial.Controls.SpatialToolStrip();
            this.map = new DotSpatial.Controls.Map();
            this.legend = new DotSpatial.Controls.Legend();
            this.spatialStatusStrip1 = new DotSpatial.Controls.SpatialStatusStrip();
            this.spatialDockManager1 = new DotSpatial.Controls.SpatialDockManager();
            this.加载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabelCoordinate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelScale = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.spatialStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).BeginInit();
            this.spatialDockManager1.Panel1.SuspendLayout();
            this.spatialDockManager1.Panel2.SuspendLayout();
            this.spatialDockManager1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.要素ToolStripMenuItem,
            this.空间分析ToolStripMenuItem,
            this.加载ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(603, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 要素ToolStripMenuItem
            // 
            this.要素ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建要素ToolStripMenuItem,
            this.创建经纬网ToolStripMenuItem,
            this.经纬网1ToolStripMenuItem,
            this.经纬网2ToolStripMenuItem});
            this.要素ToolStripMenuItem.Name = "要素ToolStripMenuItem";
            this.要素ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.要素ToolStripMenuItem.Text = "要素";
            // 
            // 创建要素ToolStripMenuItem
            // 
            this.创建要素ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.点ToolStripMenuItem,
            this.线ToolStripMenuItem,
            this.面ToolStripMenuItem,
            this.文本转点ToolStripMenuItem});
            this.创建要素ToolStripMenuItem.Name = "创建要素ToolStripMenuItem";
            this.创建要素ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.创建要素ToolStripMenuItem.Text = "创建要素";
            // 
            // 点ToolStripMenuItem
            // 
            this.点ToolStripMenuItem.Name = "点ToolStripMenuItem";
            this.点ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.点ToolStripMenuItem.Text = "点";
            this.点ToolStripMenuItem.Click += new System.EventHandler(this.点ToolStripMenuItem_Click);
            // 
            // 线ToolStripMenuItem
            // 
            this.线ToolStripMenuItem.Name = "线ToolStripMenuItem";
            this.线ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.线ToolStripMenuItem.Text = "线";
            this.线ToolStripMenuItem.Click += new System.EventHandler(this.线ToolStripMenuItem_Click);
            // 
            // 面ToolStripMenuItem
            // 
            this.面ToolStripMenuItem.Name = "面ToolStripMenuItem";
            this.面ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.面ToolStripMenuItem.Text = "面";
            this.面ToolStripMenuItem.Click += new System.EventHandler(this.面ToolStripMenuItem_Click);
            // 
            // 文本转点ToolStripMenuItem
            // 
            this.文本转点ToolStripMenuItem.Name = "文本转点ToolStripMenuItem";
            this.文本转点ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.文本转点ToolStripMenuItem.Text = "文本转点";
            this.文本转点ToolStripMenuItem.Click += new System.EventHandler(this.文本转点ToolStripMenuItem_Click);
            // 
            // 创建经纬网ToolStripMenuItem
            // 
            this.创建经纬网ToolStripMenuItem.Name = "创建经纬网ToolStripMenuItem";
            this.创建经纬网ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.创建经纬网ToolStripMenuItem.Text = "创建经纬网";
            this.创建经纬网ToolStripMenuItem.Click += new System.EventHandler(this.创建经纬网ToolStripMenuItem_Click);
            // 
            // 经纬网1ToolStripMenuItem
            // 
            this.经纬网1ToolStripMenuItem.Name = "经纬网1ToolStripMenuItem";
            this.经纬网1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.经纬网1ToolStripMenuItem.Text = "经纬网1";
            this.经纬网1ToolStripMenuItem.Click += new System.EventHandler(this.经纬网1ToolStripMenuItem_Click);
            // 
            // 经纬网2ToolStripMenuItem
            // 
            this.经纬网2ToolStripMenuItem.Name = "经纬网2ToolStripMenuItem";
            this.经纬网2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.经纬网2ToolStripMenuItem.Text = "经纬网2";
            this.经纬网2ToolStripMenuItem.Click += new System.EventHandler(this.经纬网2ToolStripMenuItem_Click);
            // 
            // 空间分析ToolStripMenuItem
            // 
            this.空间分析ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.叠置分析ToolStripMenuItem,
            this.缓冲区分析ToolStripMenuItem});
            this.空间分析ToolStripMenuItem.Name = "空间分析ToolStripMenuItem";
            this.空间分析ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.空间分析ToolStripMenuItem.Text = "空间分析";
            // 
            // 叠置分析ToolStripMenuItem
            // 
            this.叠置分析ToolStripMenuItem.Name = "叠置分析ToolStripMenuItem";
            this.叠置分析ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.叠置分析ToolStripMenuItem.Text = "叠置分析";
            this.叠置分析ToolStripMenuItem.Click += new System.EventHandler(this.叠置分析ToolStripMenuItem_Click);
            // 
            // 缓冲区分析ToolStripMenuItem
            // 
            this.缓冲区分析ToolStripMenuItem.Name = "缓冲区分析ToolStripMenuItem";
            this.缓冲区分析ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.缓冲区分析ToolStripMenuItem.Text = "缓冲区分析";
            this.缓冲区分析ToolStripMenuItem.Click += new System.EventHandler(this.缓冲区分析ToolStripMenuItem_Click);
            // 
            // spatialToolStrip
            // 
            this.spatialToolStrip.ApplicationManager = null;
            this.spatialToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.spatialToolStrip.Location = new System.Drawing.Point(0, 25);
            this.spatialToolStrip.Map = this.map;
            this.spatialToolStrip.Name = "spatialToolStrip";
            this.spatialToolStrip.Size = new System.Drawing.Size(603, 27);
            this.spatialToolStrip.TabIndex = 1;
            this.spatialToolStrip.Text = "spatialToolStrip1";
            // 
            // map
            // 
            this.map.AllowDrop = true;
            this.map.BackColor = System.Drawing.Color.White;
            this.map.CollisionDetection = false;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.ExtendBuffer = false;
            this.map.FunctionMode = DotSpatial.Controls.FunctionMode.Pan;
            this.map.IsBusy = false;
            this.map.IsZoomedToMaxExtent = false;
            this.map.Legend = this.legend;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Name = "map";
            this.map.ProgressHandler = null;
            this.map.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.map.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.map.RedrawLayersWhileResizing = false;
            this.map.SelectionEnabled = true;
            this.map.Size = new System.Drawing.Size(400, 376);
            this.map.TabIndex = 0;
            this.map.ZoomOutFartherThanMaxExtent = false;
            this.map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.map_MouseMove);
            // 
            // legend
            // 
            this.legend.BackColor = System.Drawing.Color.White;
            this.legend.ControlRectangle = new System.Drawing.Rectangle(0, 0, 199, 376);
            this.legend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.legend.HorizontalScrollEnabled = true;
            this.legend.Indentation = 30;
            this.legend.IsInitialized = false;
            this.legend.Location = new System.Drawing.Point(0, 0);
            this.legend.MinimumSize = new System.Drawing.Size(5, 5);
            this.legend.Name = "legend";
            this.legend.ProgressHandler = null;
            this.legend.ResetOnResize = false;
            this.legend.SelectionFontColor = System.Drawing.Color.Black;
            this.legend.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.legend.Size = new System.Drawing.Size(199, 376);
            this.legend.TabIndex = 0;
            this.legend.Text = "legend1";
            this.legend.UseLegendForSelection = true;
            this.legend.VerticalScrollEnabled = true;
            // 
            // spatialStatusStrip1
            // 
            this.spatialStatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.spatialStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCoordinate,
            this.toolStripStatusLabelScale});
            this.spatialStatusStrip1.Location = new System.Drawing.Point(0, 428);
            this.spatialStatusStrip1.Name = "spatialStatusStrip1";
            this.spatialStatusStrip1.ProgressBar = null;
            this.spatialStatusStrip1.ProgressLabel = this.toolStripStatusLabelCoordinate;
            this.spatialStatusStrip1.Size = new System.Drawing.Size(603, 22);
            this.spatialStatusStrip1.TabIndex = 2;
            this.spatialStatusStrip1.Text = "spatialStatusStrip1";
            // 
            // spatialDockManager1
            // 
            this.spatialDockManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spatialDockManager1.Location = new System.Drawing.Point(0, 52);
            this.spatialDockManager1.Name = "spatialDockManager1";
            // 
            // spatialDockManager1.Panel1
            // 
            this.spatialDockManager1.Panel1.Controls.Add(this.legend);
            // 
            // spatialDockManager1.Panel2
            // 
            this.spatialDockManager1.Panel2.Controls.Add(this.map);
            this.spatialDockManager1.Size = new System.Drawing.Size(603, 376);
            this.spatialDockManager1.SplitterDistance = 199;
            this.spatialDockManager1.TabControl1 = null;
            this.spatialDockManager1.TabControl2 = null;
            this.spatialDockManager1.TabIndex = 3;
            // 
            // 加载ToolStripMenuItem
            // 
            this.加载ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kMLToolStripMenuItem});
            this.加载ToolStripMenuItem.Name = "加载ToolStripMenuItem";
            this.加载ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.加载ToolStripMenuItem.Text = "加载";
            // 
            // kMLToolStripMenuItem
            // 
            this.kMLToolStripMenuItem.Name = "kMLToolStripMenuItem";
            this.kMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kMLToolStripMenuItem.Text = "KML";
            this.kMLToolStripMenuItem.Click += new System.EventHandler(this.kMLToolStripMenuItem_Click);
            // 
            // toolStripStatusLabelCoordinate
            // 
            this.toolStripStatusLabelCoordinate.Name = "toolStripStatusLabelCoordinate";
            this.toolStripStatusLabelCoordinate.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabelCoordinate.Text = "坐标信息：";
            // 
            // toolStripStatusLabelScale
            // 
            this.toolStripStatusLabelScale.Name = "toolStripStatusLabelScale";
            this.toolStripStatusLabelScale.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabelScale.Text = "版权：XYT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.spatialDockManager1);
            this.Controls.Add(this.spatialStatusStrip1);
            this.Controls.Add(this.spatialToolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.spatialStatusStrip1.ResumeLayout(false);
            this.spatialStatusStrip1.PerformLayout();
            this.spatialDockManager1.Panel1.ResumeLayout(false);
            this.spatialDockManager1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).EndInit();
            this.spatialDockManager1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 要素ToolStripMenuItem;
        private DotSpatial.Controls.SpatialToolStrip spatialToolStrip;
        private DotSpatial.Controls.Map map;
        private DotSpatial.Controls.Legend legend;
        private DotSpatial.Controls.SpatialStatusStrip spatialStatusStrip1;
        private DotSpatial.Controls.SpatialDockManager spatialDockManager1;
        private System.Windows.Forms.ToolStripMenuItem 创建要素ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 创建经纬网ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 经纬网1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 空间分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 叠置分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缓冲区分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 经纬网2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文本转点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCoordinate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelScale;
    }
}

