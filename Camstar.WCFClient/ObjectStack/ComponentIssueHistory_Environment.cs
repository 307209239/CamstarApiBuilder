// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentIssueHistory_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (BatchDispenseHistory_Environment))]
  [KnownType(typeof (RecipeDispenseHistory_Environment))]
  [Serializable]
  public class ComponentIssueHistory_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueHistory_Environment_HistoryDetails")]
    [Metadata("Records the requirement details for a particular Component issue requirement, along with a summary of the actuals.", "IssueHistoryDetail", false, false, false, "IssueHistoryDetail", 1049096, false, true, false, null)]
    protected IssueHistoryDetail_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueHistory_Environment_BillControl")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049449, false, false, false, "0")]
    protected Environment _BillControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentIssueHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;

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
  }
}
