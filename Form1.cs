using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace random_graphics
{
    public partial class Form1 : Form
    {
        private double resultF;
        private double rectangleIntegrationResult;
        private double rectangleIntegrationSigma;

        private double simpleMonteCarloIntegrationResult;
        private double geometricMonteCarloIntegrationResult;

        private double simpleMonteCarloDispersion;
        private double geometricMonteCarloDispersion;

        private ManualResetEvent handle = new ManualResetEvent(true);

        public Form1()
        {
            InitializeComponent();
        }

        private double FX(double x)
        {
            return (double)numericUpDownA.Value * x * (1 - x);
        }

        private double FY(double y)
        {
            return Math.Exp(-(double)numericUpDownM.Value * y);
        }

        private double FZ(double z)
        {
            return Math.Sin(Math.PI * z * (double)numericUpDownK.Value);
        }

        private void backgroundWorkerRectangle_DoWork(object sender, DoWorkEventArgs e)
        {
            double rectangleIntegrationResultX = 0;
            double rectangleIntegrationResultY = 0;
            double rectangleIntegrationResultZ = 0;

            double stepX = 1 / (double)numericUpDownRectangle.Value;
            double stepY = 1 / (double)numericUpDownRectangle.Value;
            double stepZ = 1 / (double)numericUpDownRectangle.Value;

            double sigmaX = 0;
            double sigmaY = 0;
            double sigmaZ = 0;

            for (int i = 0; i < numericUpDownRectangle.Value - 1; i++)
            {
                // if cancel signal -> cancel work
                if (backgroundWorkerRectangle.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    rectangleIntegrationResultX += stepX * FX((stepX / 2) + i * stepX);
                    rectangleIntegrationResultY += stepY * FY((stepY / 2) + i * stepY);
                    rectangleIntegrationResultZ += stepZ * FZ((stepZ / 2) + i * stepZ);

                    sigmaX += stepX * FX(stepX * i);
                    sigmaY += stepY * FY(stepY * i);
                    sigmaZ += stepZ * FZ(stepZ * i);

                    rectangleIntegrationResult = rectangleIntegrationResultX * rectangleIntegrationResultY * rectangleIntegrationResultZ;
                    rectangleIntegrationSigma = Math.Abs(rectangleIntegrationResult - sigmaX * sigmaY * sigmaZ);

                    while (!handle.WaitOne())
                    {

                    }
                    if (i % ((double)numericUpDownRectangle.Value / 100) == 0)
                    {
                        backgroundWorkerRectangle.ReportProgress((i * 100 / (int)numericUpDownRectangle.Value));
                    }
                }
            }
        }

        private void backgroundWorkerRectangle_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarRectangle.Value = e.ProgressPercentage;
        }

        private void backgroundWorkerRectangle_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!backgroundWorkerSimpleMonteCarlo.IsBusy && !backgroundWorkerGeometricMonteCarlo.IsBusy)
            {
                startButton.Enabled = true;
                stopButton.Enabled = false;
                continueButton.Enabled = false;
                pauseButton.Enabled = false;
            }

            rectangleResult.Text = "rectangles integration: " + rectangleIntegrationResult.ToString() +
                " ---- error = " + (rectangleIntegrationResult - resultF).ToString() +
                " ---- sigma = " + rectangleIntegrationSigma.ToString();

            backgroundWorkerRectangle.CancelAsync();
            backgroundWorkerRectangle.Dispose();
        }

        // start
        private void button1_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            stopButton.Enabled = true;
            continueButton.Enabled = false;
            pauseButton.Enabled = true;

            handle.Set();

            resultF = ((double)numericUpDownA.Value * Math.Pow(1, 2) / 6)
                * ((-Math.Exp(-(double)numericUpDownM.Value * 1)) / (double)numericUpDownM.Value
                - (-Math.Exp(-(double)numericUpDownM.Value * 0)) / (double)numericUpDownM.Value)
                * ((-Math.Cos(Math.PI * (double)numericUpDownK.Value * 1) / (Math.PI * (double)numericUpDownK.Value))
                - (-Math.Cos(Math.PI * (double)numericUpDownK.Value * 0) / (Math.PI * (double)numericUpDownK.Value)));

            directResult.Text = "direct result: " + resultF.ToString();

            if (!backgroundWorkerRectangle.IsBusy)
            {
                backgroundWorkerRectangle.RunWorkerAsync();
            }
            if (!backgroundWorkerSimpleMonteCarlo.IsBusy)
            {
                backgroundWorkerSimpleMonteCarlo.RunWorkerAsync();
            }
            if (!backgroundWorkerGeometricMonteCarlo.IsBusy)
            {
                backgroundWorkerGeometricMonteCarlo.RunWorkerAsync();
            }
        }

        //stop
        private void button2_Click(object sender, EventArgs e)
        {
            handle.Set();

            startButton.Enabled = true;
            stopButton.Enabled = false;
            continueButton.Enabled = false;
            pauseButton.Enabled = false;

            backgroundWorkerRectangle.CancelAsync();
            handle.Reset();
        }

        //pause
        private void button3_Click(object sender, EventArgs e)
        {
            continueButton.Enabled = true;
            startButton.Enabled = false;
            stopButton.Enabled = true;
            pauseButton.Enabled = false;

            handle.Reset();
        }

        //continue
        private void continueButton_Click(object sender, EventArgs e)
        {
            pauseButton.Enabled = true;
            startButton.Enabled = false;
            stopButton.Enabled = true;
            continueButton.Enabled = false;

            handle.Set();
        }

        private void backgroundWorkerSimpleMonteCarlo_DoWork(object sender, DoWorkEventArgs e)
        {
            var random = new Random();
            double resultPartX = 0;
            double resultPartY = 0;
            double resultPartZ = 0;
            double mX = 0;
            double mY = 0;
            double mZ = 0;
            double mY2 = 0;
            double mX2 = 0;
            double mZ2 = 0;
            double p = 1 / (double)numericUpDownSimpleMonteCarlo.Value;

            for (int i = 0; i < numericUpDownSimpleMonteCarlo.Value; i++)
            {
                // if cancel signal -> cancel work
                if (backgroundWorkerSimpleMonteCarlo.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    double randX = random.NextDouble();
                    double randY = random.NextDouble();
                    double randZ = random.NextDouble();
                    resultPartX += FX(randX) / (double)numericUpDownSimpleMonteCarlo.Value;
                    resultPartY += FY(randY) / (double)numericUpDownSimpleMonteCarlo.Value;
                    resultPartZ += FZ(randZ) / (double)numericUpDownSimpleMonteCarlo.Value;
                    mX += p * FX(randX);
                    mX2 += p * Math.Pow(FX(randX), 2);
                    mY += p * FY(randY);
                    mY2 += p * Math.Pow(FY(randY), 2);
                    mZ += p * FZ(randZ);
                    mZ2 += p * Math.Pow(FZ(randZ), 2);

                    simpleMonteCarloIntegrationResult = resultPartX * resultPartY * resultPartZ;
                    simpleMonteCarloDispersion = Math.Sqrt(Math.Abs((mX2 - mX) * (mY2 - mY) * (mZ2 - mZ)));

                    while (!handle.WaitOne())
                    {

                    }
                    if (i % ((double)numericUpDownSimpleMonteCarlo.Value / 100) == 0)
                    {
                        backgroundWorkerSimpleMonteCarlo.ReportProgress((i * 100 / (int)numericUpDownSimpleMonteCarlo.Value));
                    }
                }
            }
        }

        private void backgroundWorkerSimpleMonteCarlo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarSimpleMonteCarlo.Value = e.ProgressPercentage;
        }

        private void backgroundWorkerSimpleMonteCarlo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!backgroundWorkerRectangle.IsBusy && !backgroundWorkerGeometricMonteCarlo.IsBusy)
            {
                startButton.Enabled = true;
                stopButton.Enabled = false;
                continueButton.Enabled = false;
                pauseButton.Enabled = false;
            }

            simpleMonteCarloResult.Text = "simple monte-carlo integration: " + simpleMonteCarloIntegrationResult.ToString() +
                " ---- error = " + (simpleMonteCarloIntegrationResult - resultF).ToString() +
                " ---- sigma = " + simpleMonteCarloDispersion.ToString();

            backgroundWorkerSimpleMonteCarlo.CancelAsync();
            backgroundWorkerSimpleMonteCarlo.Dispose();
        }

        private void backgroundWorkerGeometricMonteCarlo_DoWork(object sender, DoWorkEventArgs e)
        {
            var random = new Random();
            double resultPartX = 0;
            double resultPartY = 0;
            double resultPartZ = 0;
            double mX = 0;
            double mY = 0;
            double mZ = 0;
            double mY2 = 0;
            double mX2 = 0;
            double mZ2 = 0;
            double p = 1 / (double)numericUpDownGeometricMonteCarlo.Value;

            for (int i = 0; i < numericUpDownGeometricMonteCarlo.Value; i++)
            {
                // if cancel signal -> cancel work
                if (backgroundWorkerGeometricMonteCarlo.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    double randX = random.NextDouble();
                    double randY = random.NextDouble();
                    double randZ = random.NextDouble();

                    double randFX = random.NextDouble() * 4 - 2;
                    double randFY = random.NextDouble() * 4 - 2;
                    double randFZ = random.NextDouble() * 4 - 2;

                    if (Math.Abs(FX(randX)) >= Math.Abs(randFX) && FX(randX) * randFX > 0)
                    {
                        resultPartX += 4 * randFX.CompareTo(0) / (double)numericUpDownGeometricMonteCarlo.Value;
                        mX += p * FX(randX);
                        mX2 += p * Math.Pow(FX(randX), 2);
                    }
                    if (Math.Abs(FY(randY)) >= Math.Abs(randFY) && FY(randY) * randFY > 0)
                    {
                        mY += p * FY(randY);
                        mY2 += p * Math.Pow(FY(randY), 2);
                        resultPartY += 4 * randFY.CompareTo(0) / (double)numericUpDownGeometricMonteCarlo.Value;
                    }
                    if (Math.Abs(FZ(randZ)) >= Math.Abs(randFZ) && FZ(randZ) * randFZ > 0)
                    {
                        mZ += p * FZ(randZ);
                        mZ2 += p * Math.Pow(FZ(randZ), 2);
                        resultPartZ += 4 * randFZ.CompareTo(0) / (double)numericUpDownGeometricMonteCarlo.Value;
                    }

                    geometricMonteCarloIntegrationResult = resultPartX * resultPartY * resultPartZ;
                    geometricMonteCarloDispersion = Math.Sqrt(Math.Abs((mX2 - mX) * (mY2 - mY) * (mZ2 - mZ)));

                    while (!handle.WaitOne())
                    {

                    }
                    if (i % ((double)numericUpDownGeometricMonteCarlo.Value / 100) == 0)
                    {
                        backgroundWorkerGeometricMonteCarlo.ReportProgress((i * 100 / (int)numericUpDownGeometricMonteCarlo.Value));
                    }
                }
            }
        }

        private void backgroundWorkerGeometricMonteCarlo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarGeometricMonteCarlo.Value = e.ProgressPercentage;
        }

        private void backgroundWorkerGeometricMonteCarlo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!backgroundWorkerRectangle.IsBusy && !backgroundWorkerSimpleMonteCarlo.IsBusy)
            {
                startButton.Enabled = true;
                stopButton.Enabled = false;
                continueButton.Enabled = false;
                pauseButton.Enabled = false;
            }

            geometricMonteCarloResult.Text = "geometric monte-carlo integration: " + geometricMonteCarloIntegrationResult.ToString() +
                 " ---- error = " + (geometricMonteCarloIntegrationResult - resultF).ToString() +
                 " ---- sigma = " + geometricMonteCarloDispersion.ToString();


            backgroundWorkerGeometricMonteCarlo.CancelAsync();
            backgroundWorkerGeometricMonteCarlo.Dispose();
        }
    }
}
