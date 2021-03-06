﻿// PDF-Export Assistent, Version 1.0.0, vom 07.02.2014
//
// Integriert einen Dialog um automatisiert PDF-Dateien in definierte Folder abzulegen.
// Der Aufruf erfolgt entweder über Menüpunkt (unter Seite > Export > PDF (Assistent)...)
// oder automatisch beim Schließen oder Beenden.
//
// Der Ursprung für diesen Assistenten war das Skript "PDFbyProjectClose"
//
// Copyright by Frank Schöneck, 2014
// letzte Änderung: Frank Schöneck, 27.01.2014 V1.0.0, Projectbeginn
//
// für Eplan Electric P8, ab V2.2
//

// PDF-Export Assistant, Version 1.0.0, dated 07.02.2014
//
// Integrates a dialog to automatically save PDF files in defined folders.
// The call is either made via the menu item (under Page> Export> PDF (Wizard) ...)
// or automatically when closing or exiting.
//
// The origin for this wizard was the script "PDFbyProjectClose"
//
// Copyright by Frank Schöneck, 2014
// last change: Frank Schöneck, 27.01.2014 V1.0.0, start of project
//
// for Eplan Electric P8, from V2.2
//

using System;
using System.Windows.Forms;
using System.Xml;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public partial class frmPDFAssistent : System.Windows.Forms.Form
{
	private Button btnAbort;
	private Button btnOK;
	private CheckBox chkSaveSettings;
	private TabControl tabControl1;
	private TabPage tabPage1;
	private Button btnFolderAuswahl;
	private TextBox txtSpeicherort;
	private TextBox txtDateiname;
	private CheckBox chkDatumStempel;
	private CheckBox chkTimeStamp;
	private ComboBox cboAusgabeNach;
	private Label label3;
	private Label label2;
	private Label label1;
	private TabPage tabPage2;
	private GroupBox groupBox1;
	private CheckBox chkByEplanEnd;
	private CheckBox chkByProjectClose;
	private Label label4;
	private CheckBox chkOhneNachfrage;
	private Button btnToSave;
	private Button button1;
	private GroupBox groupBox2;
	private Button btnProjectFolderAuswahl;
	private TextBox txtProjectFiledInFolder;
	private CheckBox chkIstInProjectFolder;

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
			this.btnAbort = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.chkSaveSettings = new System.Windows.Forms.CheckBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnFolderAuswahl = new System.Windows.Forms.Button();
			this.txtSpeicherort = new System.Windows.Forms.TextBox();
			this.txtDateiname = new System.Windows.Forms.TextBox();
			this.chkDatumStempel = new System.Windows.Forms.CheckBox();
			this.chkTimeStamp = new System.Windows.Forms.CheckBox();
			this.cboAusgabeNach = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnProjectFolderAuswahl = new System.Windows.Forms.Button();
			this.txtProjectFiledInFolder = new System.Windows.Forms.TextBox();
			this.chkIstInProjectFolder = new System.Windows.Forms.CheckBox();
			this.chkOhneNachfrage = new System.Windows.Forms.CheckBox();
			this.btnToSave = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkByEplanEnd = new System.Windows.Forms.CheckBox();
			this.chkByProjectClose = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAbort
			// 
			this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAbort.Location = new System.Drawing.Point(408, 273);
			this.btnAbort.Name = "btnAbort";
			this.btnAbort.Size = new System.Drawing.Size(95, 24);
			this.btnAbort.TabIndex = 0;
			this.btnAbort.Text = "Abort";
			this.btnAbort.UseVisualStyleBackColor = true;
			this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(298, 273);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(95, 24);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// chkSaveSettings
			// 
			this.chkSaveSettings.AutoSize = true;
			this.chkSaveSettings.Location = new System.Drawing.Point(9, 278);
			this.chkSaveSettings.Name = "chkSaveSettings";
			this.chkSaveSettings.Size = new System.Drawing.Size(138, 17);
			this.chkSaveSettings.TabIndex = 3;
			this.chkSaveSettings.Text = "Save settings";
			this.chkSaveSettings.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(9, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(498, 235);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.btnFolderAuswahl);
			this.tabPage1.Controls.Add(this.txtSpeicherort);
			this.tabPage1.Controls.Add(this.txtDateiname);
			this.tabPage1.Controls.Add(this.chkDatumStempel);
			this.tabPage1.Controls.Add(this.chkTimeStamp);
			this.tabPage1.Controls.Add(this.cboAusgabeNach);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(490, 209);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Ausgabe";
			// 
			// btnFolderAuswahl
			// 
			this.btnFolderAuswahl.Location = new System.Drawing.Point(444, 148);
			this.btnFolderAuswahl.Name = "btnFolderAuswahl";
			this.btnFolderAuswahl.Size = new System.Drawing.Size(28, 20);
			this.btnFolderAuswahl.TabIndex = 15;
			this.btnFolderAuswahl.Text = "...";
			this.btnFolderAuswahl.UseVisualStyleBackColor = true;
			this.btnFolderAuswahl.Click += new System.EventHandler(this.btnFolderAuswahl_Click);
			// 
			// txtSpeicherort
			// 
			this.txtSpeicherort.Location = new System.Drawing.Point(14, 149);
			this.txtSpeicherort.Name = "txtSpeicherort";
			this.txtSpeicherort.ReadOnly = true;
			this.txtSpeicherort.Size = new System.Drawing.Size(424, 20);
			this.txtSpeicherort.TabIndex = 13;
			// 
			// txtDateiname
			// 
			this.txtDateiname.Location = new System.Drawing.Point(14, 110);
			this.txtDateiname.Name = "txtDateiname";
			this.txtDateiname.Size = new System.Drawing.Size(458, 20);
			this.txtDateiname.TabIndex = 14;
			// 
			// chkDatumStempel
			// 
			this.chkDatumStempel.AutoSize = true;
			this.chkDatumStempel.Location = new System.Drawing.Point(174, 54);
			this.chkDatumStempel.Name = "chkDatumStempel";
			this.chkDatumStempel.Size = new System.Drawing.Size(98, 17);
			this.chkDatumStempel.TabIndex = 12;
			this.chkDatumStempel.Text = "Datum-Stempel";
			this.chkDatumStempel.UseVisualStyleBackColor = true;
			this.chkDatumStempel.CheckedChanged += new System.EventHandler(this.chkDatumStempel_CheckedChanged);
			// 
			// chkTimeStamp
			// 
			this.chkTimeStamp.AutoSize = true;
			this.chkTimeStamp.Location = new System.Drawing.Point(278, 54);
			this.chkTimeStamp.Name = "chkTimeStamp";
			this.chkTimeStamp.Size = new System.Drawing.Size(85, 17);
			this.chkTimeStamp.TabIndex = 11;
			this.chkTimeStamp.Text = "Zeit-Stempel";
			this.chkTimeStamp.UseVisualStyleBackColor = true;
			this.chkTimeStamp.CheckedChanged += new System.EventHandler(this.chkTimeStamp_CheckedChanged);
			// 
			// cboAusgabeNach
			// 
			this.cboAusgabeNach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboAusgabeNach.Items.AddRange(new object[] {
			"in den Project-Folder",
			"Ausgabeverzeichnis aus Einstellungen: PDF-Export",
			"in den Folder eine Ebene über dem Project-Folder",
			"in Folder \"Eigene Dateien\"",
			"auf den Desktop",
			"gleicher Pfad wie Project nur auf anderes Laufwerk"});
			this.cboAusgabeNach.Location = new System.Drawing.Point(96, 17);
			this.cboAusgabeNach.Name = "cboAusgabeNach";
			this.cboAusgabeNach.Size = new System.Drawing.Size(376, 21);
			this.cboAusgabeNach.TabIndex = 10;
			this.cboAusgabeNach.SelectedIndexChanged += new System.EventHandler(this.cboAusgabeNach_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(148, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "PDF-Dateiname erweitern um:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(204, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "PDF-Dateiname (ohne Erweiterung (.pdf)):";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Speicherort:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Ausgabe nach:";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Transparent;
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Controls.Add(this.btnToSave);
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(490, 209);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Einstellungen";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnProjectFolderAuswahl);
			this.groupBox2.Controls.Add(this.txtProjectFiledInFolder);
			this.groupBox2.Controls.Add(this.chkIstInProjectFolder);
			this.groupBox2.Controls.Add(this.chkOhneNachfrage);
			this.groupBox2.Location = new System.Drawing.Point(6, 96);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(478, 77);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "and zusätzliche Bedingungen erfüllt sind";
			// 
			// btnProjectFolderAuswahl
			// 
			this.btnProjectFolderAuswahl.Location = new System.Drawing.Point(442, 17);
			this.btnProjectFolderAuswahl.Name = "btnProjectFolderAuswahl";
			this.btnProjectFolderAuswahl.Size = new System.Drawing.Size(28, 20);
			this.btnProjectFolderAuswahl.TabIndex = 16;
			this.btnProjectFolderAuswahl.Text = "...";
			this.btnProjectFolderAuswahl.UseVisualStyleBackColor = true;
			this.btnProjectFolderAuswahl.Click += new System.EventHandler(this.btnProjectFolderAuswahl_Click);
			// 
			// txtProjectFiledInFolder
			// 
			this.txtProjectFiledInFolder.Location = new System.Drawing.Point(206, 17);
			this.txtProjectFiledInFolder.Name = "txtProjectFiledInFolder";
			this.txtProjectFiledInFolder.Size = new System.Drawing.Size(230, 20);
			this.txtProjectFiledInFolder.TabIndex = 5;
			// 
			// chkIstInProjectFolder
			// 
			this.chkIstInProjectFolder.AutoSize = true;
			this.chkIstInProjectFolder.Location = new System.Drawing.Point(17, 19);
			this.chkIstInProjectFolder.Name = "chkIstInProjectFolder";
			this.chkIstInProjectFolder.Size = new System.Drawing.Size(183, 17);
			this.chkIstInProjectFolder.TabIndex = 3;
			this.chkIstInProjectFolder.Text = "wenn Project in diesem Folder ist";
			this.chkIstInProjectFolder.UseVisualStyleBackColor = true;
			this.chkIstInProjectFolder.CheckedChanged += new System.EventHandler(this.chkIstInProjectFolder_CheckedChanged);
			// 
			// chkOhneNachfrage
			// 
			this.chkOhneNachfrage.AutoSize = true;
			this.chkOhneNachfrage.Location = new System.Drawing.Point(17, 54);
			this.chkOhneNachfrage.Name = "chkOhneNachfrage";
			this.chkOhneNachfrage.Size = new System.Drawing.Size(138, 17);
			this.chkOhneNachfrage.TabIndex = 4;
			this.chkOhneNachfrage.Text = "direkt (ohne Nachfrage)";
			this.chkOhneNachfrage.UseVisualStyleBackColor = true;
			// 
			// btnToSave
			// 
			this.btnToSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnToSave.Location = new System.Drawing.Point(389, 179);
			this.btnToSave.Name = "btnToSave";
			this.btnToSave.Size = new System.Drawing.Size(95, 24);
			this.btnToSave.TabIndex = 2;
			this.btnToSave.Text = "ToSave";
			this.btnToSave.UseVisualStyleBackColor = true;
			this.btnToSave.Click += new System.EventHandler(this.btnToSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.chkByEplanEnd);
			this.groupBox1.Controls.Add(this.chkByProjectClose);
			this.groupBox1.Location = new System.Drawing.Point(6, 19);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(478, 71);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "To Run nur";
			// 
			// chkByEplanEnd
			// 
			this.chkByEplanEnd.AutoSize = true;
			this.chkByEplanEnd.Location = new System.Drawing.Point(17, 43);
			this.chkByEplanEnd.Name = "chkByEplanEnd";
			this.chkByEplanEnd.Size = new System.Drawing.Size(146, 17);
			this.chkByEplanEnd.TabIndex = 2;
			this.chkByEplanEnd.Text = "wenn Eplan beendet wird";
			this.chkByEplanEnd.UseVisualStyleBackColor = true;
			// 
			// chkByProjectClose
			// 
			this.chkByProjectClose.AutoSize = true;
			this.chkByProjectClose.Location = new System.Drawing.Point(17, 20);
			this.chkByProjectClose.Name = "chkByProjectClose";
			this.chkByProjectClose.Size = new System.Drawing.Size(172, 17);
			this.chkByProjectClose.TabIndex = 1;
			this.chkByProjectClose.Text = "wenn Project geschlossen wird";
			this.chkByProjectClose.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(166, 260);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 35);
			this.button1.TabIndex = 3;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmPDFAssistent
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnAbort;
			this.ClientSize = new System.Drawing.Size(519, 309);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.chkSaveSettings);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnAbort);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPDFAssistent";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PDF-Export (Assistent)";
			this.Load += new System.EventHandler(this.frmPDFAssistent_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

	}

	public frmPDFAssistent()
	{
		InitializeComponent();
	}

	#endregion

	//Menüpunkt anlegen
	[DeclareMenu()]
	public void PDFAssistent_Menu()
	{
		//Menüeintrag
		Eplan.EplApi.Gui.Menu oMenu = new Eplan.EplApi.Gui.Menu();
		oMenu.AddMenuItem("PDF (Assistent)...", "PDFAssistent_Start", "PDF Assistent, aktuelles Project als PDF-Datei exportieren", 35287, 1, false, false);
	}

	//Event ProjectClose abfangen
	[DeclareEventHandler("onActionStart.String.XPrjActionProjectClose")]
	public void Project_Close_Event()
	{
		//Einstellung einlesen
		Eplan.EplApi.Base.Settings oSettings = new Eplan.EplApi.Base.Settings();
		if (oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.ByProjectClose"))
		{
			bool bChecked = oSettings.GetBoolSetting("USER.SCRIPTS.PDF_Assistant.ByProjectClose", 1);
			if (bChecked) //Bei ProjectClose To Run
			{
				PDFAssistent_SollStarten();
			}
		}
		return;
	}

	//Event Eplan End abfangen
	[DeclareEventHandler("Eplan.EplApi.OnMainEnd")]
	public void Eplan_End_Event()
	{
		//Einstellung einlesen
		Eplan.EplApi.Base.Settings oSettings = new Eplan.EplApi.Base.Settings();
		if (oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.ByEplanEnd"))
		{
			bool bChecked = oSettings.GetBoolSetting("USER.SCRIPTS.PDF_Assistant.ByEplanEnd", 1);
			if (bChecked) //Bei EplanEnd To Run
			{
				PDFAssistent_SollStarten();
			}
		}
		return;
	}

	//Prüfen ob Assistent gestartet werden soll
	public void PDFAssistent_SollStarten()
	{
		Eplan.EplApi.Base.Settings oSettings = new Eplan.EplApi.Base.Settings();

		//Ist Project in Project-Folder
		//Wenn angekreuzt dann muß Project im Folder sein für Assistent, sonst kein Assistent
		//Wenn nicht angekreuzt dann Assistent
		if (oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.OhneNachfrage"))
		{
			bool bChecked = oSettings.GetBoolSetting("USER.SCRIPTS.PDF_Assistant.ProjectInFolder", 1);
			string sProjectInFolder = oSettings.GetStringSetting("USER.SCRIPTS.PDF_Assistant.ProjectInFolderName", 0);
			if (bChecked)
			{
				string sProjectFolder = PathMap.SubstitutePath("$(PROJECTPATH)");
				sProjectFolder = sProjectFolder.Substring(0, sProjectFolder.LastIndexOf(@"\"));
				if (!sProjectFolder.EndsWith(@"\"))
				{
					sProjectFolder += @"\";
				}
				if (sProjectInFolder == sProjectFolder) //hier vielleicht noch erweitern auf alle UnterFolder (InString?)
				{
					PDFAssistent_To Run();
				}
				else
				{
					Close();
				}
			}
			else
			{
				PDFAssistent_To Run();
			}
		}
	}

	//Assistent ohne Dialog direkt To Run (Ohne Nachfrage To Run)
	public void PDFAssistent_To Run()
	{
		Eplan.EplApi.Base.Settings oSettings = new Eplan.EplApi.Base.Settings();
		if (oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.OhneNachfrage"))
		{
			bool bChecked = oSettings.GetBoolSetting("USER.SCRIPTS.PDF_Assistant.OhneNachfrage", 1);
			if (bChecked)
			{
				cboAusgabeNach.SelectedIndex = 0;
				ReadSettings();
				PDFexport(txtSpeicherort.Text + txtDateiname.Text + @".pdf");
				Close();
			}
			else
			{
				PDFAssistent_Start();
			}
		}
	}

	//Assistent Form starten
	[DeclareAction("PDFAssistent_Start")]
	public void PDFAssistent_Start()
	{
		frmPDFAssistent frm = new frmPDFAssistent();
		frm.ShowDialog();
		return;
	}

	//Form wird geladen
	private void frmPDFAssistent_Load(object sender, EventArgs e)
	{
		//Ausgabe Nach einstellen
		cboAusgabeNach.SelectedIndex = 0;
		chkIstInProjectFolder.CheckState = CheckState.Unchecked;
		txtProjectFiledInFolder.Enabled = false;
		btnProjectFolderAuswahl.Enabled = false; 
		ReadSettings();
	}

	//Button: Abort
	private void btnAbort_Click(object sender, System.EventArgs e)
	{
		Close();
	}

	//Button: OK
	private void btnOK_Click(object sender, System.EventArgs e)
	{
		if (txtDateiname.Text != string.Empty)
		{
			PDFexport(txtSpeicherort.Text + txtDateiname.Text + @".pdf");
		}
		WriteSettings();
		Close();
	}

	//Ausgabe Nach hat sich geändert
	private void cboAusgabeNach_SelectedIndexChanged(object sender, EventArgs e)
	{
#if !DEBUG
		string sProjectFolder = PathMap.SubstitutePath("$(PROJECTPATH)");
		string sDateiName = PathMap.SubstitutePath("$(PROJECTNAME)");
#else
		string sProjectFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		string sDateiName = "TEST";
#endif
		string sAusgabeFolder = sProjectFolder;

		switch (cboAusgabeNach.SelectedIndex)
		{
			case 0: //in den Project-Folder
				sAusgabeFolder = sProjectFolder;
				break;

			case 1: //Ausgabeverzeichnis aus Einstellungen: PDF-Export
#if !DEBUG
				Eplan.EplApi.Base.Settings oSettings = new Eplan.EplApi.Base.Settings();
				string sLastSchema = string.Empty;
				if (oSettings.ExistSetting("USER.PDFExportGUI.SCHEMAS.LastUsed"))
				{
					sLastSchema = oSettings.GetStringSetting("USER.PDFExportGUI.SCHEMAS.LastUsed", 0);
				}
				if (oSettings.ExistSetting("USER.PDFExportGUI.SCHEMAS.Steinert.Data.TargetPath"))
				{
					sAusgabeFolder = oSettings.GetStringSetting("USER.PDFExportGUI.SCHEMAS." + sLastSchema + ".Data.TargetPath", 0);
				}
#endif
				break;

			case 2: //in den Folder eine Ebene über dem Project-Folder
				sAusgabeFolder = sProjectFolder.Substring(0, sProjectFolder.LastIndexOf(@"\"));
				break;

			case 3: //in Folder "Eigene Dateien"
				sAusgabeFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				break;

			case 4: //auf den Desktop
				sAusgabeFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
				break;

			case 5: //gleicher Pfad wie Project nur auf anderes Laufwerk
				sAusgabeFolder = sProjectFolder.Substring(0, sProjectFolder.LastIndexOf(@"\"));	//in den Folder eine Ebene über dem Project-Folder
				sAusgabeFolder = sAusgabeFolder.Replace("C:", "D:");	//Hier anpassen, welche Laufwerksbuchstaben verwendet werden.
				break;

			default:
				MessageBox.Show("Auswahl:default");
				break;
		}

		//DateStamp hinzufügen
		if (chkDatumStempel.Checked)
		{
			sDateiName += "_" + DateTime.Now.ToString("yyyyMMdd");
		}

		//TimeStamp hinzufügen
		if (chkTimeStamp.Checked)
		{
			sDateiName += "-" + DateTime.Now.ToString("HHmmss"); ;
		}

		//Endet mit \ ?
		if (!sAusgabeFolder.EndsWith(@"\"))
		{
			sAusgabeFolder += @"\";
		}

		txtDateiname.Text = sDateiName;
		txtSpeicherort.Text = sAusgabeFolder;
	}

	//Datumstempel zustand hat sich geändert
	private void chkDatumStempel_CheckedChanged(object sender, EventArgs e)
	{
		cboAusgabeNach_SelectedIndexChanged(sender, e);
	}

	//TimeStamp zustand hat sich geändert
	private void chkTimeStamp_CheckedChanged(object sender, EventArgs e)
	{
		cboAusgabeNach_SelectedIndexChanged(sender, e);
	}

	//Gesamtes Project als PDF ausgeben
	public void PDFexport(string sZielDatei)
	{
		//Progressbar ein
		Eplan.EplApi.Base.Progress oProgress = new Eplan.EplApi.Base.Progress("SimpleProgress");
		oProgress.ShowImmediately();

		ActionCallingContext pdfContext = new ActionCallingContext();
		pdfContext.AddParameter("type", "PDFPROJECTSCHEME"); //PDFPROJECTSCHEME = Project im PDF-Format exportieren
		//pdfContext.AddParameter("exportscheme", "NAME_SCHEMA"); //verwendetes Schema
		pdfContext.AddParameter("exportfile", sZielDatei); //Name export.Project, Vorgabewert: Projectname
		pdfContext.AddParameter("exportmodel", "0"); //0 = keine Modelle ausgeben
		pdfContext.AddParameter("blackwhite", "1"); //1 = PDF wird schwarz-weiss
		pdfContext.AddParameter("useprintmargins", "1"); //1 = Druckränder verwenden
		pdfContext.AddParameter("readonlyexport", "2"); //1 = PDF wird schreibgeschützt
		pdfContext.AddParameter("usesimplelink", "1"); //1 = einfache Sprungfunktion
		pdfContext.AddParameter("usezoomlevel", "1"); //Springen in Navigationsseiten
		pdfContext.AddParameter("fastwebview", "1"); //1 = schnelle Web-Anzeige
		pdfContext.AddParameter("zoomlevel", "1"); //wenn USEZOOMLEVEL auf 1 dann hier Zoomstufe in mm

		CommandLineInterpreter cmdLineItp = new CommandLineInterpreter();
		cmdLineItp.Execute("export", pdfContext);

		//'Progressbar aus
		oProgress.EndPart(true);

		return;
	}

	//Save settings
	public void WriteSettings()
	{
		Eplan.EplApi.Base.Settings oSettings = new Eplan.EplApi.Base.Settings();

		//Save settings
		if (!oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.SaveSettings"))
		{
			oSettings.AddBoolSetting("USER.SCRIPTS.PDF_Assistant.SaveSettings",
				new bool[] { false },
				"SaveSettings Info",
				new bool[] { false },
				ISettings.CreationFlag.Insert);
		}
		oSettings.SetBoolSetting("USER.SCRIPTS.PDF_Assistant.SaveSettings", chkSaveSettings.Checked, 1); //1 = Visible = True

		//Save only if desired
		if (chkSaveSettings.Checked)
		{

            //Close PDF on project
            if (!oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.ByProjectClose"))
			{
				oSettings.AddBoolSetting("USER.SCRIPTS.PDF_Assistant.ByProjectClose",
					new bool[] { false },
					"Save date stamp",
					new bool[] { false },
					ISettings.CreationFlag.Insert);
			}
			oSettings.SetBoolSetting("USER.SCRIPTS.PDF_Assistant.ByProjectClose", chkByProjectClose.Checked, 1); //1 = Visible = True

            //Exit PDF at Eplan
            if (!oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.ByEplanEnd"))
			{
				oSettings.AddBoolSetting("USER.SCRIPTS.PDF_Assistant.ByEplanEnd",
					new bool[] { false },
					"Save date stamp",
					new bool[] { false },
					ISettings.CreationFlag.Insert);
			}
			oSettings.SetBoolSetting("USER.SCRIPTS.PDF_Assistant.ByEplanEnd", chkByEplanEnd.Checked, 1); //1 = Visible = True

            //Edition after
            if (!oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.AusgabeNach"))
			{
				oSettings.AddNumericSetting("USER.SCRIPTS.PDF_Assistant.AusgabeNach",
					new int[] { 0 },
					new Range[] { new Range { FromValue = 0, ToValue = 32768 } },
					"Default value of test setting",
					new int[] { 0 },
					ISettings.CreationFlag.Insert);
			}
			oSettings.SetNumericSetting("USER.SCRIPTS.PDF_Assistant.AusgabeNach", cboAusgabeNach.SelectedIndex, 1); //1 = Visible = True

			oSettings.SetBoolSetting("USER.SCRIPTS.PDF_Assistant.ByEplanEnd", chkByEplanEnd.Checked, 1); //1 = Visible = True

            //To run without demand
            if (!oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.OhneNachfrage"))
			{
				oSettings.AddBoolSetting("USER.SCRIPTS.PDF_Assistant.OhneNachfrage",
					new bool[] { false },
					"Save date stamp",
					new bool[] { false },
					ISettings.CreationFlag.Insert);
			}
			oSettings.SetBoolSetting("USER.SCRIPTS.PDF_Assistant.OhneNachfrage", chkOhneNachfrage.Checked, 1); //1 = Visible = True

			//DateStamp
			if (!oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.DateStamp"))
			{
				oSettings.AddBoolSetting("USER.SCRIPTS.PDF_Assistant.DateStamp",
					new bool[] { false },
					"Save date stamp",
					new bool[] { false },
					ISettings.CreationFlag.Insert);
			}
			oSettings.SetBoolSetting("USER.SCRIPTS.PDF_Assistant.DateStamp", chkDatumStempel.Checked, 1); //1 = Visible = True

			//TimeStamp
			if (!oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.TimeStamp"))
			{
				oSettings.AddBoolSetting("USER.SCRIPTS.PDF_Assistant.TimeStamp",
					new bool[] { false },
					"TimeStamp ToSave",
					new bool[] { false },
					ISettings.CreationFlag.Insert);
			}
			oSettings.SetBoolSetting("USER.SCRIPTS.PDF_Assistant.TimeStamp", chkTimeStamp.Checked, 1); //1 = Visible = True

			//Project in Folder
			if (!oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.ProjectInFolder"))
			{
				oSettings.AddBoolSetting("USER.SCRIPTS.PDF_Assistant.ProjectInFolder",
					new bool[] { false },
					"Project in folder to save",
					new bool[] { false },
					ISettings.CreationFlag.Insert);
			}
			oSettings.SetBoolSetting("USER.SCRIPTS.PDF_Assistant.ProjectInFolder", chkIstInProjectFolder.Checked, 1); //1 = Visible = True

			if (!oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.ProjectInFolderName"))
			{
				oSettings.AddStringSetting("USER.SCRIPTS.PDF_Assistant.ProjectInFolderName",
				new string[] { },
				new string[] { }, "test setting",
				new string[] { "Default value of test setting" },
				ISettings.CreationFlag.Insert);
			}
			oSettings.SetStringSetting("USER.SCRIPTS.PDF_Assistant.ProjectInFolderName", txtProjectFiledInFolder.Text, 0);
		}
	}

	//Einstellungen einlesen
	public void ReadSettings()
	{
		Eplan.EplApi.Base.Settings oSettings = new Eplan.EplApi.Base.Settings();

		//ByProjectClose
		if (oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.ByProjectClose"))
		{
			chkByProjectClose.Checked = oSettings.GetBoolSetting("USER.SCRIPTS.PDF_Assistant.ByProjectClose", 1);
		}

		//ByEplanEnd
		if (oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.ByEplanEnd"))
		{
			chkByEplanEnd.Checked = oSettings.GetBoolSetting("USER.SCRIPTS.PDF_Assistant.ByEplanEnd", 1);
		}

		//To Run ohne Nachfrage
		if (oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.OhneNachfrage"))
		{
			chkOhneNachfrage.Checked = oSettings.GetBoolSetting("USER.SCRIPTS.PDF_Assistant.OhneNachfrage", 1);
		}

		//Save settings
		if (oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.SaveSettings"))
		{
			chkSaveSettings.Checked = oSettings.GetBoolSetting("USER.SCRIPTS.PDF_Assistant.SaveSettings", 1);
		}

		//DateStamp 
		if (oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.DateStamp"))
		{
			chkDatumStempel.Checked = oSettings.GetBoolSetting("USER.SCRIPTS.PDF_Assistant.DateStamp", 1);
		}

		//TimeStamp 
		if (oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.TimeStamp"))
		{
			chkTimeStamp.Checked = oSettings.GetBoolSetting("USER.SCRIPTS.PDF_Assistant.TimeStamp", 1);
		}

		//Ausgabe Nach
		if (oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.AusgabeNach"))
		{
			cboAusgabeNach.SelectedIndex = oSettings.GetNumericSetting("USER.SCRIPTS.PDF_Assistant.AusgabeNach", 1);
		}

		//Project in Folder
		if (oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.ProjectInFolder"))
		{
			chkIstInProjectFolder.Checked = oSettings.GetBoolSetting("USER.SCRIPTS.PDF_Assistant.ProjectInFolder", 1);
		}
		if (oSettings.ExistSetting("USER.SCRIPTS.PDF_Assistant.ProjectInFolderName"))
		{
			txtProjectFiledInFolder.Text = oSettings.GetStringSetting("USER.SCRIPTS.PDF_Assistant.ProjectInFolderName", 0);
		}
	}

	//Button: PDF Folder auswählen
	private void btnFolderAuswahl_Click(object sender, EventArgs e)
	{
		FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
		folderBrowserDialog1.SelectedPath = txtSpeicherort.Text;
		folderBrowserDialog1.Description = "Wählen Sie den ZielFolder aus in dem die PDF-Datei gespeichert werden soll:";
		DialogResult result = folderBrowserDialog1.ShowDialog();
		if (result == DialogResult.OK)
		{
			string sSpeicherort = folderBrowserDialog1.SelectedPath;
			if (!sSpeicherort.EndsWith(@"\"))
			{
				sSpeicherort += @"\";
			}
			txtSpeicherort.Text = sSpeicherort;
		}
	}

	//Button: ToSave
	private void btnToSave_Click(object sender, EventArgs e)
	{
		WriteSettings();
	}

	//XML-Reader
	private static string ReadXml(string filename, int ID)
	{
		string strLastVersion = "";
		XmlTextReader reader = new XmlTextReader(filename);
		while (reader.Read())
		{
			if (reader.HasAttributes)
			{
				while (reader.MoveToNextAttribute())
				{
					if (reader.Name == "id")
					{
						if (reader.Value == ID.ToString())
						{
							strLastVersion = reader.ReadString();
							reader.Close();
							return strLastVersion;
						}
					}
				}
			}
		}
		return strLastVersion;
	}

	//Test-Button
	private void button1_Click(object sender, EventArgs e)
	{
		string filename = PathMap.SubstitutePath("$(PROJECTPATH)" + @"\" + "Projectinfo.xml");

		string LastVersion = ReadXml(filename, 10043);

		MessageBox.Show(
			"Zuletzt verwendete EPLAN-Version:\n"
			+ LastVersion,
			"Information",
			MessageBoxButtons.OK,
			MessageBoxIcon.Information
			);

	}

	//Button: Project Folder auswählen
	private void btnProjectFolderAuswahl_Click(object sender, EventArgs e)
	{
		FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
		folderBrowserDialog1.SelectedPath = txtProjectFiledInFolder.Text;
		folderBrowserDialog1.Description = "Select the folder in which the project must be stored:";
		DialogResult result = folderBrowserDialog1.ShowDialog();
		if (result == DialogResult.OK)
		{
			string sSpeicherort = folderBrowserDialog1.SelectedPath;
			if (!sSpeicherort.EndsWith(@"\"))
			{
				sSpeicherort += @"\";
			}
			txtProjectFiledInFolder.Text = sSpeicherort;
		}
	}

    //Is in Folder has changed
    private void chkIstInProjectFolder_CheckedChanged(object sender, EventArgs e)
	{
		if (chkIstInProjectFolder.Checked)
		{
			txtProjectFiledInFolder.Enabled = true;
			btnProjectFolderAuswahl.Enabled = true;
		}
		else
		{
			txtProjectFiledInFolder.Enabled = false;
			btnProjectFolderAuswahl.Enabled = false;
		}
	}
}