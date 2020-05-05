namespace Xamasoft.JsonClassGenerator.UI
{
    partial class frmCSharpClassGeneration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCSharpClassGeneration));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.edtJson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNamespace = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radFields = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radPublic = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radProperties = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radInternal = new System.Windows.Forms.RadioButton();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.edtSecondaryNamespace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radSameNamespace = new System.Windows.Forms.RadioButton();
            this.radDifferentNamespace = new System.Windows.Forms.RadioButton();
            this.radNestedClasses = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.chkApplyObfuscationAttributes = new System.Windows.Forms.CheckBox();
            this.chkExplicitDeserialization = new System.Windows.Forms.CheckBox();
            this.chkPascalCase = new System.Windows.Forms.CheckBox();
            this.edtMainClass = new System.Windows.Forms.TextBox();
            this.edtTargetFolder = new System.Windows.Forms.TextBox();
            this.chkNoHelper = new System.Windows.Forms.CheckBox();
            this.edtNamespace = new System.Windows.Forms.TextBox();
            this.chkSingleFile = new System.Windows.Forms.CheckBox();
            this.lblDone = new System.Windows.Forms.Label();
            this.messageTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPasteAndGo = new System.Windows.Forms.Button();
            this.lblDoneClipboard = new System.Windows.Forms.Label();
            this.chkDocumentationExamples = new System.Windows.Forms.CheckBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(719, 610);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 27);
            this.btnGenerate.TabIndex = 17;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // edtJson
            // 
            this.edtJson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtJson.Location = new System.Drawing.Point(20, 292);
            this.edtJson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtJson.MaxLength = 10000000;
            this.edtJson.Multiline = true;
            this.edtJson.Name = "edtJson";
            this.edtJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edtJson.Size = new System.Drawing.Size(905, 312);
            this.edtJson.TabIndex = 14;
            this.edtJson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtJson_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Generate C# classes from sample JSON:";
            // 
            // lblNamespace
            // 
            this.lblNamespace.AutoSize = true;
            this.lblNamespace.Location = new System.Drawing.Point(16, 14);
            this.lblNamespace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamespace.Name = "lblNamespace";
            this.lblNamespace.Size = new System.Drawing.Size(87, 15);
            this.lblNamespace.TabIndex = 4;
            this.lblNamespace.Text = "Namespace:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(827, 610);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 27);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Members generation:";
            // 
            // radFields
            // 
            this.radFields.AutoSize = true;
            this.radFields.Location = new System.Drawing.Point(120, 3);
            this.radFields.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radFields.Name = "radFields";
            this.radFields.Size = new System.Drawing.Size(76, 19);
            this.radFields.TabIndex = 1;
            this.radFields.Text = "Fields";
            this.radFields.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Visibility:";
            // 
            // radPublic
            // 
            this.radPublic.AutoSize = true;
            this.radPublic.Location = new System.Drawing.Point(104, 3);
            this.radPublic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radPublic.Name = "radPublic";
            this.radPublic.Size = new System.Drawing.Size(76, 19);
            this.radPublic.TabIndex = 1;
            this.radPublic.Text = "Public";
            this.radPublic.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.radProperties);
            this.flowLayoutPanel1.Controls.Add(this.radFields);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(611, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 25);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // radProperties
            // 
            this.radProperties.AutoSize = true;
            this.radProperties.Checked = true;
            this.radProperties.Location = new System.Drawing.Point(4, 3);
            this.radProperties.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radProperties.Name = "radProperties";
            this.radProperties.Size = new System.Drawing.Size(108, 19);
            this.radProperties.TabIndex = 0;
            this.radProperties.TabStop = true;
            this.radProperties.Text = "Properties";
            this.radProperties.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.radInternal);
            this.flowLayoutPanel2.Controls.Add(this.radPublic);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(611, 38);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(184, 25);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // radInternal
            // 
            this.radInternal.AutoSize = true;
            this.radInternal.Checked = true;
            this.radInternal.Location = new System.Drawing.Point(4, 3);
            this.radInternal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radInternal.Name = "radInternal";
            this.radInternal.Size = new System.Drawing.Size(92, 19);
            this.radInternal.TabIndex = 0;
            this.radInternal.TabStop = true;
            this.radInternal.Text = "Internal";
            this.radInternal.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(368, 73);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(32, 27);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Target folder:";
            // 
            // edtSecondaryNamespace
            // 
            this.edtSecondaryNamespace.Location = new System.Drawing.Point(40, 78);
            this.edtSecondaryNamespace.Margin = new System.Windows.Forms.Padding(40, 3, 4, 3);
            this.edtSecondaryNamespace.Name = "edtSecondaryNamespace";
            this.edtSecondaryNamespace.Size = new System.Drawing.Size(291, 25);
            this.edtSecondaryNamespace.TabIndex = 3;
            this.edtSecondaryNamespace.Text = "Example.JsonTypes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Main class name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Secondary classes:";
            // 
            // radSameNamespace
            // 
            this.radSameNamespace.AutoSize = true;
            this.radSameNamespace.Location = new System.Drawing.Point(4, 28);
            this.radSameNamespace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radSameNamespace.Name = "radSameNamespace";
            this.radSameNamespace.Size = new System.Drawing.Size(204, 19);
            this.radSameNamespace.TabIndex = 1;
            this.radSameNamespace.TabStop = true;
            this.radSameNamespace.Text = "Use the same namespace";
            this.radSameNamespace.UseVisualStyleBackColor = true;
            this.radSameNamespace.CheckedChanged += new System.EventHandler(this.radSameNamespace_CheckedChanged);
            // 
            // radDifferentNamespace
            // 
            this.radDifferentNamespace.AutoSize = true;
            this.radDifferentNamespace.Location = new System.Drawing.Point(4, 53);
            this.radDifferentNamespace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radDifferentNamespace.Name = "radDifferentNamespace";
            this.radDifferentNamespace.Size = new System.Drawing.Size(228, 19);
            this.radDifferentNamespace.TabIndex = 2;
            this.radDifferentNamespace.TabStop = true;
            this.radDifferentNamespace.Text = "Use a different namespace";
            this.radDifferentNamespace.UseVisualStyleBackColor = true;
            this.radDifferentNamespace.CheckedChanged += new System.EventHandler(this.radDifferentNamespace_CheckedChanged);
            // 
            // radNestedClasses
            // 
            this.radNestedClasses.AutoSize = true;
            this.radNestedClasses.Location = new System.Drawing.Point(4, 3);
            this.radNestedClasses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radNestedClasses.Name = "radNestedClasses";
            this.radNestedClasses.Size = new System.Drawing.Size(172, 19);
            this.radNestedClasses.TabIndex = 0;
            this.radNestedClasses.TabStop = true;
            this.radNestedClasses.Text = "Use nested classes";
            this.radNestedClasses.UseVisualStyleBackColor = true;
            this.radNestedClasses.CheckedChanged += new System.EventHandler(this.radNestedClasses_CheckedChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.radNestedClasses);
            this.flowLayoutPanel3.Controls.Add(this.radSameNamespace);
            this.flowLayoutPanel3.Controls.Add(this.radDifferentNamespace);
            this.flowLayoutPanel3.Controls.Add(this.edtSecondaryNamespace);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(44, 155);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(356, 115);
            this.flowLayoutPanel3.TabIndex = 5;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DisplayMember = "DisplayName";
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(153, 104);
            this.cmbLanguage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(245, 23);
            this.cmbLanguage.TabIndex = 4;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(16, 107);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(79, 15);
            this.lblLanguage.TabIndex = 37;
            this.lblLanguage.Text = "Language:";
            // 
            // chkApplyObfuscationAttributes
            // 
            this.chkApplyObfuscationAttributes.AutoSize = true;
            this.chkApplyObfuscationAttributes.Location = new System.Drawing.Point(465, 157);
            this.chkApplyObfuscationAttributes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkApplyObfuscationAttributes.Name = "chkApplyObfuscationAttributes";
            this.chkApplyObfuscationAttributes.Size = new System.Drawing.Size(333, 19);
            this.chkApplyObfuscationAttributes.TabIndex = 12;
            this.chkApplyObfuscationAttributes.Text = "Apply obfuscation exclusion attributes";
            this.chkApplyObfuscationAttributes.UseVisualStyleBackColor = true;
            // 
            // chkExplicitDeserialization
            // 
            this.chkExplicitDeserialization.AutoSize = true;
            this.chkExplicitDeserialization.Location = new System.Drawing.Point(465, 104);
            this.chkExplicitDeserialization.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkExplicitDeserialization.Name = "chkExplicitDeserialization";
            this.chkExplicitDeserialization.Size = new System.Drawing.Size(341, 19);
            this.chkExplicitDeserialization.TabIndex = 10;
            this.chkExplicitDeserialization.Text = "Use explicit deserialization (obsolete)";
            this.chkExplicitDeserialization.UseVisualStyleBackColor = true;
            this.chkExplicitDeserialization.CheckedChanged += new System.EventHandler(this.chkExplicitDeserialization_CheckedChanged);
            // 
            // chkPascalCase
            // 
            this.chkPascalCase.AutoSize = true;
            this.chkPascalCase.Checked = true;
            this.chkPascalCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPascalCase.Location = new System.Drawing.Point(465, 77);
            this.chkPascalCase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkPascalCase.Name = "chkPascalCase";
            this.chkPascalCase.Size = new System.Drawing.Size(197, 19);
            this.chkPascalCase.TabIndex = 9;
            this.chkPascalCase.Text = "Convert to PascalCase";
            this.chkPascalCase.UseVisualStyleBackColor = true;
            // 
            // edtMainClass
            // 
            this.edtMainClass.Location = new System.Drawing.Point(153, 43);
            this.edtMainClass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtMainClass.Name = "edtMainClass";
            this.edtMainClass.Size = new System.Drawing.Size(245, 25);
            this.edtMainClass.TabIndex = 1;
            this.edtMainClass.Text = "JsonData";
            this.edtMainClass.TextChanged += new System.EventHandler(this.edtMainClass_TextChanged);
            // 
            // edtTargetFolder
            // 
            this.edtTargetFolder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.edtTargetFolder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.edtTargetFolder.Location = new System.Drawing.Point(153, 75);
            this.edtTargetFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtTargetFolder.Name = "edtTargetFolder";
            this.edtTargetFolder.Size = new System.Drawing.Size(205, 25);
            this.edtTargetFolder.TabIndex = 2;
            // 
            // chkNoHelper
            // 
            this.chkNoHelper.AutoSize = true;
            this.chkNoHelper.Location = new System.Drawing.Point(488, 130);
            this.chkNoHelper.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkNoHelper.Name = "chkNoHelper";
            this.chkNoHelper.Size = new System.Drawing.Size(253, 19);
            this.chkNoHelper.TabIndex = 11;
            this.chkNoHelper.Text = "Do not generate helper class";
            this.chkNoHelper.UseVisualStyleBackColor = true;
            // 
            // edtNamespace
            // 
            this.edtNamespace.Location = new System.Drawing.Point(153, 10);
            this.edtNamespace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtNamespace.Name = "edtNamespace";
            this.edtNamespace.Size = new System.Drawing.Size(245, 25);
            this.edtNamespace.TabIndex = 0;
            this.edtNamespace.Text = "Examples";
            this.edtNamespace.TextChanged += new System.EventHandler(this.edtNamespace_TextChanged);
            // 
            // chkSingleFile
            // 
            this.chkSingleFile.AutoSize = true;
            this.chkSingleFile.Location = new System.Drawing.Point(465, 185);
            this.chkSingleFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkSingleFile.Name = "chkSingleFile";
            this.chkSingleFile.Size = new System.Drawing.Size(205, 19);
            this.chkSingleFile.TabIndex = 13;
            this.chkSingleFile.Text = "Generate a single file";
            this.chkSingleFile.UseVisualStyleBackColor = true;
            // 
            // lblDone
            // 
            this.lblDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.ForeColor = System.Drawing.Color.Green;
            this.lblDone.Location = new System.Drawing.Point(30, 614);
            this.lblDone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(49, 19);
            this.lblDone.TabIndex = 38;
            this.lblDone.Text = "Done!";
            this.lblDone.Visible = false;
            // 
            // messageTimer
            // 
            this.messageTimer.Interval = 7000;
            this.messageTimer.Tick += new System.EventHandler(this.messageTimer_Tick);
            // 
            // btnPasteAndGo
            // 
            this.btnPasteAndGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPasteAndGo.Location = new System.Drawing.Point(583, 610);
            this.btnPasteAndGo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPasteAndGo.Name = "btnPasteAndGo";
            this.btnPasteAndGo.Size = new System.Drawing.Size(128, 27);
            this.btnPasteAndGo.TabIndex = 16;
            this.btnPasteAndGo.Text = "Paste && go (F9)";
            this.btnPasteAndGo.UseVisualStyleBackColor = true;
            this.btnPasteAndGo.Click += new System.EventHandler(this.btnPasteAndGo_Click);
            // 
            // lblDoneClipboard
            // 
            this.lblDoneClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoneClipboard.AutoSize = true;
            this.lblDoneClipboard.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoneClipboard.ForeColor = System.Drawing.Color.Green;
            this.lblDoneClipboard.Location = new System.Drawing.Point(30, 614);
            this.lblDoneClipboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoneClipboard.Name = "lblDoneClipboard";
            this.lblDoneClipboard.Size = new System.Drawing.Size(237, 19);
            this.lblDoneClipboard.TabIndex = 38;
            this.lblDoneClipboard.Text = "Done! Classes copied to clipboard";
            this.lblDoneClipboard.Visible = false;
            // 
            // chkDocumentationExamples
            // 
            this.chkDocumentationExamples.AutoSize = true;
            this.chkDocumentationExamples.Location = new System.Drawing.Point(465, 211);
            this.chkDocumentationExamples.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDocumentationExamples.Name = "chkDocumentationExamples";
            this.chkDocumentationExamples.Size = new System.Drawing.Size(357, 19);
            this.chkDocumentationExamples.TabIndex = 40;
            this.chkDocumentationExamples.Text = "Generate documentation with data examples";
            this.chkDocumentationExamples.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(475, 610);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(100, 27);
            this.btnGo.TabIndex = 41;
            this.btnGo.Text = "Go (F5)";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // frmCSharpClassGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(943, 651);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.chkDocumentationExamples);
            this.Controls.Add(this.btnPasteAndGo);
            this.Controls.Add(this.lblDoneClipboard);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.chkSingleFile);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.chkApplyObfuscationAttributes);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkExplicitDeserialization);
            this.Controls.Add(this.chkPascalCase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edtMainClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.edtTargetFolder);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkNoHelper);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNamespace);
            this.Controls.Add(this.edtNamespace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtJson);
            this.Controls.Add(this.btnGenerate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(889, 505);
            this.Name = "frmCSharpClassGeneration";
            this.Text = "Json Viewer|Xamasoft JSON Class Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCSharpClassGeneration_FormClosing);
            this.Load += new System.EventHandler(this.frmCSharpClassGeneration_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox edtJson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtNamespace;
        private System.Windows.Forms.Label lblNamespace;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkNoHelper;
        private System.Windows.Forms.TextBox edtSecondaryNamespace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radFields;
        private System.Windows.Forms.RadioButton radProperties;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radInternal;
        private System.Windows.Forms.RadioButton radPublic;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox edtTargetFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtMainClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkPascalCase;
        private System.Windows.Forms.CheckBox chkExplicitDeserialization;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radSameNamespace;
        private System.Windows.Forms.RadioButton radDifferentNamespace;
        private System.Windows.Forms.RadioButton radNestedClasses;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox chkApplyObfuscationAttributes;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.CheckBox chkSingleFile;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Timer messageTimer;
        private System.Windows.Forms.Button btnPasteAndGo;
        private System.Windows.Forms.Label lblDoneClipboard;
        private System.Windows.Forms.CheckBox chkDocumentationExamples;
        private System.Windows.Forms.Button btnGo;
    }
}

