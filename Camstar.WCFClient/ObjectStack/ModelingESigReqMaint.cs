// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingESigReqMaint
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
  public class ModelingESigReqMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqMaint_ObjectChanges")]
    protected ModelingESigReqChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigReqMaint_ServiceCDOType")]
    protected Primitive<int> _ServiceCDOType;

    public override bool Equals(object obj)
    {
      return obj is ModelingESigReqMaint && object.Equals((object) this._ObjectChanges, (object) ((ModelingESigReqMaint) obj)._ObjectChanges) && (object.Equals((object) this._ObjectToChange, (object) ((ModelingESigReqMaint) obj)._ObjectToChange) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ModelingESigReqMaint) obj)._ObjectListInquiry)) && object.Equals((object) this._ServiceCDOType, (object) ((ModelingESigReqMaint) obj)._ServiceCDOType) && base.Equals(obj);
    }

    public ModelingESigReqChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ModelingESigReqChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public Primitive<int> ServiceCDOType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceCDOType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ServiceCDOType));
      }
    }
  }
}
