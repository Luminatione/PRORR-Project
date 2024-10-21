using OxyPlot;
using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using PRORR;
using PRORR.Utility;
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

    public void VisualizePolynomial(Polynomial polynomial, FloatRange floatRange, int degree)
    {
        var plotModel = new PlotModel { Title = "Polynomial" };
        var series = new LineSeries { Title = "Polynomial", Color = OxyColors.Blue };
        for (int i = (int) floatRange.Min; i <= floatRange.Max; ++i)
        {
            series.Points.Add(new DataPoint(i, polynomial.Calculate(Enumerable.Repeat((float)i, degree).ToArray())));
        }

        plotModel.Series.Add(series);

        var plotView = new PlotView { Model = plotModel, Dock = DockStyle.Fill };
        var form = new Form
        {
            Text = "Polynomial Visualization",
            Width = 800,
            Height = 600
        };

        form.Controls.Add(plotView);
        Application.Run(form);
    }
}
