// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DisassociateHistory
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
  public class DisassociateHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "DisassociateHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DisassociateHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DisassociateHistory_ParentContainer")]
    protected ContainerRef _ParentContainer;
    [DataMember(EmitDefaultValue = false, Name = "DisassociateHistory_ChildContainers")]
    protected ContainerRef[] _ChildContainers;

    public override bool Equals(object obj)
    {
      return obj is DisassociateHistory && object.Equals((object) this._ExportImportKey, (object) ((DisassociateHistory) obj)._ExportImportKey) && (object.Equals((object) this._HistoryId, (object) ((DisassociateHistory) obj)._HistoryId) && object.Equals((object) this._ParentContainer, (object) ((DisassociateHistory) obj)._ParentContainer)) && this.CompareArrays((Array) this._ChildContainers, (Array) ((DisassociateHistory) obj)._ChildContainers) && base.Equals(obj);
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

    public ContainerRef ParentContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (ParentContainer));
      }
    }

    public ContainerRef[] ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (ContainerRef[]) this.PropertyGet(nameof (ChildContainers));
      }
    }
  }
}
