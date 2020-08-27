// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_CDOInquiry_Environment
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
  public class V4_CDOInquiry_Environment : Inquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Environment_CDODefName")]
    [Metadata("Generic String", "", false, false, false, "String", 1050844, false, false, false, null)]
    protected Environment _CDODefName;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Environment_CDOInstances")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1049286, false, true, false, null)]
    protected Environment _CDOInstances;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Environment_CDODefID")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1050843, false, false, false, "0")]
    protected Environment _CDODefID;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Environment_IsInstanceType")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049289, false, false, false, "0")]
    protected Environment _IsInstanceType;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Environment_NameList")]
    [Metadata("Generic String", "", false, false, false, "String", 1049291, false, true, false, null)]
    protected Environment _NameList;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049288, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Environment_IsFieldInquiry")]
    protected Environment _IsFieldInquiry;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Environment_Length")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049290, false, false, false, "0")]
    protected Environment _Length;
    [DataMember(EmitDefaultValue = false, Name = "V4_CDOInquiry_Environment_CDOTypes")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049287, false, true, false, null)]
    protected Environment _CDOTypes;

    public Environment CDODefName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDODefName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CDODefName));
      }
    }

    public Environment CDOInstances
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOInstances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CDOInstances));
      }
    }

    public Environment CDODefID
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDODefID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CDODefID));
      }
    }

    public Environment IsInstanceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsInstanceType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsInstanceType));
      }
    }

    public Environment NameList
    {
      [param: In] set
      {
        this.PropertySet(nameof (NameList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NameList));
      }
    }

    public Environment IsFieldInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFieldInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFieldInquiry));
      }
    }

    public Environment Length
    {
      [param: In] set
      {
        this.PropertySet(nameof (Length), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Length));
      }
    }

    public Environment CDOTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (CDOTypes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CDOTypes));
      }
    }
  }
}
