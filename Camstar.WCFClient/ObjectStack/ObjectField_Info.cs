// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectField_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ReferenceField_Info))]
  [KnownType(typeof (SubentityField_Info))]
  [Serializable]
  public class ObjectField_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ObjectField_Info_FieldNameLblValue")]
    protected Info _FieldNameLblValue;
    [DataMember(EmitDefaultValue = false, Name = "ObjectField_Info_IsList")]
    protected Info _IsList;
    [DataMember(EmitDefaultValue = false, Name = "ObjectField_Info_FieldName")]
    protected Info _FieldName;

    public Info FieldNameLblValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldNameLblValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FieldNameLblValue));
      }
    }

    public Info IsList
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsList));
      }
    }

    public Info FieldName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FieldName));
      }
    }
  }
}
