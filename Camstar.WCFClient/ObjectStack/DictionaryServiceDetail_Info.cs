// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DictionaryServiceDetail_Info
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
  public class DictionaryServiceDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DictionaryServiceDetail_Info_LabelValue")]
    protected Info _LabelValue;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryServiceDetail_Info_DefaultLabelValue")]
    protected Info _DefaultLabelValue;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryServiceDetail_Info_LabelName")]
    protected Info _LabelName;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryServiceDetail_Info_Category")]
    protected Info _Category;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryServiceDetail_Info_LabelId")]
    protected Info _LabelId;

    public Info LabelValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelValue));
      }
    }

    public Info DefaultLabelValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultLabelValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultLabelValue));
      }
    }

    public Info LabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelName));
      }
    }

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

    public Info LabelId
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelId));
      }
    }
  }
}
