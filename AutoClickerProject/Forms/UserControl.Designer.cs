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
            this.SelectPosBTN = new System.Windows.Forms.Button();
            this.PosBlankCBOX = new System.Windows.Forms.CheckBox();
            this.yPosTBX = new System.Windows.Forms.TextBox();
            this.xPosTBX = new System.Windows.Forms.TextBox();
            this.YLBL = new System.Windows.Forms.Label();
            this.XLBL = new System.Windows.Forms.Label();
            this.EventSelect = new System.Windows.Forms.ComboBox();
            this.EventLBL = new System.Windows.Forms.Label();
            this.ModLBL = new System.Windows.Forms.Label();
            this.ModSelect = new System.Windows.Forms.ComboBox();
            this.RemoveBTN = new System.Windows.Forms.Button();
            this.PopOutBTN = new System.Windows.Forms.Button();
            this.InspectBTN = new System.Windows.Forms.Button();
            this.RemoveAllBTN = new System.Windows.Forms.Button();
            this.ClearBTN = new System.Windows.Forms.Button();
            this.TimeCBOX = new System.Windows.Forms.CheckBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModItemsTBX = new System.Windows.Forms.TextBox();
            this.ModAddBTN = new System.Windows.Forms.Button();
            this.ClearMod = new System.Windows.Forms.Button();
            this.InputTypeBOX.SuspendLayout();
            this.PositionBOX.SuspendLayout();
            this.MenuStrip.SuspendLayout();
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
            this.AddBTN.Location = new System.Drawing.Point(12, 172);
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
            this.WaitBTN.Location = new System.Drawing.Point(6, 19);
            this.WaitBTN.Name = "WaitBTN";
            this.WaitBTN.Size = new System.Drawing.Size(47, 17);
            this.WaitBTN.TabIndex = 2;
            this.WaitBTN.Text = "Wait";
            this.WaitBTN.UseVisualStyleBackColor = true;
            this.WaitBTN.CheckedChanged += new System.EventHandler(this.WaitBTN_CheckedChanged);
            // 
            // InputTypeBOX
            // 
            this.InputTypeBOX.Controls.Add(this.KeyboardBTN);
            this.InputTypeBOX.Controls.Add(this.MouseBTN);
            this.InputTypeBOX.Controls.Add(this.WaitBTN);
            this.InputTypeBOX.Location = new System.Drawing.Point(15, 34);
            this.InputTypeBOX.Name = "InputTypeBOX";
            this.InputTypeBOX.Size = new System.Drawing.Size(284, 49);
            this.InputTypeBOX.TabIndex = 3;
            this.InputTypeBOX.TabStop = false;
            this.InputTypeBOX.Text = "Input Type";
            // 
            // KeyboardBTN
            // 
            this.KeyboardBTN.AutoSize = true;
            this.KeyboardBTN.Location = new System.Drawing.Point(189, 20);
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
            this.TimeLBL.Location = new System.Drawing.Point(9, 96);
            this.TimeLBL.Name = "TimeLBL";
            this.TimeLBL.Size = new System.Drawing.Size(55, 13);
            this.TimeLBL.TabIndex = 4;
            this.TimeLBL.Tag = "Wait, Mouse, Key";
            this.TimeLBL.Text = "Time (ms):";
            // 
            // TimeTBX
            // 
            this.TimeTBX.Location = new System.Drawing.Point(70, 93);
            this.TimeTBX.MaxLength = 8;
            this.TimeTBX.Name = "TimeTBX";
            this.TimeTBX.Size = new System.Drawing.Size(100, 20);
            this.TimeTBX.TabIndex = 5;
            this.TimeTBX.Tag = "Wait, Mouse, Key";
            // 
            // RepeatTBX
            // 
            this.RepeatTBX.Location = new System.Drawing.Point(70, 119);
            this.RepeatTBX.MaxLength = 2;
            this.RepeatTBX.Name = "RepeatTBX";
            this.RepeatTBX.Size = new System.Drawing.Size(39, 20);
            this.RepeatTBX.TabIndex = 7;
            this.RepeatTBX.Tag = "Wait, Mouse, Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Tag = "Wait, Mouse, Key";
            this.label1.Text = "Repeat:";
            // 
            // PositionBOX
            // 
            this.PositionBOX.Controls.Add(this.SelectPosBTN);
            this.PositionBOX.Controls.Add(this.PosBlankCBOX);
            this.PositionBOX.Controls.Add(this.yPosTBX);
            this.PositionBOX.Controls.Add(this.xPosTBX);
            this.PositionBOX.Controls.Add(this.YLBL);
            this.PositionBOX.Controls.Add(this.XLBL);
            this.PositionBOX.Location = new System.Drawing.Point(331, 34);
            this.PositionBOX.Name = "PositionBOX";
            this.PositionBOX.Size = new System.Drawing.Size(194, 66);
            this.PositionBOX.TabIndex = 10;
            this.PositionBOX.TabStop = false;
            this.PositionBOX.Tag = "Mouse";
            this.PositionBOX.Text = "Position";
            this.PositionBOX.Visible = false;
            // 
            // SelectPosBTN
            // 
            this.SelectPosBTN.Location = new System.Drawing.Point(142, 19);
            this.SelectPosBTN.Name = "SelectPosBTN";
            this.SelectPosBTN.Size = new System.Drawing.Size(46, 20);
            this.SelectPosBTN.TabIndex = 16;
            this.SelectPosBTN.Text = "Select";
            this.SelectPosBTN.UseVisualStyleBackColor = true;
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
            this.PosBlankCBOX.CheckedChanged += new System.EventHandler(this.PosBlankCBOX_CheckedChanged);
            // 
            // yPosTBX
            // 
            this.yPosTBX.Location = new System.Drawing.Point(88, 19);
            this.yPosTBX.MaxLength = 2;
            this.yPosTBX.Name = "yPosTBX";
            this.yPosTBX.Size = new System.Drawing.Size(38, 20);
            this.yPosTBX.TabIndex = 12;
            // 
            // xPosTBX
            // 
            this.xPosTBX.Location = new System.Drawing.Point(30, 19);
            this.xPosTBX.MaxLength = 2;
            this.xPosTBX.Name = "xPosTBX";
            this.xPosTBX.Size = new System.Drawing.Size(38, 20);
            this.xPosTBX.TabIndex = 14;
            // 
            // YLBL
            // 
            this.YLBL.AutoSize = true;
            this.YLBL.Location = new System.Drawing.Point(74, 22);
            this.YLBL.Name = "YLBL";
            this.YLBL.Size = new System.Drawing.Size(17, 13);
            this.YLBL.TabIndex = 11;
            this.YLBL.Text = "Y:";
            // 
            // XLBL
            // 
            this.XLBL.AutoSize = true;
            this.XLBL.Location = new System.Drawing.Point(16, 22);
            this.XLBL.Name = "XLBL";
            this.XLBL.Size = new System.Drawing.Size(17, 13);
            this.XLBL.TabIndex = 13;
            this.XLBL.Text = "X:";
            // 
            // EventSelect
            // 
            this.EventSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventSelect.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.EventSelect.Location = new System.Drawing.Point(70, 145);
            this.EventSelect.Name = "EventSelect";
            this.EventSelect.Size = new System.Drawing.Size(105, 21);
            this.EventSelect.TabIndex = 11;
            this.EventSelect.Tag = "Mouse, Key";
            // 
            // EventLBL
            // 
            this.EventLBL.AutoSize = true;
            this.EventLBL.Location = new System.Drawing.Point(26, 148);
            this.EventLBL.Name = "EventLBL";
            this.EventLBL.Size = new System.Drawing.Size(38, 13);
            this.EventLBL.TabIndex = 12;
            this.EventLBL.Tag = "Mouse, Key";
            this.EventLBL.Text = "Event:";
            // 
            // ModLBL
            // 
            this.ModLBL.AutoSize = true;
            this.ModLBL.Location = new System.Drawing.Point(180, 148);
            this.ModLBL.Name = "ModLBL";
            this.ModLBL.Size = new System.Drawing.Size(36, 13);
            this.ModLBL.TabIndex = 13;
            this.ModLBL.Tag = "Key";
            this.ModLBL.Text = "Mods:";
            // 
            // ModSelect
            // 
            this.ModSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModSelect.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ModSelect.Items.AddRange(new object[] {
            "some",
            "items",
            "to",
            "populate",
            "the",
            "box"});
            this.ModSelect.Location = new System.Drawing.Point(222, 171);
            this.ModSelect.Name = "ModSelect";
            this.ModSelect.Size = new System.Drawing.Size(105, 21);
            this.ModSelect.TabIndex = 14;
            this.ModSelect.Tag = "Key";
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
            this.ClearBTN.Location = new System.Drawing.Point(93, 172);
            this.ClearBTN.Name = "ClearBTN";
            this.ClearBTN.Size = new System.Drawing.Size(75, 23);
            this.ClearBTN.TabIndex = 19;
            this.ClearBTN.Text = "Clear";
            this.ClearBTN.UseVisualStyleBackColor = true;
            this.ClearBTN.Click += new System.EventHandler(this.ClearBTN_Click);
            // 
            // TimeCBOX
            // 
            this.TimeCBOX.AutoSize = true;
            this.TimeCBOX.Location = new System.Drawing.Point(116, 120);
            this.TimeCBOX.Name = "TimeCBOX";
            this.TimeCBOX.Size = new System.Drawing.Size(120, 17);
            this.TimeCBOX.TabIndex = 20;
            this.TimeCBOX.Tag = "Wait, Mouse, Key";
            this.TimeCBOX.Text = "Repeat for time (ms)";
            this.TimeCBOX.UseVisualStyleBackColor = true;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.supportToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(667, 24);
            this.MenuStrip.TabIndex = 21;
            this.MenuStrip.TabStop = true;
            this.MenuStrip.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newScriptToolStripMenuItem,
            this.saveScriptToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newScriptToolStripMenuItem
            // 
            this.newScriptToolStripMenuItem.Name = "newScriptToolStripMenuItem";
            this.newScriptToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newScriptToolStripMenuItem.Text = "New Script";
            // 
            // saveScriptToolStripMenuItem
            // 
            this.saveScriptToolStripMenuItem.Name = "saveScriptToolStripMenuItem";
            this.saveScriptToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.saveScriptToolStripMenuItem.Text = "Save Script";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.supportToolStripMenuItem.Text = "Other";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // ModItemsTBX
            // 
            this.ModItemsTBX.Location = new System.Drawing.Point(222, 145);
            this.ModItemsTBX.Name = "ModItemsTBX";
            this.ModItemsTBX.ReadOnly = true;
            this.ModItemsTBX.Size = new System.Drawing.Size(191, 20);
            this.ModItemsTBX.TabIndex = 22;
            this.ModItemsTBX.Tag = "Key";
            // 
            // ModAddBTN
            // 
            this.ModAddBTN.Location = new System.Drawing.Point(331, 171);
            this.ModAddBTN.Name = "ModAddBTN";
            this.ModAddBTN.Size = new System.Drawing.Size(82, 23);
            this.ModAddBTN.TabIndex = 23;
            this.ModAddBTN.Tag = "Key";
            this.ModAddBTN.Text = "Add Mod";
            this.ModAddBTN.UseVisualStyleBackColor = true;
            this.ModAddBTN.Click += new System.EventHandler(this.ModAddBTN_Click);
            // 
            // ClearMod
            // 
            this.ClearMod.Location = new System.Drawing.Point(419, 143);
            this.ClearMod.Name = "ClearMod";
            this.ClearMod.Size = new System.Drawing.Size(38, 23);
            this.ClearMod.TabIndex = 24;
            this.ClearMod.Tag = "Key";
            this.ClearMod.Text = "clear";
            this.ClearMod.UseVisualStyleBackColor = true;
            this.ClearMod.Click += new System.EventHandler(this.ClearMod_Click);
            // 
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(667, 503);
            this.Controls.Add(this.ClearMod);
            this.Controls.Add(this.ModAddBTN);
            this.Controls.Add(this.ModItemsTBX);
            this.Controls.Add(this.TimeCBOX);
            this.Controls.Add(this.ClearBTN);
            this.Controls.Add(this.RemoveAllBTN);
            this.Controls.Add(this.InspectBTN);
            this.Controls.Add(this.PopOutBTN);
            this.Controls.Add(this.RemoveBTN);
            this.Controls.Add(this.ModSelect);
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
            this.Controls.Add(this.MenuStrip);
            this.HelpButton = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.Name = "UserControl";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Auto Click Script";
            this.InputTypeBOX.ResumeLayout(false);
            this.InputTypeBOX.PerformLayout();
            this.PositionBOX.ResumeLayout(false);
            this.PositionBOX.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
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
        private System.Windows.Forms.ComboBox ModSelect;
        private System.Windows.Forms.Button RemoveBTN;
        private System.Windows.Forms.Button PopOutBTN;
        private System.Windows.Forms.Button InspectBTN;
        private System.Windows.Forms.Button RemoveAllBTN;
        private System.Windows.Forms.Button ClearBTN;
        private System.Windows.Forms.CheckBox TimeCBOX;
        private System.Windows.Forms.Button SelectPosBTN;
        public System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox ModItemsTBX;
        private System.Windows.Forms.Button ModAddBTN;
        private System.Windows.Forms.Button ClearMod;
    }
}

