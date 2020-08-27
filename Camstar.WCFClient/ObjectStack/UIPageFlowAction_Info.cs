// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageFlowAction_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class UIPageFlowAction_Info : UIRedirectAction_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowAction_Info_UIPageFlow")]
    protected Info _UIPageFlow;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowAction_Info_Name")]
    protected new Info _Name;

    public Info UIPageFlow
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPageFlow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UIPageFlow));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
