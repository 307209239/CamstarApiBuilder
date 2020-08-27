// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserAttributeChanges_Info
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
  public class UserAttributeChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UserAttributeChanges_Info_AttributeValue")]
    protected Info _AttributeValue;
    [DataMember(EmitDefaultValue = false, Name = "UserAttributeChanges_Info_DataType")]
    protected Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "UserAttributeChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "UserAttributeChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserAttributeChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserAttributeChanges_Info_IsExpression")]
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

    public new Info Name
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

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
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
