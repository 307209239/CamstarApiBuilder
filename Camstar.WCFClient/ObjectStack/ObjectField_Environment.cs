// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectField_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (SubentityField_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ReferenceField_Environment))]
  [Serializable]
  public class ObjectField_Environment : ServiceData_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ObjectField_Environment_FieldNameLblValue")]
    [Metadata("Label Value.", "", false, false, true, "String", 16779042, false, false, false, null)]
    protected Environment _FieldNameLblValue;
    [DataMember(EmitDefaultValue = false, Name = "ObjectField_Environment_IsList")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050847, false, false, false, "0")]
    protected Environment _IsList;
    [DataMember(EmitDefaultValue = false, Name = "ObjectField_Environment_FieldName")]
    [Metadata("Name of the CDO Definition for this instance", "", false, false, true, "String", 1049129, false, false, false, null)]
    protected Environment _FieldName;

    public Environment FieldNameLblValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldNameLblValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FieldNameLblValue));
      }
    }

    public Environment IsList
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsList));
      }
    }

    public Environment FieldName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FieldName));
      }
    }
  }
}
