// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgOrderListItemSettings_Environment
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
  public class MfgOrderListItemSettings_Environment : MaterialListItemSettings_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderListItemSettings_Environment_TypeName")]
    [Metadata("Generic String", "", false, false, true, "String", 16779177, false, false, false, "MfgOrderMaterialListItem")]
    protected new Environment _TypeName;
    [Metadata("Generic String", "", false, false, true, "String", 15663203, false, false, false, "MfgOrder")]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderListItemSettings_Environment_ParentName")]
    protected new Environment _ParentName;
    [Metadata("Generic String", "", false, false, true, "String", 1050871, false, false, false, "GetMfgOrderMaterialListItems")]
    [DataMember(EmitDefaultValue = false, Name = "MfgOrderListItemSettings_Environment_QueryName")]
    protected new Environment _QueryName;

    public new Environment TypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TypeName));
      }
    }

    public new Environment ParentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentName));
      }
    }

    public new Environment QueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QueryName));
      }
    }
  }
}
