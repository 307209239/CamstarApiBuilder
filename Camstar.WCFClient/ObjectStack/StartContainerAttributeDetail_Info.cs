// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartContainerAttributeDetail_Info
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
  public class StartContainerAttributeDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "StartContainerAttributeDetail_Info_Name")]
    protected Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "StartContainerAttributeDetail_Info_DataType")]
    protected Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "StartContainerAttributeDetail_Info_AttributeValue")]
    protected Info _AttributeValue;
    [DataMember(EmitDefaultValue = false, Name = "StartContainerAttributeDetail_Info_IsExpression")]
    protected Info _IsExpression;

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
