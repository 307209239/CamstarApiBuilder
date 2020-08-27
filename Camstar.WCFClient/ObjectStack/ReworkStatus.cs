// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReworkStatus
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
  public class ReworkStatus : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ReworkStatus_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ReworkStatus_ReEntryWorkflowStack")]
    protected NamedSubentityRef[] _ReEntryWorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "ReworkStatus_ReEntryStep")]
    protected NamedSubentityRef _ReEntryStep;
    [DataMember(EmitDefaultValue = false, Name = "ReworkStatus_ReworkReason")]
    protected NamedObjectRef _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "ReworkStatus_EndReworkStep")]
    protected NamedSubentityRef _EndReworkStep;

    public override bool Equals(object obj)
    {
      return obj is ReworkStatus && object.Equals((object) this._ExportImportKey, (object) ((ReworkStatus) obj)._ExportImportKey) && (this.CompareArrays((Array) this._ReEntryWorkflowStack, (Array) ((ReworkStatus) obj)._ReEntryWorkflowStack) && object.Equals((object) this._ReEntryStep, (object) ((ReworkStatus) obj)._ReEntryStep)) && (object.Equals((object) this._ReworkReason, (object) ((ReworkStatus) obj)._ReworkReason) && object.Equals((object) this._EndReworkStep, (object) ((ReworkStatus) obj)._EndReworkStep)) && base.Equals(obj);
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

    public NamedSubentityRef[] ReEntryWorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryWorkflowStack), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (ReEntryWorkflowStack));
      }
    }

    public NamedSubentityRef ReEntryStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReEntryStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ReEntryStep));
      }
    }

    public NamedObjectRef ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReworkReason));
      }
    }

    public NamedSubentityRef EndReworkStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndReworkStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (EndReworkStep));
      }
    }
  }
}
