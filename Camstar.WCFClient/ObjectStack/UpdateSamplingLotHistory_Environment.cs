// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateSamplingLotHistory_Environment
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
  public class UpdateSamplingLotHistory_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLotHistory_Environment_HistoryDetails")]
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLotHistory_Environment_Comments")]
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLotHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Subclass of MfgLot used to associate a group of containers for sampling.  For example, an Incoming inspection lot where multiple containers are from the same lot of material, received at different times but has one AQL Sampling.", "SamplingLot", false, false, false, "NamedObjectRef", 16777719, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLotHistory_Environment_SamplingLot")]
    protected Environment _SamplingLot;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLotHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777736, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLotHistory_Environment_SampleRate")]
    protected Environment _SampleRate;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 16777735, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLotHistory_Environment_Qty")]
    protected Environment _Qty;

    public new ServiceHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingLot));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment SampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleRate));
      }
    }

    public Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
