namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.iterationsNumLabel = new System.Windows.Forms.Label();
            this.aliveCountLabel = new System.Windows.Forms.Label();
            this.aliveCountNumLabel = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.timerSpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.skipButton = new System.Windows.Forms.Button();
            this.gridVisibilityButton = new System.Windows.Forms.Button();
            this.iterationsDelayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timerSpeedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 649);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.AutoSize = true;
            this.iterationsLabel.Location = new System.Drawing.Point(12, 690);
            this.iterationsLabel.Name = "iterationsLabel";
            this.iterationsLabel.Size = new System.Drawing.Size(74, 17);
            this.iterationsLabel.TabIndex = 1;
            this.iterationsLabel.Text = "Iterations: ";
            // 
            // iterationsNumLabel
            // 
            this.iterationsNumLabel.AutoSize = true;
            this.iterationsNumLabel.Location = new System.Drawing.Point(92, 690);
            this.iterationsNumLabel.Name = "iterationsNumLabel";
            this.iterationsNumLabel.Size = new System.Drawing.Size(16, 17);
            this.iterationsNumLabel.TabIndex = 2;
            this.iterationsNumLabel.Text = "0";
            // 
            // aliveCountLabel
            // 
            this.aliveCountLabel.AutoSize = true;
            this.aliveCountLabel.Location = new System.Drawing.Point(12, 717);
            this.aliveCountLabel.Name = "aliveCountLabel";
            this.aliveCountLabel.Size = new System.Drawing.Size(74, 17);
            this.aliveCountLabel.TabIndex = 3;
            this.aliveCountLabel.Text = "Alive cells:";
            // 
            // aliveCountNumLabel
            // 
            this.aliveCountNumLabel.AutoSize = true;
            this.aliveCountNumLabel.Location = new System.Drawing.Point(92, 717);
            this.aliveCountNumLabel.Name = "aliveCountNumLabel";
            this.aliveCountNumLabel.Size = new System.Drawing.Size(16, 17);
            this.aliveCountNumLabel.TabIndex = 4;
            this.aliveCountNumLabel.Text = "0";
            // 
            // pauseButton
            // 
            this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
            this.pauseButton.Location = new System.Drawing.Point(281, 679);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 67);
            this.pauseButton.TabIndex = 5;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Image = ((System.Drawing.Image)(resources.GetObject("continueButton.Image")));
            this.continueButton.Location = new System.Drawing.Point(200, 679);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(75, 67);
            this.continueButton.TabIndex = 6;
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // timerSpeedTrackBar
            // 
            this.timerSpeedTrackBar.Location = new System.Drawing.Point(586, 711);
            this.timerSpeedTrackBar.Maximum = 120;
            this.timerSpeedTrackBar.Minimum = 30;
            this.timerSpeedTrackBar.Name = "timerSpeedTrackBar";
            this.timerSpeedTrackBar.Size = new System.Drawing.Size(104, 56);
            this.timerSpeedTrackBar.TabIndex = 7;
            this.timerSpeedTrackBar.Value = 100;
            this.timerSpeedTrackBar.Scroll += new System.EventHandler(this.TimerSpeedTrackBar_Click);
            // 
            // skipButton
            // 
            this.skipButton.Image = ((System.Drawing.Image)(resources.GetObject("skipButton.Image")));
            this.skipButton.Location = new System.Drawing.Point(362, 679);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(75, 67);
            this.skipButton.TabIndex = 8;
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.SkipButton_Click);
            // 
            // gridVisibilityButton
            // 
            this.gridVisibilityButton.Image = ((System.Drawing.Image)(resources.GetObject("gridVisibilityButton.Image")));
            this.gridVisibilityButton.Location = new System.Drawing.Point(443, 679);
            this.gridVisibilityButton.Name = "gridVisibilityButton";
            this.gridVisibilityButton.Size = new System.Drawing.Size(75, 67);
            this.gridVisibilityButton.TabIndex = 9;
            this.gridVisibilityButton.UseVisualStyleBackColor = true;
            this.gridVisibilityButton.Click += new System.EventHandler(this.GridVisibilityButton_Click);
            // 
            // iterationsDelayLabel
            // 
            this.iterationsDelayLabel.AutoSize = true;
            this.iterationsDelayLabel.Location = new System.Drawing.Point(583, 679);
            this.iterationsDelayLabel.Name = "iterationsDelayLabel";
            this.iterationsDelayLabel.Size = new System.Drawing.Size(108, 17);
            this.iterationsDelayLabel.TabIndex = 10;
            this.iterationsDelayLabel.Text = "Iterations delay:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 779);
            this.Controls.Add(this.iterationsDelayLabel);
            this.Controls.Add(this.gridVisibilityButton);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.timerSpeedTrackBar);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.aliveCountNumLabel);
            this.Controls.Add(this.aliveCountLabel);
            this.Controls.Add(this.iterationsNumLabel);
            this.Controls.Add(this.iterationsLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timerSpeedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label iterationsLabel;
        private System.Windows.Forms.Label iterationsNumLabel;
        private System.Windows.Forms.Label aliveCountLabel;
        private System.Windows.Forms.Label aliveCountNumLabel;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.TrackBar timerSpeedTrackBar;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button gridVisibilityButton;
        private System.Windows.Forms.Label iterationsDelayLabel;
    }
}

