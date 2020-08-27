// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DictionaryLabelChanges_Environment
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
  public class DictionaryLabelChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DictionaryLabelChanges_Environment_LabelID")]
    [Metadata("LabelId", "", false, false, false, "Integer", 1049968, false, false, false, null)]
    protected Environment _LabelID;
    [Metadata("LabelCategoryId", "", false, false, false, "Integer", 1049991, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DictionaryLabelChanges_Environment_CategoryID")]
    protected Environment _CategoryID;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryLabelChanges_Environment_DefaultValue")]
    [Metadata("Label Value.", "", false, false, false, "String", 1049992, false, false, false, null)]
    protected Environment _DefaultValue;
    [Metadata("Label Value.", "", false, false, false, "String", 1049993, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DictionaryLabelChanges_Environment_LabelValue")]
    protected Environment _LabelValue;
    [Metadata("LabelName", "", false, false, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DictionaryLabelChanges_Environment_Name")]
    protected Environment _Name;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049975, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DictionaryLabelChanges_Environment_ActionMode")]
    protected Environment _ActionMode;

    public Environment LabelID
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelID));
      }
    }

    public Environment CategoryID
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CategoryID));
      }
    }

    public Environment DefaultValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultValue));
      }
    }

    public Environment LabelValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelValue));
      }
    }

    public Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public Environment ActionMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActionMode));
      }
    }
  }
}
