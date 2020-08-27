// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Builder.ProgressForm
// Assembly: WCFBuilder, Version=7.8.7004.31024, Culture=neutral, PublicKeyToken=null
// MVID: CD6CE187-0F31-415C-A6CA-288D0368C79C
// Assembly location: E:\WCFServicesGenerator\WCFBuilder.exe

using Camstar.WCF.Generator.Helper;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Camstar.WCF.Builder
{
  public class ProgressForm : Form
  {
    private Launcher generatorHelper;
    private bool isCompleted;
    private IContainer components;
    private ProgressBar progressBar1;
    private Button button2;
    private TextBox textBox1;
    private TextBox textBox2;
    private ProgressBar progressBar2;
    private TextBox textBox3;
    private TextBox textBox4;
    private TextBox textBox5;

    public ProgressForm(Launcher generatorHelper)
    {
      this.InitializeComponent();
      this.generatorHelper = generatorHelper;
      generatorHelper.StateChanged += new StateChangeEventHandler(this.OnStateChanged);
      generatorHelper.GeneratingCompleted += new GeneratingCompletedEventHandler(this.OnGeneratingCompleted);
    }

    private void OnGeneratingCompleted(object sender, GeneratingCompletedEventArgs e)
    {
      this.isCompleted = true;
      this.Close();
    }

    private void OnStateChanged(object sender, StateChangeEventArgs e)
    {
      this.textBox1.Text = "Process: " + e.ProcessName;
      this.textBox2.Text = "Item: " + e.ProcessItemName;
      this.textBox3.Text = e.TotalPercent.ToString() + "%";
      this.textBox4.Text = e.Percent.ToString() + "%";
      this.progressBar1.Value = e.TotalPercent;
      this.progressBar2.Value = e.Percent;
      this.textBox5.Text = "Remaining: " + (object) e.TimeRemaining;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void TestForm_Load(object sender, EventArgs e)
    {
      this.isCompleted = false;
      this.textBox1.Text = "Process";
      this.textBox2.Text = "Item";
      this.textBox3.Text = string.Empty;
      this.textBox4.Text = string.Empty;
      this.progressBar1.Value = 0;
      this.progressBar2.Value = 0;
      this.textBox5.Text = "Remaining: about 4 min.";
      this.generatorHelper.BeginGenerate();
    }

    private void ProgressForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      if (this.generatorHelper.GeneratorState == GeneratorStateType.InProgress)
      {
        if (MessageBox.Show("Are you sure?", "Generating", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          this.generatorHelper.StopGenerate();
          this.DialogResult = DialogResult.Cancel;
        }
        else
          e.Cancel = true;
      }
      if (!this.isCompleted)
        return;
      e.Cancel = false;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ProgressForm));
      this.progressBar1 = new ProgressBar();
      this.button2 = new Button();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.progressBar2 = new ProgressBar();
      this.textBox3 = new TextBox();
      this.textBox4 = new TextBox();
      this.textBox5 = new TextBox();
      this.SuspendLayout();
      this.progressBar1.Location = new Point(1, 26);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new Size(299, 17);
      this.progressBar1.Step = 1;
      this.progressBar1.TabIndex = 0;
      this.button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button2.Location = new Point(265, 87);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "Cancel";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.textBox1.BackColor = SystemColors.Control;
      this.textBox1.BorderStyle = BorderStyle.None;
      this.textBox1.Location = new Point(1, 7);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new Size(220, 13);
      this.textBox1.TabIndex = 3;
      this.textBox1.Text = "Process:";
      this.textBox2.BackColor = SystemColors.Control;
      this.textBox2.BorderStyle = BorderStyle.None;
      this.textBox2.Location = new Point(1, 49);
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      this.textBox2.Size = new Size(299, 13);
      this.textBox2.TabIndex = 6;
      this.textBox2.Text = "Item:";
      this.progressBar2.Location = new Point(1, 68);
      this.progressBar2.Name = "progressBar2";
      this.progressBar2.Size = new Size(299, 17);
      this.progressBar2.Step = 1;
      this.progressBar2.TabIndex = 5;
      this.textBox3.BackColor = SystemColors.Control;
      this.textBox3.BorderStyle = BorderStyle.None;
      this.textBox3.Location = new Point(306, 26);
      this.textBox3.Name = "textBox3";
      this.textBox3.ReadOnly = true;
      this.textBox3.Size = new Size(34, 13);
      this.textBox3.TabIndex = 7;
      this.textBox4.BackColor = SystemColors.Control;
      this.textBox4.BorderStyle = BorderStyle.None;
      this.textBox4.Location = new Point(306, 68);
      this.textBox4.Name = "textBox4";
      this.textBox4.ReadOnly = true;
      this.textBox4.Size = new Size(34, 13);
      this.textBox4.TabIndex = 8;
      this.textBox5.BackColor = SystemColors.Control;
      this.textBox5.BorderStyle = BorderStyle.None;
      this.textBox5.Location = new Point(227, 7);
      this.textBox5.Name = "textBox5";
      this.textBox5.ReadOnly = true;
      this.textBox5.Size = new Size(107, 13);
      this.textBox5.TabIndex = 9;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(341, 113);
      this.Controls.Add((Control) this.textBox5);
      this.Controls.Add((Control) this.textBox4);
      this.Controls.Add((Control) this.textBox3);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.progressBar2);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.progressBar1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (ProgressForm);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Generating...";
      this.FormClosing += new FormClosingEventHandler(this.ProgressForm_FormClosing);
      this.Load += new EventHandler(this.TestForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
