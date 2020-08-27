// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DictionaryService_Info
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
  public class DictionaryService_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DictionaryService_Info_DictionaryServiceDetails")]
    protected DictionaryServiceDetail_Info _DictionaryServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryService_Info_LabelCategoryDetails")]
    protected LabelCategoryDetails_Info _LabelCategoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryService_Info_SearchText")]
    protected Info _SearchText;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryService_Info_CategoryIds")]
    protected Info _CategoryIds;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryService_Info_SearchLabelName")]
    protected Info _SearchLabelName;

    public DictionaryServiceDetail_Info DictionaryServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (DictionaryServiceDetails), (object) value);
      }
      get
      {
        return (DictionaryServiceDetail_Info) this.PropertyGet(nameof (DictionaryServiceDetails));
      }
    }

    public LabelCategoryDetails_Info LabelCategoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelCategoryDetails), (object) value);
      }
      get
      {
        return (LabelCategoryDetails_Info) this.PropertyGet(nameof (LabelCategoryDetails));
      }
    }

    public Info SearchText
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SearchText));
      }
    }

    public Info CategoryIds
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryIds), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CategoryIds));
      }
    }

    public Info SearchLabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchLabelName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SearchLabelName));
      }
    }
  }
}
