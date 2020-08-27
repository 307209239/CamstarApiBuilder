// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReorderProcessObjectHistory
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
  public class ReorderProcessObjectHistory : ProcessObjectTxnHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObjectHistory_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObjectHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObjectHistory_HistoryDetails")]
    protected ReorderProcessObjectHistDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObjectHistory_ProcessObject")]
    protected new NamedSubentityRef _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObjectHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObjectHistory_Employee")]
    protected new NamedObjectRef _Employee;

    public override bool Equals(object obj)
    {
      return obj is ReorderProcessObjectHistory && object.Equals((object) this._QualityObject, (object) ((ReorderProcessObjectHistory) obj)._QualityObject) && (object.Equals((object) this._ExportImportKey, (object) ((ReorderProcessObjectHistory) obj)._ExportImportKey) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((ReorderProcessObjectHistory) obj)._HistoryDetails)) && (object.Equals((object) this._ProcessObject, (object) ((ReorderProcessObjectHistory) obj)._ProcessObject) && object.Equals((object) this._HistoryId, (object) ((ReorderProcessObjectHistory) obj)._HistoryId) && object.Equals((object) this._Employee, (object) ((ReorderProcessObjectHistory) obj)._Employee)) && base.Equals(obj);
    }

    public new NamedObjectRef QualityObject
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

    public ReorderProcessObjectHistDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ReorderProcessObjectHistDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new NamedSubentityRef ProcessObject
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

    public new NamedObjectRef Employee
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
