namespace SampleServerMonitoring
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReadEvent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReadCPU = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReadHD = new System.Windows.Forms.Button();
            this.txtHD = new System.Windows.Forms.RichTextBox();
            this.txtCPU = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtProg = new System.Windows.Forms.RichTextBox();
            this.btnReadProgram = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSendLine = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnReadEvent);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "事件檢視器";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(993, 246);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnReadEvent
            // 
            this.btnReadEvent.Location = new System.Drawing.Point(15, 21);
            this.btnReadEvent.Name = "btnReadEvent";
            this.btnReadEvent.Size = new System.Drawing.Size(150, 23);
            this.btnReadEvent.TabIndex = 0;
            this.btnReadEvent.Text = "讀取事件檢視器";
            this.btnReadEvent.UseVisualStyleBackColor = true;
            this.btnReadEvent.Click += new System.EventHandler(this.btnReadEvent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCPU);
            this.groupBox2.Controls.Add(this.btnReadCPU);
            this.groupBox2.Location = new System.Drawing.Point(12, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPU 使用率";
            // 
            // btnReadCPU
            // 
            this.btnReadCPU.Location = new System.Drawing.Point(15, 21);
            this.btnReadCPU.Name = "btnReadCPU";
            this.btnReadCPU.Size = new System.Drawing.Size(150, 23);
            this.btnReadCPU.TabIndex = 1;
            this.btnReadCPU.Text = "讀取 CPU 使用率";
            this.btnReadCPU.UseVisualStyleBackColor = true;
            this.btnReadCPU.Click += new System.EventHandler(this.btnReadCPU_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtHD);
            this.groupBox3.Controls.Add(this.btnReadHD);
            this.groupBox3.Location = new System.Drawing.Point(260, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 159);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "硬碟可用容量";
            // 
            // btnReadHD
            // 
            this.btnReadHD.Location = new System.Drawing.Point(15, 21);
            this.btnReadHD.Name = "btnReadHD";
            this.btnReadHD.Size = new System.Drawing.Size(150, 23);
            this.btnReadHD.TabIndex = 1;
            this.btnReadHD.Text = "讀取硬碟可用容量";
            this.btnReadHD.UseVisualStyleBackColor = true;
            this.btnReadHD.Click += new System.EventHandler(this.btnReadHD_Click);
            // 
            // txtHD
            // 
            this.txtHD.Location = new System.Drawing.Point(15, 53);
            this.txtHD.Name = "txtHD";
            this.txtHD.Size = new System.Drawing.Size(265, 93);
            this.txtHD.TabIndex = 2;
            this.txtHD.Text = "";
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(15, 53);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(216, 60);
            this.txtCPU.TabIndex = 3;
            this.txtCPU.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtProg);
            this.groupBox4.Controls.Add(this.btnReadProgram);
            this.groupBox4.Location = new System.Drawing.Point(558, 320);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 159);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "程式執行狀況";
            // 
            // txtProg
            // 
            this.txtProg.Location = new System.Drawing.Point(15, 53);
            this.txtProg.Name = "txtProg";
            this.txtProg.Size = new System.Drawing.Size(229, 93);
            this.txtProg.TabIndex = 2;
            this.txtProg.Text = "";
            // 
            // btnReadProgram
            // 
            this.btnReadProgram.Location = new System.Drawing.Point(15, 21);
            this.btnReadProgram.Name = "btnReadProgram";
            this.btnReadProgram.Size = new System.Drawing.Size(150, 23);
            this.btnReadProgram.TabIndex = 1;
            this.btnReadProgram.Text = "讀取程式執行狀況";
            this.btnReadProgram.UseVisualStyleBackColor = true;
            this.btnReadProgram.Click += new System.EventHandler(this.btnReadProgram_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSendLine);
            this.groupBox5.Location = new System.Drawing.Point(819, 320);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(201, 64);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Line 即時回報";
            // 
            // btnSendLine
            // 
            this.btnSendLine.Location = new System.Drawing.Point(15, 21);
            this.btnSendLine.Name = "btnSendLine";
            this.btnSendLine.Size = new System.Drawing.Size(150, 23);
            this.btnSendLine.TabIndex = 1;
            this.btnSendLine.Text = "發送 Line 通知";
            this.btnSendLine.UseVisualStyleBackColor = true;
            this.btnSendLine.Click += new System.EventHandler(this.btnSendLine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 494);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "伺服器監控範例";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReadEvent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReadCPU;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReadHD;
        private System.Windows.Forms.RichTextBox txtCPU;
        private System.Windows.Forms.RichTextBox txtHD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox txtProg;
        private System.Windows.Forms.Button btnReadProgram;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSendLine;
    }
}

