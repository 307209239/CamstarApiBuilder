// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DictionaryServiceDetail
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
  public class DictionaryServiceDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "DictionaryServiceDetail_LabelValue")]
    protected Primitive<string> _LabelValue;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryServiceDetail_DefaultLabelValue")]
    protected Primitive<string> _DefaultLabelValue;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryServiceDetail_LabelName")]
    protected Primitive<string> _LabelName;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryServiceDetail_Category")]
    protected Primitive<string> _Category;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryServiceDetail_LabelId")]
    protected Primitive<int> _LabelId;

    public override bool Equals(object obj)
    {
      return obj is DictionaryServiceDetail && object.Equals((object) this._LabelValue, (object) ((DictionaryServiceDetail) obj)._LabelValue) && (object.Equals((object) this._DefaultLabelValue, (object) ((DictionaryServiceDetail) obj)._DefaultLabelValue) && object.Equals((object) this._LabelName, (object) ((DictionaryServiceDetail) obj)._LabelName)) && (object.Equals((object) this._Category, (object) ((DictionaryServiceDetail) obj)._Category) && object.Equals((object) this._LabelId, (object) ((DictionaryServiceDetail) obj)._LabelId)) && base.Equals(obj);
    }

    public Primitive<string> LabelValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelValue));
      }
    }

    public Primitive<string> DefaultLabelValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultLabelValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefaultLabelValue));
      }
    }

    public Primitive<string> LabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelName));
      }
    }

    public Primitive<string> Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Category));
      }
    }

    public Primitive<int> LabelId
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (LabelId));
      }
    }
  }
}
