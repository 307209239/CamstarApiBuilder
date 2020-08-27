// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentDistributeHistory_Environment
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
  public class ComponentDistributeHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Records the requirement details for a particular Component issue requirement, along with a summary of the actuals.", "IssueHistoryDetail", false, false, false, "IssueHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeHistory_Environment_HistoryDetails")]
    protected IssueHistoryDetail_Environment _HistoryDetails;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049449, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeHistory_Environment_BillControl")]
    protected Environment _BillControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistributeHistory_Environment_IssueControl")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049491, false, false, false, null)]
    protected Environment _IssueControl;

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

    public IssueHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (IssueHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Environment BillControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BillControl));
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

    public Environment IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueControl));
      }
    }
  }
}
