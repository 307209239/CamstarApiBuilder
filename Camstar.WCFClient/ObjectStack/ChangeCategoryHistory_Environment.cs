// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeCategoryHistory_Environment
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
  public class ChangeCategoryHistory_Environment : ServiceHistorySummary_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_Environment_FromCategory")]
    [Metadata("Category:\r\n1 = Event\r\n2 = CAR", "CategoryEnum", false, false, true, "Integer", 1051427, false, false, false, null)]
    protected Environment _FromCategory;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Category:\r\n1 = Event\r\n2 = CAR", "CategoryEnum", false, false, true, "Integer", 1051206, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_Environment_NewCategory")]
    protected Environment _NewCategory;
    [Metadata("Summary of the changes caused by a single ServiceDetail CDO.", "ServiceHistoryDetail", false, false, false, "ServiceHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_Environment_HistoryDetails")]
    protected new ServiceHistoryDetail_Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ChangeCategoryHistory_Environment_TriageComplete")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051655, false, false, false, "0")]
    protected Environment _TriageComplete;

    public Environment FromCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromCategory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromCategory));
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

    public Environment NewCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewCategory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewCategory));
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

    public Environment TriageComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageComplete), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TriageComplete));
      }
    }
  }
}
