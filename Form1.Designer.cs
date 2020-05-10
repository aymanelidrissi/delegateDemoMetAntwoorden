namespace delegateDemo
{
    partial class Form1
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
            this.btnMaakNieuweChildForm = new System.Windows.Forms.Button();
            this.tbLogText = new System.Windows.Forms.TextBox();
            this.btnVulLijstMetRandomGetallen = new System.Windows.Forms.Button();
            this.btnToonGetallenOpParent = new System.Windows.Forms.Button();
            this.btnToonParentNaam = new System.Windows.Forms.Button();
            this.btnToonChildForms = new System.Windows.Forms.Button();
            this.btnToonGetallenOpChild = new System.Windows.Forms.Button();
            this.btnClearLogText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaakNieuweChildForm
            // 
            this.btnMaakNieuweChildForm.Location = new System.Drawing.Point(12, 12);
            this.btnMaakNieuweChildForm.Name = "btnMaakNieuweChildForm";
            this.btnMaakNieuweChildForm.Size = new System.Drawing.Size(552, 45);
            this.btnMaakNieuweChildForm.TabIndex = 0;
            this.btnMaakNieuweChildForm.Text = "Maak nieuwe childform";
            this.btnMaakNieuweChildForm.UseVisualStyleBackColor = true;
            this.btnMaakNieuweChildForm.Click += new System.EventHandler(this.BtnMaakNieuweChildForm_Click);
            // 
            // tbLogText
            // 
            this.tbLogText.Location = new System.Drawing.Point(12, 376);
            this.tbLogText.Multiline = true;
            this.tbLogText.Name = "tbLogText";
            this.tbLogText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLogText.Size = new System.Drawing.Size(552, 263);
            this.tbLogText.TabIndex = 1;
            // 
            // btnVulLijstMetRandomGetallen
            // 
            this.btnVulLijstMetRandomGetallen.Location = new System.Drawing.Point(12, 63);
            this.btnVulLijstMetRandomGetallen.Name = "btnVulLijstMetRandomGetallen";
            this.btnVulLijstMetRandomGetallen.Size = new System.Drawing.Size(552, 48);
            this.btnVulLijstMetRandomGetallen.TabIndex = 2;
            this.btnVulLijstMetRandomGetallen.Text = "Vul List<int> met\r\n20 randomgetallen";
            this.btnVulLijstMetRandomGetallen.UseVisualStyleBackColor = true;
            this.btnVulLijstMetRandomGetallen.Click += new System.EventHandler(this.BtnVulLijstMetRandomGetallen_Click);
            // 
            // btnToonGetallenOpParent
            // 
            this.btnToonGetallenOpParent.Location = new System.Drawing.Point(13, 117);
            this.btnToonGetallenOpParent.Name = "btnToonGetallenOpParent";
            this.btnToonGetallenOpParent.Size = new System.Drawing.Size(551, 48);
            this.btnToonGetallenOpParent.TabIndex = 3;
            this.btnToonGetallenOpParent.Text = "Toon inhoud van random \r\nlijst op parent-form";
            this.btnToonGetallenOpParent.UseVisualStyleBackColor = true;
            this.btnToonGetallenOpParent.Click += new System.EventHandler(this.BtnToonGetallenOpParent_Click);
            // 
            // btnToonParentNaam
            // 
            this.btnToonParentNaam.Location = new System.Drawing.Point(13, 226);
            this.btnToonParentNaam.Name = "btnToonParentNaam";
            this.btnToonParentNaam.Size = new System.Drawing.Size(552, 48);
            this.btnToonParentNaam.TabIndex = 4;
            this.btnToonParentNaam.Text = "Toon naam van parent-form";
            this.btnToonParentNaam.UseVisualStyleBackColor = true;
            this.btnToonParentNaam.Click += new System.EventHandler(this.BtnToonParentNaam_Click);
            // 
            // btnToonChildForms
            // 
            this.btnToonChildForms.Location = new System.Drawing.Point(13, 280);
            this.btnToonChildForms.Name = "btnToonChildForms";
            this.btnToonChildForms.Size = new System.Drawing.Size(552, 43);
            this.btnToonChildForms.TabIndex = 5;
            this.btnToonChildForms.Text = "Toon childForms van deze parent";
            this.btnToonChildForms.UseVisualStyleBackColor = true;
            this.btnToonChildForms.Click += new System.EventHandler(this.BtnToonChildForms_Click);
            // 
            // btnToonGetallenOpChild
            // 
            this.btnToonGetallenOpChild.Location = new System.Drawing.Point(14, 172);
            this.btnToonGetallenOpChild.Name = "btnToonGetallenOpChild";
            this.btnToonGetallenOpChild.Size = new System.Drawing.Size(551, 48);
            this.btnToonGetallenOpChild.TabIndex = 6;
            this.btnToonGetallenOpChild.Text = "Toon inhoud van random \r\nlijst op child-form";
            this.btnToonGetallenOpChild.UseVisualStyleBackColor = true;
            this.btnToonGetallenOpChild.Click += new System.EventHandler(this.BtnToonGetallenOpChild_Click);
            // 
            // btnClearLogText
            // 
            this.btnClearLogText.Location = new System.Drawing.Point(14, 329);
            this.btnClearLogText.Name = "btnClearLogText";
            this.btnClearLogText.Size = new System.Drawing.Size(550, 41);
            this.btnClearLogText.TabIndex = 7;
            this.btnClearLogText.Text = "Wis tekstbox";
            this.btnClearLogText.UseVisualStyleBackColor = true;
            this.btnClearLogText.Click += new System.EventHandler(this.BtnClearLogText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 651);
            this.Controls.Add(this.btnClearLogText);
            this.Controls.Add(this.btnToonGetallenOpChild);
            this.Controls.Add(this.btnToonChildForms);
            this.Controls.Add(this.btnToonParentNaam);
            this.Controls.Add(this.btnToonGetallenOpParent);
            this.Controls.Add(this.btnVulLijstMetRandomGetallen);
            this.Controls.Add(this.tbLogText);
            this.Controls.Add(this.btnMaakNieuweChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaakNieuweChildForm;
        private System.Windows.Forms.Button btnVulLijstMetRandomGetallen;
        private System.Windows.Forms.Button btnToonGetallenOpParent;
        private System.Windows.Forms.Button btnToonParentNaam;
        public System.Windows.Forms.TextBox tbLogText;
        private System.Windows.Forms.Button btnToonChildForms;
        private System.Windows.Forms.Button btnToonGetallenOpChild;
        private System.Windows.Forms.Button btnClearLogText;
    }
}

