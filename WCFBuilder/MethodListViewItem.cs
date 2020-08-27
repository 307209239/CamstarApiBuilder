// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Builder.MethodListViewItem
// Assembly: WCFBuilder, Version=7.8.7004.31024, Culture=neutral, PublicKeyToken=null
// MVID: CD6CE187-0F31-415C-A6CA-288D0368C79C
// Assembly location: E:\WCFServicesGenerator\WCFBuilder.exe

using Camstar.WCF.Generator.Helper;
using System.Drawing;
using System.Windows.Forms;

namespace Camstar.WCF.Builder
{
  internal class MethodListViewItem : ListViewItem
  {
    private MethodItem method;

    public MethodItem Method
    {
      get
      {
        return this.method;
      }
    }

    public MethodListViewItem(MethodItem method)
    {
      this.Text = method.Name;
      this.SubItems.Add(method.ExposedState.ToString());
      this.method = method;
      this.Update();
    }

    public void Update()
    {
      switch (this.method.ExposedState)
      {
        case ExposedMethodStateType.Exposed:
          this.ImageIndex = 1;
          break;
        case ExposedMethodStateType.Base:
          this.ImageIndex = 2;
          break;
        case ExposedMethodStateType.BaseAndExposed:
          this.ImageIndex = 3;
          break;
        default:
          this.ImageIndex = 0;
          break;
      }
      if (this.method.Method.IsInherited)
        this.ForeColor = Color.Gray;
      else
        this.ForeColor = Color.Black;
      this.SubItems[1].Text = this.method.ExposedState.ToString();
    }
  }
}
