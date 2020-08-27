// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SerializeHistoryDetails
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
  public class SerializeHistoryDetails : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "SerializeHistoryDetails_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SerializeHistoryDetails_ChildCount")]
    protected Primitive<int> _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "SerializeHistoryDetails_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "SerializeHistoryDetails_ChildContainerLevel")]
    protected NamedObjectRef _ChildContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "SerializeHistoryDetails_Product")]
    protected RevisionedObjectRef _Product;

    public override bool Equals(object obj)
    {
      return obj is SerializeHistoryDetails && object.Equals((object) this._ExportImportKey, (object) ((SerializeHistoryDetails) obj)._ExportImportKey) && (object.Equals((object) this._ChildCount, (object) ((SerializeHistoryDetails) obj)._ChildCount) && object.Equals((object) this._HistoryId, (object) ((SerializeHistoryDetails) obj)._HistoryId)) && (object.Equals((object) this._ChildContainerLevel, (object) ((SerializeHistoryDetails) obj)._ChildContainerLevel) && object.Equals((object) this._Product, (object) ((SerializeHistoryDetails) obj)._Product)) && base.Equals(obj);
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

    public Primitive<int> ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ChildCount));
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

    public NamedObjectRef ChildContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainerLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ChildContainerLevel));
      }
    }

    public RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }
  }
}
