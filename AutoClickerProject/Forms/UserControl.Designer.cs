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
            this.PositionBOX = new System.Windows.Forms.GroupBox();
            this.yPosTBX = new System.Windows.Forms.TextBox();
            this.YLBL = new System.Windows.Forms.Label();
            this.xPosTBX = new System.Windows.Forms.TextBox();
            this.XLBL = new System.Windows.Forms.Label();
            this.PosBlankCBOX = new System.Windows.Forms.CheckBox();
            this.EventSelect = new System.Windows.Forms.ComboBox();
            this.EventLBL = new System.Windows.Forms.Label();
            this.ModLBL = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RemoveBTN = new System.Windows.Forms.Button();
            this.PopOutBTN = new System.Windows.Forms.Button();
            this.InspectBTN = new System.Windows.Forms.Button();
            this.RemoveAllBTN = new System.Windows.Forms.Button();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.TimeCBOX = new System.Windows.Forms.CheckBox();
            this.InputTypeBOX.SuspendLayout();
            this.PositionBOX.SuspendLayout();
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
            this.ScriptView.MultiSelect = false;
            this.ScriptView.Name = "ScriptView";
            this.ScriptView.ShowGroups = false;
            this.ScriptView.Size = new System.Drawing.Size(637, 215);
            this.ScriptView.TabIndex = 0;
            this.ScriptView.UseCompatibleStateImageBehavior = false;
            this.ScriptView.View = System.Windows.Forms.View.Details;
            // 
            // Order
            // 
            this.Order.Text = "#";
            this.Order.Width = 38;
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
            this.AddBTN.Location = new System.Drawing.Point(9, 150);
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
            this.TimeLBL.Location = new System.Drawing.Point(6, 74);
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
            this.RepeatTBX.Size = new System.Drawing.Size(39, 20);
            this.RepeatTBX.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Repeat:";
            // 
            // PositionBOX
            // 
            this.PositionBOX.Controls.Add(this.PosBlankCBOX);
            this.PositionBOX.Controls.Add(this.yPosTBX);
            this.PositionBOX.Controls.Add(this.xPosTBX);
            this.PositionBOX.Controls.Add(this.YLBL);
            this.PositionBOX.Controls.Add(this.XLBL);
            this.PositionBOX.Location = new System.Drawing.Point(328, 12);
            this.PositionBOX.Name = "PositionBOX";
            this.PositionBOX.Size = new System.Drawing.Size(180, 66);
            this.PositionBOX.TabIndex = 10;
            this.PositionBOX.TabStop = false;
            this.PositionBOX.Text = "Position";
            this.PositionBOX.Visible = false;
            // 
            // yPosTBX
            // 
            this.yPosTBX.Location = new System.Drawing.Point(101, 19);
            this.yPosTBX.MaxLength = 2;
            this.yPosTBX.Name = "yPosTBX";
            this.yPosTBX.Size = new System.Drawing.Size(20, 20);
            this.yPosTBX.TabIndex = 12;
            // 
            // YLBL
            // 
            this.YLBL.AutoSize = true;
            this.YLBL.Location = new System.Drawing.Point(78, 22);
            this.YLBL.Name = "YLBL";
            this.YLBL.Size = new System.Drawing.Size(17, 13);
            this.YLBL.TabIndex = 11;
            this.YLBL.Text = "Y:";
            // 
            // xPosTBX
            // 
            this.xPosTBX.Location = new System.Drawing.Point(30, 19);
            this.xPosTBX.MaxLength = 2;
            this.xPosTBX.Name = "xPosTBX";
            this.xPosTBX.Size = new System.Drawing.Size(20, 20);
            this.xPosTBX.TabIndex = 14;
            // 
            // XLBL
            // 
            this.XLBL.AutoSize = true;
            this.XLBL.Location = new System.Drawing.Point(7, 22);
            this.XLBL.Name = "XLBL";
            this.XLBL.Size = new System.Drawing.Size(17, 13);
            this.XLBL.TabIndex = 13;
            this.XLBL.Text = "X:";
            // 
            // PosBlankCBOX
            // 
            this.PosBlankCBOX.AutoSize = true;
            this.PosBlankCBOX.Location = new System.Drawing.Point(10, 45);
            this.PosBlankCBOX.Name = "PosBlankCBOX";
            this.PosBlankCBOX.Size = new System.Drawing.Size(89, 17);
            this.PosBlankCBOX.TabIndex = 15;
            this.PosBlankCBOX.Text = "Track Mouse";
            this.PosBlankCBOX.UseVisualStyleBackColor = true;
            // 
            // EventSelect
            // 
            this.EventSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EventSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventSelect.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.EventSelect.Location = new System.Drawing.Point(67, 123);
            this.EventSelect.Name = "EventSelect";
            this.EventSelect.Size = new System.Drawing.Size(105, 21);
            this.EventSelect.TabIndex = 11;
            // 
            // EventLBL
            // 
            this.EventLBL.AutoSize = true;
            this.EventLBL.Location = new System.Drawing.Point(23, 126);
            this.EventLBL.Name = "EventLBL";
            this.EventLBL.Size = new System.Drawing.Size(38, 13);
            this.EventLBL.TabIndex = 12;
            this.EventLBL.Text = "Event:";
            // 
            // ModLBL
            // 
            this.ModLBL.AutoSize = true;
            this.ModLBL.Location = new System.Drawing.Point(177, 126);
            this.ModLBL.Name = "ModLBL";
            this.ModLBL.Size = new System.Drawing.Size(36, 13);
            this.ModLBL.TabIndex = 13;
            this.ModLBL.Text = "Mods:";
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Items.AddRange(new object[] {
            "some",
            "items",
            "to",
            "populate",
            "the",
            "box"});
            this.comboBox1.Location = new System.Drawing.Point(219, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // RemoveBTN
            // 
            this.RemoveBTN.Location = new System.Drawing.Point(99, 247);
            this.RemoveBTN.Name = "RemoveBTN";
            this.RemoveBTN.Size = new System.Drawing.Size(75, 23);
            this.RemoveBTN.TabIndex = 15;
            this.RemoveBTN.Text = "Remove";
            this.RemoveBTN.UseVisualStyleBackColor = true;
            // 
            // PopOutBTN
            // 
            this.PopOutBTN.Location = new System.Drawing.Point(574, 247);
            this.PopOutBTN.Name = "PopOutBTN";
            this.PopOutBTN.Size = new System.Drawing.Size(75, 23);
            this.PopOutBTN.TabIndex = 16;
            this.PopOutBTN.Text = "Pop-Out";
            this.PopOutBTN.UseVisualStyleBackColor = true;
            // 
            // InspectBTN
            // 
            this.InspectBTN.Location = new System.Drawing.Point(18, 247);
            this.InspectBTN.Name = "InspectBTN";
            this.InspectBTN.Size = new System.Drawing.Size(75, 23);
            this.InspectBTN.TabIndex = 17;
            this.InspectBTN.Text = "Inspect Item";
            this.InspectBTN.UseVisualStyleBackColor = true;
            // 
            // RemoveAllBTN
            // 
            this.RemoveAllBTN.Location = new System.Drawing.Point(180, 247);
            this.RemoveAllBTN.Name = "RemoveAllBTN";
            this.RemoveAllBTN.Size = new System.Drawing.Size(75, 23);
            this.RemoveAllBTN.TabIndex = 18;
            this.RemoveAllBTN.Text = "Remove All";
            this.RemoveAllBTN.UseVisualStyleBackColor = true;
            // 
            // ClearBTN
            // 
            this.ClearBTN.Location = new System.Drawing.Point(90, 150);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(75, 23);
            this.ClearBTN.TabIndex = 19;
            this.ClearBTN.Text = "Clear";
            this.ClearBTN.UseVisualStyleBackColor = true;
            // 
            // TimeCBOX
            // 
            this.TimeCBOX.AutoSize = true;
            this.TimeCBOX.Location = new System.Drawing.Point(113, 98);
            this.TimeCBOX.Name = "TimeCBOX";
            this.TimeCBOX.Size = new System.Drawing.Size(120, 17);
            this.TimeCBOX.TabIndex = 20;
            this.TimeCBOX.Text = "Repeat for time (ms)";
            this.TimeCBOX.UseVisualStyleBackColor = true;
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(667, 503);
            this.Controls.Add(this.TimeCBOX);
            this.Controls.Add(this.ClearBTN);
            this.Controls.Add(this.RemoveAllBTN);
            this.Controls.Add(this.InspectBTN);
            this.Controls.Add(this.PopOutBTN);
            this.Controls.Add(this.RemoveBTN);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ModLBL);
            this.Controls.Add(this.EventLBL);
            this.Controls.Add(this.EventSelect);
            this.Controls.Add(this.PositionBOX);
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
            this.PositionBOX.ResumeLayout(false);
            this.PositionBOX.PerformLayout();
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
        private System.Windows.Forms.GroupBox PositionBOX;
        private System.Windows.Forms.CheckBox PosBlankCBOX;
        private System.Windows.Forms.TextBox yPosTBX;
        private System.Windows.Forms.TextBox xPosTBX;
        private System.Windows.Forms.Label YLBL;
        private System.Windows.Forms.Label XLBL;
        private System.Windows.Forms.ComboBox EventSelect;
        private System.Windows.Forms.Label EventLBL;
        private System.Windows.Forms.Label ModLBL;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RemoveBTN;
        private System.Windows.Forms.Button PopOutBTN;
        private System.Windows.Forms.Button InspectBTN;
        private System.Windows.Forms.Button RemoveAllBTN;
        private System.Windows.Forms.Button ClearBTN;
        private System.Windows.Forms.CheckBox TimeCBOX;
    }
}

