// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Builder.MethodsEditForm
// Assembly: WCFBuilder, Version=7.8.7004.31024, Culture=neutral, PublicKeyToken=null
// MVID: CD6CE187-0F31-415C-A6CA-288D0368C79C
// Assembly location: E:\WCFServicesGenerator\WCFBuilder.exe

using Camstar.WCF.Generator.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Camstar.WCF.Builder
{
  public class MethodsEditForm : Form
  {
    private List<IMethod> mMethods;
    private IContainer components;
    private Panel panel1;
    private ListView listView1;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private SplitContainer splitContainer1;
    private PropertyGrid propertyGrid1;
    private Button button1;
    private ImageList imageList1;

    public List<IMethod> Methods
    {
      get
      {
        return this.mMethods;
      }
      set
      {
        this.mMethods = value;
      }
    }

    public MethodsEditForm()
    {
      this.InitializeComponent();
    }

    private void MethodsEditForm_Load(object sender, EventArgs e)
    {
      foreach (IMethod method in this.Methods)
        this.listView1.Items.Add((ListViewItem) new MethodListViewItem(new MethodItem(method)));
      this.listView1.Items[0].Selected = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void propertyGrid1_SelectedGridItemChanged(
      object sender,
      SelectedGridItemChangedEventArgs e)
    {
      this.propertyGrid1_Leave(sender, (EventArgs) e);
    }

    private void propertyGrid1_Leave(object sender, EventArgs e)
    {
      if (this.listView1.SelectedItems.Count == 1)
      {
        (this.listView1.SelectedItems[0] as MethodListViewItem).Update();
      }
      else
      {
        if (this.listView1.SelectedItems.Count <= 1)
          return;
        foreach (MethodListViewItem selectedItem in this.listView1.SelectedItems)
          selectedItem.Update();
      }
    }

    private void listView1_ItemSelectionChanged(
      object sender,
      ListViewItemSelectionChangedEventArgs e)
    {
      if (this.listView1.SelectedItems.Count == 1)
        this.propertyGrid1.SelectedObject = (object) (this.listView1.SelectedItems[0] as MethodListViewItem).Method;
      else if (this.listView1.SelectedItems.Count > 1)
      {
        List<object> objectList = new List<object>();
        foreach (MethodListViewItem selectedItem in this.listView1.SelectedItems)
          objectList.Add((object) selectedItem.Method);
        this.propertyGrid1.SelectedObjects = objectList.ToArray();
      }
      else
        this.propertyGrid1.SelectedObject = (object) null;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MethodsEditForm));
      this.panel1 = new Panel();
      this.button1 = new Button();
      this.listView1 = new ListView();
      this.columnHeader1 = new ColumnHeader();
      this.columnHeader2 = new ColumnHeader();
      this.imageList1 = new ImageList(this.components);
      this.splitContainer1 = new SplitContainer();
      this.propertyGrid1 = new PropertyGrid();
      this.panel1.SuspendLayout();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Dock = DockStyle.Bottom;
      this.panel1.Location = new Point(0, 394);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(594, 29);
      this.panel1.TabIndex = 0;
      this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.button1.Location = new Point(516, 3);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Close";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.listView1.Columns.AddRange(new ColumnHeader[2]
      {
        this.columnHeader1,
        this.columnHeader2
      });
      this.listView1.Dock = DockStyle.Fill;
      this.listView1.FullRowSelect = true;
      this.listView1.GridLines = true;
      this.listView1.HideSelection = false;
      this.listView1.Location = new Point(0, 0);
      this.listView1.Name = "listView1";
      this.listView1.Size = new Size(309, 394);
      this.listView1.SmallImageList = this.imageList1;
      this.listView1.TabIndex = 1;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.View = View.Details;
      this.listView1.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
      this.columnHeader1.Text = "Name";
      this.columnHeader1.Width = 180;
      this.columnHeader2.Text = "State";
      this.columnHeader2.Width = 100;
      this.imageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imageList1.ImageStream");
      this.imageList1.TransparentColor = Color.Magenta;
      this.imageList1.Images.SetKeyName(0, "Stop.bmp");
      this.imageList1.Images.SetKeyName(1, "Play.bmp");
      this.imageList1.Images.SetKeyName(2, "Relationships.bmp");
      this.imageList1.Images.SetKeyName(3, "gear_2.bmp");
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.Location = new Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Panel1.Controls.Add((Control) this.listView1);
      this.splitContainer1.Panel2.Controls.Add((Control) this.propertyGrid1);
      this.splitContainer1.Size = new Size(594, 394);
      this.splitContainer1.SplitterDistance = 309;
      this.splitContainer1.TabIndex = 2;
      this.propertyGrid1.Dock = DockStyle.Fill;
      this.propertyGrid1.Location = new Point(0, 0);
      this.propertyGrid1.Name = "propertyGrid1";
      this.propertyGrid1.Size = new Size(281, 394);
      this.propertyGrid1.TabIndex = 0;
      this.propertyGrid1.SelectedGridItemChanged += new SelectedGridItemChangedEventHandler(this.propertyGrid1_SelectedGridItemChanged);
      this.propertyGrid1.Leave += new EventHandler(this.propertyGrid1_Leave);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(594, 423);
      this.Controls.Add((Control) this.splitContainer1);
      this.Controls.Add((Control) this.panel1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (MethodsEditForm);
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Methods";
      this.Load += new EventHandler(this.MethodsEditForm_Load);
      this.panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
