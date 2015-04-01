﻿namespace MissionPlanner.GCSViews.ConfigurationView
{
    partial class PlayUAVOSD
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
            this.Save_To_OSD = new System.Windows.Forms.Button();
            this.Load_from_OSD = new System.Windows.Forms.Button();
            this.Load_Default = new System.Windows.Forms.Button();
            this.Params = new BrightIdeasSoftware.DataTreeListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.Params)).BeginInit();
            this.SuspendLayout();
            // 
            // Save_To_OSD
            // 
            this.Save_To_OSD.Location = new System.Drawing.Point(656, 20);
            this.Save_To_OSD.Name = "Save_To_OSD";
            this.Save_To_OSD.Size = new System.Drawing.Size(77, 30);
            this.Save_To_OSD.TabIndex = 0;
            this.Save_To_OSD.Text = "保存参数";
            this.Save_To_OSD.UseVisualStyleBackColor = true;
            this.Save_To_OSD.Click += new System.EventHandler(this.btn_Save_To_OSD_Click);
            // 
            // Load_from_OSD
            // 
            this.Load_from_OSD.Location = new System.Drawing.Point(656, 56);
            this.Load_from_OSD.Name = "Load_from_OSD";
            this.Load_from_OSD.Size = new System.Drawing.Size(77, 30);
            this.Load_from_OSD.TabIndex = 1;
            this.Load_from_OSD.Text = "读取参数";
            this.Load_from_OSD.UseVisualStyleBackColor = true;
            this.Load_from_OSD.Click += new System.EventHandler(this.btn_Load_from_OSD_Click);
            // 
            // Load_Default
            // 
            this.Load_Default.Location = new System.Drawing.Point(645, 196);
            this.Load_Default.Name = "Load_Default";
            this.Load_Default.Size = new System.Drawing.Size(88, 24);
            this.Load_Default.TabIndex = 3;
            this.Load_Default.Text = "读取默认参数";
            this.Load_Default.UseVisualStyleBackColor = true;
            this.Load_Default.Click += new System.EventHandler(this.btn_Load_Default_Click);
            // 
            // Params
            // 
            this.Params.AllColumns.Add(this.olvColumn1);
            this.Params.AllColumns.Add(this.olvColumn2);
            this.Params.AllColumns.Add(this.olvColumn3);
            this.Params.AllColumns.Add(this.olvColumn4);
            this.Params.AllColumns.Add(this.olvColumn5);
            this.Params.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Params.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5});
            this.Params.DataSource = null;
            this.Params.ForeColor = System.Drawing.Color.White;
            this.Params.Location = new System.Drawing.Point(4, 4);
            this.Params.Name = "Params";
            this.Params.OwnerDraw = true;
            this.Params.RootKeyValueString = "";
            this.Params.RowHeight = 26;
            this.Params.ShowGroups = false;
            this.Params.Size = new System.Drawing.Size(622, 468);
            this.Params.TabIndex = 79;
            this.Params.UseAlternatingBackColors = true;
            this.Params.UseCompatibleStateImageBehavior = false;
            this.Params.View = System.Windows.Forms.View.Details;
            this.Params.VirtualMode = true;
            this.Params.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.Params_CellEditFinishing);
            this.Params.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.Params_FormatRow);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "paramname";
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "Command";
            this.olvColumn1.Width = 160;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Value";
            this.olvColumn2.AutoCompleteEditor = false;
            this.olvColumn2.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.olvColumn2.CellPadding = null;
            this.olvColumn2.Text = "Value";
            this.olvColumn2.Width = 80;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "unit";
            this.olvColumn3.CellPadding = null;
            this.olvColumn3.IsEditable = false;
            this.olvColumn3.Text = "Unit";
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "range";
            this.olvColumn4.CellPadding = null;
            this.olvColumn4.IsEditable = false;
            this.olvColumn4.Text = "Range";
            this.olvColumn4.Width = 100;
            this.olvColumn4.WordWrap = true;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "desc";
            this.olvColumn5.CellPadding = null;
            this.olvColumn5.IsEditable = false;
            this.olvColumn5.Text = "Description";
            this.olvColumn5.Width = 210;
            this.olvColumn5.WordWrap = true;
            // 
            // PlayUAVOSD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Params);
            this.Controls.Add(this.Load_Default);
            this.Controls.Add(this.Load_from_OSD);
            this.Controls.Add(this.Save_To_OSD);
            this.Name = "PlayUAVOSD";
            //this.Size = new System.Drawing.Size(756, 472);
            ((System.ComponentModel.ISupportInitialize)(this.Params)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Save_To_OSD;
        private System.Windows.Forms.Button Load_from_OSD;
        private System.Windows.Forms.Button Load_Default;
        private BrightIdeasSoftware.DataTreeListView Params;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;


 
    }
}

