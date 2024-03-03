namespace Lab3_Pizza_Order
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
            cheesePizzaRadioButton = new RadioButton();
            pepperoniPizzaRadioButton = new RadioButton();
            veggiePizzaRadioButton = new RadioButton();
            quantityNumericUpDown = new NumericUpDown();
            calculateButton = new Button();
            meatLoversPizzaRadioButton = new RadioButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // cheesePizzaRadioButton
            // 
            cheesePizzaRadioButton.AutoSize = true;
            cheesePizzaRadioButton.Location = new Point(20, 20);
            cheesePizzaRadioButton.Name = "cheesePizzaRadioButton";
            cheesePizzaRadioButton.Size = new Size(92, 19);
            cheesePizzaRadioButton.TabIndex = 0;
            cheesePizzaRadioButton.TabStop = true;
            cheesePizzaRadioButton.Text = "Cheese Pizza";
            cheesePizzaRadioButton.UseVisualStyleBackColor = true;
            // 
            // pepperoniPizzaRadioButton
            // 
            pepperoniPizzaRadioButton.AutoSize = true;
            pepperoniPizzaRadioButton.Location = new Point(20, 50);
            pepperoniPizzaRadioButton.Name = "pepperoniPizzaRadioButton";
            pepperoniPizzaRadioButton.Size = new Size(108, 19);
            pepperoniPizzaRadioButton.TabIndex = 1;
            pepperoniPizzaRadioButton.TabStop = true;
            pepperoniPizzaRadioButton.Text = "Pepperoni Pizza";
            pepperoniPizzaRadioButton.UseVisualStyleBackColor = true;
            // 
            // veggiePizzaRadioButton
            // 
            veggiePizzaRadioButton.AutoSize = true;
            veggiePizzaRadioButton.Location = new Point(20, 80);
            veggiePizzaRadioButton.Name = "veggiePizzaRadioButton";
            veggiePizzaRadioButton.Size = new Size(89, 19);
            veggiePizzaRadioButton.TabIndex = 2;
            veggiePizzaRadioButton.TabStop = true;
            veggiePizzaRadioButton.Text = "Veggie Pizza";
            veggiePizzaRadioButton.UseVisualStyleBackColor = true;
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Location = new Point(150, 20);
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new Size(50, 23);
            quantityNumericUpDown.TabIndex = 3;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(30, 160);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // meatLoversPizzaRadioButton
            // 
            meatLoversPizzaRadioButton.AutoSize = true;
            meatLoversPizzaRadioButton.Location = new Point(20, 110);
            meatLoversPizzaRadioButton.Name = "meatLoversPizzaRadioButton";
            meatLoversPizzaRadioButton.Size = new Size(81, 19);
            meatLoversPizzaRadioButton.TabIndex = 7;
            meatLoversPizzaRadioButton.TabStop = true;
            meatLoversPizzaRadioButton.Text = "Meat Pizza";
            meatLoversPizzaRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 165);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 221);
            Controls.Add(label1);
            Controls.Add(meatLoversPizzaRadioButton);
            Controls.Add(calculateButton);
            Controls.Add(quantityNumericUpDown);
            Controls.Add(veggiePizzaRadioButton);
            Controls.Add(pepperoniPizzaRadioButton);
            Controls.Add(cheesePizzaRadioButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton cheesePizzaRadioButton;
        private RadioButton pepperoniPizzaRadioButton;
        private RadioButton veggiePizzaRadioButton;
        private NumericUpDown quantityNumericUpDown;
        private Button calculateButton;
        private RadioButton meatLoversPizzaRadioButton;
        private Label label1;
    }
}
