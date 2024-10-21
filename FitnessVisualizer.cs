using OxyPlot;
using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Collections.Generic;
using System.Windows.Forms;

public class FitnessVisualizer
{
    public void VisualizeFitness(List<double> minFitness, List<double> maxFitness, List<double> meanFitness)
    {
        var plotModel = new PlotModel { Title = "Population Fitness Over Generations" };

        var minSeries = new LineSeries { Title = "Min Fitness", Color = OxyColors.Red };
        var maxSeries = new LineSeries { Title = "Max Fitness", Color = OxyColors.Green };
        var meanSeries = new LineSeries { Title = "Mean Fitness", Color = OxyColors.Blue };

        for (int i = 0; i < minFitness.Count; i++)
        {
            minSeries.Points.Add(new DataPoint(i, minFitness[i]));
            maxSeries.Points.Add(new DataPoint(i, maxFitness[i]));
            meanSeries.Points.Add(new DataPoint(i, meanFitness[i]));
        }

        plotModel.Series.Add(minSeries);
        plotModel.Series.Add(maxSeries);
        plotModel.Series.Add(meanSeries);

        var plotView = new PlotView { Model = plotModel, Dock = DockStyle.Fill };
        plotModel.Legends.Add(new Legend { LegendPosition = LegendPosition.TopCenter, LegendPlacement = LegendPlacement.Outside, LegendOrientation = LegendOrientation.Horizontal });
        var form = new Form
        {
            Text = "Fitness Visualization",
            Width = 800,
            Height = 600
        };

        form.Controls.Add(plotView);
        Application.Run(form);
    }
}
