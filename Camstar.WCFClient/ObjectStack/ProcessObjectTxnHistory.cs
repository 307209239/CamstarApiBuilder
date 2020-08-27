// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectTxnHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ModifyProcessObjectHistory))]
  [KnownType(typeof (OpenProcessObjectHistory))]
  [KnownType(typeof (EndCollaborationHistory))]
  [KnownType(typeof (ReprocessActivityHistory))]
  [KnownType(typeof (RoutingHistory))]
  [KnownType(typeof (VoidProcessObjectHistory))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ReorderProcessObjectHistory))]
  [KnownType(typeof (AssignmentHistory))]
  [KnownType(typeof (CompleteActivityHistory))]
  [KnownType(typeof (CompleteProcessObjectHistory))]
  [KnownType(typeof (CompletionHistory))]
  [KnownType(typeof (DesignateProcessObjectHistory))]
  [Serializable]
  public class ProcessObjectTxnHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxnHistory_QualityObject")]
    protected NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxnHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxnHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxnHistory_ProcessObject")]
    protected NamedSubentityRef _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxnHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTxnHistory_Employee")]
    protected NamedObjectRef _Employee;

    public override bool Equals(object obj)
    {
      return obj is ProcessObjectTxnHistory && object.Equals((object) this._QualityObject, (object) ((ProcessObjectTxnHistory) obj)._QualityObject) && (object.Equals((object) this._ExportImportKey, (object) ((ProcessObjectTxnHistory) obj)._ExportImportKey) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((ProcessObjectTxnHistory) obj)._HistoryDetails)) && (object.Equals((object) this._ProcessObject, (object) ((ProcessObjectTxnHistory) obj)._ProcessObject) && object.Equals((object) this._HistoryId, (object) ((ProcessObjectTxnHistory) obj)._HistoryId) && object.Equals((object) this._Employee, (object) ((ProcessObjectTxnHistory) obj)._Employee)) && base.Equals(obj);
    }

    public NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
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

    public new ServiceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public NamedSubentityRef ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessObject));
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

    public NamedObjectRef Employee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Employee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Employee));
      }
    }
  }
}
