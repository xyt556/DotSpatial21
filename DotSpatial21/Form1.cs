using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Projections;
using DotSpatial.Symbology;
//using DotSpatial.Topology;
using GeoAPI.Geometries;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Point = NetTopologySuite.Geometries.Point;

namespace DotSpatial21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            



            // 创建一个FeatureSet对象，指定FeatureType为Line
            IFeatureSet fs = new FeatureSet(FeatureType.Line);
            fs.Projection = ProjectionInfo.FromEpsgCode(4326); // 设置地理坐标系为WGS84

            // 创建经纬网
            double minLat = -90;
            double maxLat = 90;
            double minLon = -180;
            double maxLon = 180;
            double interval = 10; // 经纬度网格间隔

            for (double lat = minLat; lat <= maxLat; lat += interval)
            {
                List<Coordinate> coords = new List<Coordinate>();
                coords.Add(new Coordinate(minLon, lat));
                coords.Add(new Coordinate(maxLon, lat));
                ILineString line = new LineString(coords.ToArray());
                fs.AddFeature(line);
            }

            for (double lon = minLon; lon <= maxLon; lon += interval)
            {
                List<Coordinate> coords = new List<Coordinate>();
                coords.Add(new Coordinate(lon, minLat));
                coords.Add(new Coordinate(lon, maxLat));
                ILineString line = new LineString(coords.ToArray());
                fs.AddFeature(line);
            }

            // 创建一个MapLineLayer对象，传入FeatureSet作为参数
            MapLineLayer mpl = new MapLineLayer(fs);

            // 设置MapLineLayer的符号化和样式
            LineSymbolizer lineSymbolizer = new LineSymbolizer(Color.Black, 1);
            mpl.Symbolizer = lineSymbolizer;
            fs.SaveAs(@"D:\jww.shp", true);
            // 使用Map的Layers或MapFrame的DrawingLayers属性，添加MapLineLayer到地图上
            map.Layers.Add(mpl);
            map.Refresh();
            fs.Close();
            map.ClearLayers();
        }

        private void 创建经纬网ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 创建一个FeatureSet对象，指定FeatureType为Line
            IFeatureSet fs = new FeatureSet(FeatureType.Line);
            fs.Projection = ProjectionInfo.FromEpsgCode(4326); // 设置地理坐标系为WGS84

            // 创建经纬网
            double minLat = -90;
            double maxLat = 90;
            double minLon = -180;
            double maxLon = 180;
            double interval = 10; // 经纬度网格间隔

            for (double lat = minLat; lat <= maxLat; lat += interval)
            {
                List<Coordinate> coords = new List<Coordinate>();
                coords.Add(new Coordinate(minLon, lat));
                coords.Add(new Coordinate(maxLon, lat));
                ILineString line = new LineString(coords.ToArray());
                fs.AddFeature(line);
            }

            for (double lon = minLon; lon <= maxLon; lon += interval)
            {
                List<Coordinate> coords = new List<Coordinate>();
                coords.Add(new Coordinate(lon, minLat));
                coords.Add(new Coordinate(lon, maxLat));
                ILineString line = new LineString(coords.ToArray());
                fs.AddFeature(line);
            }

            // 创建一个MapLineLayer对象，传入FeatureSet作为参数
            MapLineLayer mpl = new MapLineLayer(fs);
            fs.SaveAs(@"D:\jww.shp", true);
            fs.Close();
            // 设置MapLineLayer的符号化和样式
            LineSymbolizer lineSymbolizer = new LineSymbolizer(Color.Black, 1);
            mpl.Symbolizer = lineSymbolizer;
            mpl.LegendText = "经纬网";
            // 使用Map的Layers或MapFrame的DrawingLayers属性，添加MapLineLayer到地图上
            map.Layers.Add(mpl);
            map.Refresh();

        }



        private void 点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 创建一个点要素数据集
            FeatureSet pointFeatureSet = new FeatureSet(FeatureType.Point);

            // 添加字段
            pointFeatureSet.DataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            pointFeatureSet.DataTable.Columns.Add(new DataColumn("X", typeof(double)));
            pointFeatureSet.DataTable.Columns.Add(new DataColumn("Y", typeof(double)));

            // 创建一个点
            NetTopologySuite.Geometries.Point point = new Point(10, 20);

            // 添加一个点要素
            IFeature feature = pointFeatureSet.AddFeature(point);

            // 设置点要素的属性值
            feature.DataRow["Name"] = "Point1";
            feature.DataRow["X"] = point.X;
            feature.DataRow["Y"] = point.Y;

            // 将点要素数据集添加到地图控件中作为一个图层
            MapPointLayer pointLayer = new MapPointLayer(pointFeatureSet);
            map.Layers.Add(pointLayer);
            pointLayer.LegendText = "point";
            // 显示地图
            map.Show();

            // 保存点要素数据集到Shapefile文件
            pointFeatureSet.SaveAs(@"D:\point.shp", true);
        }

        private void 线ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 创建一个线要素数据集
            FeatureSet lineFeatureSet = new FeatureSet(FeatureType.Line);

            // 添加字段
            lineFeatureSet.DataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            lineFeatureSet.DataTable.Columns.Add(new DataColumn("Length", typeof(double)));

            // 创建一条线
            LineString lineString = new LineString(new[] { new Coordinate(0, 0), new Coordinate(10, 10), new Coordinate(20, 0) });

            // 添加一条线要素
            IFeature feature = lineFeatureSet.AddFeature(lineString);

            // 设置线要素的属性值
            feature.DataRow["Name"] = "Line1";
            feature.DataRow["Length"] = lineString.Length;

            // 将线要素数据集添加到地图控件中作为一个图层
            MapLineLayer lineLayer = new MapLineLayer(lineFeatureSet);
            map.Layers.Add(lineLayer);
            lineLayer.LegendText = "line";
            // 显示地图
            map.Show();

            // 等待用户操作

            // 保存线要素数据集到Shapefile文件
            lineFeatureSet.SaveAs(@"D:\line.shp", true);
        }

        private void 面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 创建一个面要素数据集
            FeatureSet polygonFeatureSet = new FeatureSet(FeatureType.Polygon);

            // 添加字段
            polygonFeatureSet.DataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            polygonFeatureSet.DataTable.Columns.Add(new DataColumn("Area", typeof(double)));

            // 创建一个多边形
            Coordinate[] coords = new Coordinate[]
            {
            new Coordinate(0, 0),
            new Coordinate(10, 0),
            new Coordinate(10, 10),
            new Coordinate(0, 10),
            new Coordinate(0, 0)
            };
            Polygon polygon = new Polygon(new LinearRing(coords));

            // 添加一个面要素
            IFeature feature = polygonFeatureSet.AddFeature(polygon);

            // 设置面要素的属性值
            feature.DataRow["Name"] = "Polygon1";
            feature.DataRow["Area"] = polygon.Area;

            // 将面要素数据集添加到地图控件中作为一个图层
            MapPolygonLayer polygonLayer = new MapPolygonLayer(polygonFeatureSet);
            map.Layers.Add(polygonLayer);
            polygonLayer.LegendText = "polygon";
            // 显示地图
            map.Show();

            // 等待用户操作

            // 保存面要素数据集到Shapefile文件
            polygonFeatureSet.SaveAs(@"D:\polygon.shp", true);
        }

        private void 经纬网1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 指定投影为UTM50
            ProjectionInfo utmProjection = KnownCoordinateSystems.Projected.UtmWgs1984.WGS1984UTMZone50N;
            //// 指定左下角和右上角坐标（投影坐标）
            //double leftBottomX = 1000000.0; // 左下角X坐标
            //double leftBottomY = 2000000.0; // 左下角Y坐标
            //double rightTopX = 1500000.0; // 右上角X坐标
            //double rightTopY = 2500000.0; // 右上角Y坐标

            //// 指定比例尺
            //double scale = 1000000.0; // 1:1,000,000

            //// 计算经纬网的格点数
            //double gridSizeX = (rightTopX - leftBottomX) / (scale / 1000.0); // 1 km
            //double gridSizeY = (rightTopY - leftBottomY) / (scale / 1000.0); // 1 km

            //// 创建一个面要素数据集
            //FeatureSet gridFeatureSet = new FeatureSet(FeatureType.Polygon);

            //// 添加字段
            //gridFeatureSet.DataTable.Columns.Add(new DataColumn("Row", typeof(int)));
            //gridFeatureSet.DataTable.Columns.Add(new DataColumn("Col", typeof(int)));
            //gridFeatureSet.DataTable.Columns.Add(new DataColumn("X", typeof(double)));
            //gridFeatureSet.DataTable.Columns.Add(new DataColumn("Y", typeof(double)));

            //// 创建经纬网
            //for (int row = 0; row < gridSizeY; row++)
            //{
            //    for (int col = 0; col < gridSizeX; col++)
            //    {
            //        // 计算格点的投影坐标
            //        double x = leftBottomX + col * (scale / 1000.0);
            //        double y = leftBottomY + row * (scale / 1000.0);

            //        // 创建一个矩形多边形
            //        Coordinate[] coords = new Coordinate[]
            //        {
            //        new Coordinate(x, y),
            //        new Coordinate(x + (scale / 1000.0), y),
            //        new Coordinate(x + (scale / 1000.0), y + (scale / 1000.0)),
            //        new Coordinate(x, y + (scale / 1000.0)),
            //        new Coordinate(x, y)
            //        };
            //        Polygon polygon = new Polygon(new LinearRing(coords));

            //        // 添加一个面要素
            //        IFeature feature = gridFeatureSet.AddFeature(polygon);

            //        // 设置面要素的属性值
            //        feature.DataRow["Row"] = row;
            //        feature.DataRow["Col"] = col;
            //        feature.DataRow["X"] = x;
            //        feature.DataRow["Y"] = y;
            //    }
            //}



            //// 设置要素数据集的投影信息
            //gridFeatureSet.Projection = utmProjection;
            //// 将经纬网要素数据集添加到地图控件中

            //MapPolygonLayer gridLayer = new MapPolygonLayer(gridFeatureSet);
            //map.Layers.Add(gridLayer);
            // 指定左下角坐标（经度、纬度）
            double leftBottomLongitude = 100.0;
            double leftBottomLatitude = 20.0;

            // 指定行列数
            int rowCount = 10;
            int colCount = 10;

            // 计算格点的经度和纬度增量
            double lonIncrement = 1.0 / colCount;
            double latIncrement = 1.0 / rowCount;

            // 创建一个面要素数据集
            FeatureSet gridFeatureSet = new FeatureSet(FeatureType.Polygon);

            // 添加字段
            gridFeatureSet.DataTable.Columns.Add(new DataColumn("Row", typeof(int)));
            gridFeatureSet.DataTable.Columns.Add(new DataColumn("Col", typeof(int)));
            gridFeatureSet.DataTable.Columns.Add(new DataColumn("X", typeof(double)));
            gridFeatureSet.DataTable.Columns.Add(new DataColumn("Y", typeof(double)));

            // 创建经纬网
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    // 计算格点的经度和纬度
                    double lon = leftBottomLongitude + col * lonIncrement;
                    double lat = leftBottomLatitude + row * latIncrement;

                    // 创建一个矩形多边形
                    Coordinate[] coords = new Coordinate[]
                    {
                    new Coordinate(lon, lat),
                    new Coordinate(lon + lonIncrement, lat),
                    new Coordinate(lon + lonIncrement, lat + latIncrement),
                    new Coordinate(lon, lat + latIncrement),
                    new Coordinate(lon, lat)
                    };
                    Polygon polygon = new Polygon(new LinearRing(coords));

                    // 添加一个面要素
                    IFeature feature = gridFeatureSet.AddFeature(polygon);

                    // 设置面要素的属性值
                    feature.DataRow["Row"] = row;
                    feature.DataRow["Col"] = col;
                    feature.DataRow["X"] = lon;
                    feature.DataRow["Y"] = lat;
                }
            }
            //// 设置要素数据集的投影信息
            //gridFeatureSet.Projection = utmProjection;


            // 将线要素数据集添加到地图控件中作为一个图层
            MapPolygonLayer gridLayer = new MapPolygonLayer(gridFeatureSet);
            map.Layers.Add(gridLayer);
            gridLayer.LegendText = "经纬网";
            // 显示地图
            map.Show();

            // 将要素数据集保存为shapefile文件
            string shapefilePath = @"D:\Grid.shp";
            gridFeatureSet.SaveAs(shapefilePath, true);
        }

        private void 叠置分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 缓冲区分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<IFeature> selectedFeatures = new List<IFeature>();
            foreach (IMapLayer layer in map.Layers)
            {
                IMapFeatureLayer featureLayer = layer as IMapFeatureLayer;
                if (featureLayer != null)
                {
                    selectedFeatures.AddRange(featureLayer.Selection.ToFeatureList());
                }
            }

            double distance = 100; // 缓冲区距离
            //double bufferSegments = 8;
            FeatureSet bufferResult = new FeatureSet();
            IFeature[] buf_result = new IFeature[selectedFeatures.Count];
            int i = 0;
            foreach (IFeature feature in selectedFeatures)
            {

                buf_result[i] = feature.Buffer(distance);
                bufferResult.Features.Add(buf_result[i]);

                i++;
            }
            // 将缓冲区数据集添加到地图控件中作为一个图层
            MapPolygonLayer bufferLayer = new MapPolygonLayer(bufferResult);
            map.Layers.Add(bufferLayer);
            bufferLayer.LegendText = "缓冲区";
            // 显示地图
            map.Show();

            bufferResult.SaveAs("C:/1/buffer_result_selected.shp", true);
            map.ResetBuffer();
        }

        private void 经纬网2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 打开新窗体以获取用户输入的参数
            using (var inputForm = new FormInputParams())
            {
                var result = inputForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    double startX = inputForm.StartX;
                    double startY = inputForm.StartY;
                    double endX = inputForm.EndX;
                    double endY = inputForm.EndY;
                    double intervalX = inputForm.IntervalX;
                    double intervalY = inputForm.IntervalY;

                    // 清除地图中的图层
                    map.ClearLayers();

                    // 绘制公里网
                    DrawKilometerGrid(startX, startY, endX, endY, intervalX, intervalY);

                    // 刷新地图

                    map.ZoomToMaxExtent();
                    map.Refresh();
                }
            }
        }
        private void DrawKilometerGrid(double startX, double startY, double endX, double endY, double intervalX, double intervalY)
        {
            int numLinesX = Convert.ToInt32((endX - startX) / intervalX);
            int numLinesY = Convert.ToInt32((endY - startY) / intervalY);

            double currentX = startX;
            double currentY = startY;
            FeatureSet jww = new FeatureSet();



            // 绘制水平线
            for (int i = 0; i <= numLinesY; i++)
            {
                Coordinate startCoord = new Coordinate(startX, currentY);
                Coordinate endCoord = new Coordinate(endX, currentY);
                LineString line = new LineString(new[] { startCoord, endCoord });
                jww.AddFeature(line);
                currentY += intervalY;
            }

            // 绘制垂直线
            for (int i = 0; i <= numLinesX; i++)
            {
                Coordinate startCoord = new Coordinate(currentX, startY);
                Coordinate endCoord = new Coordinate(currentX, endY);
                LineString line = new LineString(new[] { startCoord, endCoord });
                jww.AddFeature(line);
                currentX += intervalX;
            }
            MapLineLayer jwwLayer = new MapLineLayer(jww);
            map.Layers.Add(jwwLayer);
            jww.SaveAs("经纬网.shp", true);
        }

        private void 文本转点ToolStripMenuItem_Click(object sender, EventArgs e)
        {



            // 使用 OpenFileDialog 打开文本文件
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "文本文件 (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // 读取文本文件内容
                List<string> lines = new List<string>();
                int index = 0;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }

                // 解析文本文件内容，创建点要素集
                FeatureSet pointFeatureSet = new FeatureSet(FeatureType.Point);
                // 添加字段
                pointFeatureSet.DataTable.Columns.Add(new DataColumn("ID", typeof(int)));
                pointFeatureSet.DataTable.Columns.Add(new DataColumn("X", typeof(double)));
                pointFeatureSet.DataTable.Columns.Add(new DataColumn("Y", typeof(double)));
                pointFeatureSet.DataTable.Columns.Add(new DataColumn("名称", typeof(string)));
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    // 确保每行有足够的字段
                    if (parts.Length >= 2)
                    {
                        double x, y;
                        if (Double.TryParse(parts[0], out x) && Double.TryParse(parts[1], out y))
                        {
                            // 创建点要素
                            NetTopologySuite.Geometries.Point point = new Point(x, y);
                            // 添加一个点要素
                            IFeature feature = pointFeatureSet.AddFeature(point);
                            // 设置点要素的属性值
                            feature.DataRow["ID"] = index++;
                            feature.DataRow["X"] = point.X;
                            feature.DataRow["Y"] = point.Y;
                            feature.DataRow["名称"] = parts[2];


                        }
                    }
                }
                // 创建点要素图层
                MapPointLayer pointLayer = new MapPointLayer(pointFeatureSet);

                map.Layers.Add(pointLayer);
                pointLayer.LegendText = "点";
                // 将点要素集添加到点要素图层，并刷新地图
                pointLayer.DataSet = pointFeatureSet;
                map.ResetBuffer();
            }
        }

        private void kMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //// OpenFileDialog 用于选择 KML 文件
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "KML 文件 (*.kml)|*.kml";
            //openFileDialog.Title = "选择 KML 文件";
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
                
            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        string fileName = openFileDialog.FileName;

            //        try
            //        {
            //            // 使用 FeatureSet 类加载 KML 文件
            //            FeatureSet featureSet = FeatureSet.Open(fileName);
            //            // 将 FeatureSet 添加到地图控件中
            //            // 这里假设你的地图控件名为 mapControl
            //            map.Layers.Add(featureSet);

            //            // 刷新地图
            //            map.Refresh();
            //        }
            //        catch (Exception ex)
            //        {
            //            // 处理异常
            //            MessageBox.Show("加载 KML 文件时发生错误：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            }

        private void map_MouseMove(object sender, MouseEventArgs e)
        {
            // 获取鼠标在地图上的坐标
            double x = map.PixelToProj(e.Location).X;
            double y = map.PixelToProj(e.Location).Y;

            // 将坐标信息格式化为字符串
            string coordinateInfo = string.Format("X: {0}, Y: {1}", x, y);

            // 将坐标信息设置到 spatialStatusStrip 中的 ToolStripStatusLabel 控件中
            toolStripStatusLabelCoordinate.Text = coordinateInfo;
        }
    }
}





