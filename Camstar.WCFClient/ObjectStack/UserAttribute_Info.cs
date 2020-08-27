// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserAttribute_Info
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
  public class UserAttribute_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_Info_AttributeValue")]
    protected Info _AttributeValue;
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_Info_DataType")]
    protected Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_Info_IsExpression")]
    protected Info _IsExpression;
    [DataMember(EmitDefaultValue = false, Name = "UserAttribute_Info_IsFrozen")]
    protected new Info _IsFrozen;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
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

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
