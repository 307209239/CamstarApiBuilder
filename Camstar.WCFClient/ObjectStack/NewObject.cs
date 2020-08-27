// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NewObject
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
  public class NewObject : ChgAttributeHistoryObject
  {
    [DataMember(EmitDefaultValue = false, Name = "NewObject_ObjectDisplayName")]
    protected new Primitive<string> _ObjectDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "NewObject_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "NewObject_ObjectRef")]
    protected new BaseObjectRef _ObjectRef;
    [DataMember(EmitDefaultValue = false, Name = "NewObject_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is NewObject && object.Equals((object) this._ObjectDisplayName, (object) ((NewObject) obj)._ObjectDisplayName) && (object.Equals((object) this._ExportImportKey, (object) ((NewObject) obj)._ExportImportKey) && object.Equals((object) this._ObjectRef, (object) ((NewObject) obj)._ObjectRef)) && object.Equals((object) this._HistoryId, (object) ((NewObject) obj)._HistoryId) && base.Equals(obj);
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
