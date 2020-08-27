// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Builder.MainForm
// Assembly: WCFBuilder, Version=7.8.7004.31024, Culture=neutral, PublicKeyToken=null
// MVID: CD6CE187-0F31-415C-A6CA-288D0368C79C
// Assembly location: E:\WCFServicesGenerator\WCFBuilder.exe

using Camstar.WCF.Generator.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Camstar.WCF.Builder
{
  public class MainForm : Form
  {
    private Launcher generatorHelper;
    private ProgressForm progressForm;
    private bool _SilverlightMode;
    private IContainer components;
    private TreeView treeView1;
    private PropertyGrid propertyGrid1;
    private Panel panel1;
    private Splitter splitter1;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem setAllChildAsExposedToolStripMenuItem;
    private ToolStripMenuItem setAllChildAsNonExposedToolStripMenuItem;
    private SaveFileDialog saveFileDialog1;
    private OpenFileDialog openFileDialog1;
    private ToolStripContainer toolStripContainer1;
    private MenuStrip menuStrip1;
    private StatusStrip statusStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem saveAsToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem toolsToolStripMenuItem;
    private ToolStripMenuItem optionsToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem contentsToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem generateToolStripMenuItem;
    private ToolStripMenuItem applyExposedMethodsToChildServicesToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem setFilterToToolStripMenuItem;
    private ToolStripMenuItem removeFilterToolStripMenuItem;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private ToolStrip toolStrip1;
    private ToolStripButton openToolStripButton;
    private ToolStripButton saveToolStripButton;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripButton filterToolStripButton;
    private ImageList imageList1;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripButton toolStripButton2;
    private ToolStripButton toolStripButton1;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripMenuItem includeNonExposedToolStripMenuItem;
    private ToolStripMenuItem excludeNonExposedToolStripMenuItem;
    private ToolStripMenuItem setAllMethodsAsToolStripMenuItem;
    private ToolStripMenuItem exposedToolStripMenuItem;
    private ToolStripMenuItem nonExposedToolStripMenuItem;
    private ToolStripMenuItem baseToolStripMenuItem;
    private ToolStripMenuItem baseAndExposedToolStripMenuItem;
    private ToolStripComboBox LightModeComboBox;

    public MainForm()
    {
      this.InitializeComponent();
      this.LightModeComboBox.SelectedIndex = 0;
    }

    private void LoadServices(List<IService> list)
    {
      try
      {
        foreach (IService service in list)
          this.treeView1.Nodes.Add((TreeNode) new ServiceTreeNode(new ServiceItem(service)));
      }
      catch (WCFGeneratorException ex)
      {
        int num = (int) MessageBox.Show(ex.InnerException.Message, "Generation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      catch (OleDbException ex)
      {
        if (ex.Message.IndexOf("Compiled.mdb") <= 0)
          return;
        int num = (int) MessageBox.Show("Error: Compiled.mdb is missing. Execute DBupdate in Management Studio to generate file.", "Generation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    protected override void OnShown(EventArgs e)
    {
      base.OnShown(e);
      try
      {
        this.generatorHelper = new Launcher();
        this.progressForm = new ProgressForm(this.generatorHelper);
        this.generatorHelper.Init();
        this.RefreshServicesTree();
      }
      catch (WCFGeneratorException ex)
      {
        int num = (int) MessageBox.Show(ex.InnerException.Message, "Generation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      ServiceItem service = (e.Node as ServiceTreeNode).Service;
      this.propertyGrid1.SelectedObject = (object) service;
      this.toolStripButton1.Enabled = service.Service.IsParent;
    }

    private void propertyGrid1_SelectedGridItemChanged(
      object sender,
      SelectedGridItemChangedEventArgs e)
    {
      if (!(this.treeView1.SelectedNode is ServiceTreeNode selectedNode))
        return;
      selectedNode.UpdateNode();
    }

    private void setAllChildAsExposedToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!(this.treeView1.SelectedNode is ServiceTreeNode selectedNode))
        return;
      selectedNode.SetChildState(ExposedServiceStateType.Exposed);
    }

    private void setAllChildAsNonExposedToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!(this.treeView1.SelectedNode is ServiceTreeNode selectedNode))
        return;
      selectedNode.SetChildState(ExposedServiceStateType.NonExposed);
    }

    private void treeView1_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Right || !(this.treeView1.GetNodeAt(e.Location) is ServiceTreeNode nodeAt))
        return;
      this.treeView1.SelectedNode = (TreeNode) nodeAt;
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      try
      {
        this.generatorHelper.SaveServices();
        this.generatorHelper.Settings.Save();
      }
      catch (WCFGeneratorException ex)
      {
        int num = (int) MessageBox.Show(ex.InnerException.Message, "Generation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        return;
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
      this.toolStripStatusLabel1.Text = "Configuration saved";
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.saveFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.Cursor = Cursors.WaitCursor;
      try
      {
        this.generatorHelper.SaveServices();
        this.generatorHelper.Settings.SaveAs(this.saveFileDialog1.FileName);
      }
      catch (WCFGeneratorException ex)
      {
        int num = (int) MessageBox.Show(ex.InnerException.Message, "Generation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        return;
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
      this.toolStripStatusLabel1.Text = "Configuration saved";
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.propertyGrid1.SelectedObject = (object) null;
      this.Cursor = Cursors.WaitCursor;
      this.generatorHelper.Open(this.openFileDialog1.FileName);
      this.RefreshServicesTree();
      this.Cursor = Cursors.Default;
      this.toolStripStatusLabel1.Text = "Configuration opened";
    }

    private void propertyGrid1_Leave(object sender, EventArgs e)
    {
      if (!(this.treeView1.SelectedNode is ServiceTreeNode selectedNode))
        return;
      selectedNode.UpdateNode();
    }

    private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AdvancedSettings settings = new AdvancedSettings(this.generatorHelper.Settings);
      bool isGenerateAll = this.generatorHelper.Settings.IsGenerateAll;
      if (new AdvancedSettingsForm(settings).ShowDialog() != DialogResult.OK)
        return;
      settings.Save();
      if (isGenerateAll == this.generatorHelper.Settings.IsGenerateAll)
        return;
      try
      {
        this.generatorHelper = new Launcher(this.generatorHelper.Settings);
        this.progressForm = new ProgressForm(this.generatorHelper);
        this.generatorHelper.Init();
        this.RefreshServicesTree();
      }
      catch (WCFGeneratorException ex)
      {
        int num = (int) MessageBox.Show(ex.InnerException.Message, "Generation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void generateToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.progressForm.ShowDialog() == DialogResult.OK)
      {
        if (this.generatorHelper.CompleteInformation.IsSuccess)
        {
          int num = (int) MessageBox.Show("Generation complete with:\n" + (object) this.generatorHelper.CompleteInformation);
          this.toolStripStatusLabel1.Text = "Generation succeeded";
        }
        else
        {
          int num = (int) MessageBox.Show("Generation failure with:\n" + (object) this.generatorHelper.CompleteInformation, "Generation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.toolStripStatusLabel1.Text = "Generation failure";
        }
      }
      else
        this.toolStripStatusLabel1.Text = "Generation aborted";
    }

    private void removeFilterToolStripMenuItem_Click(object sender, EventArgs e)
    {
      System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
      configuration.AppSettings.Settings.Remove("Filter");
      configuration.Save();
      this.RefreshServicesTree();
      this.toolStripStatusLabel1.Text = "Filter is removed";
    }

    private void RefreshServicesTree()
    {
      this.Cursor = Cursors.WaitCursor;
      this.treeView1.Nodes.Clear();
      ConfigurationManager.RefreshSection("appSettings");
      string appSetting = ConfigurationManager.AppSettings["Filter"];
      IService service = this._SilverlightMode ? this.generatorHelper.GetRootSilverlightService() : this.generatorHelper.GetRootService();
      if (string.IsNullOrEmpty(appSetting))
      {
        this.removeFilterToolStripMenuItem.Visible = false;
        this.filterToolStripButton.Visible = false;
        this.LoadServices(new List<IService>((IEnumerable<IService>) new IService[1]
        {
          service
        }));
      }
      else
      {
        this.removeFilterToolStripMenuItem.Visible = true;
        this.filterToolStripButton.Visible = true;
        this.filterToolStripButton.Text = "Remove '" + appSetting + "' filter";
        this.LoadServices(service.FindChild(appSetting).Children);
      }
      if (this.treeView1.Nodes.Count != 0)
        this.treeView1.SelectedNode = this.treeView1.Nodes[0];
      this.Cursor = Cursors.Default;
    }

    private void setFilterToToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!(this.treeView1.SelectedNode is ServiceTreeNode selectedNode))
        return;
      System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
      configuration.AppSettings.Settings.Remove("Filter");
      configuration.AppSettings.Settings.Add("Filter", selectedNode.Service.Name);
      configuration.Save();
      this.RefreshServicesTree();
      this.toolStripStatusLabel1.Text = "Filter is set to " + selectedNode.Service.Name;
    }

    private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
    {
      if (this.treeView1.SelectedNode is ServiceTreeNode selectedNode)
      {
        this.contextMenuStrip1.Enabled = true;
        if (selectedNode.Service.Service.IsParent)
        {
          this.setFilterToToolStripMenuItem.Text = "Set filter to '" + selectedNode.Service.Name + "'";
          this.applyExposedMethodsToChildServicesToolStripMenuItem.Enabled = true;
          this.setAllChildAsExposedToolStripMenuItem.Enabled = true;
          this.setAllChildAsNonExposedToolStripMenuItem.Enabled = true;
          this.setFilterToToolStripMenuItem.Enabled = true;
        }
        else
        {
          this.applyExposedMethodsToChildServicesToolStripMenuItem.Enabled = false;
          this.setAllChildAsExposedToolStripMenuItem.Enabled = false;
          this.setAllChildAsNonExposedToolStripMenuItem.Enabled = false;
          this.setFilterToToolStripMenuItem.Enabled = false;
        }
      }
      else
        this.contextMenuStrip1.Enabled = false;
    }

    private void ApplyMethodsToChildren(IService service, List<IService> services, bool isInclude)
    {
      foreach (IService service1 in services)
      {
        foreach (IMethod method1 in service1.Methods)
        {
          foreach (IMethod method2 in service.Methods)
          {
            if (method2.Name == method1.Name && method2.ExposedState != ExposedMethodStateType.NonExposed | isInclude)
              method1.ExposedState = method2.ExposedState;
          }
        }
        if (service1.IsParent)
          this.ApplyMethodsToChildren(service, service1.Children, isInclude);
      }
      this.toolStripStatusLabel1.Text = "Methods are applied";
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new AboutForm().ShowDialog();
      this.toolStripStatusLabel1.Text = "Ready";
    }

    private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Process.Start("http://support.camstar.com");
      this.toolStripStatusLabel1.Text = "Ready";
    }

    private void setAllMethodsAs(IService service, ExposedMethodStateType exposedState)
    {
      foreach (IMethod method in service.Methods)
        method.ExposedState = exposedState;
      this.toolStripStatusLabel1.Text = "Methods are set to " + (object) exposedState;
    }

    private void includeNonExposedToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!(this.treeView1.SelectedNode is ServiceTreeNode selectedNode) || !selectedNode.Service.Service.IsParent)
        return;
      this.ApplyMethodsToChildren(selectedNode.Service.Service, selectedNode.Service.Service.Children, true);
    }

    private void excludeNonExposedToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!(this.treeView1.SelectedNode is ServiceTreeNode selectedNode) || !selectedNode.Service.Service.IsParent)
        return;
      this.ApplyMethodsToChildren(selectedNode.Service.Service, selectedNode.Service.Service.Children, false);
    }

    private void exposedToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!(this.treeView1.SelectedNode is ServiceTreeNode selectedNode))
        return;
      this.setAllMethodsAs(selectedNode.Service.Service, ExposedMethodStateType.Exposed);
    }

    private void nonExposedToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!(this.treeView1.SelectedNode is ServiceTreeNode selectedNode))
        return;
      this.setAllMethodsAs(selectedNode.Service.Service, ExposedMethodStateType.NonExposed);
    }

    private void baseToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!(this.treeView1.SelectedNode is ServiceTreeNode selectedNode))
        return;
      this.setAllMethodsAs(selectedNode.Service.Service, ExposedMethodStateType.Base);
    }

    private void baseAndExposedToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!(this.treeView1.SelectedNode is ServiceTreeNode selectedNode))
        return;
      this.setAllMethodsAs(selectedNode.Service.Service, ExposedMethodStateType.BaseAndExposed);
    }

    private void LightModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this._SilverlightMode != (this.LightModeComboBox.SelectedIndex == 0))
        return;
      this._SilverlightMode = !this._SilverlightMode;
      this.RefreshServicesTree();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MainForm));
      this.treeView1 = new TreeView();
      this.contextMenuStrip1 = new ContextMenuStrip();
      this.setAllChildAsExposedToolStripMenuItem = new ToolStripMenuItem();
      this.setAllChildAsNonExposedToolStripMenuItem = new ToolStripMenuItem();
      this.applyExposedMethodsToChildServicesToolStripMenuItem = new ToolStripMenuItem();
      this.includeNonExposedToolStripMenuItem = new ToolStripMenuItem();
      this.excludeNonExposedToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator7 = new ToolStripSeparator();
      this.setAllMethodsAsToolStripMenuItem = new ToolStripMenuItem();
      this.exposedToolStripMenuItem = new ToolStripMenuItem();
      this.nonExposedToolStripMenuItem = new ToolStripMenuItem();
      this.baseToolStripMenuItem = new ToolStripMenuItem();
      this.baseAndExposedToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator4 = new ToolStripSeparator();
      this.setFilterToToolStripMenuItem = new ToolStripMenuItem();
      this.removeFilterToolStripMenuItem = new ToolStripMenuItem();
      this.editToolStripMenuItem = new ToolStripMenuItem();
      this.imageList1 = new ImageList();
      this.propertyGrid1 = new PropertyGrid();
      this.panel1 = new Panel();
      this.splitter1 = new Splitter();
      this.saveFileDialog1 = new SaveFileDialog();
      this.openFileDialog1 = new OpenFileDialog();
      this.toolStripContainer1 = new ToolStripContainer();
      this.statusStrip1 = new StatusStrip();
      this.toolStripStatusLabel1 = new ToolStripStatusLabel();
      this.menuStrip1 = new MenuStrip();
      this.fileToolStripMenuItem = new ToolStripMenuItem();
      this.openToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator = new ToolStripSeparator();
      this.saveToolStripMenuItem = new ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.generateToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.exitToolStripMenuItem = new ToolStripMenuItem();
      this.toolsToolStripMenuItem = new ToolStripMenuItem();
      this.optionsToolStripMenuItem = new ToolStripMenuItem();
      this.helpToolStripMenuItem = new ToolStripMenuItem();
      this.contentsToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator5 = new ToolStripSeparator();
      this.aboutToolStripMenuItem = new ToolStripMenuItem();
      this.LightModeComboBox = new ToolStripComboBox();
      this.toolStrip1 = new ToolStrip();
      this.openToolStripButton = new ToolStripButton();
      this.saveToolStripButton = new ToolStripButton();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.toolStripButton2 = new ToolStripButton();
      this.toolStripSeparator6 = new ToolStripSeparator();
      this.toolStripButton1 = new ToolStripButton();
      this.filterToolStripButton = new ToolStripButton();
      this.contextMenuStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
      this.toolStripContainer1.ContentPanel.SuspendLayout();
      this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
      this.toolStripContainer1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
      this.treeView1.Dock = DockStyle.Left;
      this.treeView1.HideSelection = false;
      this.treeView1.ImageIndex = 0;
      this.treeView1.ImageList = this.imageList1;
      this.treeView1.Location = new Point(0, 0);
      this.treeView1.Name = "treeView1";
      this.treeView1.SelectedImageIndex = 0;
      this.treeView1.ShowNodeToolTips = true;
      this.treeView1.Size = new Size(336, 439);
      this.treeView1.TabIndex = 0;
      this.treeView1.AfterSelect += new TreeViewEventHandler(this.treeView1_AfterSelect);
      this.treeView1.MouseClick += new MouseEventHandler(this.treeView1_MouseClick);
      this.contextMenuStrip1.Items.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.setAllChildAsExposedToolStripMenuItem,
        (ToolStripItem) this.setAllChildAsNonExposedToolStripMenuItem,
        (ToolStripItem) this.applyExposedMethodsToChildServicesToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator7,
        (ToolStripItem) this.setAllMethodsAsToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.setFilterToToolStripMenuItem,
        (ToolStripItem) this.removeFilterToolStripMenuItem
      });
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new Size(247, 148);
      this.contextMenuStrip1.Opening += new CancelEventHandler(this.contextMenuStrip1_Opening);
      this.setAllChildAsExposedToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("setAllChildAsExposedToolStripMenuItem.Image");
      this.setAllChildAsExposedToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.setAllChildAsExposedToolStripMenuItem.Name = "setAllChildAsExposedToolStripMenuItem";
      this.setAllChildAsExposedToolStripMenuItem.Size = new Size(246, 22);
      this.setAllChildAsExposedToolStripMenuItem.Text = "Set child services as Exposed";
      this.setAllChildAsExposedToolStripMenuItem.Click += new EventHandler(this.setAllChildAsExposedToolStripMenuItem_Click);
      this.setAllChildAsNonExposedToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("setAllChildAsNonExposedToolStripMenuItem.Image");
      this.setAllChildAsNonExposedToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.setAllChildAsNonExposedToolStripMenuItem.Name = "setAllChildAsNonExposedToolStripMenuItem";
      this.setAllChildAsNonExposedToolStripMenuItem.Size = new Size(246, 22);
      this.setAllChildAsNonExposedToolStripMenuItem.Text = "Set child services as NonExposed";
      this.setAllChildAsNonExposedToolStripMenuItem.Click += new EventHandler(this.setAllChildAsNonExposedToolStripMenuItem_Click);
      this.applyExposedMethodsToChildServicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.includeNonExposedToolStripMenuItem,
        (ToolStripItem) this.excludeNonExposedToolStripMenuItem
      });
      this.applyExposedMethodsToChildServicesToolStripMenuItem.Name = "applyExposedMethodsToChildServicesToolStripMenuItem";
      this.applyExposedMethodsToChildServicesToolStripMenuItem.Size = new Size(246, 22);
      this.applyExposedMethodsToChildServicesToolStripMenuItem.Text = "Apply methods to child services";
      this.includeNonExposedToolStripMenuItem.Name = "includeNonExposedToolStripMenuItem";
      this.includeNonExposedToolStripMenuItem.Size = new Size(183, 22);
      this.includeNonExposedToolStripMenuItem.Text = "Include NonExposed";
      this.includeNonExposedToolStripMenuItem.Click += new EventHandler(this.includeNonExposedToolStripMenuItem_Click);
      this.excludeNonExposedToolStripMenuItem.Name = "excludeNonExposedToolStripMenuItem";
      this.excludeNonExposedToolStripMenuItem.Size = new Size(183, 22);
      this.excludeNonExposedToolStripMenuItem.Text = "Exclude NonExposed";
      this.excludeNonExposedToolStripMenuItem.Click += new EventHandler(this.excludeNonExposedToolStripMenuItem_Click);
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new Size(243, 6);
      this.setAllMethodsAsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.exposedToolStripMenuItem,
        (ToolStripItem) this.nonExposedToolStripMenuItem,
        (ToolStripItem) this.baseToolStripMenuItem,
        (ToolStripItem) this.baseAndExposedToolStripMenuItem
      });
      this.setAllMethodsAsToolStripMenuItem.Name = "setAllMethodsAsToolStripMenuItem";
      this.setAllMethodsAsToolStripMenuItem.Size = new Size(246, 22);
      this.setAllMethodsAsToolStripMenuItem.Text = "Set all methods as";
      this.exposedToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("exposedToolStripMenuItem.Image");
      this.exposedToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.exposedToolStripMenuItem.Name = "exposedToolStripMenuItem";
      this.exposedToolStripMenuItem.Size = new Size(169, 22);
      this.exposedToolStripMenuItem.Text = "Exposed";
      this.exposedToolStripMenuItem.Click += new EventHandler(this.exposedToolStripMenuItem_Click);
      this.nonExposedToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("nonExposedToolStripMenuItem.Image");
      this.nonExposedToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.nonExposedToolStripMenuItem.Name = "nonExposedToolStripMenuItem";
      this.nonExposedToolStripMenuItem.Size = new Size(169, 22);
      this.nonExposedToolStripMenuItem.Text = "NonExposed";
      this.nonExposedToolStripMenuItem.Click += new EventHandler(this.nonExposedToolStripMenuItem_Click);
      this.baseToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("baseToolStripMenuItem.Image");
      this.baseToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.baseToolStripMenuItem.Name = "baseToolStripMenuItem";
      this.baseToolStripMenuItem.Size = new Size(169, 22);
      this.baseToolStripMenuItem.Text = "Base";
      this.baseToolStripMenuItem.Click += new EventHandler(this.baseToolStripMenuItem_Click);
      this.baseAndExposedToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("baseAndExposedToolStripMenuItem.Image");
      this.baseAndExposedToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.baseAndExposedToolStripMenuItem.Name = "baseAndExposedToolStripMenuItem";
      this.baseAndExposedToolStripMenuItem.Size = new Size(169, 22);
      this.baseAndExposedToolStripMenuItem.Text = "Base And Exposed";
      this.baseAndExposedToolStripMenuItem.Click += new EventHandler(this.baseAndExposedToolStripMenuItem_Click);
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new Size(243, 6);
      this.setFilterToToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("setFilterToToolStripMenuItem.Image");
      this.setFilterToToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.setFilterToToolStripMenuItem.Name = "setFilterToToolStripMenuItem";
      this.setFilterToToolStripMenuItem.Size = new Size(246, 22);
      this.setFilterToToolStripMenuItem.Text = "Set filter to ...";
      this.setFilterToToolStripMenuItem.Click += new EventHandler(this.setFilterToToolStripMenuItem_Click);
      this.removeFilterToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("removeFilterToolStripMenuItem.Image");
      this.removeFilterToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.removeFilterToolStripMenuItem.Name = "removeFilterToolStripMenuItem";
      this.removeFilterToolStripMenuItem.Size = new Size(246, 22);
      this.removeFilterToolStripMenuItem.Text = "Remove filter";
      this.removeFilterToolStripMenuItem.Visible = false;
      this.removeFilterToolStripMenuItem.Click += new EventHandler(this.removeFilterToolStripMenuItem_Click);
      this.editToolStripMenuItem.DropDown = (ToolStripDropDown) this.contextMenuStrip1;
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new Size(39, 23);
      this.editToolStripMenuItem.Text = "&Edit";
      this.imageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imageList1.ImageStream");
      this.imageList1.TransparentColor = Color.Magenta;
      this.imageList1.Images.SetKeyName(0, "Stop.bmp");
      this.imageList1.Images.SetKeyName(1, "Play.bmp");
      this.imageList1.Images.SetKeyName(2, "Relationships.bmp");
      this.imageList1.Images.SetKeyName(3, "gear_2.bmp");
      this.imageList1.Images.SetKeyName(4, "gear_32.bmp");
      this.propertyGrid1.Dock = DockStyle.Fill;
      this.propertyGrid1.Location = new Point(339, 0);
      this.propertyGrid1.Name = "propertyGrid1";
      this.propertyGrid1.Size = new Size(339, 439);
      this.propertyGrid1.TabIndex = 1;
      this.propertyGrid1.SelectedGridItemChanged += new SelectedGridItemChangedEventHandler(this.propertyGrid1_SelectedGridItemChanged);
      this.propertyGrid1.Leave += new EventHandler(this.propertyGrid1_Leave);
      this.panel1.Controls.Add((Control) this.propertyGrid1);
      this.panel1.Controls.Add((Control) this.splitter1);
      this.panel1.Controls.Add((Control) this.treeView1);
      this.panel1.Dock = DockStyle.Fill;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(678, 439);
      this.panel1.TabIndex = 4;
      this.splitter1.Location = new Point(336, 0);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new Size(3, 439);
      this.splitter1.TabIndex = 2;
      this.splitter1.TabStop = false;
      this.openFileDialog1.DefaultExt = "xml";
      this.toolStripContainer1.BottomToolStripPanel.Controls.Add((Control) this.statusStrip1);
      this.toolStripContainer1.ContentPanel.AutoScroll = true;
      this.toolStripContainer1.ContentPanel.Controls.Add((Control) this.panel1);
      this.toolStripContainer1.ContentPanel.Size = new Size(678, 439);
      this.toolStripContainer1.Dock = DockStyle.Fill;
      this.toolStripContainer1.Location = new Point(0, 0);
      this.toolStripContainer1.Name = "toolStripContainer1";
      this.toolStripContainer1.Size = new Size(678, 513);
      this.toolStripContainer1.TabIndex = 4;
      this.toolStripContainer1.Text = "toolStripContainer1";
      this.toolStripContainer1.TopToolStripPanel.Controls.Add((Control) this.menuStrip1);
      this.toolStripContainer1.TopToolStripPanel.Controls.Add((Control) this.toolStrip1);
      this.statusStrip1.Dock = DockStyle.None;
      this.statusStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.toolStripStatusLabel1
      });
      this.statusStrip1.Location = new Point(0, 0);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new Size(678, 22);
      this.statusStrip1.TabIndex = 0;
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new Size(39, 17);
      this.toolStripStatusLabel1.Text = "Ready";
      this.menuStrip1.Dock = DockStyle.None;
      this.menuStrip1.GripStyle = ToolStripGripStyle.Visible;
      this.menuStrip1.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.fileToolStripMenuItem,
        (ToolStripItem) this.editToolStripMenuItem,
        (ToolStripItem) this.toolsToolStripMenuItem,
        (ToolStripItem) this.helpToolStripMenuItem,
        (ToolStripItem) this.LightModeComboBox
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(678, 27);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.openToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator,
        (ToolStripItem) this.saveToolStripMenuItem,
        (ToolStripItem) this.saveAsToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.generateToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.exitToolStripMenuItem
      });
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new Size(37, 23);
      this.fileToolStripMenuItem.Text = "&File";
      this.openToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("openToolStripMenuItem.Image");
      this.openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = Keys.O | Keys.Control;
      this.openToolStripMenuItem.Size = new Size(225, 22);
      this.openToolStripMenuItem.Text = "&Open Configuration";
      this.openToolStripMenuItem.Click += new EventHandler(this.openToolStripMenuItem_Click);
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new Size(222, 6);
      this.saveToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("saveToolStripMenuItem.Image");
      this.saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = Keys.S | Keys.Control;
      this.saveToolStripMenuItem.Size = new Size(225, 22);
      this.saveToolStripMenuItem.Text = "&Save Configuration";
      this.saveToolStripMenuItem.Click += new EventHandler(this.saveToolStripMenuItem_Click);
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.Size = new Size(225, 22);
      this.saveAsToolStripMenuItem.Text = "Save Configuration &As";
      this.saveAsToolStripMenuItem.Click += new EventHandler(this.saveAsToolStripMenuItem_Click);
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(222, 6);
      this.generateToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("generateToolStripMenuItem.Image");
      this.generateToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
      this.generateToolStripMenuItem.ShortcutKeys = Keys.G | Keys.Control;
      this.generateToolStripMenuItem.Size = new Size(225, 22);
      this.generateToolStripMenuItem.Text = "Generate Assemblies";
      this.generateToolStripMenuItem.Click += new EventHandler(this.generateToolStripMenuItem_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(222, 6);
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new Size(225, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new EventHandler(this.exitToolStripMenuItem_Click);
      this.toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.optionsToolStripMenuItem
      });
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new Size(48, 23);
      this.toolsToolStripMenuItem.Text = "&Tools";
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new Size(116, 22);
      this.optionsToolStripMenuItem.Text = "&Options";
      this.optionsToolStripMenuItem.Click += new EventHandler(this.optionsToolStripMenuItem_Click);
      this.helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.contentsToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.aboutToolStripMenuItem
      });
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new Size(44, 23);
      this.helpToolStripMenuItem.Text = "&Help";
      this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
      this.contentsToolStripMenuItem.Size = new Size(175, 22);
      this.contentsToolStripMenuItem.Text = "&Support Web Site";
      this.contentsToolStripMenuItem.Click += new EventHandler(this.contentsToolStripMenuItem_Click);
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new Size(172, 6);
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new Size(175, 22);
      this.aboutToolStripMenuItem.Text = "&About WCF Builder";
      this.aboutToolStripMenuItem.Click += new EventHandler(this.aboutToolStripMenuItem_Click);
      this.LightModeComboBox.Alignment = ToolStripItemAlignment.Right;
      this.LightModeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      this.LightModeComboBox.Items.AddRange(new object[2]
      {
        (object) "Regular",
        (object) "Silverlight"
      });
      this.LightModeComboBox.Name = "LightModeComboBox";
      this.LightModeComboBox.Size = new Size(121, 23);
      this.LightModeComboBox.SelectedIndexChanged += new EventHandler(this.LightModeComboBox_SelectedIndexChanged);
      this.toolStrip1.Dock = DockStyle.None;
      this.toolStrip1.Items.AddRange(new ToolStripItem[7]
      {
        (ToolStripItem) this.openToolStripButton,
        (ToolStripItem) this.saveToolStripButton,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.toolStripButton2,
        (ToolStripItem) this.toolStripSeparator6,
        (ToolStripItem) this.toolStripButton1,
        (ToolStripItem) this.filterToolStripButton
      });
      this.toolStrip1.Location = new Point(0, 27);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new Size(678, 25);
      this.toolStrip1.Stretch = true;
      this.toolStrip1.TabIndex = 0;
      this.openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.openToolStripButton.Image = (Image) componentResourceManager.GetObject("openToolStripButton.Image");
      this.openToolStripButton.ImageTransparentColor = Color.Magenta;
      this.openToolStripButton.Name = "openToolStripButton";
      this.openToolStripButton.Size = new Size(23, 22);
      this.openToolStripButton.Text = "&Open Configuration";
      this.openToolStripButton.Click += new EventHandler(this.openToolStripMenuItem_Click);
      this.saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.saveToolStripButton.Image = (Image) componentResourceManager.GetObject("saveToolStripButton.Image");
      this.saveToolStripButton.ImageTransparentColor = Color.Magenta;
      this.saveToolStripButton.Name = "saveToolStripButton";
      this.saveToolStripButton.Size = new Size(23, 22);
      this.saveToolStripButton.Text = "&Save Configuration";
      this.saveToolStripButton.Click += new EventHandler(this.saveToolStripMenuItem_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(6, 25);
      this.toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButton2.Image = (Image) componentResourceManager.GetObject("toolStripButton2.Image");
      this.toolStripButton2.ImageTransparentColor = Color.Magenta;
      this.toolStripButton2.Name = "toolStripButton2";
      this.toolStripButton2.Size = new Size(23, 22);
      this.toolStripButton2.Text = "Generate Assemblies";
      this.toolStripButton2.Click += new EventHandler(this.generateToolStripMenuItem_Click);
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new Size(6, 25);
      this.toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = (Image) componentResourceManager.GetObject("toolStripButton1.Image");
      this.toolStripButton1.ImageTransparentColor = Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new Size(23, 22);
      this.toolStripButton1.Text = "Filter";
      this.toolStripButton1.Click += new EventHandler(this.setFilterToToolStripMenuItem_Click);
      this.filterToolStripButton.Alignment = ToolStripItemAlignment.Right;
      this.filterToolStripButton.Image = (Image) componentResourceManager.GetObject("filterToolStripButton.Image");
      this.filterToolStripButton.ImageTransparentColor = Color.Magenta;
      this.filterToolStripButton.Name = "filterToolStripButton";
      this.filterToolStripButton.Size = new Size(106, 22);
      this.filterToolStripButton.Text = "Remove '' filter";
      this.filterToolStripButton.ToolTipText = "Remove filter";
      this.filterToolStripButton.Visible = false;
      this.filterToolStripButton.Click += new EventHandler(this.removeFilterToolStripMenuItem_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(678, 513);
      this.Controls.Add((Control) this.toolStripContainer1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (MainForm);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "WCF Services Generator";
      this.contextMenuStrip1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
      this.toolStripContainer1.ContentPanel.ResumeLayout(false);
      this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
      this.toolStripContainer1.TopToolStripPanel.PerformLayout();
      this.toolStripContainer1.ResumeLayout(false);
      this.toolStripContainer1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
