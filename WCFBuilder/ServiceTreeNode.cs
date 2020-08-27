// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Builder.ServiceTreeNode
// Assembly: WCFBuilder, Version=7.8.7004.31024, Culture=neutral, PublicKeyToken=null
// MVID: CD6CE187-0F31-415C-A6CA-288D0368C79C
// Assembly location: E:\WCFServicesGenerator\WCFBuilder.exe

using Camstar.WCF.Generator.Helper;
using System.Windows.Forms;

namespace Camstar.WCF.Builder
{
  public class ServiceTreeNode : TreeNode
  {
    private ServiceItem service;

    public ServiceItem Service
    {
      get
      {
        return this.service;
      }
    }

    public ServiceTreeNode(ServiceItem service)
    {
      this.service = service;
      this.UpdateNode();
      foreach (IService child in service.Service.Children)
        this.Nodes.Add((TreeNode) new ServiceTreeNode(new ServiceItem(child)));
    }

    public void UpdateNode()
    {
      switch (this.service.ExposedState)
      {
        case ExposedServiceStateType.Exposed:
          this.ImageIndex = this.SelectedImageIndex = 1;
          break;
        case ExposedServiceStateType.Base:
          this.ImageIndex = this.SelectedImageIndex = 2;
          break;
        case ExposedServiceStateType.BaseAndExposed:
          this.ImageIndex = this.SelectedImageIndex = 3;
          break;
        default:
          this.ImageIndex = this.SelectedImageIndex = 0;
          break;
      }
      this.Text = this.service.Name + " (" + (object) this.service.ExposedState + ")";
      this.ToolTipText = this.service.Description;
    }

    public void SetChildState(ExposedServiceStateType exposedStateType)
    {
      foreach (TreeNode node in this.Nodes)
      {
        ServiceTreeNode serviceTreeNode = node as ServiceTreeNode;
        serviceTreeNode.Service.ExposedState = exposedStateType;
        serviceTreeNode.UpdateNode();
        serviceTreeNode.SetChildState(exposedStateType);
      }
    }
  }
}
