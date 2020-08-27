// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DictionaryMaint
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
  public class DictionaryMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Category")]
    protected Primitive<int> _Category;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_DictionaryLabelsWorkingSet")]
    protected DictionaryLabelChanges[] _DictionaryLabelsWorkingSet;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_ObjectChanges")]
    protected DictionaryChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_LabelIDsWorkingSet")]
    protected Primitive<int>[] _LabelIDsWorkingSet;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_LabelNameFilter")]
    protected Primitive<string> _LabelNameFilter;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_LabelValueFilter")]
    protected Primitive<string> _LabelValueFilter;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;

    public override bool Equals(object obj)
    {
      return obj is DictionaryMaint && object.Equals((object) this._Category, (object) ((DictionaryMaint) obj)._Category) && (object.Equals((object) this._ObjectToChange, (object) ((DictionaryMaint) obj)._ObjectToChange) && this.CompareArrays((Array) this._DictionaryLabelsWorkingSet, (Array) ((DictionaryMaint) obj)._DictionaryLabelsWorkingSet)) && (object.Equals((object) this._ObjectChanges, (object) ((DictionaryMaint) obj)._ObjectChanges) && this.CompareArrays((Array) this._LabelIDsWorkingSet, (Array) ((DictionaryMaint) obj)._LabelIDsWorkingSet) && (object.Equals((object) this._LabelNameFilter, (object) ((DictionaryMaint) obj)._LabelNameFilter) && object.Equals((object) this._LabelValueFilter, (object) ((DictionaryMaint) obj)._LabelValueFilter))) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((DictionaryMaint) obj)._ObjectListInquiry) && base.Equals(obj);
    }

    public Primitive<int> Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Category));
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

    public DictionaryLabelChanges[] DictionaryLabelsWorkingSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DictionaryLabelsWorkingSet), (object) value);
      }
      get
      {
        return (DictionaryLabelChanges[]) this.PropertyGet(nameof (DictionaryLabelsWorkingSet));
      }
    }

    public DictionaryChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (DictionaryChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Primitive<int>[] LabelIDsWorkingSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelIDsWorkingSet), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (LabelIDsWorkingSet));
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
  }
}
