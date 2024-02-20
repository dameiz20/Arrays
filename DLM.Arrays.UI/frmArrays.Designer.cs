namespace DLM.Arrays.UI
{
    partial class frmArrays
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
            btnCreate1DArray = new Button();
            btnGPAs = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            lbxInfo = new ListBox();
            txtInfo = new TextBox();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreate1DArray
            // 
            btnCreate1DArray.Location = new Point(12, 12);
            btnCreate1DArray.Name = "btnCreate1DArray";
            btnCreate1DArray.Size = new Size(150, 30);
            btnCreate1DArray.TabIndex = 0;
            btnCreate1DArray.Text = "Create 1D Scores";
            btnCreate1DArray.UseVisualStyleBackColor = true;
            btnCreate1DArray.Click += btnCreate1DArray_Click;
            // 
            // btnGPAs
            // 
            btnGPAs.Location = new Point(12, 48);
            btnGPAs.Name = "btnGPAs";
            btnGPAs.Size = new Size(150, 30);
            btnGPAs.TabIndex = 1;
            btnGPAs.Text = "Create 1D GPAs";
            btnGPAs.UseVisualStyleBackColor = true;
            btnGPAs.Click += btnGPAs_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 84);
            button3.Name = "button3";
            button3.Size = new Size(150, 30);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 120);
            button4.Name = "button4";
            button4.Size = new Size(150, 30);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 156);
            button5.Name = "button5";
            button5.Size = new Size(150, 30);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(12, 192);
            button6.Name = "button6";
            button6.Size = new Size(150, 30);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(12, 228);
            button7.Name = "button7";
            button7.Size = new Size(150, 30);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(12, 264);
            button8.Name = "button8";
            button8.Size = new Size(150, 30);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // lbxInfo
            // 
            lbxInfo.FormattingEnabled = true;
            lbxInfo.ItemHeight = 20;
            lbxInfo.Location = new Point(188, 10);
            lbxInfo.Name = "lbxInfo";
            lbxInfo.Size = new Size(271, 284);
            lbxInfo.TabIndex = 8;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(188, 300);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(271, 27);
            txtInfo.TabIndex = 10;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 410);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(548, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 16);
            // 
            // frmArrays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 432);
            Controls.Add(statusStrip1);
            Controls.Add(txtInfo);
            Controls.Add(lbxInfo);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnGPAs);
            Controls.Add(btnCreate1DArray);
            Name = "frmArrays";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arrays";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate1DArray;
        private Button btnGPAs;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private ListBox lbxInfo;
        private TextBox txtInfo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
    }
}
