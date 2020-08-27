// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserLabelMaint
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
  public class UserLabelMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "UserLabelMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "UserLabelMaint_LabelNameFilter")]
    protected Primitive<string> _LabelNameFilter;
    [DataMember(EmitDefaultValue = false, Name = "UserLabelMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserLabelMaint_LabelValueFilter")]
    protected Primitive<string> _LabelValueFilter;
    [DataMember(EmitDefaultValue = false, Name = "UserLabelMaint_ObjectChanges")]
    protected UserLabelChanges _ObjectChanges;

    public override bool Equals(object obj)
    {
      return obj is UserLabelMaint && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((UserLabelMaint) obj)._ObjectListInquiry) && (object.Equals((object) this._LabelNameFilter, (object) ((UserLabelMaint) obj)._LabelNameFilter) && object.Equals((object) this._ObjectToChange, (object) ((UserLabelMaint) obj)._ObjectToChange)) && (object.Equals((object) this._LabelValueFilter, (object) ((UserLabelMaint) obj)._LabelValueFilter) && object.Equals((object) this._ObjectChanges, (object) ((UserLabelMaint) obj)._ObjectChanges)) && base.Equals(obj);
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

    public Primitive<string> LabelNameFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelNameFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelNameFilter));
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

    public Primitive<string> LabelValueFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelValueFilter), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelValueFilter));
      }
    }

    public UserLabelChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (UserLabelChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
