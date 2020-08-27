// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GateStatus
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
  public class GateStatus : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_CompletedSteps")]
    protected NamedSubentityRef[] _CompletedSteps;
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_GateType")]
    protected Primitive<int> _GateType;
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_Gate")]
    protected NamedSubentityRef _Gate;
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_RequiredStepsRemaining")]
    protected NamedSubentityRef[] _RequiredStepsRemaining;

    public override bool Equals(object obj)
    {
      return obj is GateStatus && object.Equals((object) this._ExportImportKey, (object) ((GateStatus) obj)._ExportImportKey) && (object.Equals((object) this._Container, (object) ((GateStatus) obj)._Container) && this.CompareArrays((Array) this._CompletedSteps, (Array) ((GateStatus) obj)._CompletedSteps)) && (object.Equals((object) this._GateType, (object) ((GateStatus) obj)._GateType) && object.Equals((object) this._Gate, (object) ((GateStatus) obj)._Gate) && this.CompareArrays((Array) this._RequiredStepsRemaining, (Array) ((GateStatus) obj)._RequiredStepsRemaining)) && base.Equals(obj);
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

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public NamedSubentityRef[] CompletedSteps
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedSteps), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (CompletedSteps));
      }
    }

    public Primitive<int> GateType
    {
      [param: In] set
      {
        this.PropertySet(nameof (GateType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (GateType));
      }
    }

    public NamedSubentityRef Gate
    {
      [param: In] set
      {
        this.PropertySet(nameof (Gate), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Gate));
      }
    }

    public NamedSubentityRef[] RequiredStepsRemaining
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequiredStepsRemaining), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (RequiredStepsRemaining));
      }
    }
  }
}
