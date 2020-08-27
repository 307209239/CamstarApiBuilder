// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventCrossRefsHistory_Environment
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
  public class UpdateEventCrossRefsHistory_Environment : UpdateEventDetailsHistory_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 16779193, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventCrossRefsHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("QualityCrossRefHistory", "QualityCrossRefHistory", false, false, false, "QualityCrossRefHistory", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventCrossRefsHistory_Environment_HistoryDetails")]
    protected QualityCrossRefHistory_Environment _HistoryDetails;

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

    public QualityCrossRefHistory_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (QualityCrossRefHistory_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }
  }
}
