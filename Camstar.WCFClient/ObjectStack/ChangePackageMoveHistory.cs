// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackageMoveHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (MoveNonStdChangePkgHistory))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MoveStdChangePkgHistory))]
  [Serializable]
  public class ChangePackageMoveHistory : TrackableObjectMovementHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageMoveHistory_Path")]
    protected NamedSubentityRef _Path;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageMoveHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageMoveHistory_ToWorkflow")]
    protected RevisionedObjectRef _ToWorkflow;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageMoveHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageMoveHistory_Step")]
    protected NamedSubentityRef _Step;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackageMoveHistory_ToStep")]
    protected NamedSubentityRef _ToStep;

    public override bool Equals(object obj)
    {
      return obj is ChangePackageMoveHistory && object.Equals((object) this._Path, (object) ((ChangePackageMoveHistory) obj)._Path) && (object.Equals((object) this._ExportImportKey, (object) ((ChangePackageMoveHistory) obj)._ExportImportKey) && object.Equals((object) this._ToWorkflow, (object) ((ChangePackageMoveHistory) obj)._ToWorkflow)) && (object.Equals((object) this._HistoryId, (object) ((ChangePackageMoveHistory) obj)._HistoryId) && object.Equals((object) this._Step, (object) ((ChangePackageMoveHistory) obj)._Step) && object.Equals((object) this._ToStep, (object) ((ChangePackageMoveHistory) obj)._ToStep)) && base.Equals(obj);
    }

    public NamedSubentityRef Path
    {
      [param: In] set
      {
        this.PropertySet(nameof (Path), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Path));
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

    public RevisionedObjectRef ToWorkflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToWorkflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ToWorkflow));
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

    public NamedSubentityRef Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Step));
      }
    }

    public NamedSubentityRef ToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ToStep));
      }
    }
  }
}
