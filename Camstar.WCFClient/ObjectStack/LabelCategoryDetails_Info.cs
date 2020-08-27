// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LabelCategoryDetails_Info
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
  public class LabelCategoryDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_Info_StartLabelId")]
    protected Info _StartLabelId;
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_Info_LabelTypeId")]
    protected Info _LabelTypeId;
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_Info_CategoryName")]
    protected Info _CategoryName;
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_Info_CategoryDescription")]
    protected Info _CategoryDescription;
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_Info_EndLabelId")]
    protected Info _EndLabelId;
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_Info_CategoryId")]
    protected Info _CategoryId;

    public Info StartLabelId
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartLabelId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartLabelId));
      }
    }

    public Info LabelTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTypeId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelTypeId));
      }
    }

    public Info CategoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CategoryName));
      }
    }

    public Info CategoryDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CategoryDescription));
      }
    }

    public Info EndLabelId
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndLabelId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndLabelId));
      }
    }

    public Info CategoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CategoryId));
      }
    }
  }
}
