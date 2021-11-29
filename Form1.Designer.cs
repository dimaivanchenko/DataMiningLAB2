
namespace random_graphics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.progressBarRectangle = new System.Windows.Forms.ProgressBar();
            this.backgroundWorkerRectangle = new System.ComponentModel.BackgroundWorker();
            this.continueButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rectangleResult = new System.Windows.Forms.Label();
            this.progressBarSimpleMonteCarlo = new System.Windows.Forms.ProgressBar();
            this.progressBarGeometricMonteCarlo = new System.Windows.Forms.ProgressBar();
            this.directResult = new System.Windows.Forms.Label();
            this.geometricMonteCarloResult = new System.Windows.Forms.Label();
            this.simpleMonteCarloResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownK = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownGeometricMonteCarlo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSimpleMonteCarlo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRectangle = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorkerSimpleMonteCarlo = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerGeometricMonteCarlo = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGeometricMonteCarlo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSimpleMonteCarlo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectangle)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(58, 237);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(58, 268);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Enabled = false;
            this.pauseButton.Location = new System.Drawing.Point(58, 297);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 2;
            this.pauseButton.Text = "pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBarRectangle
            // 
            this.progressBarRectangle.Location = new System.Drawing.Point(58, 41);
            this.progressBarRectangle.Name = "progressBarRectangle";
            this.progressBarRectangle.Size = new System.Drawing.Size(610, 23);
            this.progressBarRectangle.TabIndex = 3;
            // 
            // backgroundWorkerRectangle
            // 
            this.backgroundWorkerRectangle.WorkerReportsProgress = true;
            this.backgroundWorkerRectangle.WorkerSupportsCancellation = true;
            this.backgroundWorkerRectangle.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerRectangle_DoWork);
            this.backgroundWorkerRectangle.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerRectangle_ProgressChanged);
            this.backgroundWorkerRectangle.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerRectangle_RunWorkerCompleted);
            // 
            // continueButton
            // 
            this.continueButton.Enabled = false;
            this.continueButton.Location = new System.Drawing.Point(58, 326);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 23);
            this.continueButton.TabIndex = 7;
            this.continueButton.Text = "continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "rectangle method";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "simple monte-carlo method";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "geometric monte-carlo method";
            // 
            // rectangleResult
            // 
            this.rectangleResult.AutoSize = true;
            this.rectangleResult.Location = new System.Drawing.Point(197, 270);
            this.rectangleResult.Name = "rectangleResult";
            this.rectangleResult.Size = new System.Drawing.Size(79, 13);
            this.rectangleResult.TabIndex = 30;
            this.rectangleResult.Text = "rectangle result";
            // 
            // progressBarSimpleMonteCarlo
            // 
            this.progressBarSimpleMonteCarlo.Location = new System.Drawing.Point(58, 107);
            this.progressBarSimpleMonteCarlo.Name = "progressBarSimpleMonteCarlo";
            this.progressBarSimpleMonteCarlo.Size = new System.Drawing.Size(610, 23);
            this.progressBarSimpleMonteCarlo.TabIndex = 31;
            // 
            // progressBarGeometricMonteCarlo
            // 
            this.progressBarGeometricMonteCarlo.Location = new System.Drawing.Point(58, 178);
            this.progressBarGeometricMonteCarlo.Name = "progressBarGeometricMonteCarlo";
            this.progressBarGeometricMonteCarlo.Size = new System.Drawing.Size(610, 23);
            this.progressBarGeometricMonteCarlo.TabIndex = 32;
            // 
            // directResult
            // 
            this.directResult.AutoSize = true;
            this.directResult.Location = new System.Drawing.Point(197, 242);
            this.directResult.Name = "directResult";
            this.directResult.Size = new System.Drawing.Size(61, 13);
            this.directResult.TabIndex = 33;
            this.directResult.Text = "direct result";
            // 
            // geometricMonteCarloResult
            // 
            this.geometricMonteCarloResult.AutoSize = true;
            this.geometricMonteCarloResult.Location = new System.Drawing.Point(197, 329);
            this.geometricMonteCarloResult.Name = "geometricMonteCarloResult";
            this.geometricMonteCarloResult.Size = new System.Drawing.Size(141, 13);
            this.geometricMonteCarloResult.TabIndex = 34;
            this.geometricMonteCarloResult.Text = "geometric Monte Carlo result";
            // 
            // simpleMonteCarloResult
            // 
            this.simpleMonteCarloResult.AutoSize = true;
            this.simpleMonteCarloResult.Location = new System.Drawing.Point(197, 298);
            this.simpleMonteCarloResult.Name = "simpleMonteCarloResult";
            this.simpleMonteCarloResult.Size = new System.Drawing.Size(124, 13);
            this.simpleMonteCarloResult.TabIndex = 35;
            this.simpleMonteCarloResult.Text = "simple Monte Carlo result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Function: F(x, y, z) = a(1-x)x * exp(-m*y) * sin(pikz)";
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.DecimalPlaces = 5;
            this.numericUpDownA.Location = new System.Drawing.Point(191, 396);
            this.numericUpDownA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownA.TabIndex = 37;
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.DecimalPlaces = 5;
            this.numericUpDownM.Location = new System.Drawing.Point(334, 396);
            this.numericUpDownM.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownM.TabIndex = 38;
            // 
            // numericUpDownK
            // 
            this.numericUpDownK.DecimalPlaces = 5;
            this.numericUpDownK.Location = new System.Drawing.Point(475, 396);
            this.numericUpDownK.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownK.Name = "numericUpDownK";
            this.numericUpDownK.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownK.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "k";
            // 
            // numericUpDownGeometricMonteCarlo
            // 
            this.numericUpDownGeometricMonteCarlo.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownGeometricMonteCarlo.Location = new System.Drawing.Point(731, 161);
            this.numericUpDownGeometricMonteCarlo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownGeometricMonteCarlo.Name = "numericUpDownGeometricMonteCarlo";
            this.numericUpDownGeometricMonteCarlo.Size = new System.Drawing.Size(166, 20);
            this.numericUpDownGeometricMonteCarlo.TabIndex = 45;
            // 
            // numericUpDownSimpleMonteCarlo
            // 
            this.numericUpDownSimpleMonteCarlo.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSimpleMonteCarlo.Location = new System.Drawing.Point(731, 103);
            this.numericUpDownSimpleMonteCarlo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownSimpleMonteCarlo.Name = "numericUpDownSimpleMonteCarlo";
            this.numericUpDownSimpleMonteCarlo.Size = new System.Drawing.Size(166, 20);
            this.numericUpDownSimpleMonteCarlo.TabIndex = 44;
            // 
            // numericUpDownRectangle
            // 
            this.numericUpDownRectangle.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRectangle.Location = new System.Drawing.Point(731, 54);
            this.numericUpDownRectangle.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownRectangle.Name = "numericUpDownRectangle";
            this.numericUpDownRectangle.Size = new System.Drawing.Size(166, 20);
            this.numericUpDownRectangle.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(728, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "statistics for geometric monte-carlo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(728, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "statistics for simple monte-carlo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(728, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "nodes for rectangle";
            // 
            // backgroundWorkerSimpleMonteCarlo
            // 
            this.backgroundWorkerSimpleMonteCarlo.WorkerReportsProgress = true;
            this.backgroundWorkerSimpleMonteCarlo.WorkerSupportsCancellation = true;
            this.backgroundWorkerSimpleMonteCarlo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSimpleMonteCarlo_DoWork);
            this.backgroundWorkerSimpleMonteCarlo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerSimpleMonteCarlo_ProgressChanged);
            this.backgroundWorkerSimpleMonteCarlo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSimpleMonteCarlo_RunWorkerCompleted);
            // 
            // backgroundWorkerGeometricMonteCarlo
            // 
            this.backgroundWorkerGeometricMonteCarlo.WorkerReportsProgress = true;
            this.backgroundWorkerGeometricMonteCarlo.WorkerSupportsCancellation = true;
            this.backgroundWorkerGeometricMonteCarlo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerGeometricMonteCarlo_DoWork);
            this.backgroundWorkerGeometricMonteCarlo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerGeometricMonteCarlo_ProgressChanged);
            this.backgroundWorkerGeometricMonteCarlo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerGeometricMonteCarlo_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(987, 505);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownGeometricMonteCarlo);
            this.Controls.Add(this.numericUpDownSimpleMonteCarlo);
            this.Controls.Add(this.numericUpDownRectangle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownK);
            this.Controls.Add(this.numericUpDownM);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleMonteCarloResult);
            this.Controls.Add(this.geometricMonteCarloResult);
            this.Controls.Add(this.directResult);
            this.Controls.Add(this.progressBarGeometricMonteCarlo);
            this.Controls.Add(this.progressBarSimpleMonteCarlo);
            this.Controls.Add(this.rectangleResult);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.progressBarRectangle);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGeometricMonteCarlo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSimpleMonteCarlo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRectangle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.ProgressBar progressBarRectangle;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRectangle;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label rectangleResult;
        private System.Windows.Forms.ProgressBar progressBarSimpleMonteCarlo;
        private System.Windows.Forms.ProgressBar progressBarGeometricMonteCarlo;
        private System.Windows.Forms.Label directResult;
        private System.Windows.Forms.Label geometricMonteCarloResult;
        private System.Windows.Forms.Label simpleMonteCarloResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.NumericUpDown numericUpDownK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownGeometricMonteCarlo;
        private System.Windows.Forms.NumericUpDown numericUpDownSimpleMonteCarlo;
        private System.Windows.Forms.NumericUpDown numericUpDownRectangle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSimpleMonteCarlo;
        private System.ComponentModel.BackgroundWorker backgroundWorkerGeometricMonteCarlo;
    }
}

