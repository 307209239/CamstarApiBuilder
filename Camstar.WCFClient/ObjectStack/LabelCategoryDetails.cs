// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LabelCategoryDetails
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
  public class LabelCategoryDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_StartLabelId")]
    protected Primitive<int> _StartLabelId;
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_LabelTypeId")]
    protected Primitive<int> _LabelTypeId;
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_CategoryName")]
    protected Primitive<string> _CategoryName;
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_CategoryDescription")]
    protected Primitive<string> _CategoryDescription;
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_EndLabelId")]
    protected Primitive<int> _EndLabelId;
    [DataMember(EmitDefaultValue = false, Name = "LabelCategoryDetails_CategoryId")]
    protected Primitive<int> _CategoryId;

    public override bool Equals(object obj)
    {
      return obj is LabelCategoryDetails && object.Equals((object) this._StartLabelId, (object) ((LabelCategoryDetails) obj)._StartLabelId) && (object.Equals((object) this._LabelTypeId, (object) ((LabelCategoryDetails) obj)._LabelTypeId) && object.Equals((object) this._CategoryName, (object) ((LabelCategoryDetails) obj)._CategoryName)) && (object.Equals((object) this._CategoryDescription, (object) ((LabelCategoryDetails) obj)._CategoryDescription) && object.Equals((object) this._EndLabelId, (object) ((LabelCategoryDetails) obj)._EndLabelId) && object.Equals((object) this._CategoryId, (object) ((LabelCategoryDetails) obj)._CategoryId)) && base.Equals(obj);
    }

    public Primitive<int> StartLabelId
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartLabelId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (StartLabelId));
      }
    }

    public Primitive<int> LabelTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTypeId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (LabelTypeId));
      }
    }

    public Primitive<string> CategoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CategoryName));
      }
    }

    public Primitive<string> CategoryDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CategoryDescription));
      }
    }

    public Primitive<int> EndLabelId
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndLabelId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (EndLabelId));
      }
    }

    public Primitive<int> CategoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CategoryId));
      }
    }
  }
}
