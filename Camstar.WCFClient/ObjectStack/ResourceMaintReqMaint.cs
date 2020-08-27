// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceMaintReqMaint
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
  public class ResourceMaintReqMaint : AssignedMaintReqMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceMaintReqMaint_ResourceGroup")]
    protected NamedObjectRef _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceMaintReqMaint_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceMaintReqMaint_ObjectChanges")]
    protected ResourceMaintReqChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ResourceMaintReqMaint_ParentDataObject")]
    protected NamedObjectRef _ParentDataObject;

    public override bool Equals(object obj)
    {
      return obj is ResourceMaintReqMaint && object.Equals((object) this._ResourceGroup, (object) ((ResourceMaintReqMaint) obj)._ResourceGroup) && (object.Equals((object) this._ObjectToChange, (object) ((ResourceMaintReqMaint) obj)._ObjectToChange) && object.Equals((object) this._ObjectChanges, (object) ((ResourceMaintReqMaint) obj)._ObjectChanges)) && object.Equals((object) this._ParentDataObject, (object) ((ResourceMaintReqMaint) obj)._ParentDataObject) && base.Equals(obj);
    }

    public NamedObjectRef ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceGroup));
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

    public ResourceMaintReqChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ResourceMaintReqChanges) this.PropertyGet(nameof (ObjectChanges));
      }
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
  }
}
