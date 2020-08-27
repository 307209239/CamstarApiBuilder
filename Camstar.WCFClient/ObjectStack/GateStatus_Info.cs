// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GateStatus_Info
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
  public class GateStatus_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_Info_CompletedSteps")]
    protected Info _CompletedSteps;
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_Info_GateType")]
    protected Info _GateType;
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_Info_Gate")]
    protected Info _Gate;
    [DataMember(EmitDefaultValue = false, Name = "GateStatus_Info_RequiredStepsRemaining")]
    protected Info _RequiredStepsRemaining;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info CompletedSteps
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedSteps), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletedSteps));
      }
    }

    public Info GateType
    {
      [param: In] set
      {
        this.PropertySet(nameof (GateType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GateType));
      }
    }

    public Info Gate
    {
      [param: In] set
      {
        this.PropertySet(nameof (Gate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Gate));
      }
    }

    public Info RequiredStepsRemaining
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequiredStepsRemaining), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RequiredStepsRemaining));
      }
    }
  }
}
