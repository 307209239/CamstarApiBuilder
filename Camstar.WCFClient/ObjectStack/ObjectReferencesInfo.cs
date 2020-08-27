// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectReferencesInfo
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ObjectToResolve))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ObjectReferencesInfo : ObjectAlternateKey
  {
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_ObjectTypeValue")]
    protected Primitive<string> _ObjectTypeValue;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_ObjectType")]
    protected new Primitive<int> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_ObjectTypeName")]
    protected new Primitive<string> _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_ObjectName")]
    protected new Primitive<string> _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_ObjectFields")]
    protected ObjectField[] _ObjectFields;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_LastEditDateGMT")]
    protected Primitive<DateTime> _LastEditDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_LastEditDate")]
    protected Primitive<DateTime> _LastEditDate;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_ObjectInstance")]
    protected BaseObject _ObjectInstance;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Revision")]
    protected new Primitive<string> _Revision;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_LastEditBy")]
    protected Primitive<string> _LastEditBy;
    [DataMember(EmitDefaultValue = false, Name = "ObjectReferencesInfo_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is ObjectReferencesInfo && object.Equals((object) this._ObjectTypeValue, (object) ((ObjectReferencesInfo) obj)._ObjectTypeValue) && (object.Equals((object) this._ObjectType, (object) ((ObjectReferencesInfo) obj)._ObjectType) && object.Equals((object) this._ObjectTypeName, (object) ((ObjectReferencesInfo) obj)._ObjectTypeName)) && (object.Equals((object) this._ObjectName, (object) ((ObjectReferencesInfo) obj)._ObjectName) && this.CompareArrays((Array) this._ObjectFields, (Array) ((ObjectReferencesInfo) obj)._ObjectFields) && (object.Equals((object) this._LastEditDateGMT, (object) ((ObjectReferencesInfo) obj)._LastEditDateGMT) && object.Equals((object) this._LastEditDate, (object) ((ObjectReferencesInfo) obj)._LastEditDate))) && (object.Equals((object) this._ObjectInstance, (object) ((ObjectReferencesInfo) obj)._ObjectInstance) && object.Equals((object) this._Revision, (object) ((ObjectReferencesInfo) obj)._Revision) && (object.Equals((object) this._LastEditBy, (object) ((ObjectReferencesInfo) obj)._LastEditBy) && object.Equals((object) this._Description, (object) ((ObjectReferencesInfo) obj)._Description))) && base.Equals(obj);
    }

    public Primitive<string> ObjectTypeValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectTypeValue));
      }
    }

    public new Primitive<int> ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ObjectType));
      }
    }

    public new Primitive<string> ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectTypeName));
      }
    }

    public new Primitive<string> ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectName));
      }
    }

    public ObjectField[] ObjectFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectFields), (object) value);
      }
      get
      {
        return (ObjectField[]) this.PropertyGet(nameof (ObjectFields));
      }
    }

    public Primitive<DateTime> LastEditDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEditDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastEditDateGMT));
      }
    }

    public Primitive<DateTime> LastEditDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEditDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastEditDate));
      }
    }

    public BaseObject ObjectInstance
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstance), (object) value);
      }
      get
      {
        return (BaseObject) this.PropertyGet(nameof (ObjectInstance));
      }
    }

    public new Primitive<string> Revision
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

    public Primitive<string> LastEditBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastEditBy), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LastEditBy));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }
  }
}
