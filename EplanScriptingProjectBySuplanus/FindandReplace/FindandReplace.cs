﻿using System.Drawing;
using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public partial class frmFindandReplace : Form
{
    private Button btnDone;
    private Button btnFind;
    private TextBox txtFindWhat;
    private CommandLineInterpreter oCLI = new CommandLineInterpreter();
    private TextBox txtReplaceWith;
    private Button btnReplace;
    private Button btnReplaceAll;
    private Label lblFindWhat;
    private Label lblReplaceWith;

    #region Code generated by Windows Form Designer

    // <summary>
    // Required designer variable.
    // </summary>

    private System.ComponentModel.IContainer components = null;

    // <summary>
    // Clean used resources.
    // </summary>
    // <param name="disposing">True, when managed resources
    // to be deleted; otherwise False. </ param>

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    // <summary>
    // Required method for designer support.
    // The content of the method must not be with the code editor
    // be changed.
    // </summary>

    private void InitializeComponent()
    {
            this.btnDone = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFindWhat = new System.Windows.Forms.TextBox();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.lblFindWhat = new System.Windows.Forms.Label();
            this.lblReplaceWith = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDone.Location = new System.Drawing.Point(648, 192);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(120, 23);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(520, 192);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(120, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtFindWhat
            // 
            this.txtFindWhat.BackColor = System.Drawing.Color.Snow;
            this.txtFindWhat.Location = new System.Drawing.Point(8, 32);
            this.txtFindWhat.Name = "txtFindWhat";
            this.txtFindWhat.Size = new System.Drawing.Size(370, 20);
            this.txtFindWhat.TabIndex = 5;
            this.txtFindWhat.TextChanged += new System.EventHandler(this.txtAction_TextChanged);
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.BackColor = System.Drawing.Color.Snow;
            this.txtReplaceWith.Location = new System.Drawing.Point(8, 96);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(370, 20);
            this.txtReplaceWith.TabIndex = 6;
            this.txtReplaceWith.TextChanged += new System.EventHandler(this.txtReplaceWith_TextChanged);
            // 
            // btnReplace
            // 
            this.btnReplace.Enabled = false;
            this.btnReplace.Location = new System.Drawing.Point(224, 192);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(120, 23);
            this.btnReplace.TabIndex = 1;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReplaceAll.Location = new System.Drawing.Point(352, 192);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(120, 23);
            this.btnReplaceAll.TabIndex = 2;
            this.btnReplaceAll.Text = "Replace All";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // lblFindWhat
            // 
            this.lblFindWhat.AutoSize = true;
            this.lblFindWhat.Location = new System.Drawing.Point(8, 8);
            this.lblFindWhat.Name = "lblFindWhat";
            this.lblFindWhat.Size = new System.Drawing.Size(56, 13);
            this.lblFindWhat.TabIndex = 7;
            this.lblFindWhat.Text = "Find what:";
            this.lblFindWhat.Click += new System.EventHandler(this.lblFindWhat_Click);
            // 
            // lblReplaceWith
            // 
            this.lblReplaceWith.AutoSize = true;
            this.lblReplaceWith.Location = new System.Drawing.Point(8, 72);
            this.lblReplaceWith.Name = "lblReplaceWith";
            this.lblReplaceWith.Size = new System.Drawing.Size(72, 13);
            this.lblReplaceWith.TabIndex = 8;
            this.lblReplaceWith.Text = "Replace with:";
            this.lblReplaceWith.Click += new System.EventHandler(this.lblReplaceWith_Click);
            // 
            // frmFindandReplace
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDone;
            this.ClientSize = new System.Drawing.Size(779, 232);
            this.Controls.Add(this.lblReplaceWith);
            this.Controls.Add(this.lblFindWhat);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.txtReplaceWith);
            this.Controls.Add(this.txtFindWhat);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmFindandReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindandReplace";
            this.Load += new System.EventHandler(this.frmFindandReplace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    public frmFindandReplace()
    {
        InitializeComponent();
    }

    #endregion

    [DeclareAction("FindandReplace")]
    public void Function()
    {
        frmFindandReplace frm = new frmFindandReplace();
        frm.ShowDialog();

        return;
    }

    private void frmFindandReplace_Load(object sender, System.EventArgs e)
    {

        return;
    }

    private void btnOk_Click(object sender, System.EventArgs e)
    {
        
        return;
    }

    private void txtAction_TextChanged(object sender, System.EventArgs e)
    {

        return;
    }

    private void lblFindWhat_Click(object sender, System.EventArgs e)
    {

        return;
    }

    private void txtReplaceWith_TextChanged(object sender, System.EventArgs e)
    {

        return;
    }

    private void lblReplaceWith_Click(object sender, System.EventArgs e)
    {
        
    }

    private void btnReplace_Click(object sender, System.EventArgs e)
    {

        return;
    }

    private void btnReplaceAll_Click(object sender, System.EventArgs e)
    {

        return;
    }

    private void btnCancel_Click(object sender, System.EventArgs e)
    {
        Close();
        return;
    }
}

