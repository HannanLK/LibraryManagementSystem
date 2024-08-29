namespace Library_Management_System.FORMS
{
    partial class interfaceSelect
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
            btn_gui = new Button();
            btn_cli = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_gui
            // 
            btn_gui.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_gui.Location = new Point(120, 158);
            btn_gui.Name = "btn_gui";
            btn_gui.Size = new Size(160, 60);
            btn_gui.TabIndex = 0;
            btn_gui.Text = "G U I";
            btn_gui.UseVisualStyleBackColor = true;
            btn_gui.Click += btn_gui_Click;
            // 
            // btn_cli
            // 
            btn_cli.BackColor = Color.Black;
            btn_cli.FlatStyle = FlatStyle.Popup;
            btn_cli.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cli.ForeColor = SystemColors.ActiveCaption;
            btn_cli.Location = new Point(417, 158);
            btn_cli.Name = "btn_cli";
            btn_cli.Size = new Size(144, 60);
            btn_cli.TabIndex = 1;
            btn_cli.Text = "C L I";
            btn_cli.UseVisualStyleBackColor = false;
            btn_cli.Click += btn_cli_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(252, 243, 207);
            label1.Location = new Point(186, 68);
            label1.Name = "label1";
            label1.Size = new Size(340, 42);
            label1.TabIndex = 2;
            label1.Text = "Select an interface";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(633, 12);
            button1.Name = "button1";
            button1.Size = new Size(48, 32);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // interfaceSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 82, 118);
            ClientSize = new Size(693, 295);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btn_cli);
            Controls.Add(btn_gui);
            ForeColor = Color.FromArgb(26, 82, 118);
            FormBorderStyle = FormBorderStyle.None;
            Name = "interfaceSelect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "interfaceSelect";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_gui;
        private Button btn_cli;
        private Label label1;
        private Button button1;
    }
}