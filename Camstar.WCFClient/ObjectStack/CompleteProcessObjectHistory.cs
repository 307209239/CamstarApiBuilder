// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteProcessObjectHistory
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
  public class CompleteProcessObjectHistory : ProcessObjectTxnHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObjectHistory_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObjectHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObjectHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObjectHistory_ProcessObject")]
    protected new NamedSubentityRef _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObjectHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObjectHistory_CompletionComments")]
    protected Primitive<string> _CompletionComments;
    [DataMember(EmitDefaultValue = false, Name = "CompleteProcessObjectHistory_Employee")]
    protected new NamedObjectRef _Employee;

    public override bool Equals(object obj)
    {
      return obj is CompleteProcessObjectHistory && object.Equals((object) this._QualityObject, (object) ((CompleteProcessObjectHistory) obj)._QualityObject) && (object.Equals((object) this._ExportImportKey, (object) ((CompleteProcessObjectHistory) obj)._ExportImportKey) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((CompleteProcessObjectHistory) obj)._HistoryDetails)) && (object.Equals((object) this._ProcessObject, (object) ((CompleteProcessObjectHistory) obj)._ProcessObject) && object.Equals((object) this._HistoryId, (object) ((CompleteProcessObjectHistory) obj)._HistoryId) && (object.Equals((object) this._CompletionComments, (object) ((CompleteProcessObjectHistory) obj)._CompletionComments) && object.Equals((object) this._Employee, (object) ((CompleteProcessObjectHistory) obj)._Employee))) && base.Equals(obj);
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

    public Primitive<string> CompletionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CompletionComments));
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
