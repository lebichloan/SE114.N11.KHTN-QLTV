﻿using System.Windows.Forms;

namespace GUI.UserControls
{
    partial class ucTuaSach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.butDel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.butAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.TuaSachGrid = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.tUASACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isChosen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTuaSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTuaSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTheLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TuaSachGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUASACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.butDel);
            this.topPanel.Controls.Add(this.butAdd);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(997, 120);
            this.topPanel.TabIndex = 0;
            // 
            // butDel
            // 
            this.butDel.BorderRadius = 6;
            this.butDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butDel.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.butDel.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDel.ForeColor = System.Drawing.Color.White;
            this.butDel.Image = global::GUI.Properties.Resources.close_icon;
            this.butDel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butDel.ImageOffset = new System.Drawing.Point(2, 0);
            this.butDel.Location = new System.Drawing.Point(137, 76);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(124, 24);
            this.butDel.TabIndex = 5;
            this.butDel.Text = "Xóa Tựa Sách";
            this.butDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butDel.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // butAdd
            // 
            this.butAdd.BorderRadius = 6;
            this.butAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAdd.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.butAdd.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.ForeColor = System.Drawing.Color.White;
            this.butAdd.Image = global::GUI.Properties.Resources.Plus_icon;
            this.butAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.ImageOffset = new System.Drawing.Point(2, 0);
            this.butAdd.Location = new System.Drawing.Point(5, 76);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(126, 24);
            this.butAdd.TabIndex = 6;
            this.butAdd.Text = "Thêm Tựa Sách";
            this.butAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAdd.TextOffset = new System.Drawing.Point(3, 0);
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // TuaSachGrid
            // 
            this.TuaSachGrid.AllowUserToAddRows = false;
            this.TuaSachGrid.AllowUserToDeleteRows = false;
            this.TuaSachGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TuaSachGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TuaSachGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TuaSachGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TuaSachGrid.ColumnHeadersHeight = 35;
            this.TuaSachGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TuaSachGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isChosen,
            this.Edit,
            this.idDataGridViewTextBoxColumn,
            this.maTuaSachDataGridViewTextBoxColumn,
            this.tenTuaSachDataGridViewTextBoxColumn,
            this.TheLoai,
            this.TacGia,
            this.idTheLoaiDataGridViewTextBoxColumn});
            this.TuaSachGrid.DataSource = this.tUASACHBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TuaSachGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.TuaSachGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TuaSachGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TuaSachGrid.Location = new System.Drawing.Point(0, 120);
            this.TuaSachGrid.Name = "TuaSachGrid";
            this.TuaSachGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TuaSachGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TuaSachGrid.RowHeadersVisible = false;
            this.TuaSachGrid.RowHeadersWidth = 51;
            this.TuaSachGrid.RowTemplate.Height = 28;
            this.TuaSachGrid.Size = new System.Drawing.Size(997, 476);
            this.TuaSachGrid.TabIndex = 1;
            this.TuaSachGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TuaSachGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TuaSachGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TuaSachGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TuaSachGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TuaSachGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TuaSachGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TuaSachGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TuaSachGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TuaSachGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuaSachGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TuaSachGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TuaSachGrid.ThemeStyle.HeaderStyle.Height = 35;
            this.TuaSachGrid.ThemeStyle.ReadOnly = false;
            this.TuaSachGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TuaSachGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TuaSachGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuaSachGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TuaSachGrid.ThemeStyle.RowsStyle.Height = 28;
            this.TuaSachGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TuaSachGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tUASACHBindingSource
            // 
            this.tUASACHBindingSource.DataSource = typeof(DTO.TUASACH);
            // 
            // isChosen
            // 
            this.isChosen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.isChosen.FalseValue = "0";
            this.isChosen.HeaderText = "";
            this.isChosen.IndeterminateValue = "0";
            this.isChosen.MinimumWidth = 6;
            this.isChosen.Name = "isChosen";
            this.isChosen.TrueValue = "1";
            this.isChosen.Width = 6;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // maTuaSachDataGridViewTextBoxColumn
            // 
            this.maTuaSachDataGridViewTextBoxColumn.DataPropertyName = "MaTuaSach";
            this.maTuaSachDataGridViewTextBoxColumn.HeaderText = "Mã tựa sách";
            this.maTuaSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maTuaSachDataGridViewTextBoxColumn.Name = "maTuaSachDataGridViewTextBoxColumn";
            this.maTuaSachDataGridViewTextBoxColumn.ReadOnly = true;
            this.maTuaSachDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tenTuaSachDataGridViewTextBoxColumn
            // 
            this.tenTuaSachDataGridViewTextBoxColumn.DataPropertyName = "TenTuaSach";
            this.tenTuaSachDataGridViewTextBoxColumn.HeaderText = "Tên tựa sách";
            this.tenTuaSachDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenTuaSachDataGridViewTextBoxColumn.Name = "tenTuaSachDataGridViewTextBoxColumn";
            this.tenTuaSachDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenTuaSachDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TheLoai
            // 
            this.TheLoai.HeaderText = "Thể loại";
            this.TheLoai.MinimumWidth = 6;
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.ReadOnly = true;
            // 
            // TacGia
            // 
            this.TacGia.HeaderText = "Tác giả";
            this.TacGia.MinimumWidth = 6;
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            // 
            // idTheLoaiDataGridViewTextBoxColumn
            // 
            this.idTheLoaiDataGridViewTextBoxColumn.DataPropertyName = "idTheLoai";
            this.idTheLoaiDataGridViewTextBoxColumn.HeaderText = "idTheLoai";
            this.idTheLoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTheLoaiDataGridViewTextBoxColumn.Name = "idTheLoaiDataGridViewTextBoxColumn";
            this.idTheLoaiDataGridViewTextBoxColumn.Visible = false;
            // 
            // ucTuaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TuaSachGrid);
            this.Controls.Add(this.topPanel);
            this.Name = "ucTuaSach";
            this.Size = new System.Drawing.Size(997, 596);
            this.Load += new System.EventHandler(this.ucTuaSach_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TuaSachGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUASACHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel topPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView TuaSachGrid;
        private BindingSource tUASACHBindingSource;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butDel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton butAdd;
        private DataGridViewCheckBoxColumn isChosen;
        private DataGridViewImageColumn Edit;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maTuaSachDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenTuaSachDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TheLoai;
        private DataGridViewTextBoxColumn TacGia;
        private DataGridViewTextBoxColumn idTheLoaiDataGridViewTextBoxColumn;
    }
}
