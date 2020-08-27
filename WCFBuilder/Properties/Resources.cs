// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Builder.Properties.Resources
// Assembly: WCFBuilder, Version=7.8.7004.31024, Culture=neutral, PublicKeyToken=null
// MVID: CD6CE187-0F31-415C-A6CA-288D0368C79C
// Assembly location: E:\WCFServicesGenerator\WCFBuilder.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Camstar.WCF.Builder.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Camstar.WCF.Builder.Properties.Resources.resourceMan == null)
          Camstar.WCF.Builder.Properties.Resources.resourceMan = new ResourceManager("Camstar.WCF.Builder.Properties.Resources", typeof (Camstar.WCF.Builder.Properties.Resources).Assembly);
        return Camstar.WCF.Builder.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return Camstar.WCF.Builder.Properties.Resources.resourceCulture;
      }
      set
      {
        Camstar.WCF.Builder.Properties.Resources.resourceCulture = value;
      }
    }
  }
}
