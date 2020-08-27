// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OldObject
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
  public class OldObject : ChgAttributeHistoryObject
  {
    [DataMember(EmitDefaultValue = false, Name = "OldObject_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "OldObject_ObjectDisplayName")]
    protected new Primitive<string> _ObjectDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "OldObject_ObjectRef")]
    protected new BaseObjectRef _ObjectRef;
    [DataMember(EmitDefaultValue = false, Name = "OldObject_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is OldObject && object.Equals((object) this._ExportImportKey, (object) ((OldObject) obj)._ExportImportKey) && (object.Equals((object) this._ObjectDisplayName, (object) ((OldObject) obj)._ObjectDisplayName) && object.Equals((object) this._ObjectRef, (object) ((OldObject) obj)._ObjectRef)) && object.Equals((object) this._HistoryId, (object) ((OldObject) obj)._HistoryId) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public new Primitive<string> ObjectDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectDisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectDisplayName));
      }
    }

    public new BaseObjectRef ObjectRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRef), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (ObjectRef));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }
  }
}
