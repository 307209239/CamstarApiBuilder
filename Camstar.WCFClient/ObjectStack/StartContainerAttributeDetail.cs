// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartContainerAttributeDetail
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
  public class StartContainerAttributeDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "StartContainerAttributeDetail_Name")]
    protected Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "StartContainerAttributeDetail_DataType")]
    protected Enumeration<TrivialTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "StartContainerAttributeDetail_AttributeValue")]
    protected Primitive<string> _AttributeValue;
    [DataMember(EmitDefaultValue = false, Name = "StartContainerAttributeDetail_IsExpression")]
    protected Primitive<bool> _IsExpression;

    public override bool Equals(object obj)
    {
      return obj is StartContainerAttributeDetail && object.Equals((object) this._Name, (object) ((StartContainerAttributeDetail) obj)._Name) && (object.Equals((object) this._DataType, (object) ((StartContainerAttributeDetail) obj)._DataType) && object.Equals((object) this._AttributeValue, (object) ((StartContainerAttributeDetail) obj)._AttributeValue)) && object.Equals((object) this._IsExpression, (object) ((StartContainerAttributeDetail) obj)._IsExpression) && base.Equals(obj);
    }

    public Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public Enumeration<TrivialTypeEnum, int> DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Enumeration<TrivialTypeEnum, int>) this.PropertyGet(nameof (DataType));
      }
    }

    public Primitive<string> AttributeValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (AttributeValue));
      }
    }

    public Primitive<bool> IsExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsExpression), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsExpression));
      }
    }
  }
}
