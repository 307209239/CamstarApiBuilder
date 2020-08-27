// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaintClassMaintReqMaint
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
  public class MaintClassMaintReqMaint : AssignedMaintReqMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "MaintClassMaintReqMaint_ParentDataObject")]
    protected NamedObjectRef _ParentDataObject;
    [DataMember(EmitDefaultValue = false, Name = "MaintClassMaintReqMaint_ObjectChanges")]
    protected MaintClassMaintReqChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "MaintClassMaintReqMaint_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MaintClassMaintReqMaint_Resource")]
    protected NamedObjectRef _Resource;

    public override bool Equals(object obj)
    {
      return obj is MaintClassMaintReqMaint && object.Equals((object) this._ParentDataObject, (object) ((MaintClassMaintReqMaint) obj)._ParentDataObject) && (object.Equals((object) this._ObjectChanges, (object) ((MaintClassMaintReqMaint) obj)._ObjectChanges) && object.Equals((object) this._ObjectToChange, (object) ((MaintClassMaintReqMaint) obj)._ObjectToChange)) && object.Equals((object) this._Resource, (object) ((MaintClassMaintReqMaint) obj)._Resource) && base.Equals(obj);
    }

    public NamedObjectRef ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ParentDataObject));
      }
    }

    public MaintClassMaintReqChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (MaintClassMaintReqChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }
  }
}
