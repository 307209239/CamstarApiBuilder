// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DictionaryMaint_Environment
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
  public class DictionaryMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Environment_Category")]
    [Metadata("LabelCategoryId", "", false, false, false, "Integer", 1049991, false, false, true, "0")]
    protected Environment _Category;
    [Metadata("Used to store dictionary information including international language and terminology.\r\n", "Dictionary", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Change CDO for DictionaryLabel.  The field Name, CategoryID, DefaultValue is used for display purpose.  The Dictionary Label does not store these information.  However, it is convenient for the user to look at these information when typing in the corresponding dictionary values.\r\nWhen doing normal maintenance, LabelID is enough to locate a label.  So if LabelID is presented, it will be used, otherwise, Name and CategoryID will be used to find a label (used for dictionary distribution).  So, either LabelID is required or Name and CategoryID pair is required.", "DictionaryLabelChanges", false, false, false, "DictionaryLabelChanges", 1049973, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Environment_DictionaryLabelsWorkingSet")]
    protected DictionaryLabelChanges_Environment _DictionaryLabelsWorkingSet;
    [Metadata("Used to store dictionary information including international language and terminology.\r\n", "DictionaryChanges", false, false, false, "DictionaryChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Environment_ObjectChanges")]
    protected DictionaryChanges_Environment _ObjectChanges;
    [Metadata("LabelId", "", false, false, false, "Integer", 1049972, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Environment_LabelIDsWorkingSet")]
    protected Environment _LabelIDsWorkingSet;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Environment_LabelNameFilter")]
    [Metadata("DisplayName", "", false, false, false, "String", 1049971, false, false, false, null)]
    protected Environment _LabelNameFilter;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Environment_LabelValueFilter")]
    [Metadata("DisplayName", "", false, false, false, "String", 1049970, false, false, false, null)]
    protected Environment _LabelValueFilter;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryMaint_Environment_ObjectListInquiry")]
    [Metadata("Used to store dictionary information including international language and terminology.\r\n", "Dictionary", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;

    public Environment Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Category));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public DictionaryLabelChanges_Environment DictionaryLabelsWorkingSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DictionaryLabelsWorkingSet), (object) value);
      }
      get
      {
        return (DictionaryLabelChanges_Environment) this.PropertyGet(nameof (DictionaryLabelsWorkingSet));
      }
    }

    public DictionaryChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (DictionaryChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Environment LabelIDsWorkingSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelIDsWorkingSet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelIDsWorkingSet));
      }
    }

    public Environment LabelNameFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelNameFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelNameFilter));
      }
    }

    public Environment LabelValueFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelValueFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelValueFilter));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
