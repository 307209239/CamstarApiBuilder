// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ModelingAuditTrail_Environment))]
  [KnownType(typeof (V4_SecurityAuditTrail_Environment))]
  [Serializable]
  public class AuditTrail_Environment : HistoryDetails_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AuditTrail_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrail_Environment_Header")]
    [Metadata("Audit Trail Header encapsulates the basic header information captured during every maintenance transaction.", "AuditTrailHeader", false, false, true, "SubentityRef", 1050770, false, false, false, null)]
    protected Environment _Header;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;

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

    public Environment Header
    {
      [param: In] set
      {
        this.PropertySet(nameof (Header), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Header));
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
