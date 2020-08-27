// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgOrderListItemSettings_Info
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
  public class MfgOrderListItemSettings_Info : MaterialListItemSettings_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderListItemSettings_Info_TypeName")]
    protected new Info _TypeName;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderListItemSettings_Info_ParentName")]
    protected new Info _ParentName;
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderListItemSettings_Info_QueryName")]
    protected new Info _QueryName;

    public new Info TypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TypeName));
      }
    }

    public new Info ParentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentName));
      }
    }

    public new Info QueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QueryName));
      }
    }
  }
}
