namespace BrunoAssistant
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
            AutoStart_box = new CheckBox();
            StatusBar = new Label();
            Status = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AutoStart_box
            // 
            AutoStart_box.AutoSize = true;
            AutoStart_box.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AutoStart_box.Location = new Point(12, 22);
            AutoStart_box.Name = "AutoStart_box";
            AutoStart_box.Size = new Size(243, 19);
            AutoStart_box.TabIndex = 1;
            AutoStart_box.Text = "Запускать при включении компьютера";
            AutoStart_box.UseVisualStyleBackColor = true;
            AutoStart_box.CheckedChanged += AutoStart_CheckedChanged;
            // 
            // StatusBar
            // 
            StatusBar.AutoSize = true;
            StatusBar.Font = new Font("Montserrat Black", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            StatusBar.Location = new Point(141, 172);
            StatusBar.Name = "StatusBar";
            StatusBar.Size = new Size(114, 33);
            StatusBar.TabIndex = 2;
            StatusBar.Text = "Статус:";
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new Font("Montserrat Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Status.Location = new Point(176, 209);
            Status.Name = "Status";
            Status.Size = new Size(0, 17);
            Status.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(StatusBar);
            panel1.Controls.Add(AutoStart_box);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 581);
            panel1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 581);
            Controls.Add(panel1);
            Controls.Add(Status);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Bruno";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox AutoStart_box;
        private Label StatusBar;
        private Label Status;
        private Panel panel1;
    }
}
