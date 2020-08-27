// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CDOField
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (CDOList))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CDOSubentityField))]
  [Serializable]
  public class CDOField : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "CDOField_FieldValue")]
    protected Primitive<string> _FieldValue;
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Fields")]
    protected CDOField[] _Fields;
    [DataMember(EmitDefaultValue = false, Name = "CDOField_IsList")]
    protected Primitive<bool> _IsList;
    [DataMember(EmitDefaultValue = false, Name = "CDOField_ObjectReference")]
    protected BaseObject _ObjectReference;
    [DataMember(EmitDefaultValue = false, Name = "CDOField_IsSubentity")]
    protected Primitive<bool> _IsSubentity;
    [DataMember(EmitDefaultValue = false, Name = "CDOField_IsObjRef")]
    protected Primitive<bool> _IsObjRef;
    [DataMember(EmitDefaultValue = false, Name = "CDOField_Revision")]
    protected Primitive<string> _Revision;
    [DataMember(EmitDefaultValue = false, Name = "CDOField_FieldName")]
    protected Primitive<string> _FieldName;

    public override bool Equals(object obj)
    {
      return obj is CDOField && object.Equals((object) this._FieldValue, (object) ((CDOField) obj)._FieldValue) && (this.CompareArrays((Array) this._Fields, (Array) ((CDOField) obj)._Fields) && object.Equals((object) this._IsList, (object) ((CDOField) obj)._IsList)) && (object.Equals((object) this._ObjectReference, (object) ((CDOField) obj)._ObjectReference) && object.Equals((object) this._IsSubentity, (object) ((CDOField) obj)._IsSubentity) && (object.Equals((object) this._IsObjRef, (object) ((CDOField) obj)._IsObjRef) && object.Equals((object) this._Revision, (object) ((CDOField) obj)._Revision))) && object.Equals((object) this._FieldName, (object) ((CDOField) obj)._FieldName) && base.Equals(obj);
    }

    public Primitive<string> FieldValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FieldValue));
      }
    }

    public CDOField[] Fields
    {
      [param: In] set
      {
        this.PropertySet(nameof (Fields), (object) value);
      }
      get
      {
        return (CDOField[]) this.PropertyGet(nameof (Fields));
      }
    }

    public Primitive<bool> IsList
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsList), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsList));
      }
    }

    public BaseObject ObjectReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectReference), (object) value);
      }
      get
      {
        return (BaseObject) this.PropertyGet(nameof (ObjectReference));
      }
    }

    public Primitive<bool> IsSubentity
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSubentity), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsSubentity));
      }
    }

    public Primitive<bool> IsObjRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsObjRef), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsObjRef));
      }
    }

    public Primitive<string> Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Revision));
      }
    }

    public Primitive<string> FieldName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FieldName));
      }
    }
  }
}
