// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DictionaryService_Environment
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
  public class DictionaryService_Environment : Inquiry_Environment
  {
    [Metadata("Holds the details for a label definition", "DictionaryServiceDetail", false, false, false, "DictionaryServiceDetail", 16779058, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DictionaryService_Environment_DictionaryServiceDetails")]
    protected DictionaryServiceDetail_Environment _DictionaryServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryService_Environment_LabelCategoryDetails")]
    [Metadata("Details for a Label Category", "LabelCategoryDetails", false, false, false, "LabelCategoryDetails", 16779255, false, true, true, null)]
    protected LabelCategoryDetails_Environment _LabelCategoryDetails;
    [Metadata("Generic String", "", false, false, false, "String", 16779254, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DictionaryService_Environment_SearchText")]
    protected Environment _SearchText;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16779057, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DictionaryService_Environment_CategoryIds")]
    protected Environment _CategoryIds;
    [Metadata("Generic String", "", false, false, false, "String", 16779253, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DictionaryService_Environment_SearchLabelName")]
    protected Environment _SearchLabelName;

    public DictionaryServiceDetail_Environment DictionaryServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (DictionaryServiceDetails), (object) value);
      }
      get
      {
        return (DictionaryServiceDetail_Environment) this.PropertyGet(nameof (DictionaryServiceDetails));
      }
    }

    public LabelCategoryDetails_Environment LabelCategoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelCategoryDetails), (object) value);
      }
      get
      {
        return (LabelCategoryDetails_Environment) this.PropertyGet(nameof (LabelCategoryDetails));
      }
    }

    public Environment SearchText
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SearchText));
      }
    }

    public Environment CategoryIds
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryIds), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CategoryIds));
      }
    }

    public Environment SearchLabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchLabelName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SearchLabelName));
      }
    }
  }
}
