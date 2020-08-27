namespace JSONParser1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmdDeserialize = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDebugOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(23, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raw JSON (Serialized String)";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(20, 21);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(746, 134);
            this.txtInput.TabIndex = 0;
            // 
            // cmdDeserialize
            // 
            this.cmdDeserialize.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdDeserialize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdDeserialize.Location = new System.Drawing.Point(43, 206);
            this.cmdDeserialize.Name = "cmdDeserialize";
            this.cmdDeserialize.Size = new System.Drawing.Size(170, 29);
            this.cmdDeserialize.TabIndex = 1;
            this.cmdDeserialize.Text = "Deserialize";
            this.cmdDeserialize.UseVisualStyleBackColor = false;
            this.cmdDeserialize.Click += new System.EventHandler(this.cmdDeserialize_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmdClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdClear.Location = new System.Drawing.Point(220, 206);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(168, 29);
            this.cmdClear.TabIndex = 2;
            this.cmdClear.Text = "Clear Debug";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtDebugOutput);
            this.groupBox2.Location = new System.Drawing.Point(23, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(792, 203);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debug Output";
            // 
            // txtDebugOutput
            // 
            this.txtDebugOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDebugOutput.Location = new System.Drawing.Point(20, 21);
            this.txtDebugOutput.Multiline = true;
            this.txtDebugOutput.Name = "txtDebugOutput";
            this.txtDebugOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDebugOutput.Size = new System.Drawing.Size(746, 162);
            this.txtDebugOutput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdDeserialize);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "JSON Parser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button cmdDeserialize;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDebugOutput;
    }
}

