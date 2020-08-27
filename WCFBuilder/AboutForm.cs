// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Builder.AboutForm
// Assembly: WCFBuilder, Version=7.8.7004.31024, Culture=neutral, PublicKeyToken=null
// MVID: CD6CE187-0F31-415C-A6CA-288D0368C79C
// Assembly location: E:\WCFServicesGenerator\WCFBuilder.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Camstar.WCF.Builder
{
  public class AboutForm : Form
  {
    private IContainer components;
    private Label label1;
    private TextBox textBox1;
    private Button button1;
    private TextBox textBox2;
    private Label label2;
    private TextBox textBox3;
    private Label label3;
    private TextBox textBox4;
    private Label label4;
    private TextBox textBox5;
    private Label label5;
    private TextBox textBox6;
    private Label label6;

    public AboutForm()
    {
      this.InitializeComponent();
    }

    private void AboutForm_Load(object sender, EventArgs e)
    {
      AssemblyName name = Assembly.GetExecutingAssembly().GetName();
      foreach (Attribute customAttribute in Assembly.GetExecutingAssembly().GetCustomAttributes(false))
      {
        if (customAttribute is AssemblyTitleAttribute)
          this.textBox1.Text = (customAttribute as AssemblyTitleAttribute).Title;
        if (customAttribute is AssemblyDescriptionAttribute)
          this.textBox2.Text = (customAttribute as AssemblyDescriptionAttribute).Description;
        if (customAttribute is AssemblyCompanyAttribute)
          this.textBox3.Text = (customAttribute as AssemblyCompanyAttribute).Company;
        if (customAttribute is AssemblyProductAttribute)
          this.textBox4.Text = (customAttribute as AssemblyProductAttribute).Product;
        if (customAttribute is AssemblyCopyrightAttribute)
          this.textBox5.Text = (customAttribute as AssemblyCopyrightAttribute).Copyright;
      }
      this.textBox6.Text = name.Version.ToString();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AboutForm));
      this.label1 = new Label();
      this.textBox1 = new TextBox();
      this.button1 = new Button();
      this.textBox2 = new TextBox();
      this.label2 = new Label();
      this.textBox3 = new TextBox();
      this.label3 = new Label();
      this.textBox4 = new TextBox();
      this.label4 = new Label();
      this.textBox5 = new TextBox();
      this.label5 = new Label();
      this.textBox6 = new TextBox();
      this.label6 = new Label();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(27, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Title";
      this.textBox1.BorderStyle = BorderStyle.None;
      this.textBox1.Location = new Point(78, 9);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new Size(246, 13);
      this.textBox1.TabIndex = 1;
      this.textBox1.TabStop = false;
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.Location = new Point(254, 124);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Close";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.textBox2.BorderStyle = BorderStyle.None;
      this.textBox2.Location = new Point(78, 28);
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      this.textBox2.Size = new Size(246, 13);
      this.textBox2.TabIndex = 4;
      this.textBox2.TabStop = false;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(12, 28);
      this.label2.Name = "label2";
      this.label2.Size = new Size(60, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Description";
      this.textBox3.BorderStyle = BorderStyle.None;
      this.textBox3.Location = new Point(78, 47);
      this.textBox3.Name = "textBox3";
      this.textBox3.ReadOnly = true;
      this.textBox3.Size = new Size(246, 13);
      this.textBox3.TabIndex = 6;
      this.textBox3.TabStop = false;
      this.label3.AutoSize = true;
      this.label3.Location = new Point(12, 47);
      this.label3.Name = "label3";
      this.label3.Size = new Size(51, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Company";
      this.textBox4.BorderStyle = BorderStyle.None;
      this.textBox4.Location = new Point(78, 66);
      this.textBox4.Name = "textBox4";
      this.textBox4.ReadOnly = true;
      this.textBox4.Size = new Size(246, 13);
      this.textBox4.TabIndex = 8;
      this.textBox4.TabStop = false;
      this.label4.AutoSize = true;
      this.label4.Location = new Point(12, 66);
      this.label4.Name = "label4";
      this.label4.Size = new Size(44, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Product";
      this.textBox5.BorderStyle = BorderStyle.None;
      this.textBox5.Location = new Point(78, 85);
      this.textBox5.Name = "textBox5";
      this.textBox5.ReadOnly = true;
      this.textBox5.Size = new Size(246, 13);
      this.textBox5.TabIndex = 10;
      this.textBox5.TabStop = false;
      this.label5.AutoSize = true;
      this.label5.Location = new Point(12, 85);
      this.label5.Name = "label5";
      this.label5.Size = new Size(51, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Copyright";
      this.textBox6.BorderStyle = BorderStyle.None;
      this.textBox6.Location = new Point(78, 104);
      this.textBox6.Name = "textBox6";
      this.textBox6.ReadOnly = true;
      this.textBox6.Size = new Size(246, 13);
      this.textBox6.TabIndex = 12;
      this.textBox6.TabStop = false;
      this.label6.AutoSize = true;
      this.label6.Location = new Point(12, 104);
      this.label6.Name = "label6";
      this.label6.Size = new Size(42, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Version";
      this.AcceptButton = (IButtonControl) this.button1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(332, 149);
      this.Controls.Add((Control) this.textBox6);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.textBox5);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.textBox4);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.textBox3);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (AboutForm);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "About WCF Builder";
      this.Load += new EventHandler(this.AboutForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
