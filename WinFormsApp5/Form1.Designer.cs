namespace WinFormsApp5
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
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            cmbCommand = new ComboBox();
            btnResult = new Button();
            btnClear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblAnswer = new Label();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(36, 57);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(266, 27);
            txtNumber1.TabIndex = 0;
            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(36, 118);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(266, 27);
            txtNumber2.TabIndex = 1;
            // 
            // cmbCommand
            // 
            cmbCommand.FormattingEnabled = true;
            cmbCommand.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbCommand.Location = new Point(36, 187);
            cmbCommand.Name = "cmbCommand";
            cmbCommand.Size = new Size(266, 28);
            cmbCommand.TabIndex = 2;
            // 
            // btnResult
            // 
            btnResult.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResult.Location = new Point(36, 289);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(266, 53);
            btnResult.TabIndex = 3;
            btnResult.Text = "Result";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(36, 363);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(266, 53);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(105, 19);
            label1.TabIndex = 5;
            label1.Text = "Number one";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 96);
            label2.Name = "label2";
            label2.Size = new Size(105, 19);
            label2.TabIndex = 6;
            label2.Text = "Number two";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 164);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 7;
            label3.Text = "Command";
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnswer.Location = new Point(36, 239);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(98, 19);
            lblAnswer.TabIndex = 8;
            lblAnswer.Text = "Answer:   0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(346, 448);
            Controls.Add(lblAnswer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnResult);
            Controls.Add(cmbCommand);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private ComboBox cmbCommand;
        private Button btnResult;
        private Button btnClear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblAnswer;
    }
}
