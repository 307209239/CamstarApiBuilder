// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CDOField_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (CDOSubentityField_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CDOList_Environment))]
  [Serializable]
  public class CDOField_Environment : ServiceData_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Environment_FieldValue")]
    [Metadata("String that is able to accomodate all other string subtypes.", "", false, false, true, "String", 16778268, false, false, false, null)]
    protected Environment _FieldValue;
    [Metadata("Generic object for use in modeling inquiry to return a list of fields with values for a modeling instance.", "CDOField", false, false, false, "CDOField", 16778269, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Environment_Fields")]
    protected CDOField_Environment _Fields;
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Environment_IsList")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050847, false, false, false, "0")]
    protected Environment _IsList;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObject", 16778273, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Environment_ObjectReference")]
    protected BaseObject_Environment _ObjectReference;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778270, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Environment_IsSubentity")]
    protected Environment _IsSubentity;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778271, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Environment_IsObjRef")]
    protected Environment _IsObjRef;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1048710, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Environment_Revision")]
    protected Environment _Revision;
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Environment_FieldName")]
    [Metadata("Name of the CDO Definition for this instance", "", false, false, true, "String", 1049129, false, false, false, null)]
    protected Environment _FieldName;

    public Environment FieldValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FieldValue));
      }
    }

    public CDOField_Environment Fields
    {
      [param: In] set
      {
        this.PropertySet(nameof (Fields), (object) value);
      }
      get
      {
        return (CDOField_Environment) this.PropertyGet(nameof (Fields));
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

    public BaseObject_Environment ObjectReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectReference), (object) value);
      }
      get
      {
        return (BaseObject_Environment) this.PropertyGet(nameof (ObjectReference));
      }
    }

    public Environment IsSubentity
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSubentity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsSubentity));
      }
    }

    public Environment IsObjRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsObjRef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsObjRef));
      }
    }

    public Environment Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Revision));
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
