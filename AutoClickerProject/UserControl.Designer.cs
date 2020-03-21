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
            this.ScriptView = new System.Windows.Forms.ListView();
            this.Order = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Repeat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Delay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.Delay});
            this.ScriptView.HideSelection = false;
            this.ScriptView.Location = new System.Drawing.Point(12, 276);
            this.ScriptView.Name = "ScriptView";
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
            // UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(679, 503);
            this.Controls.Add(this.ScriptView);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "UserControl";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Auto Click Script";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ScriptView;
        private System.Windows.Forms.ColumnHeader Order;
        private System.Windows.Forms.ColumnHeader Action;
        private System.Windows.Forms.ColumnHeader Repeat;
        private System.Windows.Forms.ColumnHeader Delay;
    }
}

