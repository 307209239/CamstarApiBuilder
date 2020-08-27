// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectToResolve
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
  public class ObjectToResolve : ObjectReferencesInfo
  {
    [DataMember(EmitDefaultValue = false, Name = "ObjectToResolve_ObjectTypeName")]
    protected new Primitive<string> _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ObjectToResolve_ObjectType")]
    protected new Primitive<int> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectToResolve_ObjectName")]
    protected new Primitive<string> _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "ObjectToResolve_Revision")]
    protected new Primitive<string> _Revision;

    public override bool Equals(object obj)
    {
      return obj is ObjectToResolve && object.Equals((object) this._ObjectTypeName, (object) ((ObjectToResolve) obj)._ObjectTypeName) && (object.Equals((object) this._ObjectType, (object) ((ObjectToResolve) obj)._ObjectType) && object.Equals((object) this._ObjectName, (object) ((ObjectToResolve) obj)._ObjectName)) && object.Equals((object) this._Revision, (object) ((ObjectToResolve) obj)._Revision) && base.Equals(obj);
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
  }
}
