// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Builder.AdvancedSettingsForm
// Assembly: WCFBuilder, Version=7.8.7004.31024, Culture=neutral, PublicKeyToken=null
// MVID: CD6CE187-0F31-415C-A6CA-288D0368C79C
// Assembly location: E:\WCFServicesGenerator\WCFBuilder.exe

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Camstar.WCF.Builder
{
  public class AdvancedSettingsForm : Form
  {
    private IContainer components;
    private Panel panel1;
    private Button button2;
    private PropertyGrid propertyGrid1;
    private Button button1;

    public AdvancedSettingsForm(AdvancedSettings settings)
    {
      this.InitializeComponent();
      this.propertyGrid1.SelectedObject = (object) settings;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AdvancedSettingsForm));
      this.panel1 = new Panel();
      this.button1 = new Button();
      this.button2 = new Button();
      this.propertyGrid1 = new PropertyGrid();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Controls.Add((Control) this.button2);
      this.panel1.Dock = DockStyle.Bottom;
      this.panel1.Location = new Point(0, 326);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(410, 30);
      this.panel1.TabIndex = 0;
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.DialogResult = DialogResult.Cancel;
      this.button1.Location = new Point(332, 3);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Cancel";
      this.button1.UseVisualStyleBackColor = true;
      this.button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button2.DialogResult = DialogResult.OK;
      this.button2.Location = new Point(251, 3);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Ok";
      this.button2.UseVisualStyleBackColor = true;
      this.propertyGrid1.Dock = DockStyle.Fill;
      this.propertyGrid1.Location = new Point(0, 0);
      this.propertyGrid1.Name = "propertyGrid1";
      this.propertyGrid1.Size = new Size(410, 326);
      this.propertyGrid1.TabIndex = 1;
      this.AcceptButton = (IButtonControl) this.button2;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.button1;
      this.ClientSize = new Size(410, 356);
      this.Controls.Add((Control) this.propertyGrid1);
      this.Controls.Add((Control) this.panel1);
      
      this.Name = "AdvancedSettings";
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Advanced Settings";
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
