// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LabelCategoryDetails_Environment
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
  public class LabelCategoryDetails_Environment : ServiceDetails_Environment
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16779260, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_Environment_StartLabelId")]
    protected Environment _StartLabelId;
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_Environment_LabelTypeId")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16779259, false, false, false, null)]
    protected Environment _LabelTypeId;
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_Environment_CategoryName")]
    [Metadata("Generic String", "", false, false, false, "String", 16779257, false, false, false, null)]
    protected Environment _CategoryName;
    [Metadata("Generic String", "", false, false, false, "String", 16779256, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_Environment_CategoryDescription")]
    protected Environment _CategoryDescription;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16779258, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_Environment_EndLabelId")]
    protected Environment _EndLabelId;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049636, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_Environment_CategoryId")]
    protected Environment _CategoryId;

    public Environment StartLabelId
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartLabelId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartLabelId));
      }
    }

    public Environment LabelTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTypeId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelTypeId));
      }
    }

    public Environment CategoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CategoryName));
      }
    }

    public Environment CategoryDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CategoryDescription));
      }
    }

    public Environment EndLabelId
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndLabelId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndLabelId));
      }
    }

    public Environment CategoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CategoryId));
      }
    }
  }
}
