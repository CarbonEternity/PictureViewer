namespace PictureViewer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuActual = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCenterImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAutoSize = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuResizeStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuActualStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCenterImageStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAutoSizeStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sbFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.contextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSave,
            this.toolStripSeparator1,
            this.mnuPageSetup,
            this.mnuPrintPreview,
            this.mnuPrint,
            this.toolStripSeparator2,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(48, 20);
            this.mnuFile.Text = "&Файл";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpen.ShowShortcutKeys = false;
            this.mnuOpen.Size = new System.Drawing.Size(233, 22);
            this.mnuOpen.Text = "&Открыть";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.ShowShortcutKeys = false;
            this.mnuSave.Size = new System.Drawing.Size(233, 22);
            this.mnuSave.Text = "&Сохранить";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // mnuPageSetup
            // 
            this.mnuPageSetup.Name = "mnuPageSetup";
            this.mnuPageSetup.Size = new System.Drawing.Size(233, 22);
            this.mnuPageSetup.Text = "Пара&метры страницы";
            this.mnuPageSetup.Click += new System.EventHandler(this.mnuPageSetup_Click);
            // 
            // mnuPrintPreview
            // 
            this.mnuPrintPreview.Name = "mnuPrintPreview";
            this.mnuPrintPreview.Size = new System.Drawing.Size(233, 22);
            this.mnuPrintPreview.Text = "Пред&варительный просмотр";
            this.mnuPrintPreview.Click += new System.EventHandler(this.mnuPrintPreview_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuPrint.ShowShortcutKeys = false;
            this.mnuPrint.Size = new System.Drawing.Size(233, 22);
            this.mnuPrint.Text = "&Печать";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(230, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.ShowShortcutKeys = false;
            this.mnuExit.Size = new System.Drawing.Size(233, 22);
            this.mnuExit.Text = "&Exit";
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuResize,
            this.mnuActual,
            this.mnuCenterImage,
            this.mnuAutoSize});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(39, 20);
            this.mnuView.Text = "&Вид";
            this.mnuView.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuResize
            // 
            this.mnuResize.Name = "mnuResize";
            this.mnuResize.Size = new System.Drawing.Size(209, 22);
            this.mnuResize.Text = "&Подогнать размер";
            this.mnuResize.Click += new System.EventHandler(this.mnuResize_Click);
            // 
            // mnuActual
            // 
            this.mnuActual.Name = "mnuActual";
            this.mnuActual.Size = new System.Drawing.Size(209, 22);
            this.mnuActual.Text = "&Истинный размер";
            this.mnuActual.Click += new System.EventHandler(this.mnuActual_Click);
            // 
            // mnuCenterImage
            // 
            this.mnuCenterImage.Name = "mnuCenterImage";
            this.mnuCenterImage.Size = new System.Drawing.Size(209, 22);
            this.mnuCenterImage.Text = "&По центру";
            this.mnuCenterImage.Click += new System.EventHandler(this.mnuCenterImage_Click);
            // 
            // mnuAutoSize
            // 
            this.mnuAutoSize.Name = "mnuAutoSize";
            this.mnuAutoSize.Size = new System.Drawing.Size(209, 22);
            this.mnuAutoSize.Text = "&Автоматический размер";
            this.mnuAutoSize.Click += new System.EventHandler(this.mnuAutoSize_Click);
            // 
            // contextMenu1
            // 
            this.contextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuResizeStripMenu,
            this.mnuActualStripMenu,
            this.mnuCenterImageStripMenu,
            this.mnuAutoSizeStripMenu});
            this.contextMenu1.Name = "contextMenu1";
            this.contextMenu1.Size = new System.Drawing.Size(210, 92);
            // 
            // mnuResizeStripMenu
            // 
            this.mnuResizeStripMenu.Name = "mnuResizeStripMenu";
            this.mnuResizeStripMenu.Size = new System.Drawing.Size(209, 22);
            this.mnuResizeStripMenu.Text = "&Подогнать размер";
            this.mnuResizeStripMenu.Click += new System.EventHandler(this.mnuResizeStripMenu_Click);
            // 
            // mnuActualStripMenu
            // 
            this.mnuActualStripMenu.Name = "mnuActualStripMenu";
            this.mnuActualStripMenu.Size = new System.Drawing.Size(209, 22);
            this.mnuActualStripMenu.Text = "&Истинный размер";
            this.mnuActualStripMenu.Click += new System.EventHandler(this.mnuActualStripMenu_Click);
            // 
            // mnuCenterImageStripMenu
            // 
            this.mnuCenterImageStripMenu.Name = "mnuCenterImageStripMenu";
            this.mnuCenterImageStripMenu.Size = new System.Drawing.Size(209, 22);
            this.mnuCenterImageStripMenu.Text = "&По центру";
            this.mnuCenterImageStripMenu.Click += new System.EventHandler(this.mnuCenterImageStripMenu_Click);
            // 
            // mnuAutoSizeStripMenu
            // 
            this.mnuAutoSizeStripMenu.Name = "mnuAutoSizeStripMenu";
            this.mnuAutoSizeStripMenu.Size = new System.Drawing.Size(209, 22);
            this.mnuAutoSizeStripMenu.Text = "&Автоматический размер";
            this.mnuAutoSizeStripMenu.Click += new System.EventHandler(this.mnuAutoSizeStripMenu_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Выбор изображения";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Сохранение изображения";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenu1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbFile,
            this.sbSize});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sbFile
            // 
            this.sbFile.AutoSize = false;
            this.sbFile.Margin = new System.Windows.Forms.Padding(100, 3, 0, 2);
            this.sbFile.Name = "sbFile";
            this.sbFile.Size = new System.Drawing.Size(500, 17);
            // 
            // sbSize
            // 
            this.sbSize.AutoSize = false;
            this.sbSize.Margin = new System.Windows.Forms.Padding(50, 3, 0, 2);
            this.sbSize.Name = "sbSize";
            this.sbSize.Size = new System.Drawing.Size(100, 17);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuPageSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuResize;
        private System.Windows.Forms.ToolStripMenuItem mnuActual;
        private System.Windows.Forms.ToolStripMenuItem mnuCenterImage;
        private System.Windows.Forms.ToolStripMenuItem mnuAutoSize;
        private System.Windows.Forms.ContextMenuStrip contextMenu1;
        private System.Windows.Forms.ToolStripMenuItem mnuResizeStripMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuActualStripMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuCenterImageStripMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAutoSizeStripMenu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sbFile;
        private System.Windows.Forms.ToolStripStatusLabel sbSize;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

