# How-to-explode-the-pie-chart-slice-in-WinUI-SfCircularChart
The WinUi Chart provides a simple way to achieve specific visual effects by exploding segments in a pie Chart. You can control the explosion of a particular data point’s segment by adjusting the ExplodeIndex property of the chart series. Additionally, the ExplodeRadius property allows you to define how far the segment will be exploded from the center of the chart.The ExplodeOnTap property enables the segments to be exploded when they are touched or clicked by the user. The following code example demonstrates how to explode the segment in the pie chart:

**XAML**

       <chart:PieSeries ItemsSource="{Binding Data}"
                             XBindingPath="Name"
                             YBindingPath="GDP"
                             ExplodeIndex="2"
                             ExplodeRadius="20"
                             ExplodeOnTap="True"
                             ShowDataLabels="True" >
       </chart:PieSeries>
 
**C#**

      PieSeries pieSeries = new PieSeries ();
      pieSeries .ItemsSource = "{Binding Data}";
      pieSeries .XBindingPath = "Name";
      pieSeries .YBindingPath = "GDP";
      pieSeries .ExplodeIndex = 2;
      pieSeries .ExplodeRadius = 20;
      pieSeries .ExplodeOnTap = true;
      pieSeries .ShowDataLabels = true;
     
      circularChart.Series.Add(pieSeries );
      this.Content = circularChart;



