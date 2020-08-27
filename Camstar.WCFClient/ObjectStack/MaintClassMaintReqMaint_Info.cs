// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaintClassMaintReqMaint_Info
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
  public class MaintClassMaintReqMaint_Info : AssignedMaintReqMaint_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MaintClassMaintReqMaint_Info_ParentDataObject")]
    protected new Info _ParentDataObject;
    [DataMember(EmitDefaultValue = false, Name = "MaintClassMaintReqMaint_Info_ObjectChanges")]
    protected MaintClassMaintReqChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "MaintClassMaintReqMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MaintClassMaintReqMaint_Info_Resource")]
    protected Info _Resource;

    public new Info ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentDataObject));
      }
    }

    public MaintClassMaintReqChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (MaintClassMaintReqChanges_Info) this.PropertyGet(nameof (ObjectChanges));
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

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }
  }
}
