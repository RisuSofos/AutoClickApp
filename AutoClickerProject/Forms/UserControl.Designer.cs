namespace AutoClickerProject
{
    partial class UserControl
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
            this.components = new System.ComponentModel.Container();
            this.ScriptView = new System.Windows.Forms.ListView();
            this.Order = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Repeat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Delay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Args = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DelayTimer = new System.Windows.Forms.Timer(this.components);
            this.AddBTN = new System.Windows.Forms.Button();
            this.WaitBTN = new System.Windows.Forms.RadioButton();
            this.InputTypeBOX = new System.Windows.Forms.GroupBox();
            this.KeyboardBTN = new System.Windows.Forms.RadioButton();
            this.MouseBTN = new System.Windows.Forms.RadioButton();
            this.TimeLBL = new System.Windows.Forms.Label();
            this.TimeTBX = new System.Windows.Forms.TextBox();
            this.RepeatTBX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputTypeBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScriptView
            // 
            this.ScriptView.AccessibleDescription = "The List View of the script";
            this.ScriptView.AccessibleName = "ScriptView";
            this.ScriptView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.ScriptView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Order,
            this.Action,
            this.Repeat,
            this.Delay,
            this.Args});
            this.ScriptView.FullRowSelect = true;
            this.ScriptView.GridLines = true;
            this.ScriptView.HideSelection = false;
            this.ScriptView.Location = new System.Drawing.Point(12, 276);
            this.ScriptView.Name = "ScriptView";
            this.ScriptView.ShowGroups = false;
            this.ScriptView.Size = new System.Drawing.Size(655, 215);
            this.ScriptView.TabIndex = 0;
            this.ScriptView.UseCompatibleStateImageBehavior = false;
            this.ScriptView.View = System.Windows.Forms.View.Details;
            // 
            // Order
            // 
            this.Order.Text = "#";
            this.Order.Width = 56;
            // 
            // Action
            // 
            this.Action.Text = "Action";
            this.Action.Width = 206;
            // 
            // Repeat
            // 
            this.Repeat.Text = "Repeat";
            this.Repeat.Width = 92;
            // 
            // Delay
            // 
            this.Delay.Text = "Delay (ms)";
            this.Delay.Width = 121;
            // 
            // Args
            // 
            this.Args.Text = "Mods.";
            this.Args.Width = 176;
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(12, 247);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(75, 23);
            this.AddBTN.TabIndex = 1;
            this.AddBTN.Text = "Add";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // WaitBTN
            // 
            this.WaitBTN.AutoSize = true;
            this.WaitBTN.Checked = true;
            this.WaitBTN.Location = new System.Drawing.Point(6, 19);
            this.WaitBTN.Name = "WaitBTN";
            this.WaitBTN.Size = new System.Drawing.Size(47, 17);
            this.WaitBTN.TabIndex = 2;
            this.WaitBTN.TabStop = true;
            this.WaitBTN.Text = "Wait";
            this.WaitBTN.UseVisualStyleBackColor = true;
            this.WaitBTN.CheckedChanged += new System.EventHandler(this.WaitBTN_CheckedChanged);
            // 
            // InputTypeBOX
            // 
            this.InputTypeBOX.Controls.Add(this.KeyboardBTN);
            this.InputTypeBOX.Controls.Add(this.MouseBTN);
            this.InputTypeBOX.Controls.Add(this.WaitBTN);
            this.InputTypeBOX.Location = new System.Drawing.Point(12, 12);
            this.InputTypeBOX.Name = "InputTypeBOX";
            this.InputTypeBOX.Size = new System.Drawing.Size(284, 49);
            this.InputTypeBOX.TabIndex = 3;
            this.InputTypeBOX.TabStop = false;
            this.InputTypeBOX.Text = "Input Type";
            // 
            // KeyboardBTN
            // 
            this.KeyboardBTN.AutoSize = true;
            this.KeyboardBTN.Location = new System.Drawing.Point(189, 19);
            this.KeyboardBTN.Name = "KeyboardBTN";
            this.KeyboardBTN.Size = new System.Drawing.Size(70, 17);
            this.KeyboardBTN.TabIndex = 4;
            this.KeyboardBTN.Text = "Keyboard";
            this.KeyboardBTN.UseVisualStyleBackColor = true;
            this.KeyboardBTN.CheckedChanged += new System.EventHandler(this.KeyboardBTN_CheckedChanged);
            // 
            // MouseBTN
            // 
            this.MouseBTN.AutoSize = true;
            this.MouseBTN.Location = new System.Drawing.Point(98, 20);
            this.MouseBTN.Name = "MouseBTN";
            this.MouseBTN.Size = new System.Drawing.Size(57, 17);
            this.MouseBTN.TabIndex = 3;
            this.MouseBTN.Text = "Mouse";
            this.MouseBTN.UseVisualStyleBackColor = true;
            this.MouseBTN.CheckedChanged += new System.EventHandler(this.MouseBTN_CheckedChanged);
            // 
            // TimeLBL
            // 
            this.TimeLBL.AutoSize = true;
            this.TimeLBL.Location = new System.Drawing.Point(12, 78);
            this.TimeLBL.Name = "TimeLBL";
            this.TimeLBL.Size = new System.Drawing.Size(55, 13);
            this.TimeLBL.TabIndex = 4;
            this.TimeLBL.Text = "Time (ms):";
            // 
            // TimeTBX
            // 
            this.TimeTBX.Location = new System.Drawing.Point(67, 71);
            this.TimeTBX.MaxLength = 8;
            this.TimeTBX.Name = "TimeTBX";
            this.TimeTBX.Size = new System.Drawing.Size(100, 20);
            this.TimeTBX.TabIndex = 5;
            // 
            // RepeatTBX
            // 
            this.RepeatTBX.Location = new System.Drawing.Point(67, 97);
            this.RepeatTBX.MaxLength = 2;
            this.RepeatTBX.Name = "RepeatTBX";
            this.RepeatTBX.Size = new System.Drawing.Size(20, 20);
            this.RepeatTBX.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Repeat:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 123);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Time (ms):";
            this.label2.Visible = false;
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(679, 503);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RepeatTBX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeTBX);
            this.Controls.Add(this.TimeLBL);
            this.Controls.Add(this.InputTypeBOX);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.ScriptView);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "UserControl";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Auto Click Script";
            this.InputTypeBOX.ResumeLayout(false);
            this.InputTypeBOX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ScriptView;
        private System.Windows.Forms.ColumnHeader Order;
        private System.Windows.Forms.ColumnHeader Action;
        private System.Windows.Forms.ColumnHeader Repeat;
        private System.Windows.Forms.ColumnHeader Delay;
        private System.Windows.Forms.Timer DelayTimer;
        private System.Windows.Forms.ColumnHeader Args;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.RadioButton WaitBTN;
        private System.Windows.Forms.GroupBox InputTypeBOX;
        private System.Windows.Forms.RadioButton KeyboardBTN;
        private System.Windows.Forms.RadioButton MouseBTN;
        private System.Windows.Forms.Label TimeLBL;
        private System.Windows.Forms.TextBox TimeTBX;
        private System.Windows.Forms.TextBox RepeatTBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}

