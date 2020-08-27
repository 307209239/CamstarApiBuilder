// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgAttributeHistoryObject
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (OldObject))]
  [KnownType(typeof (NewObject))]
  [Serializable]
  public class ChgAttributeHistoryObject : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgAttributeHistoryObject_ObjectDisplayName")]
    protected Primitive<string> _ObjectDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ChgAttributeHistoryObject_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChgAttributeHistoryObject_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ChgAttributeHistoryObject_ObjectRef")]
    protected BaseObjectRef _ObjectRef;

    public override bool Equals(object obj)
    {
      return obj is ChgAttributeHistoryObject && object.Equals((object) this._ObjectDisplayName, (object) ((ChgAttributeHistoryObject) obj)._ObjectDisplayName) && (object.Equals((object) this._ExportImportKey, (object) ((ChgAttributeHistoryObject) obj)._ExportImportKey) && object.Equals((object) this._HistoryId, (object) ((ChgAttributeHistoryObject) obj)._HistoryId)) && object.Equals((object) this._ObjectRef, (object) ((ChgAttributeHistoryObject) obj)._ObjectRef) && base.Equals(obj);
    }

    public Primitive<string> ObjectDisplayName
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

    public BaseObjectRef ObjectRef
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
  }
}
