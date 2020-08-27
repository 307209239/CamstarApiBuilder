// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignChangePkgContentHistory_Environment
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
  public class AssignChangePkgContentHistory_Environment : ChangePackageHistory_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContentHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContentHistory_Environment_HistoryDetails")]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContentHistory_Environment_Instances")]
    [Metadata("History for Change Package Modeling Instance", "CPModelingInstanceHistDtl", false, false, true, "SubentityRef", 1053260, false, true, false, null)]
    protected Environment _Instances;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContentHistory_Environment_TargetSystems")]
    [Metadata("History for Change Package Target System", "CPTargetSystemHistDtl", false, false, true, "SubentityRef", 1053270, false, true, false, null)]
    protected Environment _TargetSystems;
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContentHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053234, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignChangePkgContentHistory_Environment_ChangePackageName")]
    protected new Environment _ChangePackageName;

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

    public Environment Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Instances));
      }
    }

    public Environment TargetSystems
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystems), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetSystems));
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

    public new Environment ChangePackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackageName));
      }
    }
  }
}
