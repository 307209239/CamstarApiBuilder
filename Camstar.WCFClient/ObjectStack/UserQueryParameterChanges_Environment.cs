// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserQueryParameterChanges_Environment
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
  public class UserQueryParameterChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UserQueryParameterChanges_Environment_DataType")]
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, true, false, "Integer", 1049990, false, false, true, null)]
    protected Environment _DataType;
    [DataMember(EmitDefaultValue = false, Name = "UserQueryParameterChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050262, false, false, false, null)]
    protected new Environment _Name;

    public Environment DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataType));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
