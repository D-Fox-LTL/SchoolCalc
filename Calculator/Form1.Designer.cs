namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btOne = new Button();
            btTwo = new Button();
            btThree = new Button();
            btFour = new Button();
            btFive = new Button();
            btSix = new Button();
            btSeven = new Button();
            btEight = new Button();
            btNine = new Button();
            btZero = new Button();
            btMinus = new Button();
            btPlus = new Button();
            btMultiply = new Button();
            btDivision = new Button();
            btPower = new Button();
            btEquals = new Button();
            btDecimal = new Button();
            btErase = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(467, 64);
            txtDisplay.TabIndex = 0;
            txtDisplay.WordWrap = false;
            txtDisplay.KeyPress += txtDisplay_KeyPress;
            // 
            // btOne
            // 
            btOne.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btOne.Location = new Point(12, 82);
            btOne.Name = "btOne";
            btOne.Size = new Size(75, 75);
            btOne.TabIndex = 1;
            btOne.Text = "1";
            btOne.UseVisualStyleBackColor = true;
            btOne.Click += bt_Click;
            // 
            // btTwo
            // 
            btTwo.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btTwo.Location = new Point(93, 82);
            btTwo.Name = "btTwo";
            btTwo.Size = new Size(75, 75);
            btTwo.TabIndex = 2;
            btTwo.Text = "2";
            btTwo.UseVisualStyleBackColor = true;
            btTwo.Click += bt_Click;
            // 
            // btThree
            // 
            btThree.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btThree.Location = new Point(174, 82);
            btThree.Name = "btThree";
            btThree.Size = new Size(75, 75);
            btThree.TabIndex = 3;
            btThree.Text = "3";
            btThree.UseVisualStyleBackColor = true;
            btThree.Click += bt_Click;
            // 
            // btFour
            // 
            btFour.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btFour.Location = new Point(12, 163);
            btFour.Name = "btFour";
            btFour.Size = new Size(75, 75);
            btFour.TabIndex = 4;
            btFour.Text = "4";
            btFour.UseVisualStyleBackColor = true;
            btFour.Click += bt_Click;
            // 
            // btFive
            // 
            btFive.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btFive.Location = new Point(93, 163);
            btFive.Name = "btFive";
            btFive.Size = new Size(75, 75);
            btFive.TabIndex = 5;
            btFive.Text = "5";
            btFive.UseVisualStyleBackColor = true;
            btFive.Click += bt_Click;
            // 
            // btSix
            // 
            btSix.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btSix.Location = new Point(174, 163);
            btSix.Name = "btSix";
            btSix.Size = new Size(75, 75);
            btSix.TabIndex = 6;
            btSix.Text = "6";
            btSix.UseVisualStyleBackColor = true;
            btSix.Click += bt_Click;
            // 
            // btSeven
            // 
            btSeven.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btSeven.Location = new Point(12, 244);
            btSeven.Name = "btSeven";
            btSeven.Size = new Size(75, 75);
            btSeven.TabIndex = 7;
            btSeven.Text = "7";
            btSeven.UseVisualStyleBackColor = true;
            btSeven.Click += bt_Click;
            // 
            // btEight
            // 
            btEight.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btEight.Location = new Point(93, 244);
            btEight.Name = "btEight";
            btEight.Size = new Size(75, 75);
            btEight.TabIndex = 8;
            btEight.Text = "8";
            btEight.UseVisualStyleBackColor = true;
            btEight.Click += bt_Click;
            // 
            // btNine
            // 
            btNine.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btNine.Location = new Point(174, 244);
            btNine.Name = "btNine";
            btNine.Size = new Size(75, 75);
            btNine.TabIndex = 9;
            btNine.Text = "9";
            btNine.UseVisualStyleBackColor = true;
            btNine.Click += bt_Click;
            // 
            // btZero
            // 
            btZero.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btZero.Location = new Point(93, 325);
            btZero.Name = "btZero";
            btZero.Size = new Size(75, 75);
            btZero.TabIndex = 10;
            btZero.Text = "0";
            btZero.UseVisualStyleBackColor = true;
            btZero.Click += bt_Click;
            // 
            // btMinus
            // 
            btMinus.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btMinus.Location = new Point(404, 82);
            btMinus.Name = "btMinus";
            btMinus.Size = new Size(75, 75);
            btMinus.TabIndex = 11;
            btMinus.Text = "-";
            btMinus.UseVisualStyleBackColor = true;
            btMinus.Click += btOp_Click;
            // 
            // btPlus
            // 
            btPlus.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btPlus.Location = new Point(323, 82);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(75, 75);
            btPlus.TabIndex = 12;
            btPlus.Text = "+";
            btPlus.UseVisualStyleBackColor = true;
            btPlus.Click += btOp_Click;
            // 
            // btMultiply
            // 
            btMultiply.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btMultiply.Location = new Point(323, 163);
            btMultiply.Name = "btMultiply";
            btMultiply.Size = new Size(75, 75);
            btMultiply.TabIndex = 13;
            btMultiply.Text = "x";
            btMultiply.UseVisualStyleBackColor = true;
            btMultiply.Click += btOp_Click;
            // 
            // btDivision
            // 
            btDivision.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btDivision.Location = new Point(404, 163);
            btDivision.Name = "btDivision";
            btDivision.Size = new Size(75, 75);
            btDivision.TabIndex = 14;
            btDivision.Text = "/";
            btDivision.UseVisualStyleBackColor = true;
            btDivision.Click += btOp_Click;
            // 
            // btPower
            // 
            btPower.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btPower.Location = new Point(323, 244);
            btPower.Name = "btPower";
            btPower.Size = new Size(156, 75);
            btPower.TabIndex = 15;
            btPower.Text = "Power";
            btPower.UseVisualStyleBackColor = true;
            btPower.Click += btOp_Click;
            // 
            // btEquals
            // 
            btEquals.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btEquals.Location = new Point(323, 325);
            btEquals.Name = "btEquals";
            btEquals.Size = new Size(156, 75);
            btEquals.TabIndex = 17;
            btEquals.Text = "=";
            btEquals.UseVisualStyleBackColor = true;
            btEquals.Click += btOp_Click;
            // 
            // btDecimal
            // 
            btDecimal.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btDecimal.Location = new Point(174, 325);
            btDecimal.Name = "btDecimal";
            btDecimal.Size = new Size(75, 75);
            btDecimal.TabIndex = 18;
            btDecimal.Text = ".";
            btDecimal.UseVisualStyleBackColor = true;
            btDecimal.Click += bt_Click;
            // 
            // btErase
            // 
            btErase.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btErase.Location = new Point(12, 325);
            btErase.Name = "btErase";
            btErase.Size = new Size(75, 75);
            btErase.TabIndex = 19;
            btErase.Text = "C";
            btErase.UseVisualStyleBackColor = true;
            btErase.Click += btOp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 417);
            Controls.Add(btErase);
            Controls.Add(btDecimal);
            Controls.Add(btEquals);
            Controls.Add(btPower);
            Controls.Add(btDivision);
            Controls.Add(btMultiply);
            Controls.Add(btPlus);
            Controls.Add(btMinus);
            Controls.Add(btZero);
            Controls.Add(btNine);
            Controls.Add(btEight);
            Controls.Add(btSeven);
            Controls.Add(btSix);
            Controls.Add(btFive);
            Controls.Add(btFour);
            Controls.Add(btThree);
            Controls.Add(btTwo);
            Controls.Add(btOne);
            Controls.Add(txtDisplay);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btOne;
        private Button btTwo;
        private Button btThree;
        private Button btFour;
        private Button btFive;
        private Button btSix;
        private Button btSeven;
        private Button btEight;
        private Button btNine;
        private Button btZero;
        private Button btMinus;
        private Button btPlus;
        private Button btMultiply;
        private Button btDivision;
        private Button btPower;
        private Button btEquals;
        private Button btDecimal;
        private Button btErase;
    }
}
