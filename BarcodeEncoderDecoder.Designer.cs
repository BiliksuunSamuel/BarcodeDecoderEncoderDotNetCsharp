
namespace BarcodeReaderDecoderProject
{
    partial class BarcodeEncoderDecoder
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
            this.Container = new MaterialSkin.Controls.MaterialCard();
            this.FormDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.FormRadius = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.DisplayGroup = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.DisplayPictureBox = new System.Windows.Forms.PictureBox();
            this.Encodetxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Decodetxt = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.Encodebtn = new MaterialSkin.Controls.MaterialButton();
            this.Decodebtn = new MaterialSkin.Controls.MaterialButton();
            this.Container.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.DisplayGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Container.Controls.Add(this.materialCard1);
            this.Container.Depth = 0;
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Container.Location = new System.Drawing.Point(3, 3);
            this.Container.Margin = new System.Windows.Forms.Padding(14);
            this.Container.MouseState = MaterialSkin.MouseState.HOVER;
            this.Container.Name = "Container";
            this.Container.Padding = new System.Windows.Forms.Padding(14);
            this.Container.Size = new System.Drawing.Size(528, 318);
            this.Container.TabIndex = 0;
            // 
            // FormDrag
            // 
            this.FormDrag.Fixed = true;
            this.FormDrag.Horizontal = true;
            this.FormDrag.TargetControl = this.Container;
            this.FormDrag.Vertical = true;
            // 
            // FormRadius
            // 
            this.FormRadius.ElipseRadius = 10;
            this.FormRadius.TargetControl = this;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.Decodebtn);
            this.materialCard1.Controls.Add(this.Encodebtn);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.Decodetxt);
            this.materialCard1.Controls.Add(this.Encodetxt);
            this.materialCard1.Controls.Add(this.DisplayGroup);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(27, 39);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(472, 251);
            this.materialCard1.TabIndex = 0;
            // 
            // DisplayGroup
            // 
            this.DisplayGroup.BorderColor = System.Drawing.Color.LightGray;
            this.DisplayGroup.BorderRadius = 1;
            this.DisplayGroup.BorderThickness = 1;
            this.DisplayGroup.Controls.Add(this.DisplayPictureBox);
            this.DisplayGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DisplayGroup.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DisplayGroup.LabelIndent = 10;
            this.DisplayGroup.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.DisplayGroup.Location = new System.Drawing.Point(17, 15);
            this.DisplayGroup.Name = "DisplayGroup";
            this.DisplayGroup.Size = new System.Drawing.Size(438, 131);
            this.DisplayGroup.TabIndex = 0;
            this.DisplayGroup.TabStop = false;
            // 
            // DisplayPictureBox
            // 
            this.DisplayPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayPictureBox.Location = new System.Drawing.Point(3, 19);
            this.DisplayPictureBox.Name = "DisplayPictureBox";
            this.DisplayPictureBox.Size = new System.Drawing.Size(432, 109);
            this.DisplayPictureBox.TabIndex = 0;
            this.DisplayPictureBox.TabStop = false;
            // 
            // Encodetxt
            // 
            this.Encodetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Encodetxt.Depth = 0;
            this.Encodetxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.Encodetxt.Hint = "Enter Code";
            this.Encodetxt.Location = new System.Drawing.Point(91, 155);
            this.Encodetxt.MaxLength = 50;
            this.Encodetxt.MouseState = MaterialSkin.MouseState.OUT;
            this.Encodetxt.Multiline = false;
            this.Encodetxt.Name = "Encodetxt";
            this.Encodetxt.Size = new System.Drawing.Size(269, 36);
            this.Encodetxt.TabIndex = 1;
            this.Encodetxt.Text = "";
            this.Encodetxt.UseTallSize = false;
            // 
            // Decodetxt
            // 
            this.Decodetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Decodetxt.Depth = 0;
            this.Decodetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Decodetxt.Location = new System.Drawing.Point(91, 198);
            this.Decodetxt.MaxLength = 50;
            this.Decodetxt.MouseState = MaterialSkin.MouseState.OUT;
            this.Decodetxt.Multiline = false;
            this.Decodetxt.Name = "Decodetxt";
            this.Decodetxt.ReadOnly = true;
            this.Decodetxt.Size = new System.Drawing.Size(269, 36);
            this.Decodetxt.TabIndex = 2;
            this.Decodetxt.Text = "";
            this.Decodetxt.UseTallSize = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(17, 159);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(66, 24);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Encode";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(17, 203);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 24);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Decode";
            // 
            // Encodebtn
            // 
            this.Encodebtn.AutoSize = false;
            this.Encodebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Encodebtn.Depth = 0;
            this.Encodebtn.DrawShadows = true;
            this.Encodebtn.HighEmphasis = false;
            this.Encodebtn.Icon = null;
            this.Encodebtn.Location = new System.Drawing.Point(373, 155);
            this.Encodebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Encodebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Encodebtn.Name = "Encodebtn";
            this.Encodebtn.Size = new System.Drawing.Size(79, 35);
            this.Encodebtn.TabIndex = 5;
            this.Encodebtn.Text = "Encode";
            this.Encodebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Encodebtn.UseAccentColor = false;
            this.Encodebtn.UseVisualStyleBackColor = true;
            this.Encodebtn.Click += new System.EventHandler(this.Encodebtn_Click);
            // 
            // Decodebtn
            // 
            this.Decodebtn.AutoSize = false;
            this.Decodebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Decodebtn.Depth = 0;
            this.Decodebtn.DrawShadows = true;
            this.Decodebtn.HighEmphasis = false;
            this.Decodebtn.Icon = null;
            this.Decodebtn.Location = new System.Drawing.Point(373, 198);
            this.Decodebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Decodebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Decodebtn.Name = "Decodebtn";
            this.Decodebtn.Size = new System.Drawing.Size(79, 35);
            this.Decodebtn.TabIndex = 6;
            this.Decodebtn.Text = "Decode";
            this.Decodebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Decodebtn.UseAccentColor = false;
            this.Decodebtn.UseVisualStyleBackColor = true;
            this.Decodebtn.Click += new System.EventHandler(this.Decodebtn_Click);
            // 
            // BarcodeEncoderDecoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 324);
            this.ControlBox = false;
            this.Controls.Add(this.Container);
            this.Name = "BarcodeEncoderDecoder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarcodeEncoderDecoder";
            this.TopMost = true;
            this.Container.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.DisplayGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard Container;
        private Bunifu.Framework.UI.BunifuDragControl FormDrag;
        private Bunifu.Framework.UI.BunifuElipse FormRadius;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Bunifu.UI.WinForms.BunifuGroupBox DisplayGroup;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox Decodetxt;
        private MaterialSkin.Controls.MaterialTextBox Encodetxt;
        private System.Windows.Forms.PictureBox DisplayPictureBox;
        private MaterialSkin.Controls.MaterialButton Decodebtn;
        private MaterialSkin.Controls.MaterialButton Encodebtn;
    }
}