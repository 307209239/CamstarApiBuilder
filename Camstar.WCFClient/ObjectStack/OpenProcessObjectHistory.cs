// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OpenProcessObjectHistory
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
  public class OpenProcessObjectHistory : ProcessObjectTxnHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "OpenProcessObjectHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "OpenProcessObjectHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "OpenProcessObjectHistory_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "OpenProcessObjectHistory_ProcessObject")]
    protected new NamedSubentityRef _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "OpenProcessObjectHistory_ChildOpenOption")]
    protected Enumeration<ChildOpenOptionEnum, int> _ChildOpenOption;
    [DataMember(EmitDefaultValue = false, Name = "OpenProcessObjectHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "OpenProcessObjectHistory_Employee")]
    protected new NamedObjectRef _Employee;

    public override bool Equals(object obj)
    {
      return obj is OpenProcessObjectHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((OpenProcessObjectHistory) obj)._HistoryDetails) && (object.Equals((object) this._ExportImportKey, (object) ((OpenProcessObjectHistory) obj)._ExportImportKey) && object.Equals((object) this._QualityObject, (object) ((OpenProcessObjectHistory) obj)._QualityObject)) && (object.Equals((object) this._ProcessObject, (object) ((OpenProcessObjectHistory) obj)._ProcessObject) && object.Equals((object) this._ChildOpenOption, (object) ((OpenProcessObjectHistory) obj)._ChildOpenOption) && (object.Equals((object) this._HistoryId, (object) ((OpenProcessObjectHistory) obj)._HistoryId) && object.Equals((object) this._Employee, (object) ((OpenProcessObjectHistory) obj)._Employee))) && base.Equals(obj);
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

    public Enumeration<ChildOpenOptionEnum, int> ChildOpenOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildOpenOption), (object) value);
      }
      get
      {
        return (Enumeration<ChildOpenOptionEnum, int>) this.PropertyGet(nameof (ChildOpenOption));
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
