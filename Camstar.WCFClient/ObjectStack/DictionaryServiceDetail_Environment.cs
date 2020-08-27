// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DictionaryServiceDetail_Environment
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
  public class DictionaryServiceDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("Label Value.", "", false, false, false, "String", 1049969, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DictionaryServiceDetail_Environment_LabelValue")]
    protected Environment _LabelValue;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryServiceDetail_Environment_DefaultLabelValue")]
    [Metadata("Label Value.", "", false, false, false, "String", 16779055, false, false, false, null)]
    protected Environment _DefaultLabelValue;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryServiceDetail_Environment_LabelName")]
    [Metadata("LabelName", "", false, false, false, "String", 1052772, false, false, false, null)]
    protected Environment _LabelName;
    [Metadata("Generic String", "", false, false, false, "String", 1051206, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DictionaryServiceDetail_Environment_Category")]
    protected Environment _Category;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049968, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DictionaryServiceDetail_Environment_LabelId")]
    protected Environment _LabelId;

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

    public Environment DefaultLabelValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultLabelValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultLabelValue));
      }
    }

    public Environment LabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelName));
      }
    }

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

    public Environment LabelId
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelId));
      }
    }
  }
}
