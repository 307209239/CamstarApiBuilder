// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectAlternateKey
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ExportImportItem))]
  [KnownType(typeof (ImportContent))]
  [KnownType(typeof (ObjectReferencesInfo))]
  [Serializable]
  public class ObjectAlternateKey : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "ObjectAlternateKey_ObjectType")]
    protected Primitive<int> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectAlternateKey_ObjectName")]
    protected Primitive<string> _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "ObjectAlternateKey_ObjectInstanceId")]
    protected Primitive<string> _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "ObjectAlternateKey_ObjectTypeName")]
    protected Primitive<string> _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ObjectAlternateKey_Revision")]
    protected Primitive<string> _Revision;
    [DataMember(EmitDefaultValue = false, Name = "ObjectAlternateKey_IsROR")]
    protected Primitive<bool> _IsROR;

    public override bool Equals(object obj)
    {
      return obj is ObjectAlternateKey && object.Equals((object) this._ObjectType, (object) ((ObjectAlternateKey) obj)._ObjectType) && (object.Equals((object) this._ObjectName, (object) ((ObjectAlternateKey) obj)._ObjectName) && object.Equals((object) this._ObjectInstanceId, (object) ((ObjectAlternateKey) obj)._ObjectInstanceId)) && (object.Equals((object) this._ObjectTypeName, (object) ((ObjectAlternateKey) obj)._ObjectTypeName) && object.Equals((object) this._Revision, (object) ((ObjectAlternateKey) obj)._Revision) && object.Equals((object) this._IsROR, (object) ((ObjectAlternateKey) obj)._IsROR)) && base.Equals(obj);
    }

    public Primitive<int> ObjectType
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

    public Primitive<string> ObjectName
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

    public Primitive<string> ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public Primitive<string> ObjectTypeName
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

    public Primitive<bool> IsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsROR), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsROR));
      }
    }
  }
}
