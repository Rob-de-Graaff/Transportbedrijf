namespace Transportbedrijf
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.panelDistance = new System.Windows.Forms.Panel();
            this.textBoxDistanceNL = new System.Windows.Forms.TextBox();
            this.textBoxDistanceForeign = new System.Windows.Forms.TextBox();
            this.labelDistanceNL = new System.Windows.Forms.Label();
            this.labelDistanceForeign = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.panelCargoTypeSelection = new System.Windows.Forms.Panel();
            this.radioButtonNonLiquids = new System.Windows.Forms.RadioButton();
            this.labelNonLiquids = new System.Windows.Forms.Label();
            this.radioButtonLiquids = new System.Windows.Forms.RadioButton();
            this.labelLiquid = new System.Windows.Forms.Label();
            this.panelCosts = new System.Windows.Forms.Panel();
            this.labelTicketsTotal = new System.Windows.Forms.Label();
            this.labelPriceTotal = new System.Windows.Forms.Label();
            this.panelInfo1 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelVolumeInfo = new System.Windows.Forms.Label();
            this.labelWeightInfo = new System.Windows.Forms.Label();
            this.labelWeightPriceNonLiquid = new System.Windows.Forms.Label();
            this.labelVolumePriceNonLiquid = new System.Windows.Forms.Label();
            this.panelInfo2 = new System.Windows.Forms.Panel();
            this.labelVolumePriceLiquid = new System.Windows.Forms.Label();
            this.labelWeightPriceLiquid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelInfo3 = new System.Windows.Forms.Panel();
            this.labeltransportationCosts = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSurtaxForeignRoads = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSurtaxCustomsFees = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSurtaxCustomsFeesMin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelDistance.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelCargoTypeSelection.SuspendLayout();
            this.panelCosts.SuspendLayout();
            this.panelInfo1.SuspendLayout();
            this.panelInfo2.SuspendLayout();
            this.panelInfo3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelInfo3);
            this.panel1.Controls.Add(this.panelDistance);
            this.panel1.Controls.Add(this.panelInfo2);
            this.panel1.Controls.Add(this.panelInfo1);
            this.panel1.Controls.Add(this.panelCosts);
            this.panel1.Controls.Add(this.buttonCalculate);
            this.panel1.Controls.Add(this.panelContent);
            this.panel1.Controls.Add(this.panelCargoTypeSelection);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 454);
            this.panel1.TabIndex = 0;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(1082, 426);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 12;
            this.buttonCalculate.Text = "Bereken";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // panelDistance
            // 
            this.panelDistance.Controls.Add(this.textBoxDistanceNL);
            this.panelDistance.Controls.Add(this.textBoxDistanceForeign);
            this.panelDistance.Controls.Add(this.labelDistanceNL);
            this.panelDistance.Controls.Add(this.labelDistanceForeign);
            this.panelDistance.Location = new System.Drawing.Point(4, 147);
            this.panelDistance.Name = "panelDistance";
            this.panelDistance.Size = new System.Drawing.Size(238, 66);
            this.panelDistance.TabIndex = 11;
            // 
            // textBoxDistanceNL
            // 
            this.textBoxDistanceNL.Location = new System.Drawing.Point(135, 5);
            this.textBoxDistanceNL.Name = "textBoxDistanceNL";
            this.textBoxDistanceNL.Size = new System.Drawing.Size(100, 22);
            this.textBoxDistanceNL.TabIndex = 6;
            this.textBoxDistanceNL.Text = "0";
            // 
            // textBoxDistanceForeign
            // 
            this.textBoxDistanceForeign.Location = new System.Drawing.Point(135, 33);
            this.textBoxDistanceForeign.Name = "textBoxDistanceForeign";
            this.textBoxDistanceForeign.Size = new System.Drawing.Size(100, 22);
            this.textBoxDistanceForeign.TabIndex = 7;
            this.textBoxDistanceForeign.Text = "0";
            // 
            // labelDistanceNL
            // 
            this.labelDistanceNL.AutoSize = true;
            this.labelDistanceNL.Location = new System.Drawing.Point(3, 8);
            this.labelDistanceNL.Name = "labelDistanceNL";
            this.labelDistanceNL.Size = new System.Drawing.Size(85, 17);
            this.labelDistanceNL.TabIndex = 4;
            this.labelDistanceNL.Text = "afstand NL :";
            // 
            // labelDistanceForeign
            // 
            this.labelDistanceForeign.AutoSize = true;
            this.labelDistanceForeign.Location = new System.Drawing.Point(3, 36);
            this.labelDistanceForeign.Name = "labelDistanceForeign";
            this.labelDistanceForeign.Size = new System.Drawing.Size(84, 17);
            this.labelDistanceForeign.TabIndex = 5;
            this.labelDistanceForeign.Text = "afstand BL :";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.textBoxVolume);
            this.panelContent.Controls.Add(this.textBoxWeight);
            this.panelContent.Controls.Add(this.labelVolume);
            this.panelContent.Controls.Add(this.labelWeight);
            this.panelContent.Location = new System.Drawing.Point(7, 75);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(238, 66);
            this.panelContent.TabIndex = 10;
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(135, 5);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(100, 22);
            this.textBoxVolume.TabIndex = 6;
            this.textBoxVolume.Text = "0";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(135, 33);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxWeight.TabIndex = 7;
            this.textBoxWeight.Text = "0";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(3, 8);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(63, 17);
            this.labelVolume.TabIndex = 4;
            this.labelVolume.Text = "Volume :";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(3, 36);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(66, 17);
            this.labelWeight.TabIndex = 5;
            this.labelWeight.Text = "Gewicht :";
            // 
            // panelCargoTypeSelection
            // 
            this.panelCargoTypeSelection.Controls.Add(this.radioButtonNonLiquids);
            this.panelCargoTypeSelection.Controls.Add(this.labelNonLiquids);
            this.panelCargoTypeSelection.Controls.Add(this.radioButtonLiquids);
            this.panelCargoTypeSelection.Controls.Add(this.labelLiquid);
            this.panelCargoTypeSelection.Location = new System.Drawing.Point(7, 3);
            this.panelCargoTypeSelection.Name = "panelCargoTypeSelection";
            this.panelCargoTypeSelection.Size = new System.Drawing.Size(238, 66);
            this.panelCargoTypeSelection.TabIndex = 9;
            // 
            // radioButtonNonLiquids
            // 
            this.radioButtonNonLiquids.AutoSize = true;
            this.radioButtonNonLiquids.Location = new System.Drawing.Point(125, 3);
            this.radioButtonNonLiquids.Name = "radioButtonNonLiquids";
            this.radioButtonNonLiquids.Size = new System.Drawing.Size(109, 21);
            this.radioButtonNonLiquids.TabIndex = 0;
            this.radioButtonNonLiquids.TabStop = true;
            this.radioButtonNonLiquids.Text = "niet-vloeistof";
            this.radioButtonNonLiquids.UseVisualStyleBackColor = true;
            // 
            // labelNonLiquids
            // 
            this.labelNonLiquids.AutoSize = true;
            this.labelNonLiquids.Location = new System.Drawing.Point(4, 5);
            this.labelNonLiquids.Name = "labelNonLiquids";
            this.labelNonLiquids.Size = new System.Drawing.Size(88, 17);
            this.labelNonLiquids.TabIndex = 1;
            this.labelNonLiquids.Text = "niet-vloeistof";
            // 
            // radioButtonLiquids
            // 
            this.radioButtonLiquids.AutoSize = true;
            this.radioButtonLiquids.Location = new System.Drawing.Point(125, 30);
            this.radioButtonLiquids.Name = "radioButtonLiquids";
            this.radioButtonLiquids.Size = new System.Drawing.Size(81, 21);
            this.radioButtonLiquids.TabIndex = 3;
            this.radioButtonLiquids.TabStop = true;
            this.radioButtonLiquids.Text = "vloeistof";
            this.radioButtonLiquids.UseVisualStyleBackColor = true;
            // 
            // labelLiquid
            // 
            this.labelLiquid.AutoSize = true;
            this.labelLiquid.Location = new System.Drawing.Point(4, 32);
            this.labelLiquid.Name = "labelLiquid";
            this.labelLiquid.Size = new System.Drawing.Size(60, 17);
            this.labelLiquid.TabIndex = 2;
            this.labelLiquid.Text = "vloeistof";
            // 
            // panelCosts
            // 
            this.panelCosts.Controls.Add(this.labelTicketsTotal);
            this.panelCosts.Controls.Add(this.labelPriceTotal);
            this.panelCosts.Location = new System.Drawing.Point(248, 358);
            this.panelCosts.Name = "panelCosts";
            this.panelCosts.Size = new System.Drawing.Size(909, 62);
            this.panelCosts.TabIndex = 13;
            // 
            // labelTicketsTotal
            // 
            this.labelTicketsTotal.AutoSize = true;
            this.labelTicketsTotal.Location = new System.Drawing.Point(4, 0);
            this.labelTicketsTotal.Name = "labelTicketsTotal";
            this.labelTicketsTotal.Size = new System.Drawing.Size(13, 17);
            this.labelTicketsTotal.TabIndex = 24;
            this.labelTicketsTotal.Text = "-";
            // 
            // labelPriceTotal
            // 
            this.labelPriceTotal.AutoSize = true;
            this.labelPriceTotal.Location = new System.Drawing.Point(4, 36);
            this.labelPriceTotal.Name = "labelPriceTotal";
            this.labelPriceTotal.Size = new System.Drawing.Size(13, 17);
            this.labelPriceTotal.TabIndex = 23;
            this.labelPriceTotal.Text = "-";
            // 
            // panelInfo1
            // 
            this.panelInfo1.Controls.Add(this.labelVolumePriceNonLiquid);
            this.panelInfo1.Controls.Add(this.labelWeightPriceNonLiquid);
            this.panelInfo1.Controls.Add(this.labelWeightInfo);
            this.panelInfo1.Controls.Add(this.labelVolumeInfo);
            this.panelInfo1.Controls.Add(this.labelName);
            this.panelInfo1.Location = new System.Drawing.Point(248, 3);
            this.panelInfo1.Name = "panelInfo1";
            this.panelInfo1.Size = new System.Drawing.Size(161, 66);
            this.panelInfo1.TabIndex = 14;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(4, 4);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(118, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "niet-vloeistof prijs";
            // 
            // labelVolumeInfo
            // 
            this.labelVolumeInfo.AutoSize = true;
            this.labelVolumeInfo.Location = new System.Drawing.Point(4, 21);
            this.labelVolumeInfo.Name = "labelVolumeInfo";
            this.labelVolumeInfo.Size = new System.Drawing.Size(63, 17);
            this.labelVolumeInfo.TabIndex = 1;
            this.labelVolumeInfo.Text = "Volume :";
            // 
            // labelWeightInfo
            // 
            this.labelWeightInfo.AutoSize = true;
            this.labelWeightInfo.Location = new System.Drawing.Point(4, 41);
            this.labelWeightInfo.Name = "labelWeightInfo";
            this.labelWeightInfo.Size = new System.Drawing.Size(66, 17);
            this.labelWeightInfo.TabIndex = 2;
            this.labelWeightInfo.Text = "Gewicht :";
            // 
            // labelWeightPriceNonLiquid
            // 
            this.labelWeightPriceNonLiquid.AutoSize = true;
            this.labelWeightPriceNonLiquid.Location = new System.Drawing.Point(68, 41);
            this.labelWeightPriceNonLiquid.Name = "labelWeightPriceNonLiquid";
            this.labelWeightPriceNonLiquid.Size = new System.Drawing.Size(13, 17);
            this.labelWeightPriceNonLiquid.TabIndex = 3;
            this.labelWeightPriceNonLiquid.Text = "-";
            // 
            // labelVolumePriceNonLiquid
            // 
            this.labelVolumePriceNonLiquid.AutoSize = true;
            this.labelVolumePriceNonLiquid.Location = new System.Drawing.Point(68, 21);
            this.labelVolumePriceNonLiquid.Name = "labelVolumePriceNonLiquid";
            this.labelVolumePriceNonLiquid.Size = new System.Drawing.Size(13, 17);
            this.labelVolumePriceNonLiquid.TabIndex = 4;
            this.labelVolumePriceNonLiquid.Text = "-";
            // 
            // panelInfo2
            // 
            this.panelInfo2.Controls.Add(this.labelVolumePriceLiquid);
            this.panelInfo2.Controls.Add(this.labelWeightPriceLiquid);
            this.panelInfo2.Controls.Add(this.label3);
            this.panelInfo2.Controls.Add(this.label4);
            this.panelInfo2.Controls.Add(this.label5);
            this.panelInfo2.Location = new System.Drawing.Point(248, 75);
            this.panelInfo2.Name = "panelInfo2";
            this.panelInfo2.Size = new System.Drawing.Size(161, 66);
            this.panelInfo2.TabIndex = 15;
            // 
            // labelVolumePriceLiquid
            // 
            this.labelVolumePriceLiquid.AutoSize = true;
            this.labelVolumePriceLiquid.Location = new System.Drawing.Point(68, 21);
            this.labelVolumePriceLiquid.Name = "labelVolumePriceLiquid";
            this.labelVolumePriceLiquid.Size = new System.Drawing.Size(13, 17);
            this.labelVolumePriceLiquid.TabIndex = 4;
            this.labelVolumePriceLiquid.Text = "-";
            // 
            // labelWeightPriceLiquid
            // 
            this.labelWeightPriceLiquid.AutoSize = true;
            this.labelWeightPriceLiquid.Location = new System.Drawing.Point(68, 41);
            this.labelWeightPriceLiquid.Name = "labelWeightPriceLiquid";
            this.labelWeightPriceLiquid.Size = new System.Drawing.Size(13, 17);
            this.labelWeightPriceLiquid.TabIndex = 3;
            this.labelWeightPriceLiquid.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gewicht :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Volume :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "vloeistof prijs";
            // 
            // panelInfo3
            // 
            this.panelInfo3.Controls.Add(this.labeltransportationCosts);
            this.panelInfo3.Controls.Add(this.label7);
            this.panelInfo3.Controls.Add(this.label8);
            this.panelInfo3.Location = new System.Drawing.Point(248, 147);
            this.panelInfo3.Name = "panelInfo3";
            this.panelInfo3.Size = new System.Drawing.Size(161, 66);
            this.panelInfo3.TabIndex = 16;
            // 
            // labeltransportationCosts
            // 
            this.labeltransportationCosts.AutoSize = true;
            this.labeltransportationCosts.Location = new System.Drawing.Point(4, 38);
            this.labeltransportationCosts.Name = "labeltransportationCosts";
            this.labeltransportationCosts.Size = new System.Drawing.Size(13, 17);
            this.labeltransportationCosts.TabIndex = 3;
            this.labeltransportationCosts.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "transportkosten / Km :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "transportkosten";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelSurtaxCustomsFeesMin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelSurtaxCustomsFees);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.labelSurtaxForeignRoads);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(248, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 133);
            this.panel2.TabIndex = 17;
            // 
            // labelSurtaxForeignRoads
            // 
            this.labelSurtaxForeignRoads.AutoSize = true;
            this.labelSurtaxForeignRoads.Location = new System.Drawing.Point(4, 38);
            this.labelSurtaxForeignRoads.Name = "labelSurtaxForeignRoads";
            this.labelSurtaxForeignRoads.Size = new System.Drawing.Size(13, 17);
            this.labelSurtaxForeignRoads.TabIndex = 3;
            this.labelSurtaxForeignRoads.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "toeslag buitenlandse wegen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "toeslagen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "toeslag douaneKosten";
            // 
            // labelSurtaxCustomsFees
            // 
            this.labelSurtaxCustomsFees.AutoSize = true;
            this.labelSurtaxCustomsFees.Location = new System.Drawing.Point(4, 72);
            this.labelSurtaxCustomsFees.Name = "labelSurtaxCustomsFees";
            this.labelSurtaxCustomsFees.Size = new System.Drawing.Size(13, 17);
            this.labelSurtaxCustomsFees.TabIndex = 5;
            this.labelSurtaxCustomsFees.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "toeslag douaneKosten minimmum";
            // 
            // labelSurtaxCustomsFeesMin
            // 
            this.labelSurtaxCustomsFeesMin.AutoSize = true;
            this.labelSurtaxCustomsFeesMin.Location = new System.Drawing.Point(4, 106);
            this.labelSurtaxCustomsFeesMin.Name = "labelSurtaxCustomsFeesMin";
            this.labelSurtaxCustomsFeesMin.Size = new System.Drawing.Size(13, 17);
            this.labelSurtaxCustomsFeesMin.TabIndex = 7;
            this.labelSurtaxCustomsFeesMin.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 475);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelDistance.ResumeLayout(false);
            this.panelDistance.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelCargoTypeSelection.ResumeLayout(false);
            this.panelCargoTypeSelection.PerformLayout();
            this.panelCosts.ResumeLayout(false);
            this.panelCosts.PerformLayout();
            this.panelInfo1.ResumeLayout(false);
            this.panelInfo1.PerformLayout();
            this.panelInfo2.ResumeLayout(false);
            this.panelInfo2.PerformLayout();
            this.panelInfo3.ResumeLayout(false);
            this.panelInfo3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Panel panelDistance;
        private System.Windows.Forms.TextBox textBoxDistanceNL;
        private System.Windows.Forms.TextBox textBoxDistanceForeign;
        private System.Windows.Forms.Label labelDistanceNL;
        private System.Windows.Forms.Label labelDistanceForeign;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Panel panelCargoTypeSelection;
        private System.Windows.Forms.RadioButton radioButtonNonLiquids;
        private System.Windows.Forms.Label labelNonLiquids;
        private System.Windows.Forms.RadioButton radioButtonLiquids;
        private System.Windows.Forms.Label labelLiquid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSurtaxCustomsFeesMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSurtaxCustomsFees;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSurtaxForeignRoads;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelInfo3;
        private System.Windows.Forms.Label labeltransportationCosts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelInfo2;
        private System.Windows.Forms.Label labelVolumePriceLiquid;
        private System.Windows.Forms.Label labelWeightPriceLiquid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelInfo1;
        private System.Windows.Forms.Label labelVolumePriceNonLiquid;
        private System.Windows.Forms.Label labelWeightPriceNonLiquid;
        private System.Windows.Forms.Label labelWeightInfo;
        private System.Windows.Forms.Label labelVolumeInfo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelCosts;
        private System.Windows.Forms.Label labelTicketsTotal;
        private System.Windows.Forms.Label labelPriceTotal;
    }
}

