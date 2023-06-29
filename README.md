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


**Conclusion**

I hope you enjoyed learning about how to slice(explode) the segment in pie Chart in WinUi (SfCircular Chart).

You can refer to our WinUI Cartesian Chart feature tour page to know about its other groundbreaking feature representations. You can also explore our WinUI Cartesian Chart documentation to understand how to present and manipulate data.

For current customers, you can check out our WinUI Controls from the License and Downloads page. If you are new to Syncfusion, you can try our 30-day free trial to check out our WinUI Cartesian Chart and other .WinUI controls.

If you have any queries or require clarifications, please let us know in comments below. You can also contact us through our support forums, Direct-Trac, or feedback portal. We are always happy to assist you!
