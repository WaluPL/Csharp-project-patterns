
namespace MatrixOP
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.scVertical = new System.Windows.Forms.SplitContainer();
            this.scLeft = new System.Windows.Forms.SplitContainer();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMatA = new System.Windows.Forms.TextBox();
            this.scRight = new System.Windows.Forms.SplitContainer();
            this.txtMatB = new System.Windows.Forms.TextBox();
            this.txtMatC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.scVertical)).BeginInit();
            this.scVertical.Panel1.SuspendLayout();
            this.scVertical.Panel2.SuspendLayout();
            this.scVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLeft)).BeginInit();
            this.scLeft.Panel1.SuspendLayout();
            this.scLeft.Panel2.SuspendLayout();
            this.scLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).BeginInit();
            this.scRight.Panel1.SuspendLayout();
            this.scRight.Panel2.SuspendLayout();
            this.scRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // scVertical
            // 
            this.scVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scVertical.Location = new System.Drawing.Point(0, 0);
            this.scVertical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scVertical.Name = "scVertical";
            // 
            // scVertical.Panel1
            // 
            this.scVertical.Panel1.Controls.Add(this.scLeft);
            // 
            // scVertical.Panel2
            // 
            this.scVertical.Panel2.Controls.Add(this.scRight);
            this.scVertical.Size = new System.Drawing.Size(1067, 554);
            this.scVertical.SplitterDistance = 533;
            this.scVertical.SplitterWidth = 13;
            this.scVertical.TabIndex = 0;
            // 
            // scLeft
            // 
            this.scLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scLeft.Location = new System.Drawing.Point(0, 0);
            this.scLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scLeft.Name = "scLeft";
            this.scLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scLeft.Panel1
            // 
            this.scLeft.Panel1.Controls.Add(this.btnSolve);
            this.scLeft.Panel1.Controls.Add(this.btnSub);
            this.scLeft.Panel1.Controls.Add(this.btnMul);
            this.scLeft.Panel1.Controls.Add(this.btnAdd);
            // 
            // scLeft.Panel2
            // 
            this.scLeft.Panel2.Controls.Add(this.txtMatA);
            this.scLeft.Size = new System.Drawing.Size(533, 554);
            this.scLeft.SplitterDistance = 277;
            this.scLeft.SplitterWidth = 12;
            this.scLeft.TabIndex = 1;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(124, 50);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(100, 28);
            this.btnSolve.TabIndex = 3;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(124, 15);
            this.btnSub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(100, 28);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "Sub";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(16, 50);
            this.btnMul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(100, 28);
            this.btnMul.TabIndex = 1;
            this.btnMul.Text = "Mul";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMatA
            // 
            this.txtMatA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMatA.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatA.Location = new System.Drawing.Point(0, 0);
            this.txtMatA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatA.Multiline = true;
            this.txtMatA.Name = "txtMatA";
            this.txtMatA.Size = new System.Drawing.Size(533, 265);
            this.txtMatA.TabIndex = 0;
            // 
            // scRight
            // 
            this.scRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRight.Location = new System.Drawing.Point(0, 0);
            this.scRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scRight.Name = "scRight";
            this.scRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scRight.Panel1
            // 
            this.scRight.Panel1.Controls.Add(this.txtMatB);
            // 
            // scRight.Panel2
            // 
            this.scRight.Panel2.Controls.Add(this.txtMatC);
            this.scRight.Size = new System.Drawing.Size(521, 554);
            this.scRight.SplitterDistance = 277;
            this.scRight.SplitterWidth = 12;
            this.scRight.TabIndex = 2;
            // 
            // txtMatB
            // 
            this.txtMatB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMatB.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatB.Location = new System.Drawing.Point(0, 0);
            this.txtMatB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatB.Multiline = true;
            this.txtMatB.Name = "txtMatB";
            this.txtMatB.Size = new System.Drawing.Size(521, 277);
            this.txtMatB.TabIndex = 1;
            // 
            // txtMatC
            // 
            this.txtMatC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMatC.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatC.Location = new System.Drawing.Point(0, 0);
            this.txtMatC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatC.Multiline = true;
            this.txtMatC.Name = "txtMatC";
            this.txtMatC.Size = new System.Drawing.Size(521, 265);
            this.txtMatC.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.scVertical);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.scVertical.Panel1.ResumeLayout(false);
            this.scVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scVertical)).EndInit();
            this.scVertical.ResumeLayout(false);
            this.scLeft.Panel1.ResumeLayout(false);
            this.scLeft.Panel2.ResumeLayout(false);
            this.scLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLeft)).EndInit();
            this.scLeft.ResumeLayout(false);
            this.scRight.Panel1.ResumeLayout(false);
            this.scRight.Panel1.PerformLayout();
            this.scRight.Panel2.ResumeLayout(false);
            this.scRight.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).EndInit();
            this.scRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scVertical;
        private System.Windows.Forms.SplitContainer scLeft;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMatA;
        private System.Windows.Forms.SplitContainer scRight;
        private System.Windows.Forms.TextBox txtMatB;
        private System.Windows.Forms.TextBox txtMatC;
    }
}

