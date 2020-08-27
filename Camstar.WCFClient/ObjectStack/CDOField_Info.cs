// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CDOField_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (CDOList_Info))]
  [KnownType(typeof (CDOSubentityField_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class CDOField_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Info_FieldValue")]
    protected Info _FieldValue;
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Info_Fields")]
    protected CDOField_Info _Fields;
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Info_IsList")]
    protected Info _IsList;
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Info_ObjectReference")]
    protected BaseObject_Info _ObjectReference;
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Info_IsSubentity")]
    protected Info _IsSubentity;
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Info_IsObjRef")]
    protected Info _IsObjRef;
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Info_Revision")]
    protected Info _Revision;
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Info_FieldName")]
    protected Info _FieldName;

    public Info FieldValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FieldValue));
      }
    }

    public CDOField_Info Fields
    {
      [param: In] set
      {
        this.PropertySet(nameof (Fields), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (Fields));
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

    public BaseObject_Info ObjectReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectReference), (object) value);
      }
      get
      {
        return (BaseObject_Info) this.PropertyGet(nameof (ObjectReference));
      }
    }

    public Info IsSubentity
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSubentity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsSubentity));
      }
    }

    public Info IsObjRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsObjRef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsObjRef));
      }
    }

    public Info Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Revision));
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
