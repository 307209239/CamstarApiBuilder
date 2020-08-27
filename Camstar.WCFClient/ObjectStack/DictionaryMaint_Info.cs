// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DictionaryMaint_Info
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
  public class DictionaryMaint_Info : NamedDataObjectMaint_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Info_Category")]
    protected Info _Category;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Info_DictionaryLabelsWorkingSet")]
    protected DictionaryLabelChanges_Info _DictionaryLabelsWorkingSet;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Info_ObjectChanges")]
    protected DictionaryChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Info_LabelIDsWorkingSet")]
    protected Info _LabelIDsWorkingSet;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Info_LabelNameFilter")]
    protected Info _LabelNameFilter;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Info_LabelValueFilter")]
    protected Info _LabelValueFilter;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Info_ObjectListInquiry")]
    protected new Info _ObjectListInquiry;

    public Info Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Category));
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

    public DictionaryLabelChanges_Info DictionaryLabelsWorkingSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DictionaryLabelsWorkingSet), (object) value);
      }
      get
      {
        return (DictionaryLabelChanges_Info) this.PropertyGet(nameof (DictionaryLabelsWorkingSet));
      }
    }

    public DictionaryChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (DictionaryChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Info LabelIDsWorkingSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelIDsWorkingSet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelIDsWorkingSet));
      }
    }

    public Info LabelNameFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelNameFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelNameFilter));
      }
    }

    public Info LabelValueFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelValueFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelValueFilter));
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
  }
}
