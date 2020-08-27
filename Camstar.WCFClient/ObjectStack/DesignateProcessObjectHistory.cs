// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DesignateProcessObjectHistory
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
  public class DesignateProcessObjectHistory : ProcessObjectTxnHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_FromRole")]
    protected NamedObjectRef _FromRole;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_ToRole")]
    protected NamedObjectRef _ToRole;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_ProcessObject")]
    protected new NamedSubentityRef _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_AssigneeOption")]
    protected Enumeration<AssigneeOptionEnum, int> _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_Employee")]
    protected new NamedObjectRef _Employee;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_FromUser")]
    protected NamedObjectRef _FromUser;
    [DataMember(EmitDefaultValue = false, Name = "DesignateProcessObjectHistory_ToUser")]
    protected NamedObjectRef _ToUser;

    public override bool Equals(object obj)
    {
      return obj is DesignateProcessObjectHistory && object.Equals((object) this._QualityObject, (object) ((DesignateProcessObjectHistory) obj)._QualityObject) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((DesignateProcessObjectHistory) obj)._HistoryDetails) && object.Equals((object) this._FromRole, (object) ((DesignateProcessObjectHistory) obj)._FromRole)) && (object.Equals((object) this._ToRole, (object) ((DesignateProcessObjectHistory) obj)._ToRole) && object.Equals((object) this._ExportImportKey, (object) ((DesignateProcessObjectHistory) obj)._ExportImportKey) && (object.Equals((object) this._ProcessObject, (object) ((DesignateProcessObjectHistory) obj)._ProcessObject) && object.Equals((object) this._AssigneeOption, (object) ((DesignateProcessObjectHistory) obj)._AssigneeOption))) && (object.Equals((object) this._HistoryId, (object) ((DesignateProcessObjectHistory) obj)._HistoryId) && object.Equals((object) this._Employee, (object) ((DesignateProcessObjectHistory) obj)._Employee) && (object.Equals((object) this._FromUser, (object) ((DesignateProcessObjectHistory) obj)._FromUser) && object.Equals((object) this._ToUser, (object) ((DesignateProcessObjectHistory) obj)._ToUser))) && base.Equals(obj);
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

    public NamedObjectRef FromRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FromRole));
      }
    }

    public NamedObjectRef ToRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ToRole));
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

    public Enumeration<AssigneeOptionEnum, int> AssigneeOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeOption), (object) value);
      }
      get
      {
        return (Enumeration<AssigneeOptionEnum, int>) this.PropertyGet(nameof (AssigneeOption));
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

    public NamedObjectRef FromUser
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromUser), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FromUser));
      }
    }

    public NamedObjectRef ToUser
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToUser), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ToUser));
      }
    }
  }
}
