// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerLevelMaint_Info
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
  public class ContainerLevelMaint_Info : NamedDataObjectMaint_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelMaint_Info_ObjectChanges")]
    protected ContainerLevelChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelMaint_Info_WIPExpressionBaseTypeId")]
    protected Info _WIPExpressionBaseTypeId;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelMaint_Info_ObjectListInquiry")]
    protected new Info _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;

    public ContainerLevelChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ContainerLevelChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Info WIPExpressionBaseTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPExpressionBaseTypeId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPExpressionBaseTypeId));
      }
    }

    public new Info ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
