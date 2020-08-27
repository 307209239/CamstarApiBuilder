// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CarrierFamilyMaint
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
  public class CarrierFamilyMaint : ResourceFamilyMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "CarrierFamilyMaint_ObjectChanges")]
    protected CarrierFamilyChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "CarrierFamilyMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "CarrierFamilyMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CarrierFamilyMaint_UseUIPreference")]
    protected new Primitive<bool> _UseUIPreference;

    public override bool Equals(object obj)
    {
      return obj is CarrierFamilyMaint && object.Equals((object) this._ObjectChanges, (object) ((CarrierFamilyMaint) obj)._ObjectChanges) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((CarrierFamilyMaint) obj)._ObjectListInquiry) && object.Equals((object) this._ObjectToChange, (object) ((CarrierFamilyMaint) obj)._ObjectToChange)) && object.Equals((object) this._UseUIPreference, (object) ((CarrierFamilyMaint) obj)._UseUIPreference) && base.Equals(obj);
    }

    public CarrierFamilyChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (CarrierFamilyChanges) this.PropertyGet(nameof (ObjectChanges));
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

    public new Primitive<bool> UseUIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseUIPreference), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseUIPreference));
      }
    }
  }
}
