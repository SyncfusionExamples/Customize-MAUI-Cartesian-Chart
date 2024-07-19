# Customize-MAUI-Cartesian-Chart

The .NET MAUI Cartesian Chart is a versatile and robust tool for creating detailed and interactive data visualizations, suitable for a wide range of applications. Its flexibility, customization options, and performance make it a valuable component for any .NET MAUI project. 

This sample demonstrates how to customize the Data labels and Tooltip in MAUI Cartesian Charts. You'll see how to customize the placement of data labels, setting the label context, creating a custom label template and personalize the tooltip template in the .NET MAUI Cartesian Chart.

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## How to run the sample

1. Clone the sample and open it in Visual Studio 2022.
   
   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.cs file as demonstrated in the following code.

		public App()
		{
			//Register Syncfusion license
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
		
			InitializeComponent();
		
			MainPage = new MainPage();
		}
		
	Refer to this [link](https://help.syncfusion.com/maui/licensing/overview) for more details.
	
3. Clean and build the application.

4. Run the application.

## Sample

```xaml
<charts:SfCartesianChart>

    <charts:SfCartesianChart.Title>
        <Label Text="Top-Growing Online Products" FontSize="20" FontAttributes="Bold" HorizontalTextAlignment="Center"/>
    </charts:SfCartesianChart.Title>

    <charts:SfCartesianChart.XAxes>
        <charts:CategoryAxis>
            <charts:CategoryAxis.Title>
                <charts:ChartAxisTitle Text="Products" FontAttributes="Bold"/>
            </charts:CategoryAxis.Title>
        </charts:CategoryAxis>
    </charts:SfCartesianChart.XAxes>

    <charts:SfCartesianChart.YAxes>
        <charts:NumericalAxis Interval="10">
            <charts:NumericalAxis.Title>
                <charts:ChartAxisTitle Text="Sales Growth (in %)" FontAttributes="Bold"/>
            </charts:NumericalAxis.Title>
        </charts:NumericalAxis>
    </charts:SfCartesianChart.YAxes>

    <charts:SfCartesianChart.TooltipBehavior>
        <charts:ChartTooltipBehavior Background="Navy" TextColor="White" FontSize="16"
                             Duration="5000"/>
    </charts:SfCartesianChart.TooltipBehavior>

    <charts:ColumnSeries ItemsSource="{Binding Data}" 
                         XBindingPath="Product"
                         YBindingPath="Sales"
                         ShowDataLabels="True"
                         EnableTooltip="True">

        <charts:ColumnSeries.DataLabelSettings>
            <charts:CartesianDataLabelSettings LabelPlacement="Outer" UseSeriesPalette="False"/>
        </charts:ColumnSeries.DataLabelSettings>

        <charts:ColumnSeries.LabelTemplate>
            <DataTemplate>
                <HorizontalStackLayout Spacing="5">
                    <Image Source="{Binding Item.Image}" WidthRequest="15" HeightRequest="15"/>
                    <Label Text="{Binding Item.Sales}" />
                </HorizontalStackLayout>
            </DataTemplate>
        </charts:ColumnSeries.LabelTemplate>

        <charts:ColumnSeries.TooltipTemplate>
            <DataTemplate>
                <HorizontalStackLayout>
                    <Label Text="{Binding Item.Product}" TextColor="White" FontAttributes="Bold"/>
                    <Label Text=" : " TextColor="White" FontAttributes="Bold"/>
                    <Label Text="{Binding Item.Sales}" TextColor="White" FontAttributes="Bold"/>
                </HorizontalStackLayout>
            </DataTemplate>
        </charts:ColumnSeries.TooltipTemplate>

    </charts:ColumnSeries>
</charts:SfCartesianChart>
```

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.