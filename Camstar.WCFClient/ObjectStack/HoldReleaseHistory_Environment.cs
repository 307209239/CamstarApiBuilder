// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HoldReleaseHistory_Environment
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
  public class HoldReleaseHistory_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_Environment_ReleaseReason")]
    [Metadata("Reason codes for releasing Containers", "ReleaseReason", false, false, true, "NamedObjectRef", 1050369, false, false, false, null)]
    protected Environment _ReleaseReason;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_Environment_HistoryDetails")]
    [Metadata("HoldReleaseHistoryDetail is used to store the history of a container and its ancestors generated durung the Release Txn.", "HoldReleaseHistoryDetail", false, false, false, "HoldReleaseHistoryDetail", 1049096, false, true, false, null)]
    protected HoldReleaseHistoryDetail_Environment _HistoryDetails;
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_Environment_DisplayName")]
    protected new Environment _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Associating a Hold Code with a Container prevents transactions from being performed for that Container. Hold Codes are User Defined to provide multiple descriptions (reasons) for Holds.", "HoldReason", false, false, false, "NamedObjectRef", 1048800, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_Environment_HoldReason")]
    protected Environment _HoldReason;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HoldReleaseHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;

    public Environment ReleaseReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReleaseReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReleaseReason));
      }
    }

    public HoldReleaseHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (HoldReleaseHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Environment DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayName));
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

    public Environment HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HoldReason));
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
  }
}
