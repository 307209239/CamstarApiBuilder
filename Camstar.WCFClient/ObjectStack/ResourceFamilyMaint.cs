// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceFamilyMaint
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
  public class ResourceFamilyMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceFamilyMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ResourceFamilyMaint_ObjectChanges")]
    protected ResourceFamilyChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ResourceFamilyMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceFamilyMaint_UseUIPreference")]
    protected Primitive<bool> _UseUIPreference;

    public override bool Equals(object obj)
    {
      return obj is ResourceFamilyMaint && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ResourceFamilyMaint) obj)._ObjectListInquiry) && (object.Equals((object) this._ObjectChanges, (object) ((ResourceFamilyMaint) obj)._ObjectChanges) && object.Equals((object) this._ObjectToChange, (object) ((ResourceFamilyMaint) obj)._ObjectToChange)) && object.Equals((object) this._UseUIPreference, (object) ((ResourceFamilyMaint) obj)._UseUIPreference) && base.Equals(obj);
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

    public ResourceFamilyChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ResourceFamilyChanges) this.PropertyGet(nameof (ObjectChanges));
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

    public Primitive<bool> UseUIPreference
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
