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
            btnError = new Button();
            btnDisplayNames = new Button();
            btnDisplayDates = new Button();
            btnSortNames = new Button();
            btnSortByNameDesc = new Button();
            btnSortGPAs = new Button();
            lbxInfo = new ListBox();
            txtInfo = new TextBox();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnSortDates = new Button();
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
            // btnError
            // 
            btnError.Location = new Point(12, 84);
            btnError.Name = "btnError";
            btnError.Size = new Size(150, 30);
            btnError.TabIndex = 2;
            btnError.Text = "Error";
            btnError.UseVisualStyleBackColor = true;
            btnError.Click += btnError_Click;
            // 
            // btnDisplayNames
            // 
            btnDisplayNames.Location = new Point(12, 120);
            btnDisplayNames.Name = "btnDisplayNames";
            btnDisplayNames.Size = new Size(150, 30);
            btnDisplayNames.TabIndex = 3;
            btnDisplayNames.Text = "Display Names";
            btnDisplayNames.UseVisualStyleBackColor = true;
            btnDisplayNames.Click += btnDisplayNames_Click;
            // 
            // btnDisplayDates
            // 
            btnDisplayDates.Location = new Point(12, 156);
            btnDisplayDates.Name = "btnDisplayDates";
            btnDisplayDates.Size = new Size(150, 30);
            btnDisplayDates.TabIndex = 4;
            btnDisplayDates.Text = "Display Dates";
            btnDisplayDates.UseVisualStyleBackColor = true;
            btnDisplayDates.Click += btnDisplayDates_Click;
            // 
            // btnSortNames
            // 
            btnSortNames.Location = new Point(12, 192);
            btnSortNames.Name = "btnSortNames";
            btnSortNames.Size = new Size(150, 30);
            btnSortNames.TabIndex = 5;
            btnSortNames.Text = "Sort Names";
            btnSortNames.UseVisualStyleBackColor = true;
            btnSortNames.Click += btnSortNames_Click;
            // 
            // btnSortByNameDesc
            // 
            btnSortByNameDesc.Location = new Point(12, 228);
            btnSortByNameDesc.Name = "btnSortByNameDesc";
            btnSortByNameDesc.Size = new Size(150, 30);
            btnSortByNameDesc.TabIndex = 6;
            btnSortByNameDesc.Text = "Sort By Name Desc";
            btnSortByNameDesc.UseVisualStyleBackColor = true;
            // 
            // btnSortGPAs
            // 
            btnSortGPAs.Location = new Point(12, 264);
            btnSortGPAs.Name = "btnSortGPAs";
            btnSortGPAs.Size = new Size(150, 30);
            btnSortGPAs.TabIndex = 7;
            btnSortGPAs.Text = "Sort GPAs";
            btnSortGPAs.UseVisualStyleBackColor = true;
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
            statusStrip1.Location = new Point(0, 469);
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
            // button1
            // 
            button1.Location = new Point(12, 408);
            button1.Name = "button1";
            button1.Size = new Size(150, 30);
            button1.TabIndex = 15;
            button1.Text = "Sort GPAs";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 372);
            button2.Name = "button2";
            button2.Size = new Size(150, 30);
            button2.TabIndex = 14;
            button2.Text = "Sort By Name Desc";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 336);
            button3.Name = "button3";
            button3.Size = new Size(150, 30);
            button3.TabIndex = 13;
            button3.Text = "Sort Names";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnSortDates
            // 
            btnSortDates.Location = new Point(12, 300);
            btnSortDates.Name = "btnSortDates";
            btnSortDates.Size = new Size(150, 30);
            btnSortDates.TabIndex = 12;
            btnSortDates.Text = "Sort Dates";
            btnSortDates.UseVisualStyleBackColor = true;
            btnSortDates.Click += btnSortDates_Click;
            // 
            // frmArrays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 491);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(btnSortDates);
            Controls.Add(statusStrip1);
            Controls.Add(txtInfo);
            Controls.Add(lbxInfo);
            Controls.Add(btnSortGPAs);
            Controls.Add(btnSortByNameDesc);
            Controls.Add(btnSortNames);
            Controls.Add(btnDisplayDates);
            Controls.Add(btnDisplayNames);
            Controls.Add(btnError);
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
        private Button btnError;
        private Button btnDisplayNames;
        private Button btnDisplayDates;
        private Button btnSortNames;
        private Button btnSortByNameDesc;
        private Button btnSortGPAs;
        private ListBox lbxInfo;
        private TextBox txtInfo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnSortDates;
    }
}
