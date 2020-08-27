// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Builder.MethodsEditor
// Assembly: WCFBuilder, Version=7.8.7004.31024, Culture=neutral, PublicKeyToken=null
// MVID: CD6CE187-0F31-415C-A6CA-288D0368C79C
// Assembly location: E:\WCFServicesGenerator\WCFBuilder.exe

using Camstar.WCF.Generator.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace Camstar.WCF.Builder
{
  internal class MethodsEditor : UITypeEditor
  {
    public override object EditValue(
      ITypeDescriptorContext context,
      IServiceProvider provider,
      object value)
    {
      MethodsEditForm methodsEditForm = new MethodsEditForm();
      methodsEditForm.Methods = value as List<IMethod>;
      methodsEditForm.Text = (context.Instance as ServiceItem).Name + " methods";
      int num = (int) methodsEditForm.ShowDialog();
      return value;
    }

    public override UITypeEditorEditStyle GetEditStyle(
      ITypeDescriptorContext context)
    {
      return UITypeEditorEditStyle.Modal;
    }
  }
}
