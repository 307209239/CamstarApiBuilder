// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DictionaryService
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
  public class DictionaryService : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "DictionaryService_DictionaryServiceDetails")]
    protected DictionaryServiceDetail[] _DictionaryServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryService_LabelCategoryDetails")]
    protected Camstar.WCF.ObjectStack.LabelCategoryDetails[] _LabelCategoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryService_SearchText")]
    protected Primitive<string> _SearchText;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryService_CategoryIds")]
    protected Primitive<int>[] _CategoryIds;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryService_SearchLabelName")]
    protected Primitive<string> _SearchLabelName;

    public override bool Equals(object obj)
    {
      return obj is DictionaryService && this.CompareArrays((Array) this._DictionaryServiceDetails, (Array) ((DictionaryService) obj)._DictionaryServiceDetails) && (this.CompareArrays((Array) this._LabelCategoryDetails, (Array) ((DictionaryService) obj)._LabelCategoryDetails) && object.Equals((object) this._SearchText, (object) ((DictionaryService) obj)._SearchText)) && (this.CompareArrays((Array) this._CategoryIds, (Array) ((DictionaryService) obj)._CategoryIds) && object.Equals((object) this._SearchLabelName, (object) ((DictionaryService) obj)._SearchLabelName)) && base.Equals(obj);
    }

    public DictionaryServiceDetail[] DictionaryServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (DictionaryServiceDetails), (object) value);
      }
      get
      {
        return (DictionaryServiceDetail[]) this.PropertyGet(nameof (DictionaryServiceDetails));
      }
    }

    public Camstar.WCF.ObjectStack.LabelCategoryDetails[] LabelCategoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelCategoryDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.LabelCategoryDetails[]) this.PropertyGet(nameof (LabelCategoryDetails));
      }
    }

    public Primitive<string> SearchText
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SearchText));
      }
    }

    public Primitive<int>[] CategoryIds
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryIds), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (CategoryIds));
      }
    }

    public Primitive<string> SearchLabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SearchLabelName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SearchLabelName));
      }
    }
  }
}
