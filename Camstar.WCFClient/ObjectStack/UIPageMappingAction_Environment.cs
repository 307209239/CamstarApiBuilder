// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageMappingAction_Environment
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
  public class UIPageMappingAction_Environment : UIRedirectAction_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageMappingAction_Environment_MapItem")]
    [Metadata("Generic String", "", false, false, false, "String", 1052803, false, false, false, null)]
    protected Environment _MapItem;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052785, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageMappingAction_Environment_Name")]
    protected new Environment _Name;

    public Environment MapItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (MapItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MapItem));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
