// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportLogDetail_Environment
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
  public class ExportImportLogDetail_Environment : ServiceData_Environment
  {
    [Metadata("ExportImportDetailStatus", "ExportImportDetailStatusEnum", false, false, true, "Integer", 1048671, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_Environment_Status")]
    protected Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_Environment_ObjectName")]
    [Metadata("LongString", "", false, false, true, "String", 1050774, false, false, false, null)]
    protected Environment _ObjectName;
    [Metadata("Generic String", "", false, false, true, "String", 1050799, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_Environment_ObjectInstanceId")]
    protected Environment _ObjectInstanceId;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050840, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_Environment_LastUpdateTime")]
    protected Environment _LastUpdateTime;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_Environment_CompletionMessage")]
    [Metadata("Message text.", "", false, false, true, "String", 1050838, false, false, false, null)]
    protected Environment _CompletionMessage;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_Environment_ObjectRevision")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1048710, false, false, false, null)]
    protected Environment _ObjectRevision;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, true, "String", 1050776, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportLogDetail_Environment_ObjectTypeName")]
    protected Environment _ObjectTypeName;

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }

    public Environment ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectName));
      }
    }

    public Environment ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public Environment LastUpdateTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdateTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastUpdateTime));
      }
    }

    public Environment CompletionMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionMessage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionMessage));
      }
    }

    public Environment ObjectRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRevision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectRevision));
      }
    }

    public Environment ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeName));
      }
    }
  }
}
