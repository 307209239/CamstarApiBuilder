// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EndCollaborationHistory
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
  public class EndCollaborationHistory : ProcessObjectTxnHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "EndCollaborationHistory_ToRole")]
    protected NamedObjectRef _ToRole;
    [DataMember(EmitDefaultValue = false, Name = "EndCollaborationHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EndCollaborationHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EndCollaborationHistory_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "EndCollaborationHistory_FromRole")]
    protected NamedObjectRef _FromRole;
    [DataMember(EmitDefaultValue = false, Name = "EndCollaborationHistory_ProcessObject")]
    protected new NamedSubentityRef _ProcessObject;
    [DataMember(EmitDefaultValue = false, Name = "EndCollaborationHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "EndCollaborationHistory_ToUser")]
    protected NamedObjectRef _ToUser;
    [DataMember(EmitDefaultValue = false, Name = "EndCollaborationHistory_Employee")]
    protected new NamedObjectRef _Employee;
    [DataMember(EmitDefaultValue = false, Name = "EndCollaborationHistory_FromUser")]
    protected NamedObjectRef _FromUser;

    public override bool Equals(object obj)
    {
      return obj is EndCollaborationHistory && object.Equals((object) this._ToRole, (object) ((EndCollaborationHistory) obj)._ToRole) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((EndCollaborationHistory) obj)._HistoryDetails) && object.Equals((object) this._ExportImportKey, (object) ((EndCollaborationHistory) obj)._ExportImportKey)) && (object.Equals((object) this._QualityObject, (object) ((EndCollaborationHistory) obj)._QualityObject) && object.Equals((object) this._FromRole, (object) ((EndCollaborationHistory) obj)._FromRole) && (object.Equals((object) this._ProcessObject, (object) ((EndCollaborationHistory) obj)._ProcessObject) && object.Equals((object) this._HistoryId, (object) ((EndCollaborationHistory) obj)._HistoryId))) && (object.Equals((object) this._ToUser, (object) ((EndCollaborationHistory) obj)._ToUser) && object.Equals((object) this._Employee, (object) ((EndCollaborationHistory) obj)._Employee) && object.Equals((object) this._FromUser, (object) ((EndCollaborationHistory) obj)._FromUser)) && base.Equals(obj);
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
  }
}
