// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerAttrDetail_Info
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
  public class ContainerAttrDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrDetail_Info_AttributeValue")]
    protected Info _AttributeValue;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrDetail_Info_Name")]
    protected Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrDetail_Info_Attribute")]
    protected Info _Attribute;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrDetail_Info_DataType")]
    protected Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrDetail_Info_IsExpression")]
    protected Info _IsExpression;

    public Info AttributeValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttributeValue));
      }
    }

    public Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info Attribute
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attribute), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Attribute));
      }
    }

    public Info DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataType));
      }
    }

    public Info IsExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsExpression), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsExpression));
      }
    }
  }
}
